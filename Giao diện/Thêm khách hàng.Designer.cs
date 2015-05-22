namespace Giao_diện
{
    partial class Thêm_khách_hàng
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
            this.Khach_hangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnthemkh = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btQuay_lai = new System.Windows.Forms.Button();
            this.lblten = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.lblcmnd = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.tbCMND = new System.Windows.Forms.TextBox();
            this.tbDia_chi = new System.Windows.Forms.TextBox();
            this.tbNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.tbGT = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Khach_hangBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Khach_hangBindingSource
            // 
            this.Khach_hangBindingSource.DataSource = typeof(DTO.Khach_hang);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.btnthemkh);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 57);
            this.panel1.TabIndex = 0;
            // 
            // btnthemkh
            // 
            this.btnthemkh.AutoSize = true;
            this.btnthemkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemkh.ForeColor = System.Drawing.Color.Black;
            this.btnthemkh.Location = new System.Drawing.Point(3, 9);
            this.btnthemkh.Name = "btnthemkh";
            this.btnthemkh.Size = new System.Drawing.Size(289, 39);
            this.btnthemkh.TabIndex = 0;
            this.btnthemkh.Text = "Thêm khách hàng";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Khach_hangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Giao_diện.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 75);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 200);
            this.reportViewer1.TabIndex = 22;
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(542, 404);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(126, 40);
            this.btQuay_lai.TabIndex = 1;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
            // 
            // lblten
            // 
            this.lblten.Location = new System.Drawing.Point(12, 285);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(115, 24);
            this.lblten.TabIndex = 7;
            this.lblten.Text = "Tên:";
            this.lblten.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.GreenYellow;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Image = global::Giao_diện.Properties.Resources.add_image_48;
            this.btnthem.Location = new System.Drawing.Point(12, 398);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(183, 53);
            this.btnthem.TabIndex = 9;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbTen
            // 
            this.tbTen.BackColor = System.Drawing.Color.White;
            this.tbTen.Location = new System.Drawing.Point(133, 281);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(184, 29);
            this.tbTen.TabIndex = 11;
            // 
            // lblcmnd
            // 
            this.lblcmnd.Location = new System.Drawing.Point(16, 319);
            this.lblcmnd.Name = "lblcmnd";
            this.lblcmnd.Size = new System.Drawing.Size(111, 24);
            this.lblcmnd.TabIndex = 12;
            this.lblcmnd.Text = "CMND:";
            this.lblcmnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.Location = new System.Drawing.Point(20, 354);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(107, 24);
            this.lblgioitinh.TabIndex = 13;
            this.lblgioitinh.Text = "Giới tính:";
            this.lblgioitinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.Location = new System.Drawing.Point(340, 285);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(138, 24);
            this.lblngaysinh.TabIndex = 14;
            this.lblngaysinh.Text = "Ngày sinh:";
            this.lblngaysinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbldiachi
            // 
            this.lbldiachi.Location = new System.Drawing.Point(340, 357);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(138, 24);
            this.lbldiachi.TabIndex = 15;
            this.lbldiachi.Text = "Địa chỉ";
            this.lbldiachi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCMND
            // 
            this.tbCMND.Location = new System.Drawing.Point(132, 316);
            this.tbCMND.Name = "tbCMND";
            this.tbCMND.Size = new System.Drawing.Size(184, 29);
            this.tbCMND.TabIndex = 16;
            // 
            // tbDia_chi
            // 
            this.tbDia_chi.Location = new System.Drawing.Point(484, 354);
            this.tbDia_chi.Name = "tbDia_chi";
            this.tbDia_chi.Size = new System.Drawing.Size(184, 29);
            this.tbDia_chi.TabIndex = 19;
            // 
            // tbNgaysinh
            // 
            this.tbNgaysinh.Location = new System.Drawing.Point(484, 281);
            this.tbNgaysinh.Name = "tbNgaysinh";
            this.tbNgaysinh.Size = new System.Drawing.Size(183, 29);
            this.tbNgaysinh.TabIndex = 20;
            // 
            // tbGT
            // 
            this.tbGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbGT.Items.AddRange(new object[] {
            "Nam",
            "Nu"});
            this.tbGT.Location = new System.Drawing.Point(133, 351);
            this.tbGT.Name = "tbGT";
            this.tbGT.Size = new System.Drawing.Size(183, 32);
            this.tbGT.TabIndex = 21;
            // 
            // Thêm_khách_hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(680, 461);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.tbGT);
            this.Controls.Add(this.tbNgaysinh);
            this.Controls.Add(this.tbDia_chi);
            this.Controls.Add(this.tbCMND);
            this.Controls.Add(this.lbldiachi);
            this.Controls.Add(this.lblngaysinh);
            this.Controls.Add(this.lblgioitinh);
            this.Controls.Add(this.lblcmnd);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.btQuay_lai);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Thêm_khách_hàng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm_khách_hàng";
            this.Load += new System.EventHandler(this.Thêm_khách_hàng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Khach_hangBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btnthemkh;
        private System.Windows.Forms.Button btQuay_lai;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.Label lblcmnd;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.TextBox tbCMND;
        private System.Windows.Forms.TextBox tbDia_chi;
        private System.Windows.Forms.DateTimePicker tbNgaysinh;
        private System.Windows.Forms.ComboBox tbGT;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Khach_hangBindingSource;
    }
}