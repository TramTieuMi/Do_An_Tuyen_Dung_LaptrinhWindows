using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    public class ThongBao
    {
        string tencty;
        string tencv;
        string trangThai;

        public ThongBao()
        {
        }

        public ThongBao(string tencty, string tencv, string trangThai)
        {
            this.tencty = tencty;
            this.tencv = tencv;
            this.trangThai = trangThai;
        }

        public string Tencty { get => tencty; set => tencty = value; }
        public string Tencv { get => tencv; set => tencv = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
