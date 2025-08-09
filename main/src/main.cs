using System;
using WorkingDirectory.CommandLines;

namespace WorkingDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmdline = CmdLine.Create(args);
            if (cmdline == null) return;

            var processor = new Processors.SaveProcessor( cmdline.Arg );
            processor.Run(null);
        }
    }
}
