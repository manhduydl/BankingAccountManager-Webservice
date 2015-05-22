using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_diện
{
    public partial class Khách_hàng : Form
    {
        public static DTO.Khach_hang KH;
        public static string So_tai_khoan;
        public static string Ten_dang_nhap;
        public static string Loai;
        string loaitk;
        string mi1, mi2, mi3;
        Service.Service1Client sc = new Service.Service1Client();
        string title;

        public Khách_hàng()
        {
            InitializeComponent();
            bindingSource1KH.DataSource = Auto_logout.start_autolog();
            UpdateLang();

            update_image();

            ContextMenu mnu = new ContextMenu();
            MenuItem CCM = new MenuItem(mi1);
            MenuItem CH = new MenuItem(mi2);
            MenuItem RM = new MenuItem(mi3);
            CCM.Click += new EventHandler(Chon_tu_may);
            CH.Click += new EventHandler(Chup_hinh);
            RM.Click += new EventHandler(Xoa_hinh);
            
            mnu.MenuItems.AddRange(new MenuItem[] { CCM,CH,RM });
            panel1.ContextMenu = mnu;
        }

        private void Xoa_hinh(object sender, EventArgs e)
        {
            panel1.BackgroundImage = Giao_diện.Properties.Resources.administrator2_48;
            Caches.caches_image("");
        }
        
        private void Chup_hinh(object sender, EventArgs e)
        {
            //panel1.BackgroundImage = null;
            //File.Delete(Application.StartupPath + "\\avatar.png");
            WebcamDemo.WebCam FWebcam = new WebcamDemo.WebCam();
            FWebcam.ShowDialog();
            try
            {
                Them_du_lieu_hinh("Resources\\avatar.png");
                update_image();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                panel1.BackgroundImage = Giao_diện.Properties.Resources.administrator2_48;
                Caches.caches_image("");
            }   
        }

        private void Them_du_lieu_hinh(string duong_dan)
        {
            Byte[] Du_lieu_hinh = null;
            if (File.Exists(duong_dan))
                Du_lieu_hinh = File.ReadAllBytes(duong_dan);

            if (Du_lieu_hinh != null)
            {
                string chuoi_hinh = Convert.ToBase64String(Du_lieu_hinh);
                Caches.caches_image(chuoi_hinh);
            }
        }

        private void update_image()
        {
            string chuoi_hinh = Caches.load_image();
            if (chuoi_hinh != "")
            {
                Byte[] Du_lieu_hinh = Convert.FromBase64String(chuoi_hinh);
                MemoryStream bo_nho = new MemoryStream(Du_lieu_hinh);
                Bitmap hinh = new Bitmap(Image.FromStream(bo_nho));
                panel1.BackgroundImage = hinh;
            }
            else
                panel1.BackgroundImage = Giao_diện.Properties.Resources.administrator2_48;
        }

        private void Chon_tu_may(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            Them_du_lieu_hinh(openFileDialog1.FileName);
                            update_image();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    panel1.BackgroundImage = Giao_diện.Properties.Resources.administrator2_48;
                    Caches.caches_image("");
                }
            }
        }

      

        //cập nhật ngôn ngữ
        CultureInfo culture;
        private void UpdateLang()
        {
            culture = CultureInfo.CurrentCulture;
            string cultureName = Check_Lang.Curr_Lang;
            culture = CultureInfo.CreateSpecificCulture(cultureName);
            ResourceManager rm = new
                ResourceManager("Giao_diện.Lang.MyResource", typeof(Form1).Assembly);

            btDang_xuat.Text = rm.GetString("dangxuat", culture);
            STK.Text = rm.GetString("sotaikhoan", culture);
            Ten.Text = rm.GetString("hoten", culture);
            MaKH.Text = rm.GetString("makhachhang", culture);
            CMND.Text = rm.GetString("cmnd", culture);
            GT.Text = rm.GetString("gioitinh", culture);
            NS.Text = rm.GetString("ngaysinh", culture);
            DC.Text = rm.GetString("diachi", culture);
            STHC.Text = rm.GetString("sotienhienco", culture);
            title = rm.GetString("thongtinkh", culture);
            if (Loai == "thuong")
                loaitk = rm.GetString("tkthuong", culture);
            else
                loaitk = rm.GetString("tkvip", culture);
            thoat = rm.GetString("muonthoat", culture);
            btnthongke.Text = rm.GetString("thongke", culture);
            btnchuyentien.Text = rm.GetString("chuyentien", culture);
            btNap_tien.Text = rm.GetString("naptien", culture);
            btndoitk.Text = rm.GetString("doimatkhau", culture);
            mi1 = rm.GetString("chontumay", culture);
            mi2 = rm.GetString("chupanhmoi", culture);
            mi3 = rm.GetString("xoaanh", culture);
        }
        //------------------

        string thoat;
        private void btDang_xuat_Click(object sender, EventArgs e)
        {
            Thông_báo.Loi = thoat;
            Thông_báo.Cancel = true;
            Thông_báo Tb = new Thông_báo();
            Tb.ShowDialog();
            if (Thông_báo.Ok == true)
            {
                this.Close();
            }
        }

        private void btNap_tien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nạp_tiền NT = new Nạp_tiền();
            NT.ShowDialog();
            this.Show();
            if (Nạp_tiền.Hop_le == false)
            {
                this.Close();
            }
            lblSotien.Text = (sc.Lay_so_tien(So_tai_khoan)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Chuyển_tiền.So_tien_hien_co = sc.Lay_so_tien(So_tai_khoan);
            Chuyển_tiền.STK = So_tai_khoan;
            //Chuyển_tiền.So_tien_hien_co = st;
            Chuyển_tiền CT = new Chuyển_tiền();
            CT.ShowDialog();
            this.Show();
            lblSotien.Text = (sc.Lay_so_tien(So_tai_khoan)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Quản_lý QL = new Quản_lý();
            QL.ShowDialog();
            this.Show();
        }

        private void btDMK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Đỗi_mật_khẫu.MKH = Ten_dang_nhap;
            Đỗi_mật_khẫu DMK = new Đỗi_mật_khẫu();
            DMK.ShowDialog();
            this.Show();
        }

        private void Khách_hàng_Load(object sender, EventArgs e)
        {
            lblStk.Text = So_tai_khoan;
            lblHoten.Text = KH.Ho_ten;
            lblMakh.Text = KH.Ma_khach_hang;
            lblCmnd.Text= KH.Cmnd;
            lblGioitinh.Text= KH.Gioi_tinh;
            lblNgaysinh.Text= KH.Ngay_sinh.ToString();
            lblDiachi.Text= KH.Dia_chi;
            lblSotien.Text= (sc.Lay_so_tien(So_tai_khoan)).ToString();
            lbLoaiTK.Text = loaitk;
            gbxKh.Text = title;

        }

   
    }
}
