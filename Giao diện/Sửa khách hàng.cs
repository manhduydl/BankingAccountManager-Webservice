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
    public partial class Sữa_khách_hàng : Form
    {
        DTO.Khach_hang khach_hang = new DTO.Khach_hang();
        Service.Service1Client sc = new Service.Service1Client();
        public Sữa_khách_hàng()
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

            lblchonkh.Text = rm.GetString("chonkhthaydoi", culture);
            lblcmnd.Text = rm.GetString("cmnd", culture);
            lbldiachi.Text = rm.GetString("diachi", culture);
            lblgt.Text = rm.GetString("gioitinh", culture);
            lblhoten.Text = rm.GetString("hoten", culture);
            lblmakh.Text = rm.GetString("makhachhang", culture);
            lblngaysinh.Text = rm.GetString("ngaysinh", culture);
            lblthaydoi.Text = rm.GetString("thaydoikh", culture);
            btChon.Text = rm.GetString("chon", culture);
            btnthaydoi.Text = rm.GetString("thaydoi", culture);
            btQuay_lai.Text = rm.GetString("quaylai", culture);
            ngsinhsai = rm.GetString("ngsinhsai", culture);

        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string ngsinhsai;
        private void button2_Click(object sender, EventArgs e)
        {
            //Thay đỗi thành công
            try
            {
                khach_hang.Ho_ten = tbHoten.Text;
                khach_hang.Cmnd = tbCmnd.Text;
                khach_hang.Gioi_tinh = tbGioitinh.Text;
                khach_hang.Ngay_sinh = DateTime.Parse(tbNgaysinh.Text);
                khach_hang.Dia_chi = tbDiachi.Text;
            }
            catch
            {
                Thông_báo.Loi = ngsinhsai;
                Thông_báo TB = new Thông_báo();
                TB.ShowDialog();
            }
            sc.Thay_doi_khach_hang(khach_hang);
            dsKhach_hang.DataSource = sc.Ds_khach();
            pnChon.Visible = true;
            pnSua.Visible = false;
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

        private void btChon_Click(object sender, EventArgs e)
        {
            khach_hang.Ma_khach_hang = dsKhach_hang.CurrentRow.Cells["Ma_khach_hang"].Value.ToString();
            tbHoten.Text = dsKhach_hang.CurrentRow.Cells["Ho_ten"].Value.ToString();
            tbCmnd.Text = dsKhach_hang.CurrentRow.Cells["Cmnd"].Value.ToString();
            tbGioitinh.Text = dsKhach_hang.CurrentRow.Cells["Gioi_tinh"].Value.ToString();
            tbNgaysinh.Text = dsKhach_hang.CurrentRow.Cells["Ngay_sinh"].Value.ToString();
            tbDiachi.Text = dsKhach_hang.CurrentRow.Cells["Dia_chi"].Value.ToString();
            MKH.Text = khach_hang.Ma_khach_hang;
            khach_hang.Tinh_trang = int.Parse(dsKhach_hang.CurrentRow.Cells["Tinh_trang"].Value.ToString());
            pnSua.Visible = true;
        }

        private void Sữa_khách_hàng_Load(object sender, EventArgs e)
        {
            dsKhach_hang.DataSource = sc.Ds_khach();
        }

    }
}
