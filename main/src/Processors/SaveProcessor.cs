using System;
using System.IO;

namespace WorkingDirectory.Processors
{
    public class SaveProcessor : IProcessor
    {
        public SaveProcessor( string arg )
        {
            this.DirPath = ToDirPath( arg );
        }

        public void Run()
        {
            Console.WriteLine(" arg = " + this.DirPath);
            // TODO: Implement here.
        }

        private string DirPath{ get; set; }

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
