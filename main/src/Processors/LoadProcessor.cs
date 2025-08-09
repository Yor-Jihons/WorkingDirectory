using System;
using System.IO;
using System.Collections.Generic;

namespace WorkingDirectory.Processors
{
    public class LoadProcessor(string arg) : IProcessor
    {
        public void Run( List<string> history )
        {
            Console.WriteLine(" arg = " + ToIndex(Arg, null));
        }

        private string Arg { get; set; } = arg;

        private static int ToIndex(string arg, List<string> history)
        {
            if (arg.Equals("HEAD") || arg.Equals("")) return 0;
            if (arg.Equals("HEAD^")) return 1;
            if (arg.Equals("HEAD^^")) return 2;
            throw new Exceptions.InvalidCommandLineArgumentException(arg);
        }
    }
}
