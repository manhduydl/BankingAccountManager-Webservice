using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Khach_hang
    {
        DAO.Khach_hang xl = new DAO.Khach_hang();
        DAO.Dang_nhap DN = new DAO.Dang_nhap();
        DAO.Tai_khoan TK = new DAO.Tai_khoan();
        
        public DTO.Khach_hang Lay_khach_hang(string Ma_khach_hang)
        {
            return xl.Lay_khach_hang(Ma_khach_hang);
        }
        public DTO.Khach_hang Lay_khach_hang(string Ten_dang_nhap, string Mat_khau)
        {
            string giai_ma_mat_khau = Giai_ma_chuoi(Mat_khau);
            string So_tai_khoan = DN.Lay_so_tai_khoan(Ten_dang_nhap, giai_ma_mat_khau);
            string Ma_khach_hang = TK.Lay_ma_khach_hang(So_tai_khoan);
            return xl.Lay_khach_hang(Ma_khach_hang);
        }
        public String Giai_ma_chuoi(String Chuoi)
        {
            String Kq = "";
            int Khoa = 2;
            for (int i = 0; i < Chuoi.Length; i++)
            {
                int Ma_so = char.ConvertToUtf32(Chuoi, i);
                char Ky_tu_ma_hoa = char.ConvertFromUtf32(Ma_so - Khoa)[0];
                Kq += Ky_tu_ma_hoa;
            }
            return Kq;
        }
        public void Them_khach_hang(DTO.Khach_hang khachhang)
        {
            khachhang.Ma_khach_hang = "KH" + (xl.So_khach_hang()+1).ToString();
            khachhang.Tinh_trang=1;
            xl.Them_khach_hang(khachhang);
        }
        public void Thay_doi_khach_hang(DTO.Khach_hang khachhang)
        {
            xl.Thay_doi_khach_hang(khachhang);
        }
        public List<DTO.Khach_hang> Ds_khach_hang()
        {
            return xl.Ds_khach_hang();
        }
        public string Ma_khach_hang()
        {
            return xl.Ma_khach_hang();
        }
        public virtual void Chuyen_tien(DTO.Chuyen_tien CT)
        {
        }
    }
}
