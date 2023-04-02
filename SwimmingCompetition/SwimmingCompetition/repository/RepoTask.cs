using SwimmingCompetition.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingCompetition.repository
{
    internal interface RepoTask : Repository<int, MyTask>
    {
        int ifExistTask(MyTask t);
    }
}
