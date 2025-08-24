using System;
using System.IO;
using System.Collections.Generic;
using WorkingDirectory.ExtensionMethods;

namespace WorkingDirectory.Processors
{
    public static class ProcessorCreator
    {
        public static IProcessor Create(CommandLines.ProcessTypes type, string arg)
        {
            if (type == CommandLines.ProcessTypes.LaodMode)
            {
                return new LoadProcessor(arg);
            }
            else if (type == CommandLines.ProcessTypes.SaveMode)
            {
                return new SaveProcessor(arg);
            }
            else if (type == CommandLines.ProcessTypes.ListMode)
            {
                return new ListProcessor();
            }
            else if (type == CommandLines.ProcessTypes.CearMode)
            {
                return new ClearProcessor();
            }
            else
            {
                return null;
            }
        }
    }
}
