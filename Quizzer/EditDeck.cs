using System;
using System.Windows.Forms;

namespace Quizzer
{
    partial class EditDeck : Form
    {
        public Quiz quiz;
        int current;
        bool _noiseQuBox;
        bool _noiseTypeBox;
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
            current = 0;
            txtQuizName.Text = quiz.Title;
            txtAuthor.Text = quiz.Author;
            updateQuestionList();
            setQuestionListToCurrent();
            showNavButtons();
            setDeckChanged(false);
            _noiseTypeBox = true;
            showCurrentQuestion();
            _noiseTypeBox = false;
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
            _noiseQuBox = true;
            questionListCmb.DataSource = null;
            questionListCmb.DataSource = quiz.Cards.Cards;
            questionListCmb.DisplayMember = "Question";
            questionListCmb.ValueMember = "Question";
            _noiseQuBox = false;
        }

        private void setQuestionListToCurrent()
        {
            if (quiz.Cards.Cards.Count == 0) return;

            _noiseQuBox = true;
            questionListCmb.SelectedIndex = current;
            _noiseQuBox = false;
        }

        private void showCurrentQuestion()
        {
            if (current < 0 || current > quiz.Cards.Cards.Count - 1) return;
            switch (quiz.Cards.Cards[current].Type)
            {
                case "flashcard":
                    showFlashCard();
                    break;
                case "multiplechoice":
                    showMultipleChoice();
                    break;
            }
        }

        private void showFlashCard()
        {
            Card c = quiz.Cards.Cards[current];
            txtQuestion.Text = c.Question;
            txtAnswer.Text = c.Answer;

            setCardTypeControl(c.Type);
            toggleMultipleChoiceControls(false);
            toggleFlashCardControls(true);
        }

        private void toggleFlashCardControls(bool state)
        {
            lblAnswer.Text = "Answer";
            lblAnswer.Visible = txtAnswer.Visible = state;
        }

        private void showMultipleChoice()
        {
            Card c = quiz.Cards.Cards[current];
            txtQuestion.Text = c.Question;
            txtA.Text = c.Options[0];
            txtB.Text = c.Options[1];
            txtC.Text = c.Options[2];
            txtD.Text = c.Options[3];

            switch (c.Answer)
            {
                case "a":
                    rdoACorrect.Checked = true;
                    break;
                case "b":
                    rdoBCorrect.Checked = true;
                    break;
                case "c":
                    rdoCCorrect.Checked = true;
                    break;
                case "d":
                    rdoDCorrect.Checked = true;
                    break;
            }

            setCardTypeControl(c.Type);
            toggleFlashCardControls(false);
            toggleMultipleChoiceControls(true);
        }

        private void toggleMultipleChoiceControls(bool state)
        {
            lblAnswer.Text = "Answers";
            lblA.Visible = lblB.Visible = lblC.Visible = lblD.Visible = state;
            txtA.Visible = txtB.Visible = txtC.Visible = txtD.Visible = state;
            rdoACorrect.Visible = rdoBCorrect.Visible = rdoCCorrect.Visible = rdoDCorrect.Visible = state;
            lblAnswer.Visible = state;
        }

        private void clearWorkArea()
        {
            toggleFlashCardControls(false);
            toggleMultipleChoiceControls(false);
            txtA.Text = txtB.Text = txtC.Text = txtD.Text = "";
            txtQuestion.Text = txtAnswer.Text = "";
            rdoACorrect.Checked = rdoBCorrect.Checked = rdoCCorrect.Checked = rdoDCorrect.Checked = false;
        }

        private void setCardTypeControl(string type)
        {
            _noiseTypeBox = true;
            switch (type)
            {
                case "flashcard":
                    cmbCardType.SelectedIndex = 0;
                    break;
                case "multiplechoice":
                    cmbCardType.SelectedIndex = 1;
                    break;
            }
            _noiseTypeBox = false;
        }

