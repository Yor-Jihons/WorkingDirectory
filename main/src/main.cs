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

            string filepath = "workingdirectory.xml";

            var processor = new Processors.SaveProcessor(cmdline.Arg);
            var history = Histories.History.Load( filepath );
            processor.Run(history.Paths);
            Histories.History.Save(history, filepath );
        }
    }
}
