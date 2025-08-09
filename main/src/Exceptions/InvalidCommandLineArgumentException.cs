using System;
using System.IO;
using System.Collections.Generic;

namespace WorkingDirectory.Exceptions
{
    [Serializable]
    public class InvalidCommandLineArgumentException( string arg ) : Exception("This is nvalid command-line argument.:" + arg)
    {
    }
}
