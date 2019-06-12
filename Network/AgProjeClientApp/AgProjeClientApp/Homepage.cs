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
    public partial class Homepage : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UGQ85ES\\Psiblen;Initial Catalog=AgData;Integrated Security=True");

        public string u_Name { get; set; }
        public Homepage()
        {
            InitializeComponent();    
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            Watching watching = new Watching();
            watching.isVideo = true;
            watching.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Watching watching2 = new Watching();
            watching2.isVideo = false;
            watching2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select sType From liveStream where [user]='" + u_Name + "'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (reader["sType"].Equals(1))
                {
                    button2.Visible = false;
                    label1.Visible = false;
                    button1.Visible = true;
                    con.Close();
                }
                else
                {
                    button1.Visible = false;
                    label1.Visible = false;
                    button2.Visible = true;
                    con.Close();
                }
            }
                
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                label1.Visible = true;
                con.Close();
            }
        }
    }
}
