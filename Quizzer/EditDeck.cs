using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            questionTxt.Text = quiz.Cards.Cards[current].Question;
            answerTxt.Text = quiz.Cards.Cards[current].Answer;
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
            saveOldBtn.Visible = false;
            if (editMode == "new")
            {
                Card c = new Card(questionTxt.Text, answerTxt.Text);
                quiz.Cards.Add(c);
                setDeckChanged(true);
            }
            current = quiz.Cards.Cards.Count - 1;
            updateQuestionList();
            setQuestionListToCurrent();
            questionTxt.Text = "";
            answerTxt.Text = "";
            editMode = "new";
            addCardBtn.Text = "Add";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quiz = new Quiz();
            questionTxt.Text = "";
            answerTxt.Text = "";
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
            DialogResult d = saveFileDialog1.ShowDialog();
            if (d == DialogResult.Cancel) return;

            try
            {
                quiz.Save(saveFileDialog1.FileName);
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
            quiz.Cards.Cards[current].Question = questionTxt.Text;
            quiz.Cards.Cards[current].Answer = answerTxt.Text;
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changed)
            {
                DialogResult r = MessageBox.Show(
                "Changes have been made to the deck.\nWould you like to save?",
                "Save Deck",
                MessageBoxButtons.YesNo);

                if (r == DialogResult.Yes) saveDeck();
            }

            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.Cancel) return;

            try
            {
                quiz = QuizFile.LoadFile(openFileDialog1.FileName);
            }
            catch (InvalidQuizFile ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            questionTxt.Text = "";
            answerTxt.Text = "";
            setDeckChanged(false);
            current = quiz.Cards.Cards.Count - 1;
            updateQuestionList();
            setQuestionListToCurrent();
            showNavButtons();
        }
    }
}
