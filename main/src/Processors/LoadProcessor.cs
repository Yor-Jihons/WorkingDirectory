using System;
using System.IO;
using System.Collections.Generic;

namespace WorkingDirectory.Processors
{
    public class LoadProcessor(string arg) : IProcessor
    {
        public void Run(List<string> history)
        {
            Console.WriteLine(" arg = " + ToIndex(Arg, null));
            // TODO: Implement here.
        }

        private string Arg { get; set; } = arg;

        private static int ToIndex(string arg, List<string> history)
        {
            if (arg.Equals("HEAD") || arg.Equals("")) return history.Count - 1;
            if (arg.Equals("HEAD^")) return history.Count - 2;
            if (arg.Equals("HEAD^^")) return history.Count - 3;
            throw new Exceptions.InvalidCommandLineArgumentException(arg);
        }
    }
}
