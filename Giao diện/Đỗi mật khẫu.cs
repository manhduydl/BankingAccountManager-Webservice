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
    public partial class Đỗi_mật_khẫu : Form
    {
        public static string MKH;
        Service.Service1Client sc = new Service.Service1Client();
        public Đỗi_mật_khẫu()
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

            STK.Text = rm.GetString("taikhoan1", culture);
            lblmkcu.Text = rm.GetString("mkcu", culture);
            lblmkmoi.Text = rm.GetString("mkmoi", culture);
            lblnhaplai.Text = rm.GetString("nhaplaimk", culture);
            btndoimk.Text = rm.GetString("doimatkhau", culture);
            btQuayLai.Text = rm.GetString("quaylai", culture);
            mk1 = rm.GetString("mk1", culture);
            mk2 = rm.GetString("mk2", culture);
            mk3 = rm.GetString("mk3", culture);
            
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string mk1, mk2, mk3;
        private void button1_Click(object sender, EventArgs e)
        {
            if (sc.Dang_nhap(MKH, MKC.Text) == -1)
            {
                Thông_báo.Loi = mk1;
                Thông_báo tb = new Thông_báo();
                tb.ShowDialog();
            }
            else if (!Xet_mat_khau(MKM.Text, MKM2.Text))
            {
                Thông_báo.Loi = mk2;
                Thông_báo tb = new Thông_báo();
                tb.ShowDialog();
            }
            else
            {
                sc.Doi_mat_khau(MKH, MKM.Text);
                Thông_báo.Loi = mk3;
                Thông_báo tb = new Thông_báo();
                tb.ShowDialog();
                this.Close();
            }
        }

        private void Đỗi_mật_khẫu_Load(object sender, EventArgs e)
        {
            //STK.Text = STK.Text + MKH;
            lblTaikhoan.Text = MKH;
        }
        bool Xet_mat_khau(string mk1, string mk2)
        {
            if (mk1 == mk2)
            {
                return true;
            }
            return false;
        }
    }
}
