using System;
using System.Collections.Generic;
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
            var history = new List<string>();
            processor.Run(history);
        }
    }
}
