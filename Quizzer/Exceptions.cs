using System;

namespace Quizzer
{
    class InvalidQuizFile : Exception
    {
        public InvalidQuizFile(string msg) : base(msg) { }
    }

    class QuizSaveException : Exception
    {
        public QuizSaveException(string msg) : base(msg) { }
    }
}
