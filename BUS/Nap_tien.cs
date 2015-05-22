using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Nap_tien
    {
        DAO.Nap_tien XL = new DAO.Nap_tien();
        DAO.Tai_khoan TK = new DAO.Tai_khoan();
        DAO.The_nap_tien TNT = new DAO.The_nap_tien();
        public List<State_Nap_tien> statenaptien = new List<State_Nap_tien>();
        public Nap_tien()
        {
            statenaptien.Add(new The_khong_ton_tai());
            statenaptien.Add(new The_da_nap());
            statenaptien.Add(new Nap_tien_binh_thuong());
        }
        public int Them_nap_tien(DTO.Nap_tien NT, string Macode)
        {
            //NT.Msgd_nap_tien = XL.Lay_ma_so() + 1;
            //NT.So_tien_nap = TNT.Lay_so_tien(NT.Ma_code);
            //XL.Them_nap_tien(NT);
            //TK.Nap_tien(NT.Stk_nap,NT.So_tien_nap);
            //TNT.Huy_the(NT.Ma_code);
            int loai = TNT.Kiem_tra_code(Macode);
            return statenaptien[loai].Nap_the(NT);
        }
        public List<DTO.Nap_tien> Danh_sach_nap(string Stk_nap)
        {
            return XL.Danh_sach_nap(Stk_nap);
        }
    }
}
