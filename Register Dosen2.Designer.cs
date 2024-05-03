namespace _232410102022_Fabian_Nabil_PBO_A_UTS
{
    partial class Register_Dosen
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
            nama_dosen = new TextBox();
            email_dosen = new TextBox();
            label2 = new Label();
            NIK_dosen = new TextBox();
            label3 = new Label();
            no_hp_dosen = new TextBox();
            label4 = new Label();
            password_dosen = new TextBox();
            label5 = new Label();
            btn_reg_dosen = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 103);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Nama Dosen";
            label1.Click += label1_Click;
            // 
            // nama_dosen
            // 
            nama_dosen.Location = new Point(79, 121);
            nama_dosen.Name = "nama_dosen";
            nama_dosen.Size = new Size(223, 23);
            nama_dosen.TabIndex = 1;
            nama_dosen.TextChanged += nama_dosen_TextChanged;
            // 
            // email_dosen
            // 
            email_dosen.Location = new Point(79, 191);
            email_dosen.Name = "email_dosen";
            email_dosen.Size = new Size(223, 23);
            email_dosen.TabIndex = 3;
            email_dosen.TextChanged += email_dosen_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 173);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // NIK_dosen
            // 
            NIK_dosen.Location = new Point(78, 265);
            NIK_dosen.Name = "NIK_dosen";
            NIK_dosen.Size = new Size(223, 23);
            NIK_dosen.TabIndex = 5;
            NIK_dosen.TextChanged += NIK_dosen_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 247);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 4;
            label3.Text = "NIK";
            // 
            // no_hp_dosen
            // 
            no_hp_dosen.Location = new Point(78, 335);
            no_hp_dosen.Name = "no_hp_dosen";
            no_hp_dosen.Size = new Size(223, 23);
            no_hp_dosen.TabIndex = 7;
            no_hp_dosen.TextChanged += no_hp_dosen_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(78, 317);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "NO HP";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // password_dosen
            // 
            password_dosen.Location = new Point(78, 404);
            password_dosen.Name = "password_dosen";
            password_dosen.Size = new Size(223, 23);
            password_dosen.TabIndex = 9;
            password_dosen.TextChanged += password_dosen_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 386);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 8;
            label5.Text = "Password";
            // 
            // btn_reg_dosen
            // 
            btn_reg_dosen.Location = new Point(78, 454);
            btn_reg_dosen.Name = "btn_reg_dosen";
            btn_reg_dosen.Size = new Size(223, 40);
            btn_reg_dosen.TabIndex = 10;
            btn_reg_dosen.Text = "Register";
            btn_reg_dosen.UseVisualStyleBackColor = true;
            btn_reg_dosen.Click += btn_reg_dosen_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(137, 66);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 11;
            label6.Text = "Register Dosen";
            // 
            // Register_Dosen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 534);
            //Controls.Add(label6);
            Controls.Add(btn_reg_dosen);
            Controls.Add(password_dosen);
            //Controls.Add(label5);
            Controls.Add(no_hp_dosen);
            //Controls.Add(label4);
            Controls.Add(NIK_dosen);
            //Controls.Add(label3);
            Controls.Add(email_dosen);
            //Controls.Add(label2);
            Controls.Add(nama_dosen);
            //Controls.Add(label1);
            Name = "Register_Dosen";
            Text = "Register_Dosen";
            Load += Register_Dosen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nama_dosen;
        private TextBox email_dosen;
        private Label label2;
        private TextBox NIK_dosen;
        private Label label3;
        private TextBox no_hp_dosen;
        private Label label4;
        private TextBox password_dosen;
        private Label label5;
        private Button btn_reg_dosen;
        private Label label6;
    }
}