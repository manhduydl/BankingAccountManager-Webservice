using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Khach_hang
    {
        public DTO.Khach_hang Lay_khach_hang(string Ma_khach_hang)
        {
            String sql = string.Format("SELECT * FROM Khach_hang where Ma_khach_hang = '{0}'",Ma_khach_hang);
            DataTable dt = DataProvider.ExecuteQuery(sql);
            DTO.Khach_hang kq = new DTO.Khach_hang();
            kq.Ma_khach_hang = dt.Rows[0]["Ma_khach_hang"].ToString();
            kq.Ho_ten = dt.Rows[0]["Ho_ten"].ToString();
            kq.Cmnd = dt.Rows[0]["Cmnd"].ToString();
            kq.Gioi_tinh = dt.Rows[0]["Gioi_tinh"].ToString();
            kq.Ngay_sinh = DateTime.Parse(dt.Rows[0]["Ngay_sinh"].ToString());
            kq.Dia_chi = dt.Rows[0]["Dia_chi"].ToString();
            return kq;
        }
        public int So_khach_hang()
        {
            String sql = string.Format("SELECT * FROM Khach_hang");
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return dt.Rows.Count;
        }
        public List<DTO.Khach_hang> Ds_khach_hang()
        {
            String sql = string.Format("SELECT * FROM Khach_hang");
            DataTable dt = DataProvider.ExecuteQuery(sql);
            List<DTO.Khach_hang> kq = new List<DTO.Khach_hang>();
            foreach (DataRow dr in dt.Rows)
            {
                DTO.Khach_hang temp = new DTO.Khach_hang();
                temp.Ma_khach_hang = dr["Ma_khach_hang"].ToString();
                temp.Ho_ten = dr["Ho_ten"].ToString();
                temp.Cmnd = dr["Cmnd"].ToString();
                temp.Gioi_tinh = dr["Gioi_tinh"].ToString();
                temp.Ngay_sinh = DateTime.Parse(dr["Ngay_sinh"].ToString());
                temp.Dia_chi = dr["Dia_chi"].ToString();
                temp.Tinh_trang = (int)dr["Tinh_trang"];
                kq.Add(temp);
            }
            return kq;
        }
        public void Them_khach_hang(DTO.Khach_hang khachhang)
        {
            String sql = string.Format("insert into Khach_hang values ( '{0}',N'{1}','{2}',N'{3}','{4}',N'{5}','{6}')", khachhang.Ma_khach_hang,khachhang.Ho_ten,khachhang.Cmnd,khachhang.Gioi_tinh,khachhang.Ngay_sinh,khachhang.Dia_chi,khachhang.Tinh_trang);
            DataProvider.ThucThi(sql);
        }
        public void Thay_doi_khach_hang(DTO.Khach_hang khachhang)
        {
            String sql = string.Format("update Khach_hang set Ho_ten = N'{0}',Cmnd='{1}',Gioi_tinh=N'{2}',Ngay_sinh='{3}',Dia_chi=N'{4}',Tinh_trang='{5}' where Ma_khach_hang = '{6}'",khachhang.Ho_ten,khachhang.Cmnd,khachhang.Gioi_tinh,khachhang.Ngay_sinh.ToString(),khachhang.Dia_chi,khachhang.Tinh_trang,khachhang.Ma_khach_hang);
            DataProvider.ThucThi(sql);
        }
        public string Ma_khach_hang()
        {
            String sql = string.Format("SELECT * FROM Khach_hang");
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return dt.Rows[dt.Rows.Count - 1]["Ma_khach_hang"].ToString();
        }
    }
}
