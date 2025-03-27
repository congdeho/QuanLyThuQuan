namespace QuanLyThuQuan
{
    partial class RegisterForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            textEmail = new TextBox();
            textPhone = new TextBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 67);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 125);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 183);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            label4.Click += label4_Click;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(45, 27);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(153, 23);
            textUsername.TabIndex = 4;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(45, 85);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(153, 23);
            textPassword.TabIndex = 5;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(45, 143);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(153, 23);
            textEmail.TabIndex = 6;
            // 
            // textPhone
            // 
            textPhone.Location = new Point(45, 201);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(153, 23);
            textPhone.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(77, 246);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 23);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(242, 281);
            Controls.Add(btnRegister);
            Controls.Add(textPhone);
            Controls.Add(textEmail);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textUsername;
        private TextBox textPassword;
        private TextBox textEmail;
        private TextBox textPhone;
        private Button btnRegister;
    }
}