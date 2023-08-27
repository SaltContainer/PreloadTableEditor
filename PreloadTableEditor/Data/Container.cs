using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreloadTableEditor.Data
{
    public class Container
    {
        public string Name { get; set; }
        public List<UnityFile> Assets { get; set; }
        public UnityFile MainAsset { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
