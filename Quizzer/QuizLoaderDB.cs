using System;
using System.IO;
using System.Data;
using System.Data.SQLite;
using System.Collections.Generic;

namespace Quizzer
{
    class QuizLoaderDB
    {
        private static string dbFile = "quizDatabase.sqlite3";
        private static SQLiteConnection dbConn;

        public static Quiz LoadQuiz(string name)
        {
            CardList list = new CardList();
            Quiz quiz = new Quiz(list);
            quiz.Title = name;

            loadMetaData(quiz);
            loadCards(quiz, list);
            return quiz;
        }

        public static Quiz LoadQuiz(Quiz quiz)
        {
            if (quiz.Title == "") return quiz;
            
            CardList list = new CardList();
            quiz.Cards = list;
            loadMetaData(quiz);
            loadCards(quiz, list);
            return quiz;
        }

        public static void createDatabaseIfNeeded()
        {
            if (File.Exists(dbFile)) return;

            SQLiteConnection.CreateFile(dbFile);
            SQLiteConnection dbConnection = new SQLiteConnection(string.Format("Data Source={0};Version=3;", dbFile));
            dbConnection.Open();

            // Create quiz table
            string sql = @"CREATE TABLE ""quiz"" (
            ""id"" INTEGER PRIMARY KEY AUTOINCREMENT,
            ""name"" TEXT,
            ""author"" TEXT,
            ""lastModified"" INTEGER
            )";
            SQLiteCommand command = new SQLiteCommand(sql, dbConnection);
            command.ExecuteNonQuery();

