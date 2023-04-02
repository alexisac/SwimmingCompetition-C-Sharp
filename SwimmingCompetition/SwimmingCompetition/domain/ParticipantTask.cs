using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingCompetition.domain
{
    public class ParticipantTask : Entity<int>{

        public int idParticipant { get; set; }
        public int idTask { get; set; }

        public ParticipantTask(int idParticipant, int idTask)
        {
            this.idParticipant = idParticipant;
            this.idTask = idTask;
        }
    }
}
