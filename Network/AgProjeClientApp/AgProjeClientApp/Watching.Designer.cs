namespace AgProjeClientApp
{
    partial class Watching
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Watching));
            this.axVideoChatReceiver1 = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).BeginInit();
            this.SuspendLayout();
            // 
            // axVideoChatReceiver1
            // 
            this.axVideoChatReceiver1.Enabled = true;
            this.axVideoChatReceiver1.Location = new System.Drawing.Point(27, 12);
            this.axVideoChatReceiver1.Name = "axVideoChatReceiver1";
            this.axVideoChatReceiver1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatReceiver1.OcxState")));
            this.axVideoChatReceiver1.Size = new System.Drawing.Size(861, 421);
            this.axVideoChatReceiver1.TabIndex = 0;
            this.axVideoChatReceiver1.Visible = false;
            this.axVideoChatReceiver1.OnNewUserConnection += new AxVideoChatReceiverLib._DVideoChatReceiverEvents_OnNewUserConnectionEventHandler(this.axVideoChatReceiver1_OnNewUserConnection);
            // 
            // Watching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 587);
            this.Controls.Add(this.axVideoChatReceiver1);
            this.Name = "Watching";
            this.Text = "Watching";
            this.Load += new System.EventHandler(this.watching_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxVideoChatReceiverLib.AxVideoChatReceiver axVideoChatReceiver1;
    }
}