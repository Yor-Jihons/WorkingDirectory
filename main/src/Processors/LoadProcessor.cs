using System;
using System.IO;
using System.Collections.Generic;

namespace WorkingDirectory.Processors
{
    public class LoadProcessor : IProcessor
    {
        // TODO: Modify the 2nd argmuent.
        public LoadProcessor( string arg, List<string> history )
        {
            this.DirPath = ToDirPath( arg );
        }

        public void Run()
        {
            Console.WriteLine( " arg = " + this.DirPath );
        }

        private string DirPath{ get; set; }

        private static string ToDirPath( string arg  )
        {
            return arg; // TODO: Modify.
        }
    }
}
