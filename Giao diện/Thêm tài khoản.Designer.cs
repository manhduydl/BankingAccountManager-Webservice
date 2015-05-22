namespace Giao_diện
{
    partial class Thêm_tài_khoản
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Tai_khoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbltendn = new System.Windows.Forms.Label();
            this.lblmk = new System.Windows.Forms.Label();
            this.lbltienbandau = new System.Windows.Forms.Label();
            this.lbltaotk = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTDN = new System.Windows.Forms.TextBox();
            this.tbMK = new System.Windows.Forms.TextBox();
            this.tbTien = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btQuay_lai = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.Tai_khoanBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tai_khoanBindingSource
            // 
            this.Tai_khoanBindingSource.DataSource = typeof(DTO.Tai_khoan);
            // 
            // lbltendn
            // 
            this.lbltendn.Location = new System.Drawing.Point(104, 286);
            this.lbltendn.Name = "lbltendn";
            this.lbltendn.Size = new System.Drawing.Size(202, 24);
            this.lbltendn.TabIndex = 0;
            this.lbltendn.Text = "Tên đăng nhập:";
            this.lbltendn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblmk
            // 
            this.lblmk.Location = new System.Drawing.Point(159, 333);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(147, 24);
            this.lblmk.TabIndex = 1;
            this.lblmk.Text = "Mật khẫu:";
            this.lblmk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltienbandau
            // 
            this.lbltienbandau.Location = new System.Drawing.Point(102, 380);
            this.lbltienbandau.Name = "lbltienbandau";
            this.lbltienbandau.Size = new System.Drawing.Size(204, 24);
            this.lbltienbandau.TabIndex = 2;
            this.lbltienbandau.Text = "Số tiền ban đầu:";
            this.lbltienbandau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltaotk
            // 
            this.lbltaotk.AutoSize = true;
            this.lbltaotk.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaotk.Location = new System.Drawing.Point(3, 0);
            this.lbltaotk.Name = "lbltaotk";
            this.lbltaotk.Size = new System.Drawing.Size(249, 44);
            this.lbltaotk.TabIndex = 3;
            this.lbltaotk.Text = "Tạo tài khoản";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.lbltaotk);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 51);
            this.panel1.TabIndex = 4;
            // 
            // tbTDN
            // 
            this.tbTDN.Location = new System.Drawing.Point(328, 286);
            this.tbTDN.Name = "tbTDN";
            this.tbTDN.Size = new System.Drawing.Size(185, 29);
            this.tbTDN.TabIndex = 6;
            // 
            // tbMK
            // 
            this.tbMK.Location = new System.Drawing.Point(328, 333);
            this.tbMK.Name = "tbMK";
            this.tbMK.Size = new System.Drawing.Size(185, 29);
            this.tbMK.TabIndex = 7;
            // 
            // tbTien
            // 
            this.tbTien.Location = new System.Drawing.Point(328, 380);
            this.tbTien.Name = "tbTien";
            this.tbTien.Size = new System.Drawing.Size(185, 29);
            this.tbTien.TabIndex = 8;
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Aquamarine;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Location = new System.Drawing.Point(298, 417);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(121, 40);
            this.btThem.TabIndex = 9;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(542, 417);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(126, 40);
            this.btQuay_lai.TabIndex = 5;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tai_khoanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Giao_diện.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(649, 194);
            this.reportViewer1.TabIndex = 10;
            // 
            // Thêm_tài_khoản
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(680, 466);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.tbTien);
            this.Controls.Add(this.tbMK);
            this.Controls.Add(this.tbTDN);
            this.Controls.Add(this.btQuay_lai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltienbandau);
            this.Controls.Add(this.lblmk);
            this.Controls.Add(this.lbltendn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Thêm_tài_khoản";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm_tài_khoản";
            this.Load += new System.EventHandler(this.Thêm_tài_khoản_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tai_khoanBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltendn;
        private System.Windows.Forms.Label lblmk;
        private System.Windows.Forms.Label lbltienbandau;
        private System.Windows.Forms.Label lbltaotk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btQuay_lai;
        private System.Windows.Forms.TextBox tbTDN;
        private System.Windows.Forms.TextBox tbMK;
        private System.Windows.Forms.TextBox tbTien;
        private System.Windows.Forms.Button btThem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tai_khoanBindingSource;
    }
}