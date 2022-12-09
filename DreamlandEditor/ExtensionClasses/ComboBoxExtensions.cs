using System.Collections.Generic;
using static System.Windows.Forms.ComboBox;

namespace DreamlandEditor.ExtensionClasses
{
  public static class ComboBoxExtensions
    {
        public static void AddItems(this ObjectCollection items, IEnumerable<object> itemsToAdd)
        {
           foreach(var item in itemsToAdd)
            {
                items.Add(item);
            }
        }
    }
}
