using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_diện
{
    public partial class Thêm_tài_khoản_kh : Form
    {
        Service.Service1Client sc = new Service.Service1Client();
        public Thêm_tài_khoản_kh()
        {
            InitializeComponent();
            UpdateLang();
        }

        CultureInfo culture;
        private void UpdateLang()
        {
            culture = CultureInfo.CurrentCulture;
            string cultureName = Check_Lang.Curr_Lang;
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("Giao_diện.Lang.MyResource", typeof(Form1).Assembly);

            //STK.Text = rm.GetString("sotaikhoan", culture);
            lblchonkh.Text = rm.GetString("chonkh", culture);
            btChon.Text = rm.GetString("chon", culture);
            btQuay_lai.Text = rm.GetString("quaylai", culture);
           
        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dsKhach_hang_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dsKhach_hang.CurrentRow.Selected = true;
            }
            catch
            {
            }
        }

        private void Thêm_tài_khoản_kh_Load(object sender, EventArgs e)
        {
            dsKhach_hang.DataSource = sc.Ds_khach();
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            Thêm_tài_khoản.Ma_khach_hang = dsKhach_hang.CurrentRow.Cells["Ma_khach_hang"].Value.ToString();
            Thêm_tài_khoản ttk = new Thêm_tài_khoản();
            ttk.ShowDialog();
        }
    }
}
