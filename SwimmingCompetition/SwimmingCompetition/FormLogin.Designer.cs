namespace SwimmingCompetition
{
    partial class FormLogin
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
            label4 = new Label();
            linkLabelSignUp = new LinkLabel();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(244, 312);
            label4.Name = "label4";
            label4.Size = new Size(207, 23);
            label4.TabIndex = 16;
            label4.Text = "Don't have an account?";
            // 
            // linkLabelSignUp
            // 
            linkLabelSignUp.AutoSize = true;
            linkLabelSignUp.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelSignUp.Location = new Point(479, 312);
            linkLabelSignUp.Name = "linkLabelSignUp";
            linkLabelSignUp.Size = new Size(75, 23);
            linkLabelSignUp.TabIndex = 15;
            linkLabelSignUp.TabStop = true;
            linkLabelSignUp.Text = "Sign up";
            linkLabelSignUp.LinkClicked += linkLabelSignUp_LinkClicked;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(378, 166);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(176, 29);
            textBoxPassword.TabIndex = 14;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(378, 118);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(176, 29);
            textBoxUsername.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(244, 172);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(244, 118);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(345, 61);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 10;
            label1.Text = "Concurs Inot";
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(345, 233);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(119, 37);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(linkLabelSignUp);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private LinkLabel linkLabelSignUp;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonLogin;
    }
}