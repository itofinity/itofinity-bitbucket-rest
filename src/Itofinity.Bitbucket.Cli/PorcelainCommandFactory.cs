using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Refit.Cli.Utils;
using Itofinity.Refit.Cli.Utils.Commands;
using Itofinity.Refit.Cli.Utils.Options.Command;
using Itofinity.Refit.Cli.Utils.Options.Global;
using Microsoft.Extensions.CommandLineUtils;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Itofinity.Bitbucket.Cli
{
    public class PorcelainCommandFactory : IPorcelainCommandFactory<ApiClient>
    {
        public void AddPorcelain<ApiClient>(CommandLineApplication app, IClientFactory<ApiClient> clientFactory)
        {
            var properties = clientFactory.GetProperties();

            properties.ToList().ForEach(prop =>
            {
                var groupType = prop.PropertyType;
                var groupName = groupType.Name.Substring(0, groupType.Name.Length - 3).Substring(1);
                var methods = groupType.GetMethods();
                methods.ToList().ForEach(m =>
                {
                    var methodName = m.Name;
                    var commandName = $"{methodName}".ToKebabCase();
                    if (commandName.EndsWith("-"))
                    {
                        commandName = commandName.Substring(0, commandName.Length - 1);
                    }

                    var parameters = m.GetParameters().Where(param => !param.Name.ToLower().Equals("useragent"));
                    app.Command(commandName, (command) =>
                    {
                        command.Description = $"Porcelain command for {methodName.ToText()} Api";

                        command.HelpOption("-?|-h|--help");

                        // standard options
                        var apiToken = new Token();
                        var apiTokenOption = command.Option(apiToken.Template,
                            apiToken.Description,
                            apiToken.OptionType);

                        var indent = new Indent();
                        command.Option(indent.Template,
                            indent.Description,
                            indent.OptionType);

                        var outputPath = new OutputPath();
                        command.Option(outputPath.Template,
                            outputPath.Description,
                            outputPath.OptionType);

                        var filter = new Filter();
                        command.Option(filter.Template,
                            filter.Description,
                            filter.OptionType);

                        var options = new List<CommandOption>();
                        parameters.ToList().ForEach(param =>
                        {
                            var paramName = $"--{param.Name}";
                            var paramDesc = $"The {param.Name}";
                            var option = command.Option(paramName, paramDesc, CommandOptionType.SingleValue);
                            options.Add(option);
                        });

                        command.OnExecute(() =>
                        {
                            return command.Run(
                                app,
                                () =>
                                {
                                    var client = clientFactory.GetClient(apiTokenOption.Value());

                                    var api = GetApi(client, prop);

                                    var method = api.GetType().GetMethod(m.Name);

                                    List<object> args = CompileRequestArgs<ApiClient>(app, clientFactory, options);

                                    return InvokeRequest(api, method, args);
                                }
                                );
                        });
                    });
                });
            });
        }

        private static List<object> CompileRequestArgs<T>(CommandLineApplication app, IClientFactory<T> clientFactory, List<CommandOption> options)
        {
            var args = new List<object>() { clientFactory.GetUserAgent(app) };
            args.AddRange(options.Select(o => o.Value()));
            return args;
        }

        private static object GetApi(object client, PropertyInfo prop)
        {
            var property = client.GetType().GetProperty(prop.Name);
            var api = property.GetValue(client);
            return api;
        }

        private static object InvokeRequest(object api, MethodInfo method, List<object> args)
        {
            var result = method.Invoke(api, args.ToArray());
            var task = result as System.Threading.Tasks.Task;
            var resultProperty = task.GetType().GetProperty("Result");
            return resultProperty.GetValue(task);
        }
    }
}