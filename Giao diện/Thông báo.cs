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
    public partial class Thông_báo : Form
    {
        public static string Loi="Chương trình đã gặp sự cố";
        public static bool Cancel = false;
        public static bool Ok = true;
        public Thông_báo()
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

            lblthongbao.Text = rm.GetString("thongbao", culture);
            
        }

        private void Thông_báo_Load(object sender, EventArgs e)
        {
            lbThongbao.Text = Loi;
            if (Cancel)
            {
                btCancel.Visible = true;
                this.AcceptButton = btCancel;
            }
            else
                this.AcceptButton = button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ok = true;
            Cancel = false;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Ok = false;
            Cancel = false;
            this.Close();
        }
    }
}