            // Create question table
            sql = @"CREATE TABLE ""question"" (
            ""id"" INTEGER PRIMARY KEY AUTOINCREMENT,
            ""quiz"" INTEGER REFERENCES ""quiz"" (""id"") ON DELETE CASCADE,
            ""question"" TEXT,
            ""answer"" TEXT,
            ""type"" TEXT,
            ""options"" TEXT
            )";
            command.CommandText = sql;
            command.ExecuteNonQuery();
        }

        static void openDatabase()
        {
            // Database has never been opened
            if (dbConn != null && dbConn.State != ConnectionState.Closed) return;

            // Ensure a database file exists
            createDatabaseIfNeeded();

            // Check if database was created and opened
            if (dbConn != null && dbConn.State == ConnectionState.Open) return;

            // Open the database if it's not already
            dbConn = new SQLiteConnection(string.Format("Data Source={0};Version=3;", dbFile));
            dbConn.Open();
        }

        static void loadMetaData(Quiz quiz)
        {
            string sql = "SELECT * FROM \"quiz\" WHERE \"name\" = @title";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);

            command.Parameters.Add("@title", DbType.String);
            command.Parameters["@title"].Value = quiz.Title;

            SQLiteDataReader reader = command.ExecuteReader();
            if (!reader.HasRows) return;

            reader.Read();
            quiz.ID = int.Parse(reader["id"].ToString());
            quiz.Author = reader["author"].ToString();
            reader.Close();
        }

        static void loadCards(Quiz quiz, CardList list)
        {
            string sql = "SELECT * FROM \"question\" WHERE \"quiz\" = @quiz";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);

            command.Parameters.Add("@quiz", DbType.Int32);
            command.Parameters["@quiz"].Value = quiz.ID;

            SQLiteDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Card card = new Card(reader["question"].ToString(), reader["answer"].ToString());
                card.Type = reader["type"].ToString();
                // Fallback to flashcard type in case something went wrong
                if (card.Type == "") card.Type = "flashcard";
                card.ID = int.Parse(reader["id"].ToString());

                if (card.Type == "multiplechoice")
                {
                    string options = reader["options"].ToString();
                    string[] optionArray = options.Split(new string[] { ";;" }, StringSplitOptions.None);
                    if (optionArray.Length != 4) continue;

                    card.AddOption(0, optionArray[0]);
                    card.AddOption(1, optionArray[1]);
                    card.AddOption(2, optionArray[2]);
                    card.AddOption(3, optionArray[3]);
                }

                list.Add(card);
            }
        }

        public static void Delete(Quiz quiz)
        {
            string sql = @"DELETE FROM ""quiz"" WHERE ""id"" = @id";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);

            command.Parameters.Add("@id", DbType.Int32);
            command.Parameters["@id"].Value = quiz.ID;

            Int32 rowsDeleted = command.ExecuteNonQuery();
            if (rowsDeleted != 1)
            {
                throw new QuizSaveException("Quiz delete failed");
            }
        }

        public static void Save(Quiz quiz)
        {
            if (quiz.ID == 0) insertQuiz(quiz);
            else updateQuiz(quiz);

            saveCards(quiz);
        }

        private static void insertQuiz(Quiz quiz)
        {
            string sql = "INSERT INTO \"quiz\" (\"name\", \"author\", \"lastModified\") VALUES (@name, @auth, @lastMod)";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            command.Parameters.Add("@name", DbType.String);
            command.Parameters["@name"].Value = quiz.Title;

            command.Parameters.Add("@auth", DbType.String);
            command.Parameters["@auth"].Value = quiz.Author;

            command.Parameters.Add("@lastMod", DbType.UInt32);
            command.Parameters["@lastMod"].Value = getUnixTimeStamp(quiz.LastModified);

            Int32 rowsInserted = command.ExecuteNonQuery();
            if (rowsInserted != 1)
            {
                throw new QuizSaveException("Quiz insert failed");
            }

            quiz.ID = (int)dbConn.LastInsertRowId;
        }

        private static void updateQuiz(Quiz quiz)
        {
            string sql = "UPDATE \"quiz\" SET \"name\" = @name, \"author\" = @auth, \"lastModified\" = @lastMod WHERE id = @id";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            command.Parameters.Add("@name", DbType.String);
            command.Parameters["@name"].Value = quiz.Title;

            command.Parameters.Add("@auth", DbType.String);
            command.Parameters["@auth"].Value = quiz.Author;

            command.Parameters.Add("@lastMod", DbType.UInt32);
            command.Parameters["@lastMod"].Value = getUnixTimeStamp(quiz.LastModified);

            command.Parameters.Add("@id", DbType.Int32);
            command.Parameters["@id"].Value = quiz.ID;

            Int32 rowsUpdated = command.ExecuteNonQuery();
            if (rowsUpdated != 1)
            {
                throw new QuizSaveException("Quiz update failed");
            }
        }

        private static void saveCards(Quiz quiz)
        {
            foreach(Card c in quiz.Cards.Cards)
            {
                if (c.ID == 0) insertCard(c, quiz.ID);
                else updateCard(c);
            }
        }

        private static void insertCard(Card c, int quiz)
        {
            string sql = @"INSERT INTO ""question"" (""quiz"", ""question"", ""answer"", ""type"", ""options"")
            VALUES (@quiz, @question, @answer, @type, @options)";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);

            command.Parameters.Add("@quiz", DbType.Int32);
            command.Parameters["@quiz"].Value = quiz;

            command.Parameters.Add("@question", DbType.String);
            command.Parameters["@question"].Value = c.Question;

            command.Parameters.Add("@answer", DbType.String);
            command.Parameters["@answer"].Value = c.Answer;
            
            command.Parameters.Add("@type", DbType.String);
            command.Parameters["@type"].Value = c.Type;

            command.Parameters.Add("@options", DbType.String);
            command.Parameters["@options"].Value = String.Join(";;", c.Options);

            Int32 rowsUpdated = command.ExecuteNonQuery();
            if (rowsUpdated != 1)
            {
                throw new QuizSaveException("Card insert failed");
            }

            c.ID = (int)dbConn.LastInsertRowId;
        }

        private static void updateCard(Card c)
        {
            string sql = @"UPDATE ""question"" SET ""question"" = @question, ""answer"" = @answer, ""type"" = @type, ""options"" = @options WHERE ""id"" = @id";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);

            command.Parameters.Add("@id", DbType.Int32);
            command.Parameters["@id"].Value = c.ID;

            command.Parameters.Add("@question", DbType.String);
            command.Parameters["@question"].Value = c.Question;

            command.Parameters.Add("@answer", DbType.String);
            command.Parameters["@answer"].Value = c.Answer;
            
            command.Parameters.Add("@type", DbType.String);
            command.Parameters["@type"].Value = c.Type;

            command.Parameters.Add("@options", DbType.String);
            command.Parameters["@options"].Value = String.Join(";;", c.Options);

            Int32 rowsUpdated = command.ExecuteNonQuery();
            if (rowsUpdated != 1)
            {
                throw new QuizSaveException("Card update failed");
            }
        }

        private static long getUnixTimeStamp(DateTime d)
        {
            return (long)(d.ToUniversalTime().Subtract(new DateTime(1970, 1, 1, 0, 0, 0))).TotalSeconds;
        }

        public static List<Quiz> GetQuizList()
        {
            openDatabase();

            List<Quiz> quizzes = new List<Quiz>();

            string sql = "SELECT \"id\", \"name\" FROM \"quiz\" ORDER BY \"name\"";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Quiz q = new Quiz();
                q.ID = int.Parse(reader["id"].ToString());
                q.Title = reader["name"].ToString();
                quizzes.Add(q);
            }

            return quizzes;
        }
    }
}
