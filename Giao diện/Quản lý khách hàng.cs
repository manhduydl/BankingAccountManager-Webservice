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
    public partial class Quản_lý_khách_hàng : Form
    {
        Service.Service1Client sc = new Service.Service1Client();
        public Quản_lý_khách_hàng()
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

            lblqlikh.Text = rm.GetString("quanlykh", culture);
            btQuay_lai.Text = rm.GetString("quaylai", culture);
            btSua.Text = rm.GetString("suathongtin", culture);
            btThem.Text = rm.GetString("themkh", culture);
            btXoa.Text = rm.GetString("huykh", culture);
            
        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Thêm_khách_hàng TKH = new Thêm_khách_hàng();
            TKH.ShowDialog();
            Khach_hangBindingSource.DataSource = sc.Ds_khach();
            this.reportViewer1.RefreshReport();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Xóa_khách_hàng XKH = new Xóa_khách_hàng();
            XKH.ShowDialog();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            Sữa_khách_hàng SKH = new Sữa_khách_hàng();
            SKH.ShowDialog();
            Khach_hangBindingSource.DataSource = sc.Ds_khach();
            this.reportViewer1.RefreshReport();
        }

        private void Quản_lý_khách_hàng_Load(object sender, EventArgs e)
        {
            Khach_hangBindingSource.DataSource = sc.Ds_khach();
            this.reportViewer1.RefreshReport();
        }
    }
}
