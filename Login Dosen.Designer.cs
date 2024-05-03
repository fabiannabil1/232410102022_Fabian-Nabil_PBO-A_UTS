namespace _232410102022_Fabian_Nabil_PBO_A_UTS
{
    partial class Login_Dosen
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
            NIK_Dosen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Password_dosen = new TextBox();
            btn_log_dosen = new Button();
            SuspendLayout();
            // 
            // NIK_Dosen
            // 
            NIK_Dosen.Location = new Point(189, 175);
            NIK_Dosen.Name = "NIK_Dosen";
            NIK_Dosen.Size = new Size(359, 23);
            NIK_Dosen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 157);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "NIK ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 220);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Password_dosen
            // 
            Password_dosen.Location = new Point(189, 238);
            Password_dosen.Name = "Password_dosen";
            Password_dosen.Size = new Size(359, 23);
            Password_dosen.TabIndex = 2;
            // 
            // btn_log_dosen
            // 
            btn_log_dosen.Location = new Point(294, 294);
            btn_log_dosen.Name = "btn_log_dosen";
            btn_log_dosen.Size = new Size(146, 64);
            btn_log_dosen.TabIndex = 4;
            btn_log_dosen.Text = "LOGIN";
            btn_log_dosen.UseVisualStyleBackColor = true;
            // 
            // Login_Dosen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_log_dosen);
            Controls.Add(label2);
            Controls.Add(Password_dosen);
            Controls.Add(label1);
            Controls.Add(NIK_Dosen);
            Name = "Login_Dosen";
            Text = "Login_Dosen";
            Load += Login_Dosen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NIK_Dosen;
        private Label label1;
        private Label label2;
        private TextBox Password_dosen;
        private Button btn_log_dosen;
    }
}