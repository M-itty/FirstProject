namespace FirstProject
{
    partial class F_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BT_Login = new Button();
            label1 = new Label();
            TB_Login = new TextBox();
            TB_Pw = new TextBox();
            label2 = new Label();
            BT_Clear = new Button();
            BT_Register = new Button();
            CHB_Remember = new CheckBox();
            SuspendLayout();
            // 
            // BT_Login
            // 
            BT_Login.Anchor = AnchorStyles.None;
            BT_Login.Location = new Point(243, 140);
            BT_Login.Name = "BT_Login";
            BT_Login.Size = new Size(76, 24);
            BT_Login.TabIndex = 0;
            BT_Login.Text = "Login";
            BT_Login.UseVisualStyleBackColor = true;
            BT_Login.Click += BT_Click_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Login :";
            // 
            // TB_Login
            // 
            TB_Login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Login.Location = new Point(12, 27);
            TB_Login.Name = "TB_Login";
            TB_Login.Size = new Size(307, 23);
            TB_Login.TabIndex = 2;
            // 
            // TB_Pw
            // 
            TB_Pw.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Pw.Location = new Point(12, 79);
            TB_Pw.Name = "TB_Pw";
            TB_Pw.Size = new Size(307, 23);
            TB_Pw.TabIndex = 3;
            TB_Pw.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Password :";
            // 
            // BT_Clear
            // 
            BT_Clear.Anchor = AnchorStyles.None;
            BT_Clear.Location = new Point(118, 140);
            BT_Clear.Name = "BT_Clear";
            BT_Clear.Size = new Size(91, 24);
            BT_Clear.TabIndex = 5;
            BT_Clear.Text = "Clear";
            BT_Clear.UseVisualStyleBackColor = true;
            // 
            // BT_Register
            // 
            BT_Register.Anchor = AnchorStyles.None;
            BT_Register.Location = new Point(9, 140);
            BT_Register.Name = "BT_Register";
            BT_Register.Size = new Size(75, 23);
            BT_Register.TabIndex = 6;
            BT_Register.Text = "Register";
            BT_Register.UseVisualStyleBackColor = true;
            BT_Register.Click += BT_Register_Click;
            // 
            // CHB_Remember
            // 
            CHB_Remember.AutoSize = true;
            CHB_Remember.Location = new Point(118, 108);
            CHB_Remember.Name = "CHB_Remember";
            CHB_Remember.Size = new Size(104, 19);
            CHB_Remember.TabIndex = 7;
            CHB_Remember.Text = "Remember me";
            CHB_Remember.UseVisualStyleBackColor = true;
            CHB_Remember.CheckedChanged += CHB_Remember_CheckedChanged;
            // 
            // F_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(331, 176);
            Controls.Add(CHB_Remember);
            Controls.Add(BT_Register);
            Controls.Add(BT_Clear);
            Controls.Add(label2);
            Controls.Add(TB_Pw);
            Controls.Add(TB_Login);
            Controls.Add(label1);
            Controls.Add(BT_Login);
            Name = "F_Login";
            Text = "My App";
            Load += F_Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_Login;
        private Label label1;
        private TextBox TB_Login;
        private TextBox TB_Pw;
        private Label label2;
        private Button BT_Clear;
        private Button BT_Register;
        private CheckBox CHB_Remember;
    }
}
