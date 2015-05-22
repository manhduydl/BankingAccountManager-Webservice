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
    public partial class Form1 : Form
    {
        List<string> L = Caches.load_caches();
        string loi1 = "Tài khoản và mật khẩu không hợp lệ";
        public Form1()
        {
            InitializeComponent();
            foreach (string st in L)
            {
                txtTK.AutoCompleteCustomSource.Add(st);
            }
            Check_Lang.SetDefault();
        }

        CultureInfo culture;
        private void UpdateLang()
        {
            culture = CultureInfo.CurrentCulture;
            string cultureName = Check_Lang.Curr_Lang;
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("Giao_diện.Lang.MyResource", typeof(Form1).Assembly);

            btnTieude.Text = rm.GetString("tenphanmem", culture);
            lblTk.Text = rm.GetString("taikhoan", culture);
            lblMk.Text = rm.GetString("matkhau", culture);
            lblngonngu.Text = rm.GetString("chonngonngu", culture);
            btDang_nhap.Text = rm.GetString("dangnhap", culture);
            btnThoat.Text = rm.GetString("thoat", culture);
            btnViet.Text = rm.GetString("tiengviet", culture);
            loi1 = rm.GetString("loidangnhap", culture);
             
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void reset()
        {
            txtTK.Text = "";
            txtMK.Text = "";
        }
        private void btDang_nhap_Click(object sender, EventArgs e)
        {
            //Kiểm tra điều kiện mật khẩu
            Service.Service1Client sc = new Service.Service1Client();
            int kq = sc.Dang_nhap(txtTK.Text, txtMK.Text);
            //Nếu đăng nhập với tài khoản khách hàng
            if (kq == 1)
            {
                Caches.caches_start(txtTK.Text);
                txtTK.AutoCompleteCustomSource.Add(txtTK.Text);

                Khách_hàng.Ten_dang_nhap = txtTK.Text;
                Khách_hàng.So_tai_khoan = sc.Lay_so_tai_khoan(txtTK.Text, txtMK.Text);
                if (sc.Lay_tinh_trang(Khách_hàng.So_tai_khoan) == 1)
                {
                    Khách_hàng.Loai = sc.Lay_loai_tai_khoan(Khách_hàng.So_tai_khoan);
                    Khách_hàng.KH = sc.Lay_khach_hang(txtTK.Text, txtMK.Text);
                    Khách_hàng KH = new Khách_hàng();
                    KH.ShowDialog();
                    reset();
                }
                else
                {
                    Thông_báo.Loi = "Tài khoản đã bị khóa hoặc không còn giá trị \nLiên hệ ngân hàng để biết thêm thông tin";
                    Thông_báo TB = new Thông_báo();
                    TB.ShowDialog();
                }
            }
          

            //Nếu đăng nhập với tài khoản ngân hàng
            if (kq == 0)
            {
                Caches.caches_start(txtTK.Text);
                txtTK.AutoCompleteCustomSource.Add(txtTK.Text);

                Ngân_hàng NH = new Ngân_hàng();
                NH.ShowDialog();
                reset();
            }

            //Nếu mật khẩu và tài khoản không hợp lê
            
            
            if (kq == -1)
            {
                Thông_báo.Loi = loi1;
                Thông_báo TB = new Thông_báo();
                TB.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Check_Lang.Curr_Lang = "en-US";
            UpdateLang();
        }
        
        private void btnViet_Click(object sender, EventArgs e)
        {
            Check_Lang.Curr_Lang = "vi-VN";
            UpdateLang();
        }


    }
}
