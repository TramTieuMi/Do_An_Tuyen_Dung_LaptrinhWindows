using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_An_Tuyen_Dung
{
    public class XemUV
    {
        string ten;
        string email;
        string emailHR;
        public XemUV()
        {
        }

        public XemUV(string ten, string email, string emailHR)
        {
            this.ten = ten;
            this.email = email;
            this.emailHR = emailHR;
        }

        public string Ten { get => ten; set => ten = value; }
        public string Email { get => email; set => email = value; }
        public string EmailHR { get => emailHR; set => emailHR = value; }
    }
}
