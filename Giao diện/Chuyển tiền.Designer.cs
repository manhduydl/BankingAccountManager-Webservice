namespace Giao_diện
{
    partial class Chuyển_tiền
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
            this.lblstkchuyen = new System.Windows.Forms.Label();
            this.lblSotienchuyen = new System.Windows.Forms.Label();
            this.STKC = new System.Windows.Forms.TextBox();
            this.STC = new System.Windows.Forms.TextBox();
            this.btnchuyen = new System.Windows.Forms.Button();
            this.btQuay_lai = new System.Windows.Forms.Button();
            this.STHC = new System.Windows.Forms.Label();
            this.lblphi = new System.Windows.Forms.Label();
            this.lblhd = new System.Windows.Forms.Label();
            this.So_tien = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblstkchuyen
            // 
            this.lblstkchuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstkchuyen.Location = new System.Drawing.Point(49, 69);
            this.lblstkchuyen.Name = "lblstkchuyen";
            this.lblstkchuyen.Size = new System.Drawing.Size(350, 36);
            this.lblstkchuyen.TabIndex = 2;
            this.lblstkchuyen.Text = "Số tài khoản chuyển tiền:";
            this.lblstkchuyen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSotienchuyen
            // 
            this.lblSotienchuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSotienchuyen.Location = new System.Drawing.Point(96, 143);
            this.lblSotienchuyen.Name = "lblSotienchuyen";
            this.lblSotienchuyen.Size = new System.Drawing.Size(303, 36);
            this.lblSotienchuyen.TabIndex = 3;
            this.lblSotienchuyen.Text = "Số tiền muốn chuyển:";
            this.lblSotienchuyen.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // STKC
            // 
            this.STKC.BackColor = System.Drawing.Color.LightSeaGreen;
            this.STKC.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STKC.ForeColor = System.Drawing.Color.White;
            this.STKC.Location = new System.Drawing.Point(405, 66);
            this.STKC.Name = "STKC";
            this.STKC.Size = new System.Drawing.Size(213, 41);
            this.STKC.TabIndex = 1;
            // 
            // STC
            // 
            this.STC.BackColor = System.Drawing.Color.LightSeaGreen;
            this.STC.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STC.ForeColor = System.Drawing.Color.White;
            this.STC.Location = new System.Drawing.Point(405, 143);
            this.STC.MaxLength = 8;
            this.STC.Name = "STC";
            this.STC.Size = new System.Drawing.Size(213, 41);
            this.STC.TabIndex = 2;
            this.STC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.STC_KeyPress);
            // 
            // btnchuyen
            // 
            this.btnchuyen.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnchuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchuyen.Image = global::Giao_diện.Properties.Resources.money_exchange_48;
            this.btnchuyen.Location = new System.Drawing.Point(212, 289);
            this.btnchuyen.Name = "btnchuyen";
            this.btnchuyen.Size = new System.Drawing.Size(248, 71);
            this.btnchuyen.TabIndex = 6;
            this.btnchuyen.Text = "Chuyển";
            this.btnchuyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnchuyen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnchuyen.UseVisualStyleBackColor = false;
            this.btnchuyen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btQuay_lai
            // 
            this.btQuay_lai.BackColor = System.Drawing.Color.Khaki;
            this.btQuay_lai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuay_lai.ForeColor = System.Drawing.Color.Black;
            this.btQuay_lai.Image = global::Giao_diện.Properties.Resources.undo_26;
            this.btQuay_lai.Location = new System.Drawing.Point(546, 399);
            this.btQuay_lai.Name = "btQuay_lai";
            this.btQuay_lai.Size = new System.Drawing.Size(122, 39);
            this.btQuay_lai.TabIndex = 0;
            this.btQuay_lai.Text = "Quay lại";
            this.btQuay_lai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btQuay_lai.UseVisualStyleBackColor = false;
            this.btQuay_lai.Click += new System.EventHandler(this.btQuay_lai_Click);
            // 
            // STHC
            // 
            this.STHC.AutoSize = true;
            this.STHC.Location = new System.Drawing.Point(51, 201);
            this.STHC.Name = "STHC";
            this.STHC.Size = new System.Drawing.Size(153, 24);
            this.STHC.TabIndex = 7;
            this.STHC.Text = "*Số tiền hiện có: ";
            // 
            // lblphi
            // 
            this.lblphi.AutoSize = true;
            this.lblphi.Location = new System.Drawing.Point(245, 240);
            this.lblphi.Name = "lblphi";
            this.lblphi.Size = new System.Drawing.Size(318, 24);
            this.lblphi.TabIndex = 8;
            this.lblphi.Text = "Mỗi giao dịch sẽ tính 1000 tiền phí (*)";
            // 
            // lblhd
            // 
            this.lblhd.AutoSize = true;
            this.lblhd.Location = new System.Drawing.Point(51, 399);
            this.lblhd.Name = "lblhd";
            this.lblhd.Size = new System.Drawing.Size(355, 24);
            this.lblhd.TabIndex = 9;
            this.lblhd.Text = "* Tài khoản vip sẽ không bị trừ khoản này";
            // 
            // So_tien
            // 
            this.So_tien.AutoSize = true;
            this.So_tien.Location = new System.Drawing.Point(196, 201);
            this.So_tien.Name = "So_tien";
            this.So_tien.Size = new System.Drawing.Size(0, 24);
            this.So_tien.TabIndex = 10;
            // 
            // Chuyển_tiền
            // 
            this.AcceptButton = this.btnchuyen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.So_tien);
            this.Controls.Add(this.lblhd);
            this.Controls.Add(this.lblphi);
            this.Controls.Add(this.STHC);
            this.Controls.Add(this.btnchuyen);
            this.Controls.Add(this.STC);
            this.Controls.Add(this.STKC);
            this.Controls.Add(this.lblSotienchuyen);
            this.Controls.Add(this.lblstkchuyen);
            this.Controls.Add(this.btQuay_lai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Chuyển_tiền";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chuyển_tiền";
            this.Load += new System.EventHandler(this.Chuyển_tiền_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btQuay_lai;
        private System.Windows.Forms.Label lblstkchuyen;
        private System.Windows.Forms.Label lblSotienchuyen;
        private System.Windows.Forms.TextBox STKC;
        private System.Windows.Forms.TextBox STC;
        private System.Windows.Forms.Button btnchuyen;
        private System.Windows.Forms.Label STHC;
        private System.Windows.Forms.Label lblphi;
        private System.Windows.Forms.Label lblhd;
        private System.Windows.Forms.Label So_tien;
    }
}