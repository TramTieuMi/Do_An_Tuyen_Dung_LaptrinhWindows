
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung.DAO
{
    internal class UngVienDAO
    {
        private string hoTen;
        private string noiSinh;
        private string ngaySinh;
        private string fileCV;
        private string thanhPho;
        private string huyen;
        private string xa;
        private string soNha;
        //private string gioiThieu;

        public UngVienDAO()
        {
        }

        public UngVienDAO(string hoTen, string noiSinh, string ngaySinh, string fileCV, string thanhPho, string huyen, string xa, string soNha)
        {
            this.HoTen = hoTen;
            this.NoiSinh = noiSinh;
            this.NgaySinh = ngaySinh;
            this.FileCV = fileCV;
            this.ThanhPho = thanhPho;
            this.Huyen = huyen;
            this.Xa = xa;
            this.SoNha = soNha;
            //this.GioiThieu = gioiThieu;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NoiSinh { get => noiSinh; set => noiSinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string FileCV { get => fileCV; set => fileCV = value; }
        public string ThanhPho { get => thanhPho; set => thanhPho = value; }
        public string Huyen { get => huyen; set => huyen = value; }
        public string Xa { get => xa; set => xa = value; }
        public string SoNha { get => soNha; set => soNha = value; }
        //public string GioiThieu { get => gioiThieu; set => gioiThieu = value; }
    }
}
