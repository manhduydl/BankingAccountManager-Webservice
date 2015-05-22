using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Nap_tien_binh_thuong:State_Nap_tien
    {
        DAO.Nap_tien XL = new DAO.Nap_tien();
        DAO.Tai_khoan TK = new DAO.Tai_khoan();
        DAO.The_nap_tien TNT = new DAO.The_nap_tien();
        public override int Nap_the(DTO.Nap_tien NT)
        {
            NT.Msgd_nap_tien = XL.Lay_ma_so() + 1;
            NT.So_tien_nap = TNT.Lay_so_tien(NT.Ma_code);
            XL.Them_nap_tien(NT);
            TK.Nap_tien(NT.Stk_nap, NT.So_tien_nap);
            TNT.Huy_the(NT.Ma_code);
            return 1;
        }
    }
}
