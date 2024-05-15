using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstProject
{
    public partial class F_Motus : Form
    {
        public F_Motus()
        {
            InitializeComponent();
        }

        // Global Variables
        private string wordToGuess = "";
        private char[] guessedWord;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TB_Parcourir_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog
                {
                    //InitialDirectory = @"C:\",
                    Title = "Sélectionnez un fichier texte",

                    // Looking for only .txt
                    FileName = "Fichier",
                    Filter = "Fichiers texte (*.txt)|*.txt",
                    FilterIndex = 1,
                    RestoreDirectory = true
                };

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    string filePath = OFD.FileName;
                    string[] lines = File.ReadAllLines(filePath)
                        ;
                    Random random = new Random();
                    int randomIndex = random.Next(lines.Length);
                    string randomLine = lines[randomIndex];

                    this.TB_Parcourir.Text = OFD.FileName;

                    wordToGuess = randomLine.ToLower();
                    lb_WordToGuess.Text = wordToGuess;
                    lbl_nbWordtoGuess.Text = wordToGuess.Length.ToString();



                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur lors de la lecture du fichier : " + ex.Message);
            }
        }

        private void TB_Word_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string guess = TB_Word.Text;
                if (guess.Length != wordToGuess.Length)
                {
                    MessageBox.Show($"Veuillez entrer un mot de {wordToGuess.Length} lettres.");
                    return;
                }

                Label lblResult = new Label
                {
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold)
                    
                };


                char[] result = new string('-', wordToGuess.Length).ToCharArray();

                // Identifier les lettres bien placées
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (guess[i] == wordToGuess[i])
                    {
                        result[i] = guess[i];
                    }
                }

                lblResult.Text = new string(result);
                FLP_Labels.Controls.Add(lblResult);
                TB_Word.Text = "";

                if (guess == wordToGuess)
                {
                    MessageBox.Show("Félicitations ! Vous avez trouvé le mot !");
                    TB_Word.Enabled = false;
                }
            }
        }

        private void TB_Word_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TB_Word_TextChanged(object sender, EventArgs e)
        {
            lbl_wordtypingcount.Text = TB_Word.Text.Length.ToString();
        }
    }
}
