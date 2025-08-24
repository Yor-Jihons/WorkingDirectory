using System;
using System.Text;
using System.Threading;

namespace WorkingDirectory.CommandLines
{
    public class CmdLine
    {
        public static CmdLine Create( string[] args )
        {
            ProcessTypes type;
            var sc = StringComparison.OrdinalIgnoreCase;

            string arg;
            string cmd = args.Length >= 1 ? args[0] : "";
            if (cmd.Equals("LOAD", sc))
            {
                type = ProcessTypes.LaodMode;
                arg = args.Length >= 2 ? args[1] : "HEAD";
            }
            else if (cmd.Equals("SAVE", sc))
            {
                type = ProcessTypes.SaveMode;
                arg = args.Length >= 2 ? args[1] : ".";
            }
            else if (cmd.Equals("LIST", sc))
            {
                type = ProcessTypes.ListMode;
                arg = "";
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
                ProcessType = type,
                Arg = arg
            };
        }

        public CommandLines.ProcessTypes ProcessType{ get; private set; }
        public string Arg{ get; private set; }

        /// <summary>
        /// Creates the help text.
        /// </summary>
        /// <returns>The help text.</returns>
        private static string CreateHelpString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("[COMMANDS]");
            builder.AppendLine("WorkingDirectory list");
            builder.AppendLine("WorkingDirectory clear");
            builder.AppendLine("WorkingDirectory save [<DIRECTORY_PATH>]");
            builder.AppendLine("WorkingDirectory load [\"HEAD\" | \"HEAD^\" | \"HEAD^^\"]");
            builder.AppendLine("WorkingDirectory --help");
            builder.AppendLine("WorkingDirectory --version");
            builder.AppendLine();
            builder.AppendLine("[ARGUMENTS]");
            builder.AppendLine("<DIRECTORY_PATH>:");
            builder.AppendLine("    The directory path.");
            builder.AppendLine("\"HEAD\":");
            builder.AppendLine("    The latest directory path you set with this program.");
            builder.AppendLine("--help:");
            builder.AppendLine("    Show this help.");
            builder.AppendLine("    (Shortened: -h)");
            builder.AppendLine("--version:");
            builder.AppendLine("    Show this version.");
            builder.AppendLine("    (Shortened: -v)");
            builder.AppendLine();
            return builder.ToString();
        }
    }
}
