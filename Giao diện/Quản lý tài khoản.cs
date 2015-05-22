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
    public partial class Quản_lý_tài_khoảncs : Form
    {
        Service.Service1Client sc = new Service.Service1Client();
        public Quản_lý_tài_khoảncs()
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

            lblqlitk.Text = rm.GetString("quanlitk", culture);
            btndoitrangthai.Text = rm.GetString("doitrangthai", culture);
            btnnaprut.Text = rm.GetString("napruttien", culture);
            btThem.Text = rm.GetString("themtk", culture);
            btQuay_lai.Text = rm.GetString("quaylai", culture);
            
        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            Thêm_tài_khoản_kh ttk = new Thêm_tài_khoản_kh();
            ttk.ShowDialog();
        }

        private void Quản_lý_tài_khoảncs_Load(object sender, EventArgs e)
        {
            Tai_khoanBindingSource.DataSource = sc.Ds_tai_khoan();
            this.reportViewer1.RefreshReport();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            Thay_đỗi_tài_khoản TDTK = new Thay_đỗi_tài_khoản();
            TDTK.ShowDialog();
        }

        private void btNR_Click(object sender, EventArgs e)
        {
            Nạp_rút_tiền nrt = new Nạp_rút_tiền();
            nrt.ShowDialog();
            Tai_khoanBindingSource.DataSource = sc.Ds_tai_khoan();
            this.reportViewer1.RefreshReport();
        }
    }
}
