using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    public class DanhGia
    {
        string tencty;
        string sosao;
        string noidung;
        string thoigian;
        string tenuv;

        public DanhGia()
        {
        }

        public DanhGia(string tencty, string sosao, string noidung, string thoigian, string tenuv)
        {
            this.tencty = tencty;
            this.sosao = sosao;
            this.noidung = noidung;
            this.thoigian = thoigian;
            this.tenuv = tenuv;
        }

        public string Tencty { get => tencty; set => tencty = value; }
        public string Sosao { get => sosao; set => sosao = value; }
        public string Noidung { get => noidung; set => noidung = value; }
        public string Thoigian { get => thoigian; set => thoigian = value; }
        public string Tenuv { get => tenuv; set => tenuv = value; }
    }
}
