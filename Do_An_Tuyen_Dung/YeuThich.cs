using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    public class YeuThich
    {
        string tencty;
        string tencv;
        public YeuThich() { }

        public YeuThich(string tencty, string tencv)
        {
            this.tencty = tencty;
            this.tencv = tencv;
        }

        public string Tencty { get => tencty; set => tencty = value; }
        public string Tencv { get => tencv; set => tencv = value; }
    }
}
