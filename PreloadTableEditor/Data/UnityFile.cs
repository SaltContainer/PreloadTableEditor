using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreloadTableEditor.Data
{
    public class UnityFile
    {
        public long FileID { get; set; }
        public long PathID { get; set; }

        public override string ToString()
        {
            return string.Format("{0} : {1}", FileID, PathID);
        }
    }
}
