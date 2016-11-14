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
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void startQuiz_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.Cancel) return;
            Quiz quiz;

            try
            {
                quiz = QuizFile.LoadFile(openFileDialog1.FileName);
            }
            catch (InvalidQuizFile ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            ReviewForm quizForm = new ReviewForm();
            quizForm.quiz = quiz;
            quizForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Edit existing deck?", "Open", MessageBoxButtons.YesNo);
            Quiz quiz = null;

            if (result == DialogResult.Yes)
            {
                DialogResult r = openFileDialog1.ShowDialog();
                if (r == DialogResult.Cancel) return;

                try
                {
                    quiz = QuizFile.LoadFile(openFileDialog1.FileName);
                }
                catch (InvalidQuizFile ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }

            EditDeck editForm = new EditDeck();
            editForm.quiz = quiz;
            editForm.Show();
        }
    }
}
