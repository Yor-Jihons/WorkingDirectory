using System.Collections.Generic;

namespace WorkingDirectory.Processors
{
    public interface IProcessor
    {
        void Run(List<string> history);
    }
}
