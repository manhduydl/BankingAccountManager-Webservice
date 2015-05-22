using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Ngan_hang
    {
        public string Lay_ten_ngan_hang()
        {
            String sql = "SELECT * FROM Ngan_hang";
            DataTable dt = DataProvider.ExecuteQuery(sql);
            return dt.Rows[0]["Ten_ngan_hang"].ToString();
        }
        public void Doi_ten_ngan_hang(string ten_moi)
        {
            String sql = "SELECT * FROM Ngan_hang";
            DataTable dt = DataProvider.ExecuteQuery(sql);
            string ma_ngan_hang = dt.Rows[0]["Ma_ngan_hang"].ToString();
            sql = string.Format("update Ngan_hang set Ten_ngan_hang='{0}' where Ma_ngan_hang='{1}'", ten_moi, ma_ngan_hang);
            DataProvider.ThucThi(sql);
        }
    }
}
