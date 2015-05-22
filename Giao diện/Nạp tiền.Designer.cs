namespace Giao_diện
{
    partial class Nạp_tiền
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
            this.lblmacode = new System.Windows.Forms.Label();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.btNap = new System.Windows.Forms.Button();
            this.tb3d = new System.Windows.Forms.TextBox();
            this.tb3g = new System.Windows.Forms.TextBox();
            this.tb3c = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dsThenap = new System.Windows.Forms.DataGridView();
            this.Msgd_nap_tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stk_nap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.So_tien_nap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thoi_gian_gd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblthedanap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsThenap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmacode
            // 
            this.lblmacode.AutoSize = true;
            this.lblmacode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmacode.ForeColor = System.Drawing.Color.White;
            this.lblmacode.Location = new System.Drawing.Point(12, 27);
            this.lblmacode.Name = "lblmacode";
            this.lblmacode.Size = new System.Drawing.Size(125, 31);
            this.lblmacode.TabIndex = 0;
            this.lblmacode.Text = "Mã code:";
            // 
            // btQuayLai
            // 
            this.btQuayLai.BackColor = System.Drawing.Color.Khaki;
            this.btQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuayLai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuayLai.Location = new System.Drawing.Point(545, 400);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(123, 38);
            this.btQuayLai.TabIndex = 3;
            this.btQuayLai.Text = "Quay lại";
            this.btQuayLai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuayLai.UseVisualStyleBackColor = false;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // btNap
            // 
            this.btNap.BackColor = System.Drawing.Color.PaleGreen;
            this.btNap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNap.Image = global::Giao_diện.Properties.Resources.moneybox_48;
            this.btNap.Location = new System.Drawing.Point(426, 12);
            this.btNap.Name = "btNap";
            this.btNap.Size = new System.Drawing.Size(213, 65);
            this.btNap.TabIndex = 2;
            this.btNap.Text = "Nạp tiền";
            this.btNap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btNap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btNap.UseVisualStyleBackColor = false;
            this.btNap.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb3d
            // 
            this.tb3d.BackColor = System.Drawing.Color.Coral;
            this.tb3d.ForeColor = System.Drawing.Color.White;
            this.tb3d.Location = new System.Drawing.Point(143, 28);
            this.tb3d.MaxLength = 3;
            this.tb3d.Name = "tb3d";
            this.tb3d.Size = new System.Drawing.Size(54, 29);
            this.tb3d.TabIndex = 4;
            this.tb3d.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb3d_KeyPress);
            // 
            // tb3g
            // 
            this.tb3g.BackColor = System.Drawing.Color.Coral;
            this.tb3g.ForeColor = System.Drawing.Color.White;
            this.tb3g.Location = new System.Drawing.Point(225, 28);
            this.tb3g.MaxLength = 3;
            this.tb3g.Name = "tb3g";
            this.tb3g.Size = new System.Drawing.Size(54, 29);
            this.tb3g.TabIndex = 5;
            this.tb3g.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb3g_KeyPress);
            // 
            // tb3c
            // 
            this.tb3c.BackColor = System.Drawing.Color.Coral;
            this.tb3c.ForeColor = System.Drawing.Color.White;
            this.tb3c.Location = new System.Drawing.Point(305, 28);
            this.tb3c.MaxLength = 3;
            this.tb3c.Name = "tb3c";
            this.tb3c.Size = new System.Drawing.Size(54, 29);
            this.tb3c.TabIndex = 6;
            this.tb3c.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb3c_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(283, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "-";
            // 
            // dsThenap
            // 
            this.dsThenap.AllowUserToAddRows = false;
            this.dsThenap.AllowUserToDeleteRows = false;
            this.dsThenap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsThenap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Msgd_nap_tien,
            this.Stk_nap,
            this.So_tien_nap,
            this.Ma_code,
            this.Thoi_gian_gd});
            this.dsThenap.Location = new System.Drawing.Point(12, 150);
            this.dsThenap.Name = "dsThenap";
            this.dsThenap.ReadOnly = true;
            this.dsThenap.RowHeadersVisible = false;
            this.dsThenap.Size = new System.Drawing.Size(656, 227);
            this.dsThenap.TabIndex = 9;
            // 
            // Msgd_nap_tien
            // 
            this.Msgd_nap_tien.DataPropertyName = "Msgd_nap_tien";
            this.Msgd_nap_tien.FillWeight = 47.58885F;
            this.Msgd_nap_tien.HeaderText = "Mã số";
            this.Msgd_nap_tien.Name = "Msgd_nap_tien";
            this.Msgd_nap_tien.ReadOnly = true;
            this.Msgd_nap_tien.Width = 90;
            // 
            // Stk_nap
            // 
            this.Stk_nap.DataPropertyName = "Stk_nap";
            this.Stk_nap.FillWeight = 309.6446F;
            this.Stk_nap.HeaderText = "Số tài khoản nạp";
            this.Stk_nap.Name = "Stk_nap";
            this.Stk_nap.ReadOnly = true;
            this.Stk_nap.Width = 180;
            // 
            // So_tien_nap
            // 
            this.So_tien_nap.DataPropertyName = "So_tien_nap";
            this.So_tien_nap.FillWeight = 47.58885F;
            this.So_tien_nap.HeaderText = "Mệnh giá";
            this.So_tien_nap.Name = "So_tien_nap";
            this.So_tien_nap.ReadOnly = true;
            this.So_tien_nap.Width = 120;
            // 
            // Ma_code
            // 
            this.Ma_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Ma_code.DataPropertyName = "Ma_code";
            this.Ma_code.FillWeight = 47.58885F;
            this.Ma_code.HeaderText = "Mã code";
            this.Ma_code.Name = "Ma_code";
            this.Ma_code.ReadOnly = true;
            // 
            // Thoi_gian_gd
            // 
            this.Thoi_gian_gd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thoi_gian_gd.DataPropertyName = "Thoi_gian_gd";
            this.Thoi_gian_gd.FillWeight = 47.58885F;
            this.Thoi_gian_gd.HeaderText = "Thời gian nạp";
            this.Thoi_gian_gd.Name = "Thoi_gian_gd";
            this.Thoi_gian_gd.ReadOnly = true;
            // 
            // lblthedanap
            // 
            this.lblthedanap.AutoSize = true;
            this.lblthedanap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthedanap.ForeColor = System.Drawing.Color.White;
            this.lblthedanap.Location = new System.Drawing.Point(14, 98);
            this.lblthedanap.Name = "lblthedanap";
            this.lblthedanap.Size = new System.Drawing.Size(205, 31);
            this.lblthedanap.TabIndex = 10;
            this.lblthedanap.Text = "Các thẻ đã nạp:";
            // 
            // Nạp_tiền
            // 
            this.AcceptButton = this.btNap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.lblthedanap);
            this.Controls.Add(this.dsThenap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb3c);
            this.Controls.Add(this.tb3g);
            this.Controls.Add(this.tb3d);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.btNap);
            this.Controls.Add(this.lblmacode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Nạp_tiền";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nạp_tiền";
            this.Load += new System.EventHandler(this.Nạp_tiền_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsThenap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmacode;
        private System.Windows.Forms.Button btNap;
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.TextBox tb3d;
        private System.Windows.Forms.TextBox tb3g;
        private System.Windows.Forms.TextBox tb3c;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dsThenap;
        private System.Windows.Forms.Label lblthedanap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Msgd_nap_tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stk_nap;
        private System.Windows.Forms.DataGridViewTextBoxColumn So_tien_nap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thoi_gian_gd;
    }
}