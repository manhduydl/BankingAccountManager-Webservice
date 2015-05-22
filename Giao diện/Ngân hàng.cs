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
    public partial class Ngân_hàng : Form
    {
        Service.Service1Client sc = new Service.Service1Client();
        public Ngân_hàng()
        {
            InitializeComponent();
            bindingSourceNH.DataSource = Auto_logout.start_autolog();
            UpdateLang();
        }

        //bổ sung thêm
        CultureInfo culture;
        private void UpdateLang()
        {
            culture = CultureInfo.CurrentCulture;
            string cultureName = Check_Lang.Curr_Lang;
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("Giao_diện.Lang.MyResource", typeof(Form1).Assembly);
            label1.Text = rm.GetString("nganhang", culture);
            txtTen.Text = rm.GetString("tennganhang", culture);
            btQLTK.Text = rm.GetString("quanlitk", culture);
            btnQLKH.Text = rm.GetString("quanlykh", culture);
            btDang_xuat.Text = rm.GetString("dangxuat", culture);
            
        }
        //------------------

        private void btDang_xuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTaocode_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tạo_code TCD = new Tạo_code();
            TCD.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Quản_lý_khách_hàng QLKH = new Quản_lý_khách_hàng();
            QLKH.ShowDialog();
        }

        private void Ngân_hàng_Load(object sender, EventArgs e)
        {
            txtTen.Text += sc.Lay_ten_ngan_hang();
        }

        private void btQLTK_Click(object sender, EventArgs e)
        {
            Quản_lý_tài_khoảncs QLTK = new Quản_lý_tài_khoảncs();
            QLTK.ShowDialog();
        }
    }
}
