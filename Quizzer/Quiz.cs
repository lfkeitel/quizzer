using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    class Quiz
    {
        public CardList Cards;
        public string Title;
        public string Author;
        public DateTime LastModified;

        public Quiz()
        {
            LastModified = DateTime.Now;
        }
    }
}
