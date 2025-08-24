using System;
using System.IO;
using System.Collections.Generic;
using WorkingDirectory.ExtensionMethods;

namespace WorkingDirectory.Processors
{
    public class SaveProcessor(string arg) : IProcessor
    {
        public void Run(List<string> history)
        {
            history.AddItem(this.DirPath);
        }

        private string DirPath { get; set; } = ToDirPath(arg);

        private static string ToDirPath( string arg )
        {
            var sc = StringComparison.OrdinalIgnoreCase;
            if( arg.Equals( ".", sc ) )
            {
                return Environment.CurrentDirectory;
            }else if( arg.Equals( "..", sc ) )
            {
                return System.IO.Path.GetDirectoryName( Environment.CurrentDirectory );
            }
        return arg;
        }
    }
}
