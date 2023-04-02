using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingCompetition.domain
{
    public class MyTask : Entity<int>{

        public Utility.enumDistance distance { get; set; }
        public Utility.enumStyle style { get; set; }


        public MyTask(Utility.enumDistance distance, Utility.enumStyle style)
        {
            this.distance = distance;
            this.style = style;
        }
    }
}
