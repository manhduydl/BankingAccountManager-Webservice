using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Tai_khoan
    {
        public string Lay_ma_khach_hang(string So_tai_khoan)
        {
            String sql = string.Format("SELECT * FROM Tai_khoan where So_tai_khoan = '{0}'", So_tai_khoan);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return dt.Rows[0]["Ma_khach_hang"].ToString();
        }
        public double Lay_so_tien(string So_tai_khoan)
        {
            String sql = string.Format("SELECT * FROM Tai_khoan where So_tai_khoan = '{0}'", So_tai_khoan);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return double.Parse(dt.Rows[0]["So_tien"].ToString());
        }
        public int Lay_tinh_trang(string So_tai_khoan)
        {
            String sql = string.Format("SELECT * FROM Tai_khoan where So_tai_khoan = '{0}'", So_tai_khoan);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return int.Parse(dt.Rows[0]["Tinh_trang"].ToString());
        }
        public void Thay_doi_tinh_trang(string So_tai_khoan, int Tinh_trang)
        {
            String sql = string.Format("update Tai_khoan set Tinh_trang = '{0}' where So_tai_khoan = '{1}'",Tinh_trang, So_tai_khoan);
            DataProvider.ThucThi(sql);
        }
        public bool Kiem_tra_tai_khoan(string So_tai_khoan)
        {
            String sql = string.Format("SELECT * FROM Tai_khoan where So_tai_khoan = '{0}'", So_tai_khoan);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else
                return false;
        }
        public void Nap_tien(string So_tai_khoan, double So_tien)
        {
            String sql = string.Format("SELECT * FROM Tai_khoan where So_tai_khoan = '{0}'", So_tai_khoan);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            double So_tien_moi = double.Parse(dt.Rows[0]["So_tien"].ToString()) + So_tien;
            sql = string.Format("update Tai_khoan set So_tien='{0}' where So_tai_khoan = '{1}'",So_tien_moi.ToString(), So_tai_khoan);
            DataProvider.ThucThi(sql);
        }
        public void Rut_tien(string So_tai_khoan, double So_tien)
        {
            String sql = string.Format("SELECT * FROM Tai_khoan where So_tai_khoan = '{0}'", So_tai_khoan);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            double So_tien_moi = double.Parse(dt.Rows[0]["So_tien"].ToString()) - So_tien;
            sql = string.Format("update Tai_khoan set So_tien='{0}' where So_tai_khoan = '{1}'", So_tien_moi.ToString(), So_tai_khoan);
            DataProvider.ThucThi(sql);
        }
        public string Lay_loai_tai_khoan(string So_tai_khoan)
        {
            String sql = string.Format("SELECT * FROM Tai_khoan where So_tai_khoan = '{0}'", So_tai_khoan);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return dt.Rows[0]["Loai_tai_khoan"].ToString();
        }
        public void Thay_doi_loai_tai_khoan(string So_tai_khoan, string Loai_tai_khoan)
        {
            String sql = string.Format("update Tai_khoan set Loai_tai_khoan = '{0}' where So_tai_khoan = '{1}'", Loai_tai_khoan, So_tai_khoan);
            DataProvider.ThucThi(sql);
        }
        public void Them_tai_khoan(DTO.Tai_khoan Taikhoan)
        {
            String sql = string.Format("insert into Tai_khoan values ( '{0}','{1}','{2}','{3}','{4}')",Taikhoan.So_tai_khoan,Taikhoan.So_tien,Taikhoan.Ma_khach_hang,Taikhoan.Tinh_trang,Taikhoan.Loai_tai_khoan);
            DataProvider.ThucThi(sql);
        }
        public List<DTO.Tai_khoan> Ds_tai_khoan()
        {
            List<DTO.Tai_khoan> kq = new List<DTO.Tai_khoan>();
            String sql = string.Format("SELECT * FROM Tai_khoan");
            DataTable dt = DataProvider.ExecuteQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                DTO.Tai_khoan temp = new DTO.Tai_khoan();
                temp.Ma_khach_hang = dr["Ma_khach_hang"].ToString();
                temp.Loai_tai_khoan = dr["Loai_tai_khoan"].ToString();
                temp.So_tai_khoan = dr["So_tai_khoan"].ToString();
                temp.So_tien = double.Parse(dr["So_tien"].ToString());
                temp.Tinh_trang = (int)dr["Tinh_trang"];
                kq.Add(temp);
            }
            return kq;
        }
        public List<DTO.Tai_khoan> Ds_tai_khoan_theo_kh(string Ma_khach_hang)
        {
            List<DTO.Tai_khoan> kq = new List<DTO.Tai_khoan>();
            String sql = string.Format("SELECT * FROM Tai_khoan where Ma_khach_hang='{0}'",Ma_khach_hang);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                DTO.Tai_khoan temp = new DTO.Tai_khoan();
                temp.Ma_khach_hang = dr["Ma_khach_hang"].ToString();
                temp.Loai_tai_khoan = dr["Loai_tai_khoan"].ToString();
                temp.So_tai_khoan = dr["So_tai_khoan"].ToString();
                temp.So_tien = double.Parse(dr["So_tien"].ToString());
                temp.Tinh_trang = (int)dr["Tinh_trang"];
                kq.Add(temp);
            }
            return kq;
        }
    }
}
