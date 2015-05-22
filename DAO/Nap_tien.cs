using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Nap_tien
    {
        public void Them_nap_tien(DTO.Nap_tien NT)
        {
            String sql = string.Format("insert into Nap_tien values ( '{0}','{1}','{2}','{3}','{4}')",NT.Msgd_nap_tien,NT.Stk_nap,NT.So_tien_nap,NT.Ma_code,NT.Thoi_gian_gd);
            DataProvider.ThucThi(sql);
        }
        public int Lay_ma_so()
        {
            String sql = "SELECT * FROM Nap_tien";
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return dt.Rows.Count;
        }
        public List<DTO.Nap_tien> Danh_sach_nap(string Stk_nap)
        {
            String sql = string.Format("SELECT * FROM Nap_tien where Stk_nap = '{0}'",Stk_nap);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            List<DTO.Nap_tien> kq = new List<DTO.Nap_tien>();
            foreach (DataRow dr in dt.Rows)
            {
                DTO.Nap_tien temp = new DTO.Nap_tien();
                temp.Msgd_nap_tien = (int)dr["Msgd_nap_tien"];
                temp.Stk_nap = dr["Stk_nap"].ToString();
                temp.Ma_code = dr["Ma_code"].ToString();
                temp.So_tien_nap = double.Parse(dr["So_tien_nap"].ToString());
                temp.Thoi_gian_gd = (DateTime)dr["Thoi_gian_gd"];
                kq.Add(temp);
            }
            return kq;
        }
    }
}
