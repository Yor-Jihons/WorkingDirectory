using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WorkingDirectory.Processors
{
    public class ListProcessor : IProcessor
    {
        private readonly string[] _list = ["HEAD  ", "HEAD^ ", "HEAD^^"];
        public void Run(List<string> history)
        {
            if (history.Count == 0)
            {
                Console.WriteLine("The WorkingDirectory has no paths.");
                return;
            }

            int loopCount = Math.Min(_list.Length, history.Count);

            for (int i = 0; i < loopCount; i++)
            {
                string tag = _list[i];
                string path = history[history.Count - 1 - i];
                Console.WriteLine($"{tag}: {path}");
            }
        }
    }
}
