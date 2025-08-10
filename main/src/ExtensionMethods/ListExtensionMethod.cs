using System;
using System.Collections.Generic;

namespace WorkingDirectory.ExtensionMethods
{
    public static class ListExtensionMethod
    {
        public static void AddItem( this List<string> items, string item )
        {
            const int max = 3;
            if (items.Count >= max)
            {
                items.RemoveRange(0, items.Count - max + 1);
            }
            items.Add(item);
        }
    }
}
