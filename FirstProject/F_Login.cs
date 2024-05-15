using System.Data.SqlClient;

namespace FirstProject
{
    public partial class F_Login : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MST15C4\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=False");

        public F_Login()
        {
            InitializeComponent();
        }

        private void BT_Click_Click(object sender, EventArgs e)
        {
            /*try
            {
                using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-MST15C4\\SQLEXPRESS;Initial Catalog=test;Integrated Security=True;Encrypt=False"))
                {
                    con.Open();
                    MessageBox.Show("Connexion à la base de données réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            if (TB_Login.Text != "" && TB_Pw.Text != "")
            {
                string query = "select count(*) from client where login = '" + TB_Login.Text + "' and password = '" + TB_Pw.Text + "'";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int v = (int)cmd.ExecuteScalar();
                if (v != 1)
                {
                    MessageBox.Show("Error username or password");
                }
                else
                {
                    MessageBox.Show("Welcome !");
                    TB_Login.Text = "";
                    TB_Pw.Text = "";
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Fill the blank !");
            }

        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }

        private void CHB_Remember_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_Remember.Checked)
            {
                TB_Pw.UseSystemPasswordChar = false;
            }
            else
            {
                TB_Pw.UseSystemPasswordChar = true;
            }
        }

        private void BT_Register_Click(object sender, EventArgs e)
        {
            F_SignUp FormSignUp = new F_SignUp();
            this.Hide();
            FormSignUp.Show();
        }
    }
}
