namespace Giao_diện
{
    partial class Quản_lý_tài_khoảncs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblqlitk = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btQuay_lai = new System.Windows.Forms.Button();
            this.btndoitrangthai = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btnnaprut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tai_khoanBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tai_khoanBindingSource
            // 
            this.Tai_khoanBindingSource.DataSource = typeof(DTO.Tai_khoan);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblqlitk);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 67);
            this.panel1.TabIndex = 9;
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
            // lblqlitk
            // 
            this.lblqlitk.AutoSize = true;
            this.lblqlitk.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqlitk.Location = new System.Drawing.Point(179, 15);
            this.lblqlitk.Name = "lblqlitk";
            this.lblqlitk.Size = new System.Drawing.Size(281, 39);
            this.lblqlitk.TabIndex = 0;
            this.lblqlitk.Text = "Quản lý tài khoản";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tai_khoanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Giao_diện.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 85);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(656, 227);
            this.reportViewer1.TabIndex = 12;
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(546, 397);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(122, 34);
            this.btQuay_lai.TabIndex = 11;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
            // 
            // btndoitrangthai
            // 
            this.btndoitrangthai.BackColor = System.Drawing.Color.Orange;
            this.btndoitrangthai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndoitrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoitrangthai.Image = global::Giao_diện.Properties.Resources.erase_48;
            this.btndoitrangthai.Location = new System.Drawing.Point(12, 318);
            this.btndoitrangthai.Name = "btndoitrangthai";
            this.btndoitrangthai.Size = new System.Drawing.Size(262, 56);
            this.btndoitrangthai.TabIndex = 7;
            this.btndoitrangthai.Text = "Đổi trạng thái";
            this.btndoitrangthai.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btndoitrangthai.UseVisualStyleBackColor = false;
            this.btndoitrangthai.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.Orange;
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::Giao_diện.Properties.Resources.add_image_48;
            this.btThem.Location = new System.Drawing.Point(12, 382);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(262, 56);
            this.btThem.TabIndex = 6;
            this.btThem.Text = "Thêm tài khoản";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btnnaprut
            // 
            this.btnnaprut.BackColor = System.Drawing.Color.Orange;
            this.btnnaprut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnaprut.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnaprut.Location = new System.Drawing.Point(280, 318);
            this.btnnaprut.Name = "btnnaprut";
            this.btnnaprut.Size = new System.Drawing.Size(243, 56);
            this.btnnaprut.TabIndex = 13;
            this.btnnaprut.Text = "Nạp rút tiền";
            this.btnnaprut.UseVisualStyleBackColor = false;
            this.btnnaprut.Click += new System.EventHandler(this.btNR_Click);
            // 
            // Quản_lý_tài_khoảncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.btnnaprut);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btQuay_lai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btndoitrangthai);
            this.Controls.Add(this.btThem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Quản_lý_tài_khoảncs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản_lý_tài_khoảncs";
            this.Load += new System.EventHandler(this.Quản_lý_tài_khoảncs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tai_khoanBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblqlitk;
        private System.Windows.Forms.Button btndoitrangthai;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btQuay_lai;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tai_khoanBindingSource;
        private System.Windows.Forms.Button btnnaprut;
    }
}