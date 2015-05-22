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
    public partial class Thay_đỗi_tài_khoản : Form
    {
        Service.Service1Client sc = new Service.Service1Client();
        public Thay_đỗi_tài_khoản()
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

            lbltrangthai.Text = rm.GetString("thaydoitrangthaitk", culture);
            lbltinhtrang.Text = rm.GetString("tinhtrang", culture);
            lblloaitk.Text = rm.GetString("loaitk", culture);
            btnkhoa.Text = rm.GetString("khoa", culture);
            btnlenvip.Text = rm.GetString("lenvip", culture);
            btnphuchoi.Text = rm.GetString("phuchoi", culture);
            btnvethuong.Text = rm.GetString("vethuong", culture);

        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btPhuchoi_Click(object sender, EventArgs e)
        {
            string So_tai_khoan = dsTai_khoan.CurrentRow.Cells["So_tai_khoan"].Value.ToString();
            sc.Thay_doi_tinh_trang(So_tai_khoan, 1);
            dsTai_khoan.DataSource = sc.Ds_tai_khoan();
        }

        private void btKhoa_Click(object sender, EventArgs e)
        {
            string So_tai_khoan = dsTai_khoan.CurrentRow.Cells["So_tai_khoan"].Value.ToString();
            sc.Thay_doi_tinh_trang(So_tai_khoan, -1);
            dsTai_khoan.DataSource = sc.Ds_tai_khoan();
        }

        private void Thay_đỗi_tài_khoản_Load(object sender, EventArgs e)
        {
            dsTai_khoan.DataSource = sc.Ds_tai_khoan();
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

        private void btVip_Click(object sender, EventArgs e)
        {
            string So_tai_khoan = dsTai_khoan.CurrentRow.Cells["So_tai_khoan"].Value.ToString();
            sc.Thay_doi_loai_tai_khoan(So_tai_khoan, "vip");
            dsTai_khoan.DataSource = sc.Ds_tai_khoan();
        }

        private void btThuong_Click(object sender, EventArgs e)
        {
            string So_tai_khoan = dsTai_khoan.CurrentRow.Cells["So_tai_khoan"].Value.ToString();
            sc.Thay_doi_loai_tai_khoan(So_tai_khoan, "thuong");
            dsTai_khoan.DataSource = sc.Ds_tai_khoan();
        }

    }
}
