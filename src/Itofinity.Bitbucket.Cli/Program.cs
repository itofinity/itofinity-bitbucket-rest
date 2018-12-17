using Itofinity.Bitbucket.Refit.Client;
using Itofinity.Refit.Cli.Utils;
using System.Collections.Generic;

namespace Itofinity.Bitbucket.Cli
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CliBuilder<ApiClient>
                .Build<ApiClient>(
                    "Itofinity Bitbucket CLI",
                    ".NET Core powered CLI for Bitbucket.",
                    new ClientFactory(),
                    new PorcelainCommandFactory(),
                    new List<string>() { "extensions" },
                    "*.dll")
                .Execute(args);
        }
    }
}