using SwimmingCompetition.domain;
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
    public partial class FormAdmin : Form
    {
        ServiceAccount sa;
        ServiceParticipant sp;
        ServiceParticipantTask spt;
        ServiceTask st;

        public FormAdmin(ServiceAccount sa, ServiceParticipant sp, ServiceParticipantTask spt, ServiceTask st)
        {
            InitializeComponent();
            this.sa = sa;
            this.sp = sp;
            this.spt = spt;
            this.st = st;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            dataGridViewParticipants.ReadOnly = true;
            initializeTabelParticipants();
            dataGridViewParticipants.ClearSelection();
            dataGridViewTasks.ReadOnly = true;
            initializeTabelTasks();
            dataGridViewTasks.ClearSelection();
        }

        private void initializeTabelParticipants()
        {
            foreach (Participant p in sp.findAll())
            {
                dataGridViewParticipants.Rows.Add(p.name, p.age);
            }
        }

        private void initializeTabelTasks()
        {
            foreach (MyTask t in st.findAll())
            {
                dataGridViewTasks.Rows.Add((int)t.distance, t.style.ToString(), numberOfParticipants(t.id));
            }
        }

        private int numberOfParticipants(int idTask)
        {
            return spt.findAllParticipants(idTask).Count();
        }

        private void reloadTableParticipants()
        {
            dataGridViewParticipants.Rows.Clear();
            foreach (Participant p in sp.findAll())
            {
                dataGridViewParticipants.Rows.Add(p.name, p.age);
            }
            dataGridViewParticipants.ClearSelection();
        }

        private void reloadTableTasks()
        {
            dataGridViewTasks.Rows.Clear();
            foreach (MyTask t in st.findAll())
            {
                dataGridViewTasks.Rows.Add((int)t.distance, t.style.ToString(), numberOfParticipants(t.id));
            }
            dataGridViewTasks.ClearSelection();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin(sa, sp, spt, st);
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void buttonAddNewParticipant_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String age = textBoxAge.Text;
            textBoxName.Clear();
            textBoxAge.Clear();
            if (name.Length != 0 && age.Length != 0)
            {
                try
                {
                    sp.add(name, Int32.Parse(age));
                    reloadTableParticipants();
                }
                catch (ServiceException ex)
                {
                    //MessageBox.Show("AICI E EROARE!");
                    MessageBox.Show(ex.myMessage, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (name.Length == 0 && age.Length == 0)
            {
                MessageBox.Show("Name and age can't be empty!", "NAME AND AGE INVALID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name.Length == 0)
            {
                MessageBox.Show("Name can't be empty!", "NAME INVALID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Age can't be empty!", "AGE INVALID!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteParticipant_Click(object sender, EventArgs e)
        {
            if (dataGridViewParticipants.CurrentRow.Cells[0].Value != null)
            {
                String name = (string)dataGridViewParticipants.CurrentRow.Cells[0].Value;
                int age = (int)dataGridViewParticipants.CurrentRow.Cells[1].Value;
                dataGridViewParticipants.ClearSelection();
                int idParticipant = sp.ifExistParticipant(name, age);

                sp.delete(idParticipant);
                reloadTableParticipants();
                reloadTableTasks();
            }
            else
            {
                dataGridViewParticipants.ClearSelection();
                MessageBox.Show("You didn't select one participant", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchByTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.CurrentRow.Cells[0].Value != null)
            {
                int distance = (int)dataGridViewTasks.CurrentRow.Cells[0].Value;
                String style = (string)dataGridViewTasks.CurrentRow.Cells[1].Value;
                dataGridViewTasks.ClearSelection();
                int idTask = st.ifExistTask(distance, style);

                FormSearchByTask search = new FormSearchByTask(sa, sp, spt, st, idTask);
                this.Hide();
                search.ShowDialog();
                this.Close();
            }
            else
            {
                dataGridViewTasks.ClearSelection();
                MessageBox.Show("You didn't select one task", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddTaskForParticipant_Click(object sender, EventArgs e)
        {
            if (dataGridViewParticipants.CurrentRow.Cells[0].Value != null && dataGridViewTasks.CurrentRow.Cells[0].Value != null)
            {

                String name = (string)dataGridViewParticipants.CurrentRow.Cells[0].Value;
                int age = (int)dataGridViewParticipants.CurrentRow.Cells[1].Value;
                dataGridViewParticipants.ClearSelection();
                int idParticipant = sp.ifExistParticipant(name, age);

                int distance = (int)dataGridViewTasks.CurrentRow.Cells[0].Value;
                String style = (string)dataGridViewTasks.CurrentRow.Cells[1].Value;
                dataGridViewTasks.ClearSelection();
                int idTask = st.ifExistTask(distance, style);

                try
                {
                    spt.add(idParticipant, idTask);
                    reloadTableTasks();
                }
                catch (ServiceException ex)
                {
                    MessageBox.Show(ex.myMessage, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else if (dataGridViewParticipants.CurrentRow.Cells[0].Value == null && dataGridViewTasks.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("You didn't select one participant and one task", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dataGridViewParticipants.CurrentRow.Cells[0].Value == null)
            {
                MessageBox.Show("You didn't select one participant", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("You didn't select one task", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
