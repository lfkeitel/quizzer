using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    class Quiz
    {
        public CardList Cards { get; private set; }
        public string Title;
        public string Author;
        public DateTime LastModified { get; private set; }

        public Quiz()
        {
            LastModified = DateTime.Now;
            Cards = new CardList();
        }

        public Quiz(CardList list)
        {
            LastModified = DateTime.Now;
            Cards = list;
        }

        public void Save(string path)
        {
            QuizFile.Save(this, path);
        }
    }
}
