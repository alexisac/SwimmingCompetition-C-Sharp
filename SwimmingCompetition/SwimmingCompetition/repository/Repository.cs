using SwimmingCompetition.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingCompetition.repository
{
    internal interface Repository<ID, E> where E : Entity<ID>{

        E findOne(ID id);
        List<E> findAll();
        void add(E entity);
        void delete(ID id);
    }
}
