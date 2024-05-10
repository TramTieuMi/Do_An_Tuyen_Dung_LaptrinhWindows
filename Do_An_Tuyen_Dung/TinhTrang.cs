using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    public class TinhTrang
    {
        string nganh;
        string diaDiem;
        string cty;
        string trangthai;
        public TinhTrang()
        {

        }

        public TinhTrang(string nganh, string diaDiem, string cty, string trangthai)
        {
            this.nganh = nganh;
            this.diaDiem = diaDiem;
            this.cty = cty;
            this.trangthai = trangthai;
        }

        public string Nganh { get => nganh; set => nganh = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public string Cty { get => cty; set => cty = value; }
        public string Trangthai { get => trangthai; set => trangthai = value; }
    }
}
