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
    public partial class FormSearchByTask : Form
    {
        ServiceAccount sa;
        ServiceParticipant sp;
        ServiceParticipantTask spt;
        ServiceTask st;
        int idTask;

        public FormSearchByTask(ServiceAccount sa, ServiceParticipant sp, ServiceParticipantTask spt, ServiceTask st, int idTask)
        {
            InitializeComponent();
            this.sa = sa;
            this.sp = sp;
            this.st = st;
            this.spt = spt;
            this.idTask = idTask;
        }

        private void FormSearchByTask_Load(object sender, EventArgs e)
        {
            foreach(Participant p in listParticipant(idTask))
            {
                foreach(MyTask t in listTask(p.id))
                {
                    dataGridViewSearchByTask.Rows.Add(p.name, p.age, (int)t.distance, t.style);
                }
            }
        }

        private List<Participant> listParticipant(int idTask) {
            List<ParticipantTask> vectParticipantTask = spt.findAllParticipants(idTask);
            List<Participant> vectParticipant = new List<Participant>();

            foreach (ParticipantTask pt in vectParticipantTask)
            {
                vectParticipant.Add(sp.findOne(pt.idParticipant));
            }
            return vectParticipant;
        }


        private List<MyTask> listTask(int idParticipant)
        {
            List<ParticipantTask> vectParticipantTask = spt.findAllTasks(idParticipant);
            List<MyTask> vectTask = new List<MyTask>();
            foreach (ParticipantTask pt in vectParticipantTask)
            {
                vectTask.Add(st.findOne(pt.idTask));
            }
            return vectTask;
        }


        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAdmin admin = new FormAdmin(sa, sp, spt, st);
            this.Hide();
            admin.ShowDialog();
            this.Close();
        }
    }
}
