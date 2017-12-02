﻿namespace FunEngGames
{
    partial class mainLevels
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
            this.picWords = new System.Windows.Forms.PictureBox();
            this.picSentences = new System.Windows.Forms.PictureBox();
            this.picPhrases = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWordsPoints = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPhrasesPoints = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSentencesPoints = new System.Windows.Forms.Label();
            this.picPhrasesLock = new System.Windows.Forms.PictureBox();
            this.picSentencesLock = new System.Windows.Forms.PictureBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSentences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhrases)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhrasesLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSentencesLock)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // picWords
            // 
            this.picWords.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picWords.BackColor = System.Drawing.Color.Transparent;
            this.picWords.BackgroundImage = global::FunEngGames.Properties.Resources.wordsTitle;
            this.picWords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picWords.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWords.Location = new System.Drawing.Point(74, 159);
            this.picWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picWords.Name = "picWords";
            this.picWords.Size = new System.Drawing.Size(243, 334);
            this.picWords.TabIndex = 1;
            this.picWords.TabStop = false;
            this.picWords.Click += new System.EventHandler(this.picWords_Click);
            this.picWords.MouseLeave += new System.EventHandler(this.picWords_MouseLeave);
            this.picWords.MouseHover += new System.EventHandler(this.picWords_MouseHover);
            // 
            // picSentences
            // 
            this.picSentences.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picSentences.BackColor = System.Drawing.Color.Transparent;
            this.picSentences.BackgroundImage = global::FunEngGames.Properties.Resources.sentencesTitle;
            this.picSentences.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSentences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSentences.Enabled = false;
            this.picSentences.Location = new System.Drawing.Point(898, 159);
            this.picSentences.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSentences.Name = "picSentences";
            this.picSentences.Size = new System.Drawing.Size(243, 334);
            this.picSentences.TabIndex = 2;
            this.picSentences.TabStop = false;
            this.picSentences.Click += new System.EventHandler(this.picSentences_Click);
            this.picSentences.MouseLeave += new System.EventHandler(this.picSentences_MouseLeave);
            this.picSentences.MouseHover += new System.EventHandler(this.picSentences_MouseHover);
            // 
            // picPhrases
            // 
            this.picPhrases.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPhrases.BackColor = System.Drawing.Color.Transparent;
            this.picPhrases.BackgroundImage = global::FunEngGames.Properties.Resources.phrasesTitle;
            this.picPhrases.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPhrases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPhrases.Enabled = false;
            this.picPhrases.Location = new System.Drawing.Point(489, 159);
            this.picPhrases.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPhrases.Name = "picPhrases";
            this.picPhrases.Size = new System.Drawing.Size(243, 334);
            this.picPhrases.TabIndex = 3;
            this.picPhrases.TabStop = false;
            this.picPhrases.Click += new System.EventHandler(this.picPhrases_Click);
            this.picPhrases.MouseLeave += new System.EventHandler(this.picPhrases_MouseLeave);
            this.picPhrases.MouseHover += new System.EventHandler(this.picPhrases_MouseHover);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(19, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1183, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "Main levels";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(107, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Words Points";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWordsPoints
            // 
            this.lblWordsPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblWordsPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblWordsPoints.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordsPoints.ForeColor = System.Drawing.Color.Black;
            this.lblWordsPoints.Location = new System.Drawing.Point(37, 7);
            this.lblWordsPoints.Name = "lblWordsPoints";
            this.lblWordsPoints.Size = new System.Drawing.Size(171, 37);
            this.lblWordsPoints.TabIndex = 9;
            this.lblWordsPoints.Text = "0";
            this.lblWordsPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(514, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phrases Points";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(912, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sentences Points";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FunEngGames.Properties.Resources.result;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lblWordsPoints);
            this.panel1.Location = new System.Drawing.Point(74, 539);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 65);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::FunEngGames.Properties.Resources.result;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.lblPhrasesPoints);
            this.panel2.Location = new System.Drawing.Point(489, 535);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 65);
            this.panel2.TabIndex = 15;
            // 
            // lblPhrasesPoints
            // 
            this.lblPhrasesPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhrasesPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPhrasesPoints.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhrasesPoints.ForeColor = System.Drawing.Color.Black;
            this.lblPhrasesPoints.Location = new System.Drawing.Point(35, 7);
            this.lblPhrasesPoints.Name = "lblPhrasesPoints";
            this.lblPhrasesPoints.Size = new System.Drawing.Size(171, 37);
            this.lblPhrasesPoints.TabIndex = 9;
            this.lblPhrasesPoints.Text = "0";
            this.lblPhrasesPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::FunEngGames.Properties.Resources.result;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Controls.Add(this.lblSentencesPoints);
            this.panel3.Location = new System.Drawing.Point(898, 535);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 65);
            this.panel3.TabIndex = 16;
            // 
            // lblSentencesPoints
            // 
            this.lblSentencesPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSentencesPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblSentencesPoints.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentencesPoints.ForeColor = System.Drawing.Color.Black;
            this.lblSentencesPoints.Location = new System.Drawing.Point(37, 7);
            this.lblSentencesPoints.Name = "lblSentencesPoints";
            this.lblSentencesPoints.Size = new System.Drawing.Size(171, 37);
            this.lblSentencesPoints.TabIndex = 9;
            this.lblSentencesPoints.Text = "0";
            this.lblSentencesPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picPhrasesLock
            // 
            this.picPhrasesLock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picPhrasesLock.BackColor = System.Drawing.Color.Transparent;
            this.picPhrasesLock.BackgroundImage = global::FunEngGames.Properties.Resources._lock;
            this.picPhrasesLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picPhrasesLock.Location = new System.Drawing.Point(586, 601);
            this.picPhrasesLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPhrasesLock.Name = "picPhrasesLock";
            this.picPhrasesLock.Size = new System.Drawing.Size(48, 46);
            this.picPhrasesLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhrasesLock.TabIndex = 23;
            this.picPhrasesLock.TabStop = false;
            this.picPhrasesLock.Click += new System.EventHandler(this.picPhrasesLock_Click);
            // 
            // picSentencesLock
            // 
            this.picSentencesLock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picSentencesLock.BackColor = System.Drawing.Color.Transparent;
            this.picSentencesLock.BackgroundImage = global::FunEngGames.Properties.Resources._lock;
            this.picSentencesLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSentencesLock.Location = new System.Drawing.Point(996, 601);
            this.picSentencesLock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSentencesLock.Name = "picSentencesLock";
            this.picSentencesLock.Size = new System.Drawing.Size(48, 46);
            this.picSentencesLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSentencesLock.TabIndex = 24;
            this.picSentencesLock.TabStop = false;
            this.picSentencesLock.Click += new System.EventHandler(this.picSentencesLock_Click);
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltitle.BackColor = System.Drawing.Color.Transparent;
            this.lbltitle.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(39, 72);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(1144, 58);
            this.lbltitle.TabIndex = 25;
            this.lbltitle.Text = "Play all Words levels to unlock Phrases levels";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbltitle.Click += new System.EventHandler(this.lbltitle_Click);
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.picSentences);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.lbltitle);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.picWords);
            this.panel4.Controls.Add(this.picPhrasesLock);
            this.panel4.Controls.Add(this.picSentencesLock);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.picPhrases);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1221, 681);
            this.panel4.TabIndex = 26;
            // 
            // mainLevels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::FunEngGames.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 681);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1237, 718);
            this.Name = "mainLevels";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fun English Learning Games: Main Levels";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainLevels_FormClosed);
            this.Load += new System.EventHandler(this.mainLevels_Load);
            this.Shown += new System.EventHandler(this.mainLevels_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.picWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSentences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPhrases)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPhrasesLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSentencesLock)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblWordsPoints;
        public System.Windows.Forms.Label lblPhrasesPoints;
        public System.Windows.Forms.Label lblSentencesPoints;
        public System.Windows.Forms.PictureBox picSentences;
        public System.Windows.Forms.PictureBox picPhrases;
        public System.Windows.Forms.PictureBox picPhrasesLock;
        public System.Windows.Forms.PictureBox picSentencesLock;
        public System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel4;
    }
}