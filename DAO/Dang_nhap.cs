using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Dang_nhap
    {
        public int DN(string Ten_tai_khoan, string Mat_khau)
        {
            String sql = string.Format("SELECT * FROM Dang_nhap where Ten_dang_nhap = '{0}'and Mat_khau = '{1}' ",Ten_tai_khoan,Mat_khau);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            if (dt.Rows.Count == 0)
                return -1;
            else
            {
                return int.Parse(dt.Rows[0]["_level"].ToString());
            }
        }
        public void Doi_mat_khau(string Ten_dang_nhap, string Mat_khau_moi)
        {
            string sql = string.Format("update Dang_nhap set Mat_khau='{0}' where Ten_dang_nhap='{1}'",Mat_khau_moi,Ten_dang_nhap);
            DataProvider.ThucThi(sql);
        }
        public string Lay_so_tai_khoan(string Ten_tai_khoan, string Mat_khau)
        {
            String sql = string.Format("SELECT * FROM Dang_nhap where Ten_dang_nhap = '{0}'and Mat_khau = '{1}' ", Ten_tai_khoan, Mat_khau);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return dt.Rows[0]["So_tai_khoan"].ToString();
        }
        public void Them_dang_nhap(DTO.Dang_nhap dangnhap)
        {
            String sql = string.Format("insert into Dang_nhap values ( '{0}','{1}','{2}',{3})", dangnhap.Ten_dang_nhap, dangnhap.Mat_khau, dangnhap.level,dangnhap.So_tai_khoan);
            DataProvider.ThucThi(sql);
        }
        public bool Kiem_tra_ten_dang_nhap(string Ten_dang_nhap)
        {
            String sql = string.Format("SELECT * FROM Dang_nhap where Ten_dang_nhap = '{0}' ", Ten_dang_nhap);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            if (dt.Rows.Count == 0)
                return false;
            else
            {
                return true;
            }
        }
    }
}
