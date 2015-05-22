using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Reporting.WinForms;
using System.Globalization;
using System.Resources;

namespace Giao_diện
{
    public partial class Quản_lý : Form
    {
        Service.Service1Client sc = new Service.Service1Client();
        public Quản_lý()
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

            btChuyen.Text = rm.GetString("chuyen", culture);
            btNhan.Text = rm.GetString("nhan", culture);
            btntim.Text = rm.GetString("timtheongay", culture);
            btQuay_lai.Text = rm.GetString("quaylai", culture);
            lblngaybd.Text = rm.GetString("ngaybd", culture);
            lblngaykt.Text = rm.GetString("ngaykt", culture);
            lbltip.Text = rm.GetString("tip", culture);
            btTatCa.Text = rm.GetString("tatca", culture);
            
        }

        private void btQuay_lai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void btXuat_Click(object sender, EventArgs e)
        //{
        //    saveFileDialog1.InitialDirectory = "C:";
        //    saveFileDialog1.Title = "Save as Excel file";
        //    saveFileDialog1.FileName = "";
        //    saveFileDialog1.Filter = "Excel files(2007)|*.xlsx";
        //    if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
        //    {
        //        Microsoft.Office.Interop.Excel.Application Excelapp = new Microsoft.Office.Interop.Excel.Application();
        //        Excelapp.Application.Workbooks.Add(Type.Missing);
        //        Excelapp.Columns.ColumnWidth = 20;
        //        for (int i = 1; i < dsChuyen_nhan.Columns.Count+1; i++)
        //        {
        //            Excelapp.Cells[1, i] = dsChuyen_nhan.Columns[i-1].HeaderText;
        //        }
        //        for (int i = 0; i < dsChuyen_nhan.Rows.Count; i++)
        //        {
        //            for (int j = 0; j < dsChuyen_nhan.Columns.Count; j++)
        //            {
        //                Excelapp.Cells[i + 2, j + 1] = dsChuyen_nhan.Rows[i].Cells[j].Value.ToString();
        //            }
        //        }
        //        Excelapp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
        //        Excelapp.ActiveWorkbook.Saved = true;
        //        Excelapp.Quit();
        //    }
        //    Thông_báo.Loi = "Đã xuất thành công";
        //    Thông_báo Tb = new Thông_báo();
        //    Tb.ShowDialog();
        //}

        private void Quản_lý_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Thong_tin_chuyen_tien.Chuyen_Tien' table. You can move, or remove it, as needed.
            //dsChuyen_nhan.DataSource = sc.Ds_chuyen_tien_tong(Khách_hàng.So_tai_khoan);
            Chuyen_tienBindingSource.DataSource = sc.Ds_chuyen_tien_tong(Khách_hàng.So_tai_khoan);
            this.reportViewer1.RefreshReport();
        }


        private void btChuyen_Click(object sender, EventArgs e)
        {
            NBT.Text = "";
            NKT.Text = "";
            //dsChuyen_nhan.DataSource = sc.Ds_chuyen_tien(Khách_hàng.So_tai_khoan);
            Chuyen_tienBindingSource.DataSource = sc.Ds_chuyen_tien(Khách_hàng.So_tai_khoan);
            this.reportViewer1.RefreshReport();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            NBT.Text = "";
            NKT.Text = "";
            //dsChuyen_nhan.DataSource = sc.Ds_nhan_tien(Khách_hàng.So_tai_khoan);
            Chuyen_tienBindingSource.DataSource = sc.Ds_nhan_tien(Khách_hàng.So_tai_khoan);
            this.reportViewer1.RefreshReport();
        }

        private void btTatCa_Click(object sender, EventArgs e)
        {
            NBT.Text = "";
            NKT.Text = "";
            //dsChuyen_nhan.DataSource = sc.Ds_chuyen_tien_tong(Khách_hàng.So_tai_khoan);
            Chuyen_tienBindingSource.DataSource = sc.Ds_chuyen_tien_tong(Khách_hàng.So_tai_khoan);
            this.reportViewer1.RefreshReport();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            NBT.Text = monthCalendar1.SelectionStart.ToString();
            NKT.Text = monthCalendar1.SelectionEnd.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Chuyen_tienBindingSource.DataSource = sc.Danh_sach_theo_ngay(monthCalendar1.SelectionStart, monthCalendar1.SelectionEnd);
            this.reportViewer1.RefreshReport();
        }
    }
}
