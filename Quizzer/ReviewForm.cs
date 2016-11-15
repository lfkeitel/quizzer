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
    partial class ReviewForm : Form
    {
        public Quiz quiz;
        Card current;

        public ReviewForm()
        {
            InitializeComponent();
        }

        private void ReviewForm_Load(object sender, EventArgs e)
        {
            showNextCard();
        }

        private void flashcardBtn_Click(object sender, EventArgs e)
        {
            if (flashcardBtn.Text == current.Question)
            {
                flashcardBtn.Text = current.Answer;
            }
        }

        private void nextCardBtn_Click(object sender, EventArgs e)
        {
            showNextCard();
        }

        private void prevCardBtn_Click(object sender, EventArgs e)
        {
            showPrevCard();
        }

        private void showButtons()
        {
            if (randomChk.Checked || quiz.Cards.IsStart(current)) prevCardBtn.Visible = false;
            else prevCardBtn.Visible = true;

            if (!randomChk.Checked && quiz.Cards.IsLast(current)) nextCardBtn.Visible = false;
            else nextCardBtn.Visible = true;
        }

        private void showMutlipleChoice(bool state)
        {
            lblMultipleChoiceQuestion.Visible = state;
            checkBtn.Visible = state;
            rdoOptionA.Visible = state;
            rdoOptionA.Checked = false;
            rdoOptionB.Visible = state;
            rdoOptionB.Checked = false;
            rdoOptionC.Visible = state;
            rdoOptionC.Checked = false;
            rdoOptionD.Visible = state;
            rdoOptionD.Checked = false;
        }

        private void showFlashCardBtn(bool state)
        {
            flashcardBtn.Visible = state;
        }

        private void showNextCard()
        {
            if (randomChk.Checked)
            {
                current = quiz.Cards.GetNextRandom();
            }
            else
            {
                current = quiz.Cards.GetNext();
            }
            displayCurrentCard();
            showButtons();
        }

        private void showPrevCard()
        {
            current = quiz.Cards.GetPrev();
            displayCurrentCard();
            showButtons();
        }

        private void displayCurrentCard()
        {
            if (current.Type == "flashcard")
            {
                showMutlipleChoice(false);
                flashcardBtn.Text = current.Question;
                showFlashCardBtn(true);
            }
            else if (current.Type == "multiplechoice")
            {
                showFlashCardBtn(false);
                lblMultipleChoiceQuestion.Text = current.Question;
                rdoOptionA.Text = current.Options[0];
                rdoOptionB.Text = current.Options[1];
                rdoOptionC.Text = current.Options[2];
                rdoOptionD.Text = current.Options[3];
                showMutlipleChoice(true);
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            string selectedAnswer = "";

            if (rdoOptionA.Checked)
            {
                selectedAnswer = "a";
            }
            else if (rdoOptionB.Checked)
            {
                selectedAnswer = "b";
            }
            else if (rdoOptionC.Checked)
            {
                selectedAnswer = "c";
            }
            else if (rdoOptionD.Checked)
            {
                selectedAnswer = "d";
            }
            
            if (current.IsCorrect(selectedAnswer))
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Incorrect");
            }
        }
    }
}
