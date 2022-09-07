using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.ComboBox;

namespace ProjectDreamland.ExtensionClasses
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
