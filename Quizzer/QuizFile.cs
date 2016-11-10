using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizzer
{
    class QuizFile
    {
        public const string Version = "0.1.0";

        public static Quiz LoadFile(string pathname)
        {
            Quiz quiz = new Quiz();
            CardList list = new CardList();
            StreamReader file = new StreamReader(pathname);

            // First check the header
            checkHeader(file);
            loadMetaData(file, quiz);
            loadCards(file, list);
            file.Close();
            quiz.Cards = list;
            return quiz;
        }

        static void checkHeader(StreamReader file)
        {
            string line = file.ReadLine();
            if (line == null)
            {
                throw new InvalidQuizFile("File doesn't have a header");
            }
            if (line != "quizzer " + Version)
            {
                throw new InvalidQuizFile("Incorrect file version");
            }
        }

        static void loadMetaData(StreamReader file, Quiz quiz)
        {
            string line;
            while ((line = file.ReadLine()) != null)
            {
                // === signifies the end of the metadata
                if (line == "===") break;

                string property = "";
                string value = "";
                int position = line.IndexOf(':');
                if (position > 0)
                {
                    property = line.Substring(0, position);
                    value = line.Substring(position + 1);
                }

                switch (property)
                {
                    case "title":
                        quiz.Title = value.Trim();
                        break;
                    case "author":
                        quiz.Author = value.Trim();
                        break;
                }
            }
        }

        static void loadCards(StreamReader file, CardList list)
        {
            string line;
            Card card = new Card();
            while ((line = file.ReadLine()) != null)
            {
                // === signifies the end of each question
                if (line == "===")
                {
                    list.Add(card);
                    card = new Card();
                    continue;
                }

                string property = "";
                string value = "";
                int position = line.IndexOf(':');
                if (position > 0)
                {
                    property = line.Substring(0, position);
                    value = line.Substring(position + 1).Trim();
                }

                switch (property)
                {
                    case "question":
                        card.Question = value;
                        break;
                    case "type":
                        card.Type = value;
                        break;
                    case "answer":
                        card.Answer = value;
                        break;
                    case "a":
                        card.AddOption(0, value);
                        break;
                    case "b":
                        card.AddOption(1, value);
                        break;
                    case "c":
                        card.AddOption(2, value);
                        break;
                    case "d":
                        card.AddOption(3, value);
                        break;
                }
            }
            // Add last card to deck
            list.Add(card);
        }

        public static void SaveCardList(CardList list)
        {

        }
    }
}
