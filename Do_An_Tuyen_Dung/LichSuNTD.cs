using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    public class LichSuNTD
    {
        string nganh;
        string diaDiem;
        string tenCTy;
        int soNguoi;

        public LichSuNTD()
        {
        }

        public LichSuNTD(string nganh, string diaDiem, string tenCTy, int soNguoi)
        {
            this.nganh = nganh;
            this.diaDiem = diaDiem;
            this.tenCTy = tenCTy;
            this.soNguoi = soNguoi;
        }

        public string Nganh { get => nganh; set => nganh = value; }
        public string DiaDiem { get => diaDiem; set => diaDiem = value; }
        public string TenCTy { get => tenCTy; set => tenCTy = value; }
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }
    }
}
