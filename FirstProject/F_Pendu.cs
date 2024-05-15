using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FirstProject
{
    public partial class F_Pendu : Form
    {
        public F_Pendu()
        {
            InitializeComponent();

        }

        // Global Variables
        private string WordToGuess = "";
        private char[] guessedWord;

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

                    WordToGuess = randomLine.ToLower();
                    label_WordToGuess.Visible = true;

                    guessedWord = new string('_', WordToGuess.Length).ToCharArray();
                    label_WordToGuess.Text = new string(guessedWord);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erreur lors de la lecture du fichier : " + ex.Message);
            }

        }

        static int CountLetters(string input)
        {
            int count = 0;
            foreach (char word in input)
            {
                if (char.IsLetter(word))
                {
                    count++;
                }
            }
            return count;
        }

        private void TB_Lettre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TB_Lettre_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                string guess = TB_Lettre.Text.ToLower();
                bool isCorrect = false;
                char LetterTry = guess[0];
                for (int i = 0; i < WordToGuess.Length; i++)
                {
                    if (WordToGuess[i] == LetterTry)
                    {
                        guessedWord[i] = LetterTry;
                        label_WordToGuess.Text = new string(guessedWord);
                        isCorrect = true;

                    }
                }
                if (isCorrect == true)
                {
                    MessageBox.Show("Lettre trouvé !");
                }
                else
                {
                    if (PB_H3.Visible == true)
                    {
                        PB_H3.Visible = false;
                    }
                    else if (PB_H2.Visible == true)
                    {
                        PB_H2.Visible = false;
                    }
                    else if (PB_H1.Visible == true)
                    {
                        PB_H1.Visible = false;
                    }

                    if (PB_H1.Visible == false)
                    {
                        MessageBox.Show("Tu as perdu !");
                        TB_Lettre.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Réessaie !");
                    }
                }

                TB_Lettre.Text = string.Empty;
            }


        }

        static string ReplaceNthOccurrence(string source, string oldSubstring, char newSubstring, int n)
        {
            int occurrence = 0;
            int index = -1;
            for (int i = 0; i <= source.Length - oldSubstring.Length; i++)
            {
                if (source.Substring(i, oldSubstring.Length) == oldSubstring)
                {
                    occurrence++;
                    if (occurrence == n)
                    {
                        index = i;
                        break;
                    }
                }
            }

            if (index != -1)
            {
                return source.Substring(0, index) + newSubstring + source.Substring(index + oldSubstring.Length);
            }

            return source;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
