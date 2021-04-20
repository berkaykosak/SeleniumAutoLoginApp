namespace SeleniumLoginTestApp
{
    partial class LoginTestApp
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
            this.kullaniciAdi_label = new System.Windows.Forms.Label();
            this.kullaniciAdi_txtBox = new System.Windows.Forms.TextBox();
            this.sifre_TxtBox = new System.Windows.Forms.TextBox();
            this.sifre_label = new System.Windows.Forms.Label();
            this.Login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciAdi_label
            // 
            this.kullaniciAdi_label.AutoSize = true;
            this.kullaniciAdi_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi_label.Location = new System.Drawing.Point(37, 60);
            this.kullaniciAdi_label.Name = "kullaniciAdi_label";
            this.kullaniciAdi_label.Size = new System.Drawing.Size(122, 23);
            this.kullaniciAdi_label.TabIndex = 0;
            this.kullaniciAdi_label.Text = "Kullanıcı Adı";
            // 
            // kullaniciAdi_txtBox
            // 
            this.kullaniciAdi_txtBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciAdi_txtBox.Location = new System.Drawing.Point(219, 57);
            this.kullaniciAdi_txtBox.Name = "kullaniciAdi_txtBox";
            this.kullaniciAdi_txtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kullaniciAdi_txtBox.Size = new System.Drawing.Size(374, 32);
            this.kullaniciAdi_txtBox.TabIndex = 1;
            // 
            // sifre_TxtBox
            // 
            this.sifre_TxtBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_TxtBox.Location = new System.Drawing.Point(219, 132);
            this.sifre_TxtBox.Name = "sifre_TxtBox";
            this.sifre_TxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sifre_TxtBox.Size = new System.Drawing.Size(374, 32);
            this.sifre_TxtBox.TabIndex = 3;
            this.sifre_TxtBox.UseSystemPasswordChar = true;
            this.sifre_TxtBox.TextChanged += new System.EventHandler(this.TextBoxChanged);
            // 
            // sifre_label
            // 
            this.sifre_label.AutoSize = true;
            this.sifre_label.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifre_label.Location = new System.Drawing.Point(37, 135);
            this.sifre_label.Name = "sifre_label";
            this.sifre_label.Size = new System.Drawing.Size(50, 23);
            this.sifre_label.TabIndex = 2;
            this.sifre_label.Text = "Şifre";
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.SystemColors.Info;
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.No;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login_btn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Login_btn.ForeColor = System.Drawing.Color.Red;
            this.Login_btn.Location = new System.Drawing.Point(282, 209);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(225, 67);
            this.Login_btn.TabIndex = 4;
            this.Login_btn.Text = "Giriş Yap";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // LoginTestApp
            // 
            this.AcceptButton = this.Login_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(641, 359);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.sifre_TxtBox);
            this.Controls.Add(this.sifre_label);
            this.Controls.Add(this.kullaniciAdi_txtBox);
            this.Controls.Add(this.kullaniciAdi_label);
            this.Name = "LoginTestApp";
            this.Text = "Login Test Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKapat);
            this.Load += new System.EventHandler(this.LoginTestApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kullaniciAdi_label;
        private System.Windows.Forms.TextBox kullaniciAdi_txtBox;
        private System.Windows.Forms.TextBox sifre_TxtBox;
        private System.Windows.Forms.Label sifre_label;
        private System.Windows.Forms.Button Login_btn;
    }
}

