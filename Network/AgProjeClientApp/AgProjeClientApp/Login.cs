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
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-UGQ85ES\\Psiblen;Initial Catalog=AgData;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            con.Open();

            if (k_adi_tb.Text == "" || sifre_tb.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Geçilemez.", "Hata !");
            }
            else {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [User] WHERE u_name='"+k_adi_tb.Text+"' AND u_pass='"+sifre_tb.Text+"'", con);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    Homepage homepage = new Homepage();
                    homepage.u_Name = k_adi_tb.Text;
                    homepage.Show();
                    this.Hide();
                    con.Close();
                }
                else
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı", "Dikkat !");
            }
            con.Close();
        }
    }
}
