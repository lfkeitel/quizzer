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
            loadQuizList();
        }

        private void loadQuizList()
        {
            List<Quiz> quizzes = QuizLoaderDB.GetQuizList();

            quizListBox.Items.Clear();

            quizListBox.DisplayMember = "Title";
            foreach (Quiz quiz in quizzes)
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
            editForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditDeck_FormClosing);
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
            editForm.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditDeck_FormClosing);
            editForm.Show();
        }

        public void EditDeck_FormClosing(object sender, EventArgs e)
        {
            loadQuizList();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exportQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quiz q = loadQuiz();
            if (q == null)
            {
                MessageBox.Show("Please select a deck");
                return;
            }

            saveFileDialog1.FileName = q.Title;
            DialogResult r = saveFileDialog1.ShowDialog();
            if (r == DialogResult.Cancel) return;

            QuizLoaderFile.Save(q, saveFileDialog1.FileName);
        }

        private void importQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();
            if (r == DialogResult.Cancel) return;

            Quiz q;

            try
            {
                q = QuizLoaderFile.LoadQuiz(openFileDialog1.FileName);
                QuizLoaderDB.Save(q);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            loadQuizList();
        }
    }
}
