using System.Collections.Generic;

namespace WorkingDirectory.ExtensionMethods
{
    public static class ListExtensionMethod
    {
        public static bool AddItem( this List<string> items, string item )
        {
            items.Add(item);
            return true;
        }
    }
}
