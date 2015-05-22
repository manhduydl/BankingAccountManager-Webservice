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
    public partial class Thêm_tài_khoản : Form
    {
        public static string Ma_khach_hang;
        Service.Service1Client sc = new Service.Service1Client();
        public Thêm_tài_khoản()
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

            lbltaotk.Text = rm.GetString("taotk", culture);
            lblmk.Text = rm.GetString("matkhau", culture);
            lbltendn.Text = rm.GetString("tendn", culture);
            lbltienbandau.Text = rm.GetString("sotienbandau", culture);
            btThem.Text = rm.GetString("them", culture);
            btQuay_lai.Text = rm.GetString("quaylai", culture);
        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            DTO.Dang_nhap dangnhap = new DTO.Dang_nhap();
            dangnhap.Ten_dang_nhap = tbTDN.Text;
            dangnhap.Mat_khau = tbMK.Text;

            DTO.Tai_khoan taikhoan = new DTO.Tai_khoan();
            taikhoan.Ma_khach_hang = Ma_khach_hang;
            taikhoan.So_tien = double.Parse(tbTien.Text);
            taikhoan.Tinh_trang = 1;
            taikhoan.Loai_tai_khoan = "thuong";
            if (sc.Them_tai_khoan(taikhoan, dangnhap))
            {
                Tai_khoanBindingSource.DataSource = sc.Ds_tai_khoan_theo_kh(Ma_khach_hang);
                this.reportViewer1.RefreshReport();
            }
            else
            {
                Thông_báo.Loi = "Tên đăng nhập đã được sử dụng";
                Thông_báo tb = new Thông_báo();
                tb.ShowDialog();
            }
        }

        private void Thêm_tài_khoản_Load(object sender, EventArgs e)
        {
            Tai_khoanBindingSource.DataSource = sc.Ds_tai_khoan_theo_kh(Ma_khach_hang);
            this.reportViewer1.RefreshReport();
        }

    }
}
