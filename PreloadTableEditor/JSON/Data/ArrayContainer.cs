using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreloadTableEditor.JSON.Data
{
    public class ArrayContainer<T>
    {
        public IList<T> Array { get; set; }
    }
}
