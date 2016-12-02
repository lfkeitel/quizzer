using System;
using System.Windows.Forms;

namespace Quizzer
{
    partial class EditDeck : Form
    {
        public Quiz quiz;
        int current;
        bool _noise;
        string editMode = "new";
        bool changed = false;

        public EditDeck()
        {
            InitializeComponent();
        }

        private void EditDeck_Load(object sender, EventArgs e)
        {
            if (quiz == null)
            {
                quiz = new Quiz();
            }
            current = quiz.Cards.Cards.Count - 1;
            txtQuizName.Text = quiz.Title;
            txtAuthor.Text = quiz.Author;
            updateQuestionList();
            setQuestionListToCurrent();
            showNavButtons();
        }

        private void showNavButtons()
        {
            prevCardBtn.Visible = (quiz.Cards.Cards.Count > 0 && current > 0);
        }

        private void setDeckStatus(string s)
        {
            deckStatusLbl.Text = s;
        }

        private void updateQuestionList()
        {
            _noise = true;
            questionListCmb.DataSource = null;
            questionListCmb.DataSource = quiz.Cards.Cards;
            questionListCmb.DisplayMember = "Question";
            questionListCmb.ValueMember = "Question";
            _noise = false;
        }

        private void setQuestionListToCurrent()
        {
            _noise = true;
            questionListCmb.SelectedIndex = current;
            _noise = false;
        }

        private void loadCurrentQuestion()
        {
            if (current < 0 || current > quiz.Cards.Cards.Count - 1) return;
            txtQuestion.Text = quiz.Cards.Cards[current].Question;
            txtAnswer.Text = quiz.Cards.Cards[current].Answer;
        }

        private void setDeckChanged(bool state)
        {
            changed = state;
            if (changed) setDeckStatus("Changes have been made");
            else setDeckStatus("No changes");
        }

        private void prevCardBtn_Click(object sender, EventArgs e)
        {

        }

        private void addCardBtn_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "" || txtAnswer.Text == "")
            {
                MessageBox.Show("Question and Answer cannot be empty");
                return;
            }

            saveOldBtn.Visible = false;
            if (editMode == "new")
            {
                Card c = new Card(txtQuestion.Text, txtAnswer.Text);
                quiz.Cards.Add(c);
                setDeckChanged(true);
            }
            current = quiz.Cards.Cards.Count - 1;
            updateQuestionList();
            setQuestionListToCurrent();
            txtQuestion.Text = "";
            txtAnswer.Text = "";
            editMode = "new";
            addCardBtn.Text = "Add";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quiz = new Quiz();
            txtQuestion.Text = "";
            txtAnswer.Text = "";
            setDeckChanged(false);
            updateQuestionList();
            showNavButtons();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDeck();
            setDeckChanged(false);
        }

        private void saveDeck()
        {
            try
            {
                quiz.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void questionListCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_noise) return;
            current = questionListCmb.SelectedIndex;
            loadCurrentQuestion();
            showNavButtons();
            editMode = "old";
            addCardBtn.Text = "Add New";
            saveOldBtn.Visible = true;
        }

        private void saveOldBtn_Click(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "" || txtAnswer.Text == "")
            {
                MessageBox.Show("Question and Answer cannot be empty");
                return;
            }

            quiz.Cards.Cards[current].Question = txtQuestion.Text;
            quiz.Cards.Cards[current].Answer = txtAnswer.Text;
            updateQuestionList();
            setQuestionListToCurrent();
            setDeckChanged(true);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditDeck_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!changed) return;

            DialogResult r = MessageBox.Show(
                "Changes have been made to the deck.\nWould you like to save?",
                "Save Deck",
                MessageBoxButtons.YesNo);

            if (r == DialogResult.No) return;
            saveDeck();
        }

        private void txtQuizName_TextChanged(object sender, EventArgs e)
        {
            quiz.Title = txtQuizName.Text;
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            quiz.Author = txtAuthor.Text;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to delete this deck?", "Delete Deck", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;

            quiz.Delete();
        }
    }
}
