namespace Quizzer
{
    partial class ReviewForm
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
            this.flashcardBtn = new System.Windows.Forms.Button();
            this.nextCardBtn = new System.Windows.Forms.Button();
            this.prevCardBtn = new System.Windows.Forms.Button();
            this.lblMultipleChoiceQuestion = new System.Windows.Forms.Label();
            this.rdoOptionA = new System.Windows.Forms.RadioButton();
            this.rdoOptionB = new System.Windows.Forms.RadioButton();
            this.rdoOptionC = new System.Windows.Forms.RadioButton();
            this.rdoOptionD = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // flashcardBtn
            // 
            this.flashcardBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.flashcardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flashcardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flashcardBtn.Location = new System.Drawing.Point(13, 13);
            this.flashcardBtn.Name = "flashcardBtn";
            this.flashcardBtn.Size = new System.Drawing.Size(487, 220);
            this.flashcardBtn.TabIndex = 0;
            this.flashcardBtn.UseVisualStyleBackColor = false;
            this.flashcardBtn.Visible = false;
            this.flashcardBtn.Click += new System.EventHandler(this.flashcardBtn_Click);
            // 
            // nextCardBtn
            // 
            this.nextCardBtn.AutoSize = true;
            this.nextCardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextCardBtn.Location = new System.Drawing.Point(291, 257);
            this.nextCardBtn.Name = "nextCardBtn";
            this.nextCardBtn.Size = new System.Drawing.Size(79, 35);
            this.nextCardBtn.TabIndex = 1;
            this.nextCardBtn.Text = "->";
            this.nextCardBtn.UseVisualStyleBackColor = true;
            this.nextCardBtn.Click += new System.EventHandler(this.nextCardBtn_Click);
            // 
            // prevCardBtn
            // 
            this.prevCardBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevCardBtn.Location = new System.Drawing.Point(149, 258);
            this.prevCardBtn.Name = "prevCardBtn";
            this.prevCardBtn.Size = new System.Drawing.Size(79, 32);
            this.prevCardBtn.TabIndex = 2;
            this.prevCardBtn.Text = "<-";
            this.prevCardBtn.UseVisualStyleBackColor = true;
            this.prevCardBtn.Click += new System.EventHandler(this.prevCardBtn_Click);
            // 
            // lblMultipleChoiceQuestion
            // 
            this.lblMultipleChoiceQuestion.AutoSize = true;
            this.lblMultipleChoiceQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultipleChoiceQuestion.Location = new System.Drawing.Point(26, 25);
            this.lblMultipleChoiceQuestion.Name = "lblMultipleChoiceQuestion";
            this.lblMultipleChoiceQuestion.Size = new System.Drawing.Size(64, 25);
            this.lblMultipleChoiceQuestion.TabIndex = 3;
            this.lblMultipleChoiceQuestion.Text = "label1";
            this.lblMultipleChoiceQuestion.Visible = false;
            // 
            // rdoOptionA
            // 
            this.rdoOptionA.AutoSize = true;
            this.rdoOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOptionA.Location = new System.Drawing.Point(76, 68);
            this.rdoOptionA.Name = "rdoOptionA";
            this.rdoOptionA.Size = new System.Drawing.Size(140, 29);
            this.rdoOptionA.TabIndex = 4;
            this.rdoOptionA.TabStop = true;
            this.rdoOptionA.Text = "radioButton1";
            this.rdoOptionA.UseVisualStyleBackColor = true;
            this.rdoOptionA.Visible = false;
            // 
            // rdoOptionB
            // 
            this.rdoOptionB.AutoSize = true;
            this.rdoOptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOptionB.Location = new System.Drawing.Point(76, 103);
            this.rdoOptionB.Name = "rdoOptionB";
            this.rdoOptionB.Size = new System.Drawing.Size(140, 29);
            this.rdoOptionB.TabIndex = 5;
            this.rdoOptionB.TabStop = true;
            this.rdoOptionB.Text = "radioButton1";
            this.rdoOptionB.UseVisualStyleBackColor = true;
            this.rdoOptionB.Visible = false;
            // 
            // rdoOptionC
            // 
            this.rdoOptionC.AutoSize = true;
            this.rdoOptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOptionC.Location = new System.Drawing.Point(76, 138);
            this.rdoOptionC.Name = "rdoOptionC";
            this.rdoOptionC.Size = new System.Drawing.Size(140, 29);
            this.rdoOptionC.TabIndex = 6;
            this.rdoOptionC.TabStop = true;
            this.rdoOptionC.Text = "radioButton2";
            this.rdoOptionC.UseVisualStyleBackColor = true;
            this.rdoOptionC.Visible = false;
            // 
            // rdoOptionD
            // 
            this.rdoOptionD.AutoSize = true;
            this.rdoOptionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOptionD.Location = new System.Drawing.Point(76, 173);
            this.rdoOptionD.Name = "rdoOptionD";
            this.rdoOptionD.Size = new System.Drawing.Size(140, 29);
            this.rdoOptionD.TabIndex = 7;
            this.rdoOptionD.TabStop = true;
            this.rdoOptionD.Text = "radioButton3";
            this.rdoOptionD.UseVisualStyleBackColor = true;
            this.rdoOptionD.Visible = false;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 302);
            this.Controls.Add(this.rdoOptionD);
            this.Controls.Add(this.rdoOptionC);
            this.Controls.Add(this.rdoOptionB);
            this.Controls.Add(this.rdoOptionA);
            this.Controls.Add(this.lblMultipleChoiceQuestion);
            this.Controls.Add(this.prevCardBtn);
            this.Controls.Add(this.nextCardBtn);
            this.Controls.Add(this.flashcardBtn);
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button flashcardBtn;
        private System.Windows.Forms.Button nextCardBtn;
        private System.Windows.Forms.Button prevCardBtn;
        private System.Windows.Forms.Label lblMultipleChoiceQuestion;
        private System.Windows.Forms.RadioButton rdoOptionA;
        private System.Windows.Forms.RadioButton rdoOptionB;
        private System.Windows.Forms.RadioButton rdoOptionC;
        private System.Windows.Forms.RadioButton rdoOptionD;
    }
}