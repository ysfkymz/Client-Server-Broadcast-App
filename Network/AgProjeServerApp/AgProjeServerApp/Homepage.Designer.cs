namespace AgProjeServerApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.video_button = new System.Windows.Forms.Button();
            this.voice_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.axVideoChatSender1 = new AxVideoChatSenderLib.AxVideoChatSender();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).BeginInit();
            this.SuspendLayout();
            // 
            // video_button
            // 
            this.video_button.BackColor = System.Drawing.Color.Transparent;
            this.video_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("video_button.BackgroundImage")));
            this.video_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.video_button.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.video_button.FlatAppearance.BorderSize = 0;
            this.video_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.video_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.video_button.ImageKey = "(yok)";
            this.video_button.Location = new System.Drawing.Point(120, 316);
            this.video_button.Margin = new System.Windows.Forms.Padding(0);
            this.video_button.Name = "video_button";
            this.video_button.Size = new System.Drawing.Size(107, 87);
            this.video_button.TabIndex = 0;
            this.video_button.UseVisualStyleBackColor = false;
            this.video_button.Click += new System.EventHandler(this.video_button_Click);
            // 
            // voice_button
            // 
            this.voice_button.BackColor = System.Drawing.Color.Transparent;
            this.voice_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("voice_button.BackgroundImage")));
            this.voice_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.voice_button.FlatAppearance.BorderSize = 0;
            this.voice_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voice_button.Location = new System.Drawing.Point(120, 149);
            this.voice_button.Name = "voice_button";
            this.voice_button.Size = new System.Drawing.Size(107, 87);
            this.voice_button.TabIndex = 1;
            this.voice_button.UseVisualStyleBackColor = false;
            this.voice_button.Click += new System.EventHandler(this.voice_button_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Marker", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(979, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yayını Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // axVideoChatSender1
            // 
            this.axVideoChatSender1.Enabled = true;
            this.axVideoChatSender1.Location = new System.Drawing.Point(369, 107);
            this.axVideoChatSender1.Name = "axVideoChatSender1";
            this.axVideoChatSender1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatSender1.OcxState")));
            this.axVideoChatSender1.Size = new System.Drawing.Size(641, 376);
            this.axVideoChatSender1.TabIndex = 3;
            this.axVideoChatSender1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1303, 677);
            this.Controls.Add(this.axVideoChatSender1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.voice_button);
            this.Controls.Add(this.video_button);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button video_button;
        private System.Windows.Forms.Button voice_button;
        private System.Windows.Forms.Button button1;
        private AxVideoChatSenderLib.AxVideoChatSender axVideoChatSender1;
    }
}

