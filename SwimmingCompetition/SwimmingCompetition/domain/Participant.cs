using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingCompetition.domain
{
    public class Participant : Entity<int>{

        public string name { get; set; }
        public int age { get; set; }


        public Participant(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
