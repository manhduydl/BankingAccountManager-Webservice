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
    public partial class Nạp_tiền : Form
    {
        public static bool Hop_le = true;
        int dem;
        Service.Service1Client sc = new Service.Service1Client();
        public Nạp_tiền()
        {
            InitializeComponent();
            dem = 0;
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

            lblmacode.Text = rm.GetString("macode", culture);
            lblthedanap.Text = rm.GetString("cacthedanap", culture);
            btNap.Text = rm.GetString("naptien", culture);
            btQuayLai.Text = rm.GetString("quaylai", culture);
            saima = rm.GetString("saima", culture);
            nhiulan = rm.GetString("nhiulan", culture);
            nap1 = rm.GetString("nap1", culture);
            nap2 = rm.GetString("nap2", culture);
            
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string saima, nhiulan, nap1, nap2;
        private void button1_Click(object sender, EventArgs e)
        {
            //Kiểm tra code hợp lệ
            string code = tb3d.Text.ToString() + "-" + tb3g.Text.ToString() + "-" + tb3c.Text.ToString();
            DTO.Nap_tien NT = new DTO.Nap_tien();
            NT.Ma_code = code;
            NT.Stk_nap = Khách_hàng.So_tai_khoan;
            NT.Thoi_gian_gd = DateTime.Now;
            int kiemtra = sc.Them_nap_tien(NT, code);
            if (kiemtra == -1)
            {
                Thông_báo.Loi = saima;
                Thông_báo TB = new Thông_báo();
                TB.ShowDialog();
                dem += 1;
                if (dem == 3)
                {
                    Hop_le = false;
                    Thông_báo.Loi = nhiulan;
                    TB.ShowDialog();
                    sc.Thay_doi_tinh_trang(Khách_hàng.So_tai_khoan, -1);
                    this.Close();
                }
            }
            if (kiemtra == 0)
            {
                Thông_báo.Loi = "Mã code đã được nạp";
                Thông_báo TB = new Thông_báo();
                TB.ShowDialog();
                dem += 1;
                if (dem == 3)
                {
                    Hop_le = false;
                    Thông_báo.Loi = nhiulan;
                    TB.ShowDialog();
                    sc.Thay_doi_tinh_trang(Khách_hàng.So_tai_khoan, -1);
                    this.Close();
                }
            }
            if (kiemtra == 1)
            {
                string so_tien_nap = sc.Lay_so_tien_the(code).ToString();
                Thông_báo.Loi = nap1 + so_tien_nap + nap2;
                Thông_báo TB = new Thông_báo();
                TB.ShowDialog();
                dsThenap.DataSource = sc.Ds_nap_tien(Khách_hàng.So_tai_khoan);
            }
        }

        private void tb3d_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb3g_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void tb3c_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Nạp_tiền_Load(object sender, EventArgs e)
        {
            dsThenap.DataSource = sc.Ds_nap_tien(Khách_hàng.So_tai_khoan);
        }
    }
}
