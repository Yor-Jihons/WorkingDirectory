using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;
using WorkingDirectory.CommandLines;
using WorkingDirectory.ExtensionMethods;

namespace WorkingDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            var cmdline = CmdLine.Create(args);
            if (cmdline == null) return;

            var dirPath = Directory.GetParent(Assembly.GetExecutingAssembly().Location).FullName;
            string filepath = Path.Join(dirPath, "workingdirectory.xml");

            var processor = Processors.ProcessorCreator.Create(cmdline.ProcessType, cmdline.Arg);
            var history = Histories.History.Load(filepath);
            processor.Run(history.Paths);
            Histories.History.Save(history, filepath);
        }
    }
}
