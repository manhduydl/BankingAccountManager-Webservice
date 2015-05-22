namespace Giao_diện
{
    partial class Quản_lý_khách_hàng
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblqlikh = new System.Windows.Forms.Label();
            this.btQuay_lai = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
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
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblqlikh);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 67);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Giao_diện.Properties.Resources.data_configuration_48;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(40, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 60);
            this.panel2.TabIndex = 6;
            // 
            // lblqlikh
            // 
            this.lblqlikh.AutoSize = true;
            this.lblqlikh.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqlikh.Location = new System.Drawing.Point(179, 15);
            this.lblqlikh.Name = "lblqlikh";
            this.lblqlikh.Size = new System.Drawing.Size(319, 39);
            this.lblqlikh.TabIndex = 0;
            this.lblqlikh.Text = "Quản lý khách hàng";
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(546, 404);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(122, 34);
            this.btQuay_lai.TabIndex = 4;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.Orange;
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::Giao_diện.Properties.Resources.edit_48;
            this.btSua.Location = new System.Drawing.Point(376, 318);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(292, 56);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sữa thông tin";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.Orange;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::Giao_diện.Properties.Resources.erase_48;
            this.btXoa.Location = new System.Drawing.Point(21, 318);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(292, 56);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Hủy khách hàng";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Orange;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::Giao_diện.Properties.Resources.add_image_48;
            this.btThem.Location = new System.Drawing.Point(21, 382);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(292, 56);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm khách hàng";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Khach_hangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Giao_diện.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 227);
            this.reportViewer1.TabIndex = 5;
            // 
            // Quản_lý_khách_hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btQuay_lai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Quản_lý_khách_hàng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản_lý_khách_hàng";
            this.Load += new System.EventHandler(this.Quản_lý_khách_hàng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Khach_hangBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblqlikh;
        private System.Windows.Forms.Button btQuay_lai;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Khach_hangBindingSource;
    }
}