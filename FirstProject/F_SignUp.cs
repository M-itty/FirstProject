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

namespace FirstProject
{
    public partial class F_SignUp : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MST15C4\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=False");

        public F_SignUp()
        {
            InitializeComponent();
            BT_SignInInvisible.Click += new EventHandler(BT_SignInInvisible_Click);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BT_SignUp_Click(object sender, EventArgs e)
        {


            try
            {
                if (TB_Login.Text != "" && TB_Password.Text != "")
                {
                    if (TB_Password.Text == TB_ConfirmPW.Text)
                    {
                        int v = checkLogin(TB_Login.Text);
                        if (v == 0)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("insert into client values(@login, @password)", con);
                            cmd.Parameters.AddWithValue("@login", TB_Login.Text);
                            cmd.Parameters.AddWithValue("@password", TB_Password.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Register OK !");
                            TB_Login.Text = "";
                            TB_Password.Text = "";
                            TB_ConfirmPW.Text = "";
                            BT_SignInInvisible.PerformClick();

                        }
                        else
                        {
                            MessageBox.Show("You are already registered !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match !");
                    }
                }
                else
                {
                    MessageBox.Show("Fill the blank !");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int checkLogin(string login)
        {
            con.Open();
            string query = "select count(*) from client where login='" + login + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            int v = (int)cmd.ExecuteScalar();
            con.Close();
            return v;
        }

        private void LL_SignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            F_Login FormLogin = new F_Login();
            FormLogin.Show();
        }

        private void BT_SignInInvisible_Click(object sender, EventArgs e)
        {
            this.Hide();
            F_Login FormLogin = new F_Login();
            FormLogin.Show();
        }
    }
}
