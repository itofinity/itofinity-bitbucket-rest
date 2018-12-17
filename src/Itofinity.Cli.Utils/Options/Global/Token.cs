using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.CommandLineUtils;

namespace Itofinity.Refit.Cli.Utils.Options.Command
{
    public class Token : AbstractOptionDefinition
    {
        public override string Template => "-t|--token";

        public override string Description => "An authentication Token";

        public override CommandOptionType OptionType => CommandOptionType.SingleValue;
    }
}