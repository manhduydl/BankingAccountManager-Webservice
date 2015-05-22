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
    public partial class Thêm_khách_hàng : Form
    {
        Service.Service1Client sc = new Service.Service1Client();
        public Thêm_khách_hàng()
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

            lblten.Text = rm.GetString("hoten", culture);
            lblcmnd.Text = rm.GetString("cmnd2", culture);
            lblgioitinh.Text = rm.GetString("gioitinh", culture);
            lblngaysinh.Text = rm.GetString("ngaysinh", culture);
            lbldiachi.Text = rm.GetString("diachi", culture);
            btnthem.Text = rm.GetString("them", culture);
            btQuay_lai.Text = rm.GetString("quaylai", culture);
            btnthemkh.Text = rm.GetString("themkh", culture);
            muonthem = rm.GetString("muonthem", culture);
        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string muonthem;
        private void button2_Click(object sender, EventArgs e)
        {
            if (tbTen.Text == "" || tbCMND.Text == "" || tbDia_chi.Text == "" || tbGT.Text == "" || tbNgaysinh.Text == "")
            {
                Thông_báo.Loi = "Chưa đủ thông tin khách hàng.";
                Thông_báo TB = new Thông_báo();
                TB.ShowDialog();
            }
            else
            {
                DTO.Khach_hang Khachhang = new DTO.Khach_hang();
                Khachhang.Ho_ten = tbTen.Text;
                Khachhang.Gioi_tinh = tbGT.Text;
                Khachhang.Ngay_sinh = tbNgaysinh.Value;
                Khachhang.Dia_chi = tbDia_chi.Text;
                Khachhang.Cmnd = tbCMND.Text;
                sc.Them_khach_hang(Khachhang);
                Khach_hangBindingSource.DataSource = sc.Ds_khach();
                this.reportViewer1.RefreshReport();
                Thông_báo.Loi = muonthem;
                Thông_báo.Cancel = true;
                Thông_báo TB = new Thông_báo();
                TB.ShowDialog();
                if (Thông_báo.Ok == true)
                {
                    Thêm_tài_khoản.Ma_khach_hang = sc.Ma_khach_hang();
                    Thêm_tài_khoản TTK = new Thêm_tài_khoản();
                    TTK.ShowDialog();
                }
            }
        }

        private void Thêm_khách_hàng_Load(object sender, EventArgs e)
        {
            Khach_hangBindingSource.DataSource = sc.Ds_khach();
            this.reportViewer1.RefreshReport();
        }
    }
}
