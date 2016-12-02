using System;

namespace Quizzer
{
    class Quiz
    {
        public CardList Cards { get; set; }
        public string Title { get; set; }
        public string Author;
        public DateTime LastModified { get; private set; }
        public int ID;

        public Quiz()
        {
            ID = 0;
            LastModified = DateTime.Now;
            Cards = new CardList();
        }

        public Quiz(CardList list)
        {
            ID = 0;
            LastModified = DateTime.Now;
            Cards = list;
        }

        public void Save()
        {
            (new QuizLoaderDB()).Save(this);
        }

        public void Delete()
        {
            (new QuizLoaderDB()).Delete(this);
        }
    }
}
