using SwimmingCompetition.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingCompetition.repository
{
    internal interface RepoParticipantTask : Repository<int, ParticipantTask>
    {
        bool ifExist(ParticipantTask pt);

        List<ParticipantTask> findAllParticipants(int idTask);

        List<ParticipantTask> findAllTasks(int idParticipant);
    }
}
