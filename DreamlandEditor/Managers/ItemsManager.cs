using DreamlandEditor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamlandEditor.Managers
{
    public static class ItemsManager
    {
        public static List<BaseFile> Items = new List<BaseFile>();

        public static BaseFile ContainsById(string id)
        {
            foreach(BaseFile item in Items)
            {
                if(item.ID == id) return item;
            }
            return null;
        }
        public static BaseFile GetById(string id)
        {
            foreach(BaseFile item in Items)
            {
                if(item.ID == id) return item;
            }
            return null;
        }
    }
}
