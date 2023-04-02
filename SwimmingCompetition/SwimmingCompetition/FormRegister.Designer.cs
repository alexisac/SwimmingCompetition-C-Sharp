namespace SwimmingCompetition
{
    partial class FormRegister
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
            label5 = new Label();
            linkLabelLogIn = new LinkLabel();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            buttonSignUp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(349, 22);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(205, 78);
            label2.Name = "label2";
            label2.Size = new Size(96, 23);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(205, 120);
            label3.Name = "label3";
            label3.Size = new Size(91, 23);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(205, 167);
            label4.Name = "label4";
            label4.Size = new Size(165, 23);
            label4.TabIndex = 3;
            label4.Text = "Confirm password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(205, 275);
            label5.Name = "label5";
            label5.Size = new Size(185, 23);
            label5.TabIndex = 4;
            label5.Text = "You have an acount?";
            // 
            // linkLabelLogIn
            // 
            linkLabelLogIn.AutoSize = true;
            linkLabelLogIn.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelLogIn.Location = new Point(515, 275);
            linkLabelLogIn.Name = "linkLabelLogIn";
            linkLabelLogIn.Size = new Size(63, 23);
            linkLabelLogIn.TabIndex = 5;
            linkLabelLogIn.TabStop = true;
            linkLabelLogIn.Text = "Log in";
            linkLabelLogIn.LinkClicked += linkLabelLogIn_LinkClicked;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(391, 75);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(187, 29);
            textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(391, 120);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(187, 29);
            textBoxPassword.TabIndex = 7;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxConfirmPassword.Location = new Point(391, 164);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(187, 29);
            textBoxConfirmPassword.TabIndex = 8;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Font = new Font("Georgia", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSignUp.Location = new Point(327, 220);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(121, 37);
            buttonSignUp.TabIndex = 9;
            buttonSignUp.Text = "Sign up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSignUp);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(linkLabelLogIn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabelLogIn;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxConfirmPassword;
        private Button buttonSignUp;
    }
}