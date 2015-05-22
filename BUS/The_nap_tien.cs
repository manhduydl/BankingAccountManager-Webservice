using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class The_nap_tien
    {
        Random rd = new Random();
        DAO.The_nap_tien TNT = new DAO.The_nap_tien();
        public void Tao_the_nap(double So_tien)
        {
            if (TNT.So_the_con(So_tien) < 10)
            {
                List<DTO.The_nap_tien> dstn = new List<DTO.The_nap_tien>();
                for (int i = 0; i < 10; i++)
                {
                    DTO.The_nap_tien temp = new DTO.The_nap_tien();
                    temp.Ma_code = Code_chuan();
                    temp.So_tien = So_tien;
                    temp.Tinh_trang = 1;
                    dstn.Add(temp);
                }
                foreach (DTO.The_nap_tien a in dstn)
                {
                    TNT.Tao_the(a);
                }
            }

        }
        public void Tao_the_ngan_hang(double So_tien)
        {
            List<DTO.The_nap_tien> dstn = new List<DTO.The_nap_tien>();
            for (int i = 0; i < 10; i++)
            {
                DTO.The_nap_tien temp = new DTO.The_nap_tien();
                temp.Ma_code = Code_chuan();
                temp.So_tien = So_tien;
                temp.Tinh_trang = 1;
                dstn.Add(temp);
            }
            foreach (DTO.The_nap_tien a in dstn)
            {
                TNT.Tao_the(a);
            }
        }
        public string Code_chuan()
        {
            bool kt = true;
            string kq = "";
            while (kt)
            {
                kq = Tao_code();
                kt = TNT.Kiem_tra(kq);
            }
            return kq;
        }
        public string Tao_code()
        {
            string kq = "";
            int a = rd.Next(100, 999);
            int b = rd.Next(100, 999);
            int c = rd.Next(100, 999);
            kq += a.ToString();
            kq += "-";
            kq += b.ToString();
            kq += "-";
            kq += c.ToString();
            return kq;
        }
        public int Kiem_tra_code(string Ma_code)
        {
            return TNT.Kiem_tra_code(Ma_code);
        }
        public double Lay_so_tien(string Ma_code)
        {
            return TNT.Lay_so_tien(Ma_code);
        }
        public List<DTO.The_nap_tien> Ds_the()
        {
            return TNT.Ds_the();
        }
    }
}
