using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Khach_hang_vip:Khach_hang
    {
        DAO.Chuyen_tien DCT = new DAO.Chuyen_tien();
        DAO.Tai_khoan TK = new DAO.Tai_khoan();
        public override void Chuyen_tien(DTO.Chuyen_tien CT)
        {
            base.Chuyen_tien(CT);
            CT.Msgd_chuyen_tien = DCT.Lay_ma_so() + 1;
            DCT.Them_chuyen_tien(CT);
            TK.Nap_tien(CT.Stk_nhan, CT.So_tien_chuyen);
            TK.Rut_tien(CT.Stk_chuyen, CT.So_tien_chuyen);
        }
    }
}
