using System;
using System.Text;
using System.Threading;

namespace WorkingDirectory.CommandLines
{
    public class CmdLine
    {
        public static CmdLine Create( string[] args )
        {
            ProcessTypes type = ProcessTypes.Unknown;
            var sc = StringComparison.OrdinalIgnoreCase;

            string cmd = args.Length > 1 ? args[0] : "";
            if (cmd.Equals("LOAD", sc))
            {
                // TODO: Implement here.
                type = ProcessTypes.LaodMode;
            }
            else if (cmd.Equals("SAVE", sc))
            {
                // TODO: Implement here.
                type = ProcessTypes.SaveMode;
            }
            else if (cmd.Equals("--version", sc) || cmd.Equals("-v", sc))
            {
                Console.WriteLine(
                    System.Diagnostics.FileVersionInfo.GetVersionInfo(
                        System.Reflection.Assembly.GetExecutingAssembly().Location
                    ).FileVersion
                );
                return null;
            }
            else
            {
                Console.WriteLine(CmdLine.CreateHelpString());
                return null;
            }

            return new CmdLine()
            {
                ProcessTypes = type
            };
        }

        public CommandLines.ProcessTypes ProcessTypes{ get; private set; }

        /// <summary>
        /// Creates the help text.
        /// </summary>
        /// <returns>The help text.</returns>
        private static string CreateHelpString()
        {
            // TODO: Implement here.
            var builder = new StringBuilder();
            builder.AppendLine( "[CMD]" );
            builder.AppendLine( "$ DotnetVersioner --info" );
            builder.AppendLine( "$ DotnetVersioner --list-sdks" );
            builder.AppendLine( "$ DotnetVersioner -g [--definition=<FILEPATH>] [--TargetFramework=<VERSION>]" );
            builder.AppendLine( "$ DotnetVersioner [--definition=<FILEPATH>] [--TargetFramework=<VERSION>]" );
            builder.AppendLine( "$ DotnetVersioner --help" );
            builder.AppendLine();
            builder.AppendLine( "[ARGUMENTS]" );
            builder.AppendLine( "  --info:" );
            builder.AppendLine( "    Show the info as \"dotnet --info\"." );
            builder.AppendLine( "    (shortened: -i)" );
            builder.AppendLine( "  --list-sdks:" );
            builder.AppendLine( "    Show the info as \"dotnet --list-sdks\"." );
            builder.AppendLine( "    (shortened: -l)" );
            builder.AppendLine( "  -g:" );
            builder.AppendLine( "    Create the xml file as definition file." );
            builder.AppendLine( "  --definition=<FILEPATH>:" );
            builder.AppendLine( "    Pass the xml file as the definition file." );
            builder.AppendLine( "    (shortened: -d=<FILEPATH>)" );
            builder.AppendLine( "  --TargetFramework=<VERSION>:" );
            builder.AppendLine( "    Pass the target framewrok." );
            builder.AppendLine( "    (shortened: -t=<VERSION>)" );
            builder.AppendLine( "  --help:" );
            builder.AppendLine( "    Show this help." );
            builder.AppendLine( "    (shortened: -h)" );
            builder.AppendLine();
        return builder.ToString();
        }
    }
}
