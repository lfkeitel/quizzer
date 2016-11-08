using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    class Card
    {
        string question;
        string answer;

        public Card(string ques, string ans)
        {
            this.question = ques;
            this.answer = ans;
        }

        public bool IsCorrect(string ans)
        {
            return ans == this.answer;
        }
    }
}
