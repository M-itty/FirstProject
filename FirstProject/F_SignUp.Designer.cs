namespace FirstProject
{
    partial class F_SignUp
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
            BT_SignUp = new Button();
            LL_SignIn = new LinkLabel();
            label1 = new Label();
            LB_Password = new Label();
            TB_Login = new TextBox();
            TB_Password = new TextBox();
            label2 = new Label();
            TB_ConfirmPW = new TextBox();
            label3 = new Label();
            BT_SignInInvisible = new Button();
            SuspendLayout();
            // 
            // BT_SignUp
            // 
            BT_SignUp.Location = new Point(155, 149);
            BT_SignUp.Name = "BT_SignUp";
            BT_SignUp.Size = new Size(75, 23);
            BT_SignUp.TabIndex = 0;
            BT_SignUp.Text = "Sign Up";
            BT_SignUp.UseVisualStyleBackColor = true;
            BT_SignUp.Click += BT_SignUp_Click;
            // 
            // LL_SignIn
            // 
            LL_SignIn.AutoSize = true;
            LL_SignIn.Location = new Point(74, 153);
            LL_SignIn.Name = "LL_SignIn";
            LL_SignIn.Size = new Size(43, 15);
            LL_SignIn.TabIndex = 2;
            LL_SignIn.TabStop = true;
            LL_SignIn.Text = "Sign In";
            LL_SignIn.LinkClicked += LL_SignIn_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 57);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // LB_Password
            // 
            LB_Password.AutoSize = true;
            LB_Password.Location = new Point(66, 86);
            LB_Password.Name = "LB_Password";
            LB_Password.Size = new Size(57, 15);
            LB_Password.TabIndex = 4;
            LB_Password.Text = "Password";
            // 
            // TB_Login
            // 
            TB_Login.Location = new Point(155, 54);
            TB_Login.Name = "TB_Login";
            TB_Login.Size = new Size(100, 23);
            TB_Login.TabIndex = 5;
            // 
            // TB_Password
            // 
            TB_Password.Location = new Point(155, 83);
            TB_Password.Name = "TB_Password";
            TB_Password.Size = new Size(100, 23);
            TB_Password.TabIndex = 6;
            TB_Password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 9);
            label2.Name = "label2";
            label2.Size = new Size(146, 30);
            label2.TabIndex = 7;
            label2.Text = "Register form";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // TB_ConfirmPW
            // 
            TB_ConfirmPW.Location = new Point(155, 112);
            TB_ConfirmPW.Name = "TB_ConfirmPW";
            TB_ConfirmPW.Size = new Size(100, 23);
            TB_ConfirmPW.TabIndex = 9;
            TB_ConfirmPW.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 115);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 8;
            label3.Text = "Confirm Password";
            // 
            // BT_SignInInvisible
            // 
            BT_SignInInvisible.Location = new Point(259, 171);
            BT_SignInInvisible.Name = "BT_SignInInvisible";
            BT_SignInInvisible.Size = new Size(75, 23);
            BT_SignInInvisible.TabIndex = 10;
            BT_SignInInvisible.Text = "Sign in";
            BT_SignInInvisible.UseVisualStyleBackColor = true;
            BT_SignInInvisible.Visible = false;
            BT_SignInInvisible.Click += BT_SignInInvisible_Click;
            // 
            // F_SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 197);
            Controls.Add(BT_SignInInvisible);
            Controls.Add(TB_ConfirmPW);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TB_Password);
            Controls.Add(TB_Login);
            Controls.Add(LB_Password);
            Controls.Add(label1);
            Controls.Add(LL_SignIn);
            Controls.Add(BT_SignUp);
            Name = "F_SignUp";
            Text = "F_SignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_SignUp;
        private LinkLabel LL_SignIn;
        private Label label1;
        private Label LB_Password;
        private TextBox TB_Login;
        private TextBox TB_Password;
        private Label label2;
        private TextBox TB_ConfirmPW;
        private Label label3;
        private Button BT_SignInInvisible;
    }
}