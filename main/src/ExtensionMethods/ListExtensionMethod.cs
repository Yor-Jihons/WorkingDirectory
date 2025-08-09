using System.Collections.Generic;

namespace WorkingDirectory.ExtensionMethods
{
    public static class ListExtensionMethod
    {
        public static void AddItem( this List<string> items, string item )
        {
            if (items.Count > 10)
            {
                items.RemoveRange(0, 10 - (items.Count - 1));
            }
            items.Add(item);
        }
    }
}
