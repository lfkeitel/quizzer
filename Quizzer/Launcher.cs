using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Quizzer
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();

            List<Quiz> quizzes = QuizLoaderDB.GetQuizList();

            quizListBox.DisplayMember = "Title";
            foreach(Quiz quiz in quizzes)
            {
                quizListBox.Items.Add(quiz);
            }
        }

        private void startQuiz_Click(object sender, EventArgs e)
        {
            Quiz q = loadQuiz();
            if (q == null)
            {
                MessageBox.Show("Please select a deck");
                return;
            }

            ReviewForm quizForm = new ReviewForm();
            quizForm.quiz = q;
            quizForm.Show();
        }

        private void editQuiz_Click(object sender, EventArgs e)
        {
            Quiz q = loadQuiz();
            if (q == null)
            {
                MessageBox.Show("Please select a deck");
                return;
            }

            EditDeck editForm = new EditDeck();
            editForm.quiz = q;
            editForm.Show();
        }

        private Quiz loadQuiz()
        {
            Quiz quiz = (Quiz)quizListBox.SelectedItem;
            if (quiz == null) return null;

            try
            {
                quiz = QuizLoaderDB.LoadQuiz(quiz);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            return quiz;
        }

        private void quizListBox_DoubleClick(object sender, EventArgs e)
        {
            startQuiz_Click(sender, e);
        }

        private void createDeck_Click(object sender, EventArgs e)
        {
            EditDeck editForm = new EditDeck();
            editForm.quiz = null;
            editForm.Show();
        }
    }
}