        private void addCardBtn_Click(object sender, EventArgs e)
        {
            saveOldBtn.Visible = false;
            current = 0;

            if (editMode == "new")
            {
                Card c = new Card();
                try
                {
                    saveCurrentQuestion(c);
                }
                catch (QuizSaveException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                quiz.Cards.Add(c);
            }

            updateQuestionList();
            setQuestionListToCurrent();
            setDeckChanged(true);

            clearWorkArea();
            editMode = "new";
            addCardBtn.Text = "Add";
        }

        private void saveOldBtn_Click(object sender, EventArgs e)
        {
            try
            {
                saveCurrentQuestion(quiz.Cards.Cards[current]);
            }
            catch (QuizSaveException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            updateQuestionList();
            setQuestionListToCurrent();
            setDeckChanged(true);
        }

        private void saveCurrentQuestion(Card c)
        {
            switch (cmbCardType.SelectedIndex)
            {
                case 0:
                    saveFlashCard(c);
                    break;
                case 1:
                    saveMultipleChoice(c);
                    break;
            }
        }

        private void saveFlashCard(Card c)
        {
            if (txtQuestion.Text == "" || txtAnswer.Text == "")
            {
                throw new QuizSaveException("Question and Answer cannot be empty");
            }

            c.Type = "flashcard";
            c.Question = txtQuestion.Text;
            c.Answer = txtAnswer.Text;
        }

        private void saveMultipleChoice(Card c)
        {
            if (txtQuestion.Text == "")
            {
                throw new QuizSaveException("Question cannot be empty");
            }

            string newAnswer = "";

            if (rdoACorrect.Checked)
            {
                newAnswer = "a";
            }
            else if (rdoBCorrect.Checked)
            {
                newAnswer = "b";
            }
            else if (rdoCCorrect.Checked)
            {
                newAnswer = "c";
            }
            else if (rdoDCorrect.Checked)
            {
                newAnswer = "d";
            }

            if (newAnswer == "")
            {
                throw new QuizSaveException("Please select an answer");
            }

            c.Type = "multiplechoice";
            c.Question = txtQuestion.Text;
            c.Answer = newAnswer;

            c.AddOption(0, txtA.Text);
            c.AddOption(1, txtB.Text);
            c.AddOption(2, txtC.Text);
            c.AddOption(3, txtD.Text);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quiz = new Quiz();
            clearWorkArea();
            setDeckChanged(false);
            updateQuestionList();
            showNavButtons();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDeck();
            setDeckChanged(false);
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
            if (_noiseQuBox) return;
            current = questionListCmb.SelectedIndex;
            showCurrentQuestion();
            showNavButtons();
            editMode = "old";
            addCardBtn.Text = "Add New";
            saveOldBtn.Visible = true;
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
            setDeckChanged(true);
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            quiz.Author = txtAuthor.Text;
            setDeckChanged(true);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Are you sure you want to delete this deck?", "Delete Deck", MessageBoxButtons.YesNo);
            if (r == DialogResult.No) return;

            quiz.Delete();
        }

        private void cmbCardType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_noiseTypeBox) return;

            string oldQuestion = txtQuestion.Text;
            string oldAnswer = "";
            if (editMode == "old")
            {
                switch (quiz.Cards.Cards[current].Type)
                {
                    case "flashcard":
                        oldAnswer = txtAnswer.Text;
                        break;
                    case "multiplechoice":
                        oldAnswer = txtA.Text;
                        break;
                }
            }

            clearWorkArea();
            txtQuestion.Text = oldQuestion;

            switch (cmbCardType.SelectedIndex)
            {
                case 0:
                    txtAnswer.Text = oldAnswer;
                    toggleFlashCardControls(true);
                    break;
                case 1:
                    txtA.Text = oldAnswer;
                    toggleMultipleChoiceControls(true);
                    break;
            }
        }
    }
}
