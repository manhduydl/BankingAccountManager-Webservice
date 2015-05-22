namespace Giao_diện
{
    partial class Form1
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
            this.lblTk = new System.Windows.Forms.Label();
            this.lblMk = new System.Windows.Forms.Label();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.btDang_nhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnViet = new System.Windows.Forms.Button();
            this.btnEng = new System.Windows.Forms.Button();
            this.lblngonngu = new System.Windows.Forms.Label();
            this.btnTieude = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTk
            // 
            this.lblTk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTk.Location = new System.Drawing.Point(155, 174);
            this.lblTk.Name = "lblTk";
            this.lblTk.Size = new System.Drawing.Size(173, 31);
            this.lblTk.TabIndex = 3;
            this.lblTk.Text = "Tài khoản:";
            this.lblTk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMk
            // 
            this.lblMk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMk.Location = new System.Drawing.Point(174, 217);
            this.lblMk.Name = "lblMk";
            this.lblMk.Size = new System.Drawing.Size(154, 31);
            this.lblMk.TabIndex = 4;
            this.lblMk.Text = "Mật khẩu:";
            this.lblMk.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtTK
            // 
            this.txtTK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTK.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Location = new System.Drawing.Point(344, 171);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(166, 38);
            this.txtTK.TabIndex = 0;
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(344, 214);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(166, 38);
            this.txtMK.TabIndex = 1;
            // 
            // btDang_nhap
            // 
            this.btDang_nhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btDang_nhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDang_nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDang_nhap.Image = global::Giao_diện.Properties.Resources.checkmark_26;
            this.btDang_nhap.Location = new System.Drawing.Point(242, 290);
            this.btDang_nhap.Name = "btDang_nhap";
            this.btDang_nhap.Size = new System.Drawing.Size(217, 66);
            this.btDang_nhap.TabIndex = 1;
            this.btDang_nhap.Text = "Đăng nhập";
            this.btDang_nhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDang_nhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btDang_nhap.UseVisualStyleBackColor = false;
            this.btDang_nhap.Click += new System.EventHandler(this.btDang_nhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Image = global::Giao_diện.Properties.Resources.delete_sign_26;
            this.btnThoat.Location = new System.Drawing.Point(565, 401);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(103, 37);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnViet
            // 
            this.btnViet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViet.Image = global::Giao_diện.Properties.Resources.icon_vn;
            this.btnViet.Location = new System.Drawing.Point(174, 401);
            this.btnViet.Name = "btnViet";
            this.btnViet.Size = new System.Drawing.Size(154, 37);
            this.btnViet.TabIndex = 7;
            this.btnViet.Text = "Tiếng Việt";
            this.btnViet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViet.UseVisualStyleBackColor = true;
            this.btnViet.Click += new System.EventHandler(this.btnViet_Click);
            // 
            // btnEng
            // 
            this.btnEng.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEng.Image = global::Giao_diện.Properties.Resources.icon_eng;
            this.btnEng.Location = new System.Drawing.Point(12, 401);
            this.btnEng.Name = "btnEng";
            this.btnEng.Size = new System.Drawing.Size(148, 37);
            this.btnEng.TabIndex = 8;
            this.btnEng.Text = "English";
            this.btnEng.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEng.UseVisualStyleBackColor = true;
            this.btnEng.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblngonngu
            // 
            this.lblngonngu.AutoSize = true;
            this.lblngonngu.Location = new System.Drawing.Point(12, 365);
            this.lblngonngu.Name = "lblngonngu";
            this.lblngonngu.Size = new System.Drawing.Size(148, 24);
            this.lblngonngu.TabIndex = 9;
            this.lblngonngu.Text = "Chọn ngôn ngữ:";
            // 
            // btnTieude
            // 
            this.btnTieude.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTieude.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTieude.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnTieude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTieude.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTieude.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTieude.Location = new System.Drawing.Point(12, 23);
            this.btnTieude.Name = "btnTieude";
            this.btnTieude.Size = new System.Drawing.Size(656, 88);
            this.btnTieude.TabIndex = 10;
            this.btnTieude.Text = "NGÂN HÀNG ĐIỆN TỬ";
            this.btnTieude.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btDang_nhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.btnTieude);
            this.Controls.Add(this.lblngonngu);
            this.Controls.Add(this.btnEng);
            this.Controls.Add(this.btnViet);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.lblMk);
            this.Controls.Add(this.lblTk);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btDang_nhap);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDang_nhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTk;
        private System.Windows.Forms.Label lblMk;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnViet;
        private System.Windows.Forms.Button btnEng;
        private System.Windows.Forms.Label lblngonngu;
        private System.Windows.Forms.Button btnTieude;

    }
}

