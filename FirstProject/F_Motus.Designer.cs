namespace FirstProject
{
    partial class F_Motus
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
            label1 = new Label();
            TB_Parcourir = new TextBox();
            TB_Word = new TextBox();
            label2 = new Label();
            FLP_Labels = new FlowLayoutPanel();
            lb_WordToGuess = new Label();
            lbl_wordtypingcount = new Label();
            lbl_nbWordtoGuess = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 50);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 3;
            label1.Text = "Parcourir :";
            label1.Click += label1_Click;
            // 
            // TB_Parcourir
            // 
            TB_Parcourir.Location = new Point(190, 47);
            TB_Parcourir.Name = "TB_Parcourir";
            TB_Parcourir.Size = new Size(371, 23);
            TB_Parcourir.TabIndex = 2;
            TB_Parcourir.Click += TB_Parcourir_TextChanged;
            // 
            // TB_Word
            // 
            TB_Word.Location = new Point(298, 112);
            TB_Word.Name = "TB_Word";
            TB_Word.Size = new Size(157, 23);
            TB_Word.TabIndex = 5;
            TB_Word.TextChanged += TB_Word_TextChanged;
            TB_Word.KeyDown += TB_Word_KeyDown;
            TB_Word.KeyPress += TB_Word_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 115);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "Mot :";
            // 
            // FLP_Labels
            // 
            FLP_Labels.AutoScroll = true;
            FLP_Labels.AutoSize = true;
            FLP_Labels.BackColor = SystemColors.ControlDark;
            FLP_Labels.FlowDirection = FlowDirection.TopDown;
            FLP_Labels.Location = new Point(254, 150);
            FLP_Labels.Name = "FLP_Labels";
            FLP_Labels.Size = new Size(272, 273);
            FLP_Labels.TabIndex = 9;
            FLP_Labels.WrapContents = false;
            // 
            // lb_WordToGuess
            // 
            lb_WordToGuess.AutoSize = true;
            lb_WordToGuess.Location = new Point(585, 50);
            lb_WordToGuess.Name = "lb_WordToGuess";
            lb_WordToGuess.Size = new Size(38, 15);
            lb_WordToGuess.TabIndex = 10;
            lb_WordToGuess.Text = "label3";
            // 
            // lbl_wordtypingcount
            // 
            lbl_wordtypingcount.AutoSize = true;
            lbl_wordtypingcount.Location = new Point(461, 115);
            lbl_wordtypingcount.Name = "lbl_wordtypingcount";
            lbl_wordtypingcount.Size = new Size(0, 15);
            lbl_wordtypingcount.TabIndex = 11;
            // 
            // lbl_nbWordtoGuess
            // 
            lbl_nbWordtoGuess.AutoSize = true;
            lbl_nbWordtoGuess.Location = new Point(350, 85);
            lbl_nbWordtoGuess.Name = "lbl_nbWordtoGuess";
            lbl_nbWordtoGuess.Size = new Size(0, 15);
            lbl_nbWordtoGuess.TabIndex = 12;
            // 
            // F_Motus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_nbWordtoGuess);
            Controls.Add(lbl_wordtypingcount);
            Controls.Add(lb_WordToGuess);
            Controls.Add(FLP_Labels);
            Controls.Add(label2);
            Controls.Add(TB_Word);
            Controls.Add(label1);
            Controls.Add(TB_Parcourir);
            Name = "F_Motus";
            Text = "F_Motus";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TB_Parcourir;
        private TextBox TB_Word;
        private Label label2;
        private FlowLayoutPanel FLP_Labels;
        private Label lb_WordToGuess;
        private Label lbl_wordtypingcount;
        private Label lbl_nbWordtoGuess;
    }
}