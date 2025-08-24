using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WorkingDirectory.Processors
{
    public class ClearProcessor : IProcessor
    {
        public void Run(List<string> history)
        {
            history.Clear();
        }
    }
}
