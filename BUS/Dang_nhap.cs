using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Dang_nhap
    {
        DAO.Dang_nhap Xl = new DAO.Dang_nhap();
        public int DN(string Ten_tai_khoan, string Mat_khau)
        {
            string giai_ma_mat_khau = Giai_ma_chuoi(Mat_khau);
            return Xl.DN(Ten_tai_khoan, giai_ma_mat_khau);
        }
        public void Doi_mat_khau(string Ten_dang_nhap, string Mat_khau_moi)
        {
            string giai_ma_mat_khau = Giai_ma_chuoi(Mat_khau_moi);
            Xl.Doi_mat_khau(Ten_dang_nhap,giai_ma_mat_khau);
        }
        public string Lay_so_tai_khoan(string Ten_tai_khoan, string Mat_khau)
        {
            string giai_ma_mat_khau = Giai_ma_chuoi(Mat_khau);
            return Xl.Lay_so_tai_khoan(Ten_tai_khoan, giai_ma_mat_khau);
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
