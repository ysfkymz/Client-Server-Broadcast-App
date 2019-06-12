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
    public partial class UserSelectWindow : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UGQ85ES\\Psiblen;Initial Catalog=AgData;Integrated Security=True");
        public UserSelectWindow()
        {
            InitializeComponent();
        }

        public int isvideo { get; set; }

        public void user_load(object sender,EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Select u_name from [User]", con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            dataAdapter.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from liveStream", con);
            cmd.ExecuteNonQuery();
            con.Close();
            DataGridViewRow select = new DataGridViewRow();
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                select = dataGridView1.Rows[i];
                if (Convert.ToBoolean(select.Cells[0].Value) == true) {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("insert into liveStream ([user],sType) values (@1,@2)", con);
                    cmd2.Parameters.AddWithValue("@1", dataGridView1.Rows[i].Cells[1].Value);
                    cmd2.Parameters.AddWithValue("@2", isvideo);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                   
                        }
                

            }
            user_load(sender, e);
            this.Close();
        }
    }
}
