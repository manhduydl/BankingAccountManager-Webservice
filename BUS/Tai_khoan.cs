using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Tai_khoan
    {
        Random rd = new Random();
        DAO.Tai_khoan TK = new DAO.Tai_khoan();
        DAO.Dang_nhap DN = new DAO.Dang_nhap();
        public double Lay_so_tien(string So_tai_khoan)
        {
            return TK.Lay_so_tien(So_tai_khoan);
        }
        public int Lay_tinh_trang(string So_tai_khoan)
        {
            return TK.Lay_tinh_trang(So_tai_khoan);
        }
        public void Thay_doi_tinh_trang(string So_tai_khoan, int Tinh_trang)
        {
            TK.Thay_doi_tinh_trang(So_tai_khoan, Tinh_trang);
        }
        public bool Kiem_tra_tai_khoan(string So_tai_khoan)
        {
            return TK.Kiem_tra_tai_khoan(So_tai_khoan);
        }
        public void Nap_tien(string So_tai_khoan, double So_tien)
        {
            TK.Nap_tien(So_tai_khoan, So_tien);
        }
        public void Rut_tien(string So_tai_khoan, double So_tien)
        {
            TK.Rut_tien(So_tai_khoan, So_tien);
        }
        public string Lay_loai_tai_khoan(string So_tai_khoan)
        {
            return TK.Lay_loai_tai_khoan(So_tai_khoan);
        }
        public void Thay_doi_loai_tai_khoan(string So_tai_khoan, string Loai_tai_khoan)
        {
            TK.Thay_doi_loai_tai_khoan(So_tai_khoan, Loai_tai_khoan);
        }
        public bool Them_tai_khoan(DTO.Tai_khoan Taikhoan,DTO.Dang_nhap dangnhap)
        {
            if (DN.Kiem_tra_ten_dang_nhap(dangnhap.Ten_dang_nhap))
            {
                return false;
            }
            else
            {
                Taikhoan.So_tai_khoan = Code_chuan();
                TK.Them_tai_khoan(Taikhoan);
                dangnhap.level = 1;
                dangnhap.So_tai_khoan = Taikhoan.So_tai_khoan;
                dangnhap.Mat_khau = Giai_ma_chuoi(dangnhap.Mat_khau);
                DN.Them_dang_nhap(dangnhap);
                return true;
            }
        }
        public string Tao_code()
        {
            string kq = "";
            int a = rd.Next(10000, 99999);
            kq = a.ToString();
            return kq;
        }
        public string Code_chuan()
        {
            bool kt = true;
            string kq = "";
            while (kt)
            {
                kq = Tao_code();
                kt = TK.Kiem_tra_tai_khoan(kq);
            }
            return kq;
        }
        public List<DTO.Tai_khoan> Ds_tai_khoan()
        {
            List<DTO.Tai_khoan> kq = new List<DTO.Tai_khoan>();
            kq = TK.Ds_tai_khoan();
            return kq;
        }
        public List<DTO.Tai_khoan> Ds_tai_khoan_theo_kh(string Ma_khach_hang)
        {
            return TK.Ds_tai_khoan_theo_kh(Ma_khach_hang);
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
    }
}
