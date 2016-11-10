using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    class InvalidQuizFile : Exception
    {
        public InvalidQuizFile(string msg) : base(msg) { }
    }
}
