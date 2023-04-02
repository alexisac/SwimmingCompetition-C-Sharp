using SwimmingCompetition.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingCompetition.repository
{
    internal interface RepoParticipant : Repository<int, Participant>
    {
        int ifExistParticipant(Participant p);
    }
}
