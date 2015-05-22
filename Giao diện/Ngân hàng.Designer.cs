namespace Giao_diện
{
    partial class Ngân_hàng
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.Label();
            this.btQLTK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btTaocode = new System.Windows.Forms.Button();
            this.btDang_xuat = new System.Windows.Forms.Button();
            this.bindingSourceNH = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(114, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn đang đăng nhập với tài khoản ngân hàng";
            // 
            // txtTen
            // 
            this.txtTen.AutoSize = true;
            this.txtTen.BackColor = System.Drawing.Color.Transparent;
            this.txtTen.ForeColor = System.Drawing.Color.White;
            this.txtTen.Location = new System.Drawing.Point(38, 139);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(150, 24);
            this.txtTen.TabIndex = 2;
            this.txtTen.Text = "Tên ngân hàng: ";
            // 
            // btQLTK
            // 
            this.btQLTK.BackColor = System.Drawing.Color.Orange;
            this.btQLTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQLTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQLTK.Location = new System.Drawing.Point(281, 188);
            this.btQLTK.Name = "btQLTK";
            this.btQLTK.Size = new System.Drawing.Size(317, 76);
            this.btQLTK.TabIndex = 7;
            this.btQLTK.Text = "Quản lý tài khoản";
            this.btQLTK.UseVisualStyleBackColor = false;
            this.btQLTK.Click += new System.EventHandler(this.btQLTK_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Giao_diện.Properties.Resources.police_badge_48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 81);
            this.panel1.TabIndex = 6;
            // 
            // btnQLKH
            // 
            this.btnQLKH.BackColor = System.Drawing.Color.Orange;
            this.btnQLKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.Image = global::Giao_diện.Properties.Resources.data_configuration_48;
            this.btnQLKH.Location = new System.Drawing.Point(281, 286);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(317, 76);
            this.btnQLKH.TabIndex = 5;
            this.btnQLKH.Text = "Quản lý khách hàng";
            this.btnQLKH.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnQLKH.UseVisualStyleBackColor = false;
            this.btnQLKH.Click += new System.EventHandler(this.button3_Click);
            // 
            // btTaocode
            // 
            this.btTaocode.BackColor = System.Drawing.Color.Orange;
            this.btTaocode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTaocode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTaocode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btTaocode.Image = global::Giao_diện.Properties.Resources.add_image_48;
            this.btTaocode.Location = new System.Drawing.Point(42, 286);
            this.btTaocode.Name = "btTaocode";
            this.btTaocode.Size = new System.Drawing.Size(201, 76);
            this.btTaocode.TabIndex = 4;
            this.btTaocode.Text = "Code";
            this.btTaocode.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btTaocode.UseVisualStyleBackColor = false;
            this.btTaocode.Click += new System.EventHandler(this.btTaocode_Click);
            // 
            // btDang_xuat
            // 
            this.btDang_xuat.BackColor = System.Drawing.Color.Khaki;
            this.btDang_xuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDang_xuat.Image = global::Giao_diện.Properties.Resources.settings3_26;
            this.btDang_xuat.Location = new System.Drawing.Point(528, 399);
            this.btDang_xuat.Name = "btDang_xuat";
            this.btDang_xuat.Size = new System.Drawing.Size(142, 36);
            this.btDang_xuat.TabIndex = 1;
            this.btDang_xuat.Text = "Đăng xuất";
            this.btDang_xuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btDang_xuat.UseVisualStyleBackColor = false;
            this.btDang_xuat.Click += new System.EventHandler(this.btDang_xuat_Click);
            // 
            // Ngân_hàng
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.btQLTK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQLKH);
            this.Controls.Add(this.btTaocode);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btDang_xuat);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Ngân_hàng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ngân_hàng";
            this.Load += new System.EventHandler(this.Ngân_hàng_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceNH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDang_xuat;
        private System.Windows.Forms.Button btTaocode;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTen;
        private System.Windows.Forms.Button btQLTK;
        private System.Windows.Forms.BindingSource bindingSourceNH;
    }
}