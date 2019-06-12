using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AgProjeServerApp
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UGQ85ES\\Psiblen;Initial Catalog=AgData;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }
        Boolean isVideo = false;

        private void voice_button_Click(object sender, EventArgs e)
        {
            UserSelectWindow userSelect = new UserSelectWindow();
            userSelect.isvideo = 2;
            userSelect.Show();
            button1.Visible = true;
            axVideoChatSender1.Visible = true;
            isVideo = false;
            axVideoChatSender1.VideoDevice = 1;
            axVideoChatSender1.AudioDevice = 0;
            axVideoChatSender1.FrameRate = 15;
            axVideoChatSender1.AudioComplexity = 0;
            axVideoChatSender1.AudioQuality = 8;
            axVideoChatSender1.SendAudioStream = true;

            axVideoChatSender1.Connect("127.0.0.2", 1234);
        }

        private void video_button_Click(object sender, EventArgs e)
        {
            UserSelectWindow userSelect = new UserSelectWindow();
            userSelect.isvideo = 1;
            userSelect.Show();
            button1.Visible = true;
            axVideoChatSender1.Visible = true;
            isVideo = true;
            axVideoChatSender1.VideoDevice = 0;
            axVideoChatSender1.AudioDevice = 0;
            axVideoChatSender1.VideoFormat = 0;
            axVideoChatSender1.FrameRate = 15;
            axVideoChatSender1.VideoBitrate = 128000;
            axVideoChatSender1.AudioComplexity = 0;
            axVideoChatSender1.AudioQuality = 8;
            axVideoChatSender1.SendAudioStream = true;
            axVideoChatSender1.SendVideoStream = true;

            axVideoChatSender1.Connect("127.0.0.1", 1234);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from liveStream", con);
            cmd.ExecuteNonQuery();
            con.Close();
            axVideoChatSender1.VideoDevice = 1;
            axVideoChatSender1.SendAudioStream = false;
            axVideoChatSender1.SendVideoStream = false;
            axVideoChatSender1.Visible = false;
            axVideoChatSender1.Connect("127.0.0.0", 1);
            button1.Visible = false;
        }
    }
}
