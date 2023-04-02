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
    public partial class FormRegister : Form
    {
        ServiceAccount sa;
        ServiceParticipant sp;
        ServiceParticipantTask spt;
        ServiceTask st;

        public FormRegister(ServiceAccount sa, ServiceParticipant sp, ServiceParticipantTask spt, ServiceTask st)
        {
            InitializeComponent();
            this.sa = sa;
            this.sp = sp;
            this.spt = spt;
            this.st = st;
        }

        private void linkLabelLogIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin login = new FormLogin(sa, sp, spt, st);
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;
            String confirmedPassword = textBoxConfirmPassword.Text;
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();

            if (password.Equals(confirmedPassword))
            {
                if (username.Length != 0 && password.Length != 0)
                {
                    if (sa.ifExistAccount(username, password) == -1)
                    {
                        try
                        {
                            sa.add(username, password);
                            MessageBox.Show("Now you can log in", "YOUR ACCOUNT WAS ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FormLogin login = new FormLogin(sa, sp, spt, st);
                            this.Hide();
                            login.ShowDialog();
                            this.Close();
                        }
                        catch (ServiceException er)
                        {
                            //MessageBox.Show(er.myMessage, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            MessageBox.Show("AICI E EROARE");
                        }
                    }
                    else
                    {
                        MessageBox.Show("This username already exist!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                MessageBox.Show("The two passwords are not identical!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
