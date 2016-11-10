﻿using System;
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
            if (nextCardBtn.Text == "Check")
            {
                MessageBox.Show("Checking...");
                nextCardBtn.Text = "->";
                return;
            }

            showNextCard();
        }

        private void prevCardBtn_Click(object sender, EventArgs e)
        {
            showPrevCard();
        }

        private void showButtons()
        {
            if (quiz.Cards.IsStart(current)) prevCardBtn.Visible = false;
            else prevCardBtn.Visible = true;

            if (quiz.Cards.IsLast(current) && current.Type != "multiplechoice") nextCardBtn.Visible = false;
            else nextCardBtn.Visible = true;
        }

        private void showMutlipleChoice(bool state)
        {
            lblMultipleChoiceQuestion.Visible = state;
            rdoOptionA.Visible = state;
            rdoOptionB.Visible = state;
            rdoOptionC.Visible = state;
            rdoOptionD.Visible = state;
        }

        private void showFlashCardBtn(bool state)
        {
            flashcardBtn.Visible = state;
        }

        private void showNextCard()
        {
            current = quiz.Cards.GetNext();
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
                nextCardBtn.Text = "->";
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
                nextCardBtn.Text = "Check";
                showMutlipleChoice(true);
            }
        }
    }
}