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
    public partial class Xóa_khách_hàng : Form
    {
        DTO.Khach_hang khach_hang = new DTO.Khach_hang();
        Service.Service1Client sc = new Service.Service1Client();
        public Xóa_khách_hàng()
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

            lblhuykh.Text = rm.GetString("huykh", culture);
            lblchonkh.Text = rm.GetString("chonkhmuonhuy", culture);
            btnhuy.Text = rm.GetString("huy", culture);
            btQuay_lai.Text = rm.GetString("quaylai", culture);
            btnphuchoi.Text = rm.GetString("phuchoi", culture);
            tbxoa = rm.GetString("tbxoa", culture);
            
        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dsKhach_hang_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                dsKhach_hang.CurrentRow.Selected = true;
            }
            catch
            {
            }
        }

        string tbxoa;
        private void btHuy_Click(object sender, EventArgs e)
        {
            Thông_báo.Loi = tbxoa;
            Thông_báo.Cancel = true;
            Thông_báo Tb = new Thông_báo();
            Tb.ShowDialog();
            if (Thông_báo.Ok == true)
            {
                khach_hang.Ma_khach_hang = dsKhach_hang.CurrentRow.Cells["Ma_khach_hang"].Value.ToString();
                khach_hang.Ho_ten = dsKhach_hang.CurrentRow.Cells["Ho_ten"].Value.ToString();
                khach_hang.Cmnd = dsKhach_hang.CurrentRow.Cells["Cmnd"].Value.ToString();
                khach_hang.Gioi_tinh = dsKhach_hang.CurrentRow.Cells["Gioi_tinh"].Value.ToString();
                khach_hang.Ngay_sinh = DateTime.Parse(dsKhach_hang.CurrentRow.Cells["Ngay_sinh"].Value.ToString());
                khach_hang.Dia_chi = dsKhach_hang.CurrentRow.Cells["Dia_chi"].Value.ToString();
                khach_hang.Tinh_trang = -1;
                sc.Thay_doi_khach_hang(khach_hang);
                dsKhach_hang.DataSource = sc.Ds_khach();
                foreach (DTO.Tai_khoan tk in sc.Ds_tai_khoan_theo_kh(khach_hang.Ma_khach_hang))
                {
                    sc.Thay_doi_tinh_trang(tk.So_tai_khoan, -1);
                }
            }
        }

        private void Xóa_khách_hàng_Load(object sender, EventArgs e)
        {
            dsKhach_hang.DataSource = sc.Ds_khach();
        }

        private void btPhucHoi_Click(object sender, EventArgs e)
        {
            khach_hang.Ho_ten = dsKhach_hang.CurrentRow.Cells["Ho_ten"].Value.ToString();
            khach_hang.Cmnd = dsKhach_hang.CurrentRow.Cells["Cmnd"].Value.ToString();
            khach_hang.Gioi_tinh = dsKhach_hang.CurrentRow.Cells["Gioi_tinh"].Value.ToString();
            khach_hang.Ngay_sinh = DateTime.Parse(dsKhach_hang.CurrentRow.Cells["Ngay_sinh"].Value.ToString());
            khach_hang.Dia_chi = dsKhach_hang.CurrentRow.Cells["Dia_chi"].Value.ToString();
            khach_hang.Tinh_trang = 1;
            sc.Thay_doi_khach_hang(khach_hang);
            dsKhach_hang.DataSource = sc.Ds_khach();
            foreach (DTO.Tai_khoan tk in sc.Ds_tai_khoan_theo_kh(khach_hang.Ma_khach_hang))
            {
                sc.Thay_doi_tinh_trang(tk.So_tai_khoan, 1);
            }
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

    }
}
