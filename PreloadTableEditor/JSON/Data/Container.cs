using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreloadTableEditor.JSON.Data
{
    public class Container
    {
        public string Name { get; set; }

        public AssetInfo Info { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
