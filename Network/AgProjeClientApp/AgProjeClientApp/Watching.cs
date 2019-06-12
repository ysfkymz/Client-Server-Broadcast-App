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

namespace AgProjeClientApp
{
    public partial class Watching : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UGQ85ES\\Psiblen;Initial Catalog=AgData;Integrated Security=True");

        public bool isVideo { get; set; }
        public Watching()
        {
            InitializeComponent();
        }

        private void watching_Load(object sender,EventArgs e)
        {
            if (isVideo)
            {
                videoStream();
            }
            else
                voiceStream();
        }
        private void axVideoChatReceiver1_OnNewUserConnection(object sender, AxVideoChatReceiverLib._DVideoChatReceiverEvents_OnNewUserConnectionEvent e)
        {
           
        }

        private void isLive(object sender,RunWorkerCompletedEventArgs e)
        {
            
        }

        private void videoStream()
        {

            axVideoChatReceiver1.Visible = true;
            axVideoChatReceiver1.ReceiveAudioStream = true;
            axVideoChatReceiver1.ReceiveVideoStream = true;

            axVideoChatReceiver1.Listen("127.0.0.1", 1234);


            
        }

        private void voiceStream()
        {
            axVideoChatReceiver1.Visible = true;
            axVideoChatReceiver1.ReceiveAudioStream = true;
            axVideoChatReceiver1.ReceiveVideoStream = false;

            axVideoChatReceiver1.Listen("127.0.0.2", 1234);
        }

        
    }
}
