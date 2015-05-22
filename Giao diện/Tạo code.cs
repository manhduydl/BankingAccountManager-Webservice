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
    public partial class Tạo_code : Form
    {
        Service.Service1Client sc = new Service.Service1Client();
        public Tạo_code()
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

            gbxtaocode.Text = rm.GetString("tudongtaocode", culture);
            lblmenhgia.Text = rm.GetString("menhgia", culture);
            btnTao.Text = rm.GetString("tao", culture);
            btQuay_lai.Text = rm.GetString("quaylai", culture);
            
        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btTaocode_Click(object sender, EventArgs e)
        {
            double menhgia = double.Parse(tbMenhgia.Text);
            sc.Tao_the_ngan_hang(menhgia);
            Thông_báo.Loi = "Tạo code thành công";
            Thông_báo TB = new Thông_báo();
            TB.ShowDialog();
            dsthe.DataSource = sc.Ds_the();
        }

        private void tbMenhgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void Tạo_code_Load(object sender, EventArgs e)
        {
            dsthe.DataSource = sc.Ds_the();
        }

    }
}
