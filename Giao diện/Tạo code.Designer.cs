namespace Giao_diện
{
    partial class Tạo_code
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
            this.btQuay_lai = new System.Windows.Forms.Button();
            this.gbxtaocode = new System.Windows.Forms.GroupBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.tbMenhgia = new System.Windows.Forms.TextBox();
            this.lblmenhgia = new System.Windows.Forms.Label();
            this.gbxdscode = new System.Windows.Forms.GroupBox();
            this.dsthe = new System.Windows.Forms.DataGridView();
            this.Ma_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tinh_trang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxtaocode.SuspendLayout();
            this.gbxdscode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsthe)).BeginInit();
            this.SuspendLayout();
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(550, 403);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(118, 38);
            this.btQuay_lai.TabIndex = 3;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
            // 
            // gbxtaocode
            // 
            this.gbxtaocode.Controls.Add(this.btnTao);
            this.gbxtaocode.Controls.Add(this.tbMenhgia);
            this.gbxtaocode.Controls.Add(this.lblmenhgia);
            this.gbxtaocode.ForeColor = System.Drawing.Color.White;
            this.gbxtaocode.Location = new System.Drawing.Point(16, 12);
            this.gbxtaocode.Name = "gbxtaocode";
            this.gbxtaocode.Size = new System.Drawing.Size(652, 113);
            this.gbxtaocode.TabIndex = 8;
            this.gbxtaocode.TabStop = false;
            this.gbxtaocode.Text = "Tự động tạo code";
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Firebrick;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTao.Location = new System.Drawing.Point(409, 47);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(127, 40);
            this.btnTao.TabIndex = 2;
            this.btnTao.Text = "Tạo";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btTaocode_Click);
            // 
            // tbMenhgia
            // 
            this.tbMenhgia.BackColor = System.Drawing.Color.RosyBrown;
            this.tbMenhgia.ForeColor = System.Drawing.Color.White;
            this.tbMenhgia.Location = new System.Drawing.Point(152, 52);
            this.tbMenhgia.MaxLength = 8;
            this.tbMenhgia.Name = "tbMenhgia";
            this.tbMenhgia.Size = new System.Drawing.Size(162, 29);
            this.tbMenhgia.TabIndex = 1;
            this.tbMenhgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMenhgia_KeyPress);
            // 
            // lblmenhgia
            // 
            this.lblmenhgia.AutoSize = true;
            this.lblmenhgia.Location = new System.Drawing.Point(50, 55);
            this.lblmenhgia.Name = "lblmenhgia";
            this.lblmenhgia.Size = new System.Drawing.Size(94, 24);
            this.lblmenhgia.TabIndex = 0;
            this.lblmenhgia.Text = "Mệnh giá:";
            // 
            // gbxdscode
            // 
            this.gbxdscode.Controls.Add(this.dsthe);
            this.gbxdscode.ForeColor = System.Drawing.Color.Black;
            this.gbxdscode.Location = new System.Drawing.Point(16, 148);
            this.gbxdscode.Name = "gbxdscode";
            this.gbxdscode.Size = new System.Drawing.Size(652, 249);
            this.gbxdscode.TabIndex = 9;
            this.gbxdscode.TabStop = false;
            this.gbxdscode.Text = "Danh sách code";
            // 
            // dsthe
            // 
            this.dsthe.AllowUserToAddRows = false;
            this.dsthe.AllowUserToDeleteRows = false;
            this.dsthe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsthe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_code,
            this.So_tien,
            this.Tinh_trang});
            this.dsthe.Location = new System.Drawing.Point(6, 28);
            this.dsthe.Name = "dsthe";
            this.dsthe.ReadOnly = true;
            this.dsthe.Size = new System.Drawing.Size(640, 215);
            this.dsthe.TabIndex = 0;
            // 
            // Ma_code
            // 
            this.Ma_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_code.DataPropertyName = "Ma_code";
            this.Ma_code.HeaderText = "Mã code";
            this.Ma_code.Name = "Ma_code";
            this.Ma_code.ReadOnly = true;
            // 
            // So_tien
            // 
            this.So_tien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.So_tien.DataPropertyName = "So_tien";
            this.So_tien.HeaderText = "Mệnh giá";
            this.So_tien.Name = "So_tien";
            this.So_tien.ReadOnly = true;
            // 
            // Tinh_trang
            // 
            this.Tinh_trang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tinh_trang.DataPropertyName = "Tinh_trang";
            this.Tinh_trang.HeaderText = "Tình trạng";
            this.Tinh_trang.Name = "Tinh_trang";
            this.Tinh_trang.ReadOnly = true;
            // 
            // Tạo_code
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.gbxdscode);
            this.Controls.Add(this.gbxtaocode);
            this.Controls.Add(this.btQuay_lai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Tạo_code";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo_code";
            this.Load += new System.EventHandler(this.Tạo_code_Load);
            this.gbxtaocode.ResumeLayout(false);
            this.gbxtaocode.PerformLayout();
            this.gbxdscode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsthe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQuay_lai;
        private System.Windows.Forms.GroupBox gbxtaocode;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.TextBox tbMenhgia;
        private System.Windows.Forms.Label lblmenhgia;
        private System.Windows.Forms.GroupBox gbxdscode;
        private System.Windows.Forms.DataGridView dsthe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tinh_trang;
    }
}