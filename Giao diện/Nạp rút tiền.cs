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
    public partial class Nạp_rút_tiền : Form
    {
        string stk;
        double st;
        Service.Service1Client sc = new Service.Service1Client();
        public Nạp_rút_tiền()
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

            lblnaprut.Text = rm.GetString("napruttien", culture);
            lblsotien.Text = rm.GetString("sotien", culture);
            lblstk.Text = rm.GetString("sotaikhoan", culture);
            btChon.Text = rm.GetString("chontk", culture);
            btNap.Text= rm.GetString("naptien", culture);
            btRut.Text= rm.GetString("ruttien", culture);
            btQuay_lai.Text = rm.GetString("quaylai", culture);
            btTDTT.Text = rm.GetString("thaydoitrangthai", culture);
            
        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dsTai_khoan_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                dsTai_khoan.CurrentRow.Selected = true;
            }
            catch
            {
            }
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            stk = dsTai_khoan.CurrentRow.Cells["So_tai_khoan"].Value.ToString();
            panel2.Visible = true;
            label4.Text = stk.ToString();
            lblsthc.Text = sc.Lay_so_tien(stk).ToString();
        }

        private void btNap_Click(object sender, EventArgs e)
        {
            Thông_báo.Loi = "Bạn thật sự muốn nạp tiền vào tài khoản này?";
            Thông_báo.Cancel = true;
            Thông_báo Tb = new Thông_báo();
            Tb.ShowDialog();
            if (Thông_báo.Ok == true)
            {
                st = double.Parse(textBox1.Text);
                sc.Nap_tien(stk, st);
                lblsthc.Text = sc.Lay_so_tien(stk).ToString();
                Thông_báo.Loi = "Đã nạp " + st.ToString();
                Thông_báo TB = new Thông_báo();
                TB.ShowDialog();
            }
            

        }

        double sotienhienco;
        private void btRut_Click(object sender, EventArgs e)
        {
            st = double.Parse(textBox1.Text);
            sotienhienco = sc.Lay_so_tien(stk);
            if (st > sotienhienco)
            {
                Thông_báo.Loi = "Số tiền rút lớn hơn số tiền hiện có.";
                Thông_báo TB = new Thông_báo();
                TB.ShowDialog();

            }
            else
            {
                sc.Rut_tien(stk, st);
                lblsthc.Text = sc.Lay_so_tien(stk).ToString();
                Thông_báo.Loi = "Đã rút "+st.ToString();
                Thông_báo TB = new Thông_báo();
                TB.ShowDialog();
            }
        }

        private void Nạp_rút_tiền_Load(object sender, EventArgs e)
        {
            dsTai_khoan.DataSource = sc.Ds_tai_khoan();
        }

        private void btTDTT_Click(object sender, EventArgs e)
        {
            Thay_đỗi_tài_khoản TDTK = new Thay_đỗi_tài_khoản();
            TDTK.ShowDialog();
        }
    }
}
