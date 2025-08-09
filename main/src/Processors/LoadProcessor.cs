using System;
using System.IO;
using System.Collections.Generic;

namespace WorkingDirectory.Processors
{
    public class LoadProcessor(string arg) : IProcessor
    {
        public void Run()
        {
            Console.WriteLine(" arg = " + this.Index);
        }

        private int Index { get; set; } = ToIndex(arg);

        private static int ToIndex(string arg)
        {
            if (arg.Equals("HEAD") || arg.Equals("")) return 0;
            if (arg.Equals("HEAD^")) return 1;
            if (arg.Equals("HEAD^^")) return 2;
            throw new Exceptions.InvalidCommandLineArgumentException( arg );
        }
    }
}
