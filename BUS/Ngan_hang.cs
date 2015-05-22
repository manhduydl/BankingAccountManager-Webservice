using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class Ngan_hang
    {
        DAO.Ngan_hang NH = new DAO.Ngan_hang();
        public string Lay_ten_ngan_hang()
        {
            return NH.Lay_ten_ngan_hang();
        }
        public void Doi_ten_ngan_hang(string ten_moi)
        {
            NH.Doi_ten_ngan_hang(ten_moi);
        }
    }
}
