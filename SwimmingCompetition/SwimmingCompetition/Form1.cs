using System.Configuration;
using SwimmingCompetition.domain;
using SwimmingCompetition.repository;
using SwimmingCompetition.service;

namespace SwimmingCompetition
{
    public partial class Form1 : Form
    {
        static string GetConnectionStringByName(string name)
        {
            // Assume failure.
            string returnValue = null;

            // Look for the name in the connectionStrings section.
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            // If found, return the connection string.
            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }

        //readonly String connectionString = @"Data Source=D:\Proiecte\MPP\baza_de_date\concursInotDatabase; Version=3; New=True; Compress=True;";
        readonly String connectionString = GetConnectionStringByName("concursInotBD");
        //DataSet ds = new DataSet();
        //SQLiteDataAdapter dataAdaptor = new SQLiteDataAdapter();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            RepoBDAccount ra = new RepoBDAccount(connectionString);
            RepoBDParticipant rp = new RepoBDParticipant(connectionString);
            RepoBDTask rt = new RepoBDTask(connectionString);
            RepoBDParticipantTask rpt = new RepoBDParticipantTask(connectionString);
            Validate v = new Validate();

            ServiceAccount sa = new ServiceAccount(ra, v);
            ServiceParticipant sp = new ServiceParticipant(rp, v);
            ServiceTask st = new ServiceTask(rt);
            ServiceParticipantTask spt = new ServiceParticipantTask(rpt);

            FormLogin login = new FormLogin(sa, sp, spt, st);
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
    }
}