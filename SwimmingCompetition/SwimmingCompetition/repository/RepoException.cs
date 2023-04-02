using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingCompetition.repository
{
    internal class RepoException : Exception
    {

        string myMessage { get; }

        public RepoException(string myMessage)
        {
            this.myMessage = myMessage;
        }

    }
}
