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
    public partial class Chuyển_tiền : Form
    {
        public static string STK;
        public static double So_tien_hien_co;
        Thông_báo TB = new Thông_báo();
        Service.Service1Client sc = new Service.Service1Client();
        public Chuyển_tiền()
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

            STHC.Text = rm.GetString("sotienhienco", culture);
            lblSotienchuyen.Text = rm.GetString("sotienchuyen", culture);
            lblstkchuyen.Text = rm.GetString("stknhan", culture);
            lblphi.Text = rm.GetString("phigd", culture);
            lblhd.Text = rm.GetString("hd", culture);
            btnchuyen.Text = rm.GetString("chuyen", culture);
            btQuay_lai.Text = rm.GetString("quaylai", culture);
            kdutien = rm.GetString("kdutien", culture);
            loitk = rm.GetString("loitk", culture);
            thanhcong = rm.GetString("thanhcong", culture);
            
        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string kdutien, loitk, thanhcong;
        private void button1_Click(object sender, EventArgs e)
        {
            //kiểm tra số tiền chuyển với số tiền hiện có
            //Nếu đủ chuyển tiền thành công
            //Nếu không đủ báo lỗi
            try
            {
                double stc = double.Parse(STC.Text);
                if (stc > So_tien_hien_co)
                {
                    Thông_báo.Loi = kdutien;
                    TB.ShowDialog();
                }
                else
                {
                    if (!sc.Kiem_tra_tai_khoan(STKC.Text))
                    {
                        Thông_báo.Loi = loitk;
                        TB.ShowDialog();
                    }
                    else
                    {
                        DTO.Chuyen_tien CT = new DTO.Chuyen_tien();
                        CT.Stk_chuyen = STK;
                        CT.Stk_nhan = STKC.Text;
                        CT.So_tien_chuyen = stc;
                        CT.Thoi_gian_gd = DateTime.Now;
                        sc.Them_chuyen_tien(CT, Khách_hàng.Loai);
                        Thông_báo.Loi = thanhcong;
                        TB.ShowDialog();
                        So_tien.Text = sc.Lay_so_tien(Khách_hàng.So_tai_khoan).ToString();
                    }
                }
            }
            catch
            {
                Thông_báo.Loi = "Số tiền chuyển phải là số";
                TB.ShowDialog();
            }
        }

        private void Chuyển_tiền_Load(object sender, EventArgs e)
        {
           So_tien.Text= So_tien_hien_co.ToString();
        }

        private void STC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
