namespace FirstProject
{
    partial class F_Pendu
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
            TB_Parcourir = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TB_Lettre = new TextBox();
            PB_H1 = new PictureBox();
            PB_H2 = new PictureBox();
            PB_H3 = new PictureBox();
            label_WordToGuess = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)PB_H1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_H2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_H3).BeginInit();
            SuspendLayout();
            // 
            // TB_Parcourir
            // 
            TB_Parcourir.Location = new Point(157, 112);
            TB_Parcourir.Name = "TB_Parcourir";
            TB_Parcourir.Size = new Size(371, 23);
            TB_Parcourir.TabIndex = 0;
            TB_Parcourir.Click += TB_Parcourir_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 115);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Parcourir :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(265, 9);
            label2.Name = "label2";
            label2.Size = new Size(140, 47);
            label2.TabIndex = 2;
            label2.Text = "PENDU";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 248);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Lettre :";
            // 
            // TB_Lettre
            // 
            TB_Lettre.Location = new Point(265, 245);
            TB_Lettre.Name = "TB_Lettre";
            TB_Lettre.Size = new Size(30, 23);
            TB_Lettre.TabIndex = 4;
            TB_Lettre.TextChanged += TB_Lettre_TextChanged;
            TB_Lettre.KeyDown += TB_Lettre_KeyDown;
            // 
            // PB_H1
            // 
            PB_H1.BackgroundImageLayout = ImageLayout.None;
            PB_H1.Image = Properties.Resources.heart;
            PB_H1.Location = new Point(12, 28);
            PB_H1.Name = "PB_H1";
            PB_H1.Size = new Size(34, 28);
            PB_H1.SizeMode = PictureBoxSizeMode.Zoom;
            PB_H1.TabIndex = 5;
            PB_H1.TabStop = false;
            // 
            // PB_H2
            // 
            PB_H2.BackgroundImageLayout = ImageLayout.None;
            PB_H2.Image = Properties.Resources.heart;
            PB_H2.Location = new Point(42, 28);
            PB_H2.Name = "PB_H2";
            PB_H2.Size = new Size(34, 28);
            PB_H2.SizeMode = PictureBoxSizeMode.Zoom;
            PB_H2.TabIndex = 6;
            PB_H2.TabStop = false;
            // 
            // PB_H3
            // 
            PB_H3.BackgroundImageLayout = ImageLayout.None;
            PB_H3.Image = Properties.Resources.heart;
            PB_H3.Location = new Point(73, 28);
            PB_H3.Name = "PB_H3";
            PB_H3.Size = new Size(34, 28);
            PB_H3.SizeMode = PictureBoxSizeMode.Zoom;
            PB_H3.TabIndex = 7;
            PB_H3.TabStop = false;
            // 
            // label_WordToGuess
            // 
            label_WordToGuess.AutoSize = true;
            label_WordToGuess.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_WordToGuess.Location = new Point(239, 177);
            label_WordToGuess.Name = "label_WordToGuess";
            label_WordToGuess.Size = new Size(96, 30);
            label_WordToGuess.TabIndex = 8;
            label_WordToGuess.Text = "Nothing";
            label_WordToGuess.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(569, 41);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // F_Pendu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 416);
            Controls.Add(label4);
            Controls.Add(label_WordToGuess);
            Controls.Add(PB_H3);
            Controls.Add(PB_H2);
            Controls.Add(PB_H1);
            Controls.Add(TB_Lettre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TB_Parcourir);
            Name = "F_Pendu";
            Text = "Pendu";
            ((System.ComponentModel.ISupportInitialize)PB_H1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_H2).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_H3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Parcourir;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TB_Lettre;
        private PictureBox PB_H1;
        private PictureBox PB_H2;
        private PictureBox PB_H3;
        private Label label_WordToGuess;
        private Label label4;
    }
}