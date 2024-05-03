namespace _232410102022_Fabian_Nabil_PBO_A_UTS
{
    partial class Register_dosen
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            email = new TextBox();
            nomor = new TextBox();
            password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            register = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 93);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(147, 159);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(203, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(147, 214);
            email.Name = "email";
            email.Size = new Size(203, 23);
            email.TabIndex = 2;
            // 
            // nomor
            // 
            nomor.Location = new Point(147, 264);
            nomor.Name = "nomor";
            nomor.Size = new Size(203, 23);
            nomor.TabIndex = 3;
            nomor.TextChanged += textBox4_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(147, 309);
            password.Name = "password";
            password.Size = new Size(203, 23);
            password.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 93);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 162);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 6;
            label2.Text = "nik";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 214);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 267);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "Nomor HP";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 312);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 9;
            label5.Text = "Password";
            // 
            // register
            // 
            register.Location = new Point(119, 355);
            register.Name = "register";
            register.Size = new Size(260, 58);
            register.TabIndex = 10;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            // 
            // Register_dosen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 450);
            Controls.Add(register);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password);
            Controls.Add(nomor);
            Controls.Add(email);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Register_dosen";
            Text = "Register_dosen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox email;
        private TextBox nomor;
        private TextBox password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button register;
    }
}