namespace Quizzer
{
    partial class EditDeck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionListCmb = new System.Windows.Forms.ComboBox();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.addCardBtn = new System.Windows.Forms.Button();
            this.prevCardBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.deckStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveOldBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuizName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCardType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.rdoACorrect = new System.Windows.Forms.RadioButton();
            this.rdoBCorrect = new System.Windows.Forms.RadioButton();
            this.rdoCCorrect = new System.Windows.Forms.RadioButton();
            this.rdoDCorrect = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionListCmb
            // 
            this.questionListCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionListCmb.FormattingEnabled = true;
            this.questionListCmb.Location = new System.Drawing.Point(12, 138);
            this.questionListCmb.Name = "questionListCmb";
            this.questionListCmb.Size = new System.Drawing.Size(403, 21);
            this.questionListCmb.TabIndex = 0;
            this.questionListCmb.SelectedIndexChanged += new System.EventHandler(this.questionListCmb_SelectedIndexChanged);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(95, 172);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(320, 26);
            this.txtQuestion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(12, 207);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(66, 20);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Answer:";
            this.lblAnswer.Visible = false;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(12, 231);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(403, 187);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.Visible = false;
            // 
            // addCardBtn
            // 
            this.addCardBtn.AutoSize = true;
            this.addCardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCardBtn.Location = new System.Drawing.Point(266, 433);
            this.addCardBtn.Name = "addCardBtn";
            this.addCardBtn.Size = new System.Drawing.Size(102, 35);
            this.addCardBtn.TabIndex = 5;
            this.addCardBtn.Text = "Add";
            this.addCardBtn.UseVisualStyleBackColor = true;
            this.addCardBtn.Click += new System.EventHandler(this.addCardBtn_Click);
            // 
            // prevCardBtn
            // 
            this.prevCardBtn.AutoSize = true;
            this.prevCardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevCardBtn.Location = new System.Drawing.Point(56, 433);
            this.prevCardBtn.Name = "prevCardBtn";
            this.prevCardBtn.Size = new System.Drawing.Size(79, 35);
            this.prevCardBtn.TabIndex = 6;
            this.prevCardBtn.Text = "<-";
            this.prevCardBtn.UseVisualStyleBackColor = true;
            this.prevCardBtn.Click += new System.EventHandler(this.prevCardBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deckStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(428, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // deckStatusLbl
            // 
            this.deckStatusLbl.Name = "deckStatusLbl";
            this.deckStatusLbl.Size = new System.Drawing.Size(0, 17);
            // 
            // saveOldBtn
            // 
            this.saveOldBtn.AutoSize = true;
            this.saveOldBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveOldBtn.Location = new System.Drawing.Point(162, 433);
            this.saveOldBtn.Name = "saveOldBtn";
            this.saveOldBtn.Size = new System.Drawing.Size(79, 35);
            this.saveOldBtn.TabIndex = 9;
            this.saveOldBtn.Text = "Save";
            this.saveOldBtn.UseVisualStyleBackColor = true;
            this.saveOldBtn.Visible = false;
            this.saveOldBtn.Click += new System.EventHandler(this.saveOldBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quiz Name:";
            // 
            // txtQuizName
            // 
            this.txtQuizName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuizName.Location = new System.Drawing.Point(111, 39);
            this.txtQuizName.Name = "txtQuizName";
            this.txtQuizName.Size = new System.Drawing.Size(304, 26);
            this.txtQuizName.TabIndex = 11;
            this.txtQuizName.TextChanged += new System.EventHandler(this.txtQuizName_TextChanged);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(111, 79);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(304, 26);
            this.txtAuthor.TabIndex = 13;
            this.txtAuthor.TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quiz Author:";
            // 
            // cmbCardType
            // 
            this.cmbCardType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCardType.FormattingEnabled = true;
            this.cmbCardType.Items.AddRange(new object[] {
            "Flashcard",
            "Multiple Choice"});
            this.cmbCardType.Location = new System.Drawing.Point(294, 204);
            this.cmbCardType.Name = "cmbCardType";
            this.cmbCardType.Size = new System.Drawing.Size(121, 21);
            this.cmbCardType.TabIndex = 14;
            this.cmbCardType.SelectedIndexChanged += new System.EventHandler(this.cmbCardType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Card:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(12, 240);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(24, 20);
            this.lblA.TabIndex = 16;
            this.lblA.Text = "A:";
            this.lblA.Visible = false;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(12, 288);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(24, 20);
            this.lblB.TabIndex = 17;
            this.lblB.Text = "B:";
            this.lblB.Visible = false;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(11, 386);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(25, 20);
            this.lblD.TabIndex = 19;
            this.lblD.Text = "D:";
            this.lblD.Visible = false;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(12, 338);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(24, 20);
            this.lblC.TabIndex = 18;
            this.lblC.Text = "C:";
            this.lblC.Visible = false;
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(62, 237);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(353, 26);
            this.txtA.TabIndex = 20;
            this.txtA.Visible = false;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(62, 285);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(353, 26);
            this.txtB.TabIndex = 21;
            this.txtB.Visible = false;
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(62, 335);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(353, 26);
            this.txtC.TabIndex = 22;
            this.txtC.Visible = false;
            // 
            // txtD
            // 
            this.txtD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtD.Location = new System.Drawing.Point(62, 383);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(353, 26);
            this.txtD.TabIndex = 23;
            this.txtD.Visible = false;
            // 
            // rdoACorrect
            // 
            this.rdoACorrect.AutoSize = true;
            this.rdoACorrect.Location = new System.Drawing.Point(42, 245);
            this.rdoACorrect.Name = "rdoACorrect";
            this.rdoACorrect.Size = new System.Drawing.Size(14, 13);
            this.rdoACorrect.TabIndex = 24;
            this.rdoACorrect.TabStop = true;
            this.rdoACorrect.UseVisualStyleBackColor = true;
            this.rdoACorrect.Visible = false;
            // 
            // rdoBCorrect
            // 
            this.rdoBCorrect.AutoSize = true;
            this.rdoBCorrect.Location = new System.Drawing.Point(42, 293);
            this.rdoBCorrect.Name = "rdoBCorrect";
            this.rdoBCorrect.Size = new System.Drawing.Size(14, 13);
            this.rdoBCorrect.TabIndex = 25;
            this.rdoBCorrect.TabStop = true;
            this.rdoBCorrect.UseVisualStyleBackColor = true;
            this.rdoBCorrect.Visible = false;
            // 
            // rdoCCorrect
            // 
            this.rdoCCorrect.AutoSize = true;
            this.rdoCCorrect.Location = new System.Drawing.Point(42, 343);
            this.rdoCCorrect.Name = "rdoCCorrect";
            this.rdoCCorrect.Size = new System.Drawing.Size(14, 13);
            this.rdoCCorrect.TabIndex = 26;
            this.rdoCCorrect.TabStop = true;
            this.rdoCCorrect.UseVisualStyleBackColor = true;
            this.rdoCCorrect.Visible = false;
            // 
            // rdoDCorrect
            // 
            this.rdoDCorrect.AutoSize = true;
            this.rdoDCorrect.Location = new System.Drawing.Point(42, 391);
            this.rdoDCorrect.Name = "rdoDCorrect";
            this.rdoDCorrect.Size = new System.Drawing.Size(14, 13);
            this.rdoDCorrect.TabIndex = 27;
            this.rdoDCorrect.TabStop = true;
            this.rdoDCorrect.UseVisualStyleBackColor = true;
            this.rdoDCorrect.Visible = false;
            // 
            // EditDeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 513);
            this.Controls.Add(this.rdoDCorrect);
            this.Controls.Add(this.rdoCCorrect);
            this.Controls.Add(this.rdoBCorrect);
            this.Controls.Add(this.rdoACorrect);
            this.Controls.Add(this.txtD);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbCardType);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtQuizName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveOldBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.prevCardBtn);
            this.Controls.Add(this.addCardBtn);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.questionListCmb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditDeck";
            this.Text = " Edit Deck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditDeck_FormClosing);
            this.Load += new System.EventHandler(this.EditDeck_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox questionListCmb;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button addCardBtn;
        private System.Windows.Forms.Button prevCardBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel deckStatusLbl;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button saveOldBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuizName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbCardType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.RadioButton rdoACorrect;
        private System.Windows.Forms.RadioButton rdoBCorrect;
        private System.Windows.Forms.RadioButton rdoCCorrect;
        private System.Windows.Forms.RadioButton rdoDCorrect;
    }
}