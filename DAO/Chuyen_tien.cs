using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Chuyen_tien
    {
        public void Them_chuyen_tien(DTO.Chuyen_tien CT)
        {
            String sql = string.Format("insert into Chuyen_tien values ( '{0}','{1}','{2}','{3}','{4}')",CT.Msgd_chuyen_tien,CT.Stk_chuyen,CT.Stk_nhan,CT.So_tien_chuyen,CT.Thoi_gian_gd);
            DataProvider.ThucThi(sql);
        }
        public int Lay_ma_so()
        {
            String sql = "SELECT * FROM Chuyen_tien";
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return dt.Rows.Count;
        }
        public List<DTO.Chuyen_tien> Danh_sach_chuyen(string Stk_chuyen)
        {
            String sql =string.Format("SELECT * FROM Chuyen_tien where Stk_chuyen = '{0}'",Stk_chuyen);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            List<DTO.Chuyen_tien> kq = new List<DTO.Chuyen_tien>();
            foreach (DataRow dr in dt.Rows)
            {
                DTO.Chuyen_tien temp = new DTO.Chuyen_tien();
                temp.Msgd_chuyen_tien = (int)dr["Msgd_chuyen_tien"];
                temp.Stk_chuyen = dr["Stk_chuyen"].ToString();
                temp.Stk_nhan = dr["Stk_nhan"].ToString();
                temp.So_tien_chuyen = double.Parse(dr["So_tien_chuyen"].ToString());
                temp.Thoi_gian_gd = (DateTime)dr["Thoi_gian_gd"];
                kq.Add(temp);
            }
            return kq;
        }
        public List<DTO.Chuyen_tien> Danh_sach_nhan(string Stk_nhan)
        {
            String sql = string.Format("SELECT * FROM Chuyen_tien where Stk_nhan = '{0}'", Stk_nhan);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            List<DTO.Chuyen_tien> kq = new List<DTO.Chuyen_tien>();
            foreach (DataRow dr in dt.Rows)
            {
                DTO.Chuyen_tien temp = new DTO.Chuyen_tien();
                temp.Msgd_chuyen_tien = (int)dr["Msgd_chuyen_tien"];
                temp.Stk_chuyen = dr["Stk_chuyen"].ToString();
                temp.Stk_nhan = dr["Stk_nhan"].ToString();
                temp.So_tien_chuyen = double.Parse(dr["So_tien_chuyen"].ToString());
                temp.Thoi_gian_gd = (DateTime)dr["Thoi_gian_gd"];
                kq.Add(temp);
            }
            return kq;
        }
        public List<DTO.Chuyen_tien> Danh_sach_theo_ngay(DateTime bd, DateTime kt)
        {
            String sql = string.Format("SELECT * FROM Chuyen_tien");
            DataTable dt = DataProvider.ExecuteQuery(sql);
            List<DTO.Chuyen_tien> kq = new List<DTO.Chuyen_tien>();
            foreach (DataRow dr in dt.Rows)
            {
                if ((DateTime)dr["Thoi_gian_gd"] >= bd && (DateTime)dr["Thoi_gian_gd"] <= kt)
                {
                    DTO.Chuyen_tien temp = new DTO.Chuyen_tien();
                    temp.Msgd_chuyen_tien = (int)dr["Msgd_chuyen_tien"];
                    temp.Stk_chuyen = dr["Stk_chuyen"].ToString();
                    temp.Stk_nhan = dr["Stk_nhan"].ToString();
                    temp.So_tien_chuyen = double.Parse(dr["So_tien_chuyen"].ToString());
                    temp.Thoi_gian_gd = (DateTime)dr["Thoi_gian_gd"];
                    kq.Add(temp);
                }
            }
            return kq;
        }
    }
}
