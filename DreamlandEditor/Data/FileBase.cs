using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DreamlandEditor.Data
{
    public class FileBase
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public FileBase()
        {
        }

        public FileBase(string id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}
