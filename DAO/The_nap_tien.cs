using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class The_nap_tien
    {
        public void Tao_the(DTO.The_nap_tien TNT)
        {
            String sql = string.Format("insert into The_Nap_Tien values ( '{0}','{1}','{2}')", TNT.Ma_code, TNT.So_tien.ToString(), TNT.Tinh_trang);
            DataProvider.ThucThi(sql);
        }
        public void Huy_the(string Ma_code)
        {
            String sql = string.Format("update The_Nap_Tien set Tinh_trang='-1' where Ma_code='{0}'", Ma_code);
            DataProvider.ThucThi(sql);
        }
        public bool Kiem_tra(string Ma_code)
        {
            String sql = string.Format("SELECT * FROM The_nap_tien where Ma_code = '{0}'", Ma_code);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else
                return false;
        }
        public int Kiem_tra_code(string Ma_code)
        {
            String sql = string.Format("SELECT * FROM The_nap_tien where Ma_code = '{0}'", Ma_code);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            if (dt.Rows.Count != 0)
            {
                if ((int)dt.Rows[0]["Tinh_trang"] == 1)
                {
                    return 2;
                }
                else
                    return 1;
            }
            else
                return 0;
        }
        public int So_the_con(double So_tien)
        {
            String sql = string.Format("SELECT * FROM The_nap_tien where So_tien ='{0}'", So_tien);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            int kq = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if ((int)dr["Tinh_trang"] == 1)
                {
                    kq += 1;
                }
            }
            return kq;
        }
        public double Lay_so_tien(string Ma_code)
        {
            String sql = string.Format("SELECT * FROM The_nap_tien where Ma_code = '{0}'", Ma_code);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return double.Parse(dt.Rows[0]["So_tien"].ToString());
        }
        public List<DTO.The_nap_tien> Ds_the()
        {
            List<DTO.The_nap_tien> kq = new List<DTO.The_nap_tien>();
            String sql = string.Format("SELECT * FROM The_nap_tien");
            DataTable dt = DataProvider.ExecuteQuery(sql);
            foreach (DataRow dr in dt.Rows)
            {
                DTO.The_nap_tien temp = new DTO.The_nap_tien();
                temp.Ma_code = dr["Ma_code"].ToString();
                temp.So_tien = double.Parse(dr["So_tien"].ToString());
                temp.Tinh_trang = (int)dr["Tinh_trang"];
                kq.Add(temp);
            }
            return kq;
        }
    }
}
