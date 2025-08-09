using System;
using System.IO;
using System.Collections.Generic;

namespace WorkingDirectory.Processors
{
    public class SaveProcessor(string arg) : IProcessor
    {
        public void Run( List<string> history )
        {
            Console.WriteLine(" arg = " + this.DirPath);
            // TODO: Implement here.
        }

        private string DirPath { get; set; } = ToDirPath(arg);

        private static string ToDirPath( string arg )
        {
            var sc = StringComparison.OrdinalIgnoreCase;
            if( arg.Equals( ".", sc ) )
            {
                return System.IO.Path.GetDirectoryName( Environment.CurrentDirectory );
            }else if( arg.Equals( "..", sc ) )
            {
                return System.IO.Path.GetDirectoryName( System.IO.Path.GetDirectoryName( Environment.CurrentDirectory ) );
            }
        return arg;
        }
    }
}
