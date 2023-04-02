using SwimmingCompetition.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingCompetition
{
    public partial class FormLogin : Form
    {
        ServiceAccount sa;
        ServiceParticipant sp;
        ServiceParticipantTask spt;
        ServiceTask st;

        public FormLogin(ServiceAccount sa, ServiceParticipant sp, ServiceParticipantTask spt, ServiceTask st)
        {
            InitializeComponent();
            this.sa = sa;
            this.sp = sp;
            this.spt = spt;
            this.st = st;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            if (username.Length != 0 && password.Length != 0)
            {
                int idAccount = sa.ifExistAccount(username, password);
                if (idAccount != -1)
                {
                    // Ma duce la interfata de admin
                    FormAdmin admin = new FormAdmin(sa, sp, spt, st);
                    this.Hide();
                    admin.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("This account doesn't exist!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (username.Length == 0 && password.Length == 0)
            {
                MessageBox.Show("Username and password can't be empty!", "USERNAME AND PASSWORD INVALID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (username.Length == 0)
            {
                MessageBox.Show("Username can't be empty!", "USERNAME INVALID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Password can't be empty!", "PASSWORD INVALID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabelSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister register = new FormRegister(sa, sp, spt, st);
            this.Hide();
            register.ShowDialog();
            this.Close();
        }
    }
}
