namespace AgProjeClientApp
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.k_adi_tb = new System.Windows.Forms.TextBox();
            this.sifre_tb = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // k_adi_tb
            // 
            this.k_adi_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.k_adi_tb.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_adi_tb.Location = new System.Drawing.Point(323, 133);
            this.k_adi_tb.Name = "k_adi_tb";
            this.k_adi_tb.Size = new System.Drawing.Size(340, 42);
            this.k_adi_tb.TabIndex = 2;
            this.k_adi_tb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sifre_tb
            // 
            this.sifre_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sifre_tb.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifre_tb.Location = new System.Drawing.Point(323, 231);
            this.sifre_tb.Name = "sifre_tb";
            this.sifre_tb.PasswordChar = '*';
            this.sifre_tb.Size = new System.Drawing.Size(340, 42);
            this.sifre_tb.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.FlatAppearance.BorderSize = 2;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Segoe Marker", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(169, 342);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(266, 65);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Giriş";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(753, 498);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.sifre_tb);
            this.Controls.Add(this.k_adi_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox k_adi_tb;
        private System.Windows.Forms.TextBox sifre_tb;
        private System.Windows.Forms.Button login_button;
    }
}

