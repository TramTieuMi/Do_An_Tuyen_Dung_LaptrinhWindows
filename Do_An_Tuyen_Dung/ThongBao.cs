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
        string emUV;
        string emHR;

        public ThongBao()
        {
        }

        public ThongBao(string tencty, string tencv, string trangThai, string emUV, string emHR)
        {
            this.tencty = tencty;
            this.tencv = tencv;
            this.trangThai = trangThai;
            this.emUV = emUV;
            this.emHR = emHR;
        }

        public string Tencty { get => tencty; set => tencty = value; }
        public string Tencv { get => tencv; set => tencv = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string EmUV { get => emUV; set => emUV = value; }
        public string EmHR { get => emHR; set => emHR = value; }
    }
}
