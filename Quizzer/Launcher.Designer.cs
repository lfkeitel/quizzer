namespace Quizzer
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.quizListBox = new System.Windows.Forms.ListBox();
            this.createDeck = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importQuizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(432, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Quiz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.startQuiz_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(432, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 83);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit Deck";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.editQuiz_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 88);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // quizListBox
            // 
            this.quizListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizListBox.FormattingEnabled = true;
            this.quizListBox.ItemHeight = 25;
            this.quizListBox.Location = new System.Drawing.Point(13, 173);
            this.quizListBox.Name = "quizListBox";
            this.quizListBox.Size = new System.Drawing.Size(381, 254);
            this.quizListBox.TabIndex = 3;
            this.quizListBox.DoubleClick += new System.EventHandler(this.quizListBox_DoubleClick);
            // 
            // createDeck
            // 
            this.createDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDeck.Location = new System.Drawing.Point(432, 263);
            this.createDeck.Name = "createDeck";
            this.createDeck.Size = new System.Drawing.Size(266, 75);
            this.createDeck.TabIndex = 4;
            this.createDeck.Text = "New Deck";
            this.createDeck.UseVisualStyleBackColor = true;
            this.createDeck.Click += new System.EventHandler(this.createDeck_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(752, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newQuizToolStripMenuItem,
            this.exportQuizToolStripMenuItem,
            this.importQuizToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newQuizToolStripMenuItem
            // 
            this.newQuizToolStripMenuItem.Name = "newQuizToolStripMenuItem";
            this.newQuizToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.newQuizToolStripMenuItem.Text = "&New Quiz";
            this.newQuizToolStripMenuItem.Click += new System.EventHandler(this.createDeck_Click);
            // 
            // exportQuizToolStripMenuItem
            // 
            this.exportQuizToolStripMenuItem.Name = "exportQuizToolStripMenuItem";
            this.exportQuizToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exportQuizToolStripMenuItem.Text = "&Export Quiz";
            this.exportQuizToolStripMenuItem.Click += new System.EventHandler(this.exportQuizToolStripMenuItem_Click);
            // 
            // importQuizToolStripMenuItem
            // 
            this.importQuizToolStripMenuItem.Name = "importQuizToolStripMenuItem";
            this.importQuizToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.importQuizToolStripMenuItem.Text = "&Import Quiz";
            this.importQuizToolStripMenuItem.Click += new System.EventHandler(this.importQuizToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Card Decks|*.deck";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Card Decks|*.deck";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 451);
            this.Controls.Add(this.createDeck);
            this.Controls.Add(this.quizListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Launcher";
            this.Text = "Quizzer";
            this.Load += new System.EventHandler(this.Launcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox quizListBox;
        private System.Windows.Forms.Button createDeck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importQuizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

