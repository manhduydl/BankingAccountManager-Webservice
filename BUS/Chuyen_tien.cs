using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Chuyen_tien
    {
        DAO.Chuyen_tien XL = new DAO.Chuyen_tien();
        DAO.Tai_khoan TK = new DAO.Tai_khoan();
        public void Them_chuyen_tien(DTO.Chuyen_tien CT,string Loai)
        {
            Khach_hang KH = new Khach_hang();
            if (Loai == "thuong")
            {
                KH = new Khach_hang_thuong();
            }
            if (Loai == "vip")
            {
                KH = new Khach_hang_vip();
            }
            KH.Chuyen_tien(CT);
        }
        public List<DTO.Chuyen_tien> Danh_sach_chuyen(string Stk_chuyen)
        {
            return XL.Danh_sach_chuyen(Stk_chuyen);
        }
        public List<DTO.Chuyen_tien> Danh_sach_nhan(string Stk_nhan)
        {
            return XL.Danh_sach_nhan(Stk_nhan);
        }
        public List<DTO.Chuyen_tien> Danh_sach_tong(string So_tai_khoan)
        {
            List<DTO.Chuyen_tien> kq = new List<DTO.Chuyen_tien>();
            List<DTO.Chuyen_tien> Ds_chuyen = XL.Danh_sach_chuyen(So_tai_khoan);
            List<DTO.Chuyen_tien> Ds_nhan = XL.Danh_sach_nhan(So_tai_khoan);
            foreach(DTO.Chuyen_tien a in Ds_chuyen)
            {
                kq.Add(a);
            }
            foreach(DTO.Chuyen_tien a in Ds_nhan)
            {
                kq.Add(a);
            }
            return kq;
        }
        public List<DTO.Chuyen_tien> Danh_sach_theo_ngay(DateTime bd, DateTime kt)
        {
            return XL.Danh_sach_theo_ngay(bd, kt);
        }
    }
}
