namespace FirstProject
{
    partial class F_RestAPI
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
            BT_ReadAPI = new Button();
            LB_Data = new ListBox();
            SuspendLayout();
            // 
            // BT_ReadAPI
            // 
            BT_ReadAPI.Location = new Point(61, 123);
            BT_ReadAPI.Name = "BT_ReadAPI";
            BT_ReadAPI.Size = new Size(129, 72);
            BT_ReadAPI.TabIndex = 0;
            BT_ReadAPI.Text = "Read API";
            BT_ReadAPI.UseVisualStyleBackColor = true;
            BT_ReadAPI.Click += BT_ReadAPI_Click;
            // 
            // LB_Data
            // 
            LB_Data.FormattingEnabled = true;
            LB_Data.ItemHeight = 15;
            LB_Data.Location = new Point(298, 20);
            LB_Data.Name = "LB_Data";
            LB_Data.Size = new Size(277, 334);
            LB_Data.TabIndex = 1;
            // 
            // F_RestAPI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 385);
            Controls.Add(LB_Data);
            Controls.Add(BT_ReadAPI);
            Name = "F_RestAPI";
            Text = "F_RestAPI";
            ResumeLayout(false);
        }

        #endregion

        private Button BT_ReadAPI;
        private ListBox LB_Data;
    }
}