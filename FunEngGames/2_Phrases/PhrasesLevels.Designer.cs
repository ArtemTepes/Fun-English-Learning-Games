﻿namespace FunEngGames
{
    partial class phrasesLevel
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
            this.picSpelling = new System.Windows.Forms.PictureBox();
            this.picIdioms = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPartOfSpeechPoints = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblIdiomsPoints = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSpelling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdioms)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picSpelling
            // 
            this.picSpelling.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picSpelling.BackColor = System.Drawing.Color.Transparent;
            this.picSpelling.BackgroundImage = global::FunEngGames.Properties.Resources.posTitle;
            this.picSpelling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSpelling.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSpelling.Location = new System.Drawing.Point(61, 181);
            this.picSpelling.Name = "picSpelling";
            this.picSpelling.Size = new System.Drawing.Size(338, 282);
            this.picSpelling.TabIndex = 1;
            this.picSpelling.TabStop = false;
            this.picSpelling.Click += new System.EventHandler(this.picSpelling_Click);
            this.picSpelling.MouseLeave += new System.EventHandler(this.picSpelling_MouseLeave);
            this.picSpelling.MouseHover += new System.EventHandler(this.picSpelling_MouseHover);
            // 
            // picIdioms
            // 
            this.picIdioms.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picIdioms.BackColor = System.Drawing.Color.Transparent;
            this.picIdioms.BackgroundImage = global::FunEngGames.Properties.Resources.idiomsTitle;
            this.picIdioms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picIdioms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picIdioms.Location = new System.Drawing.Point(749, 181);
            this.picIdioms.Name = "picIdioms";
            this.picIdioms.Size = new System.Drawing.Size(338, 282);
            this.picIdioms.TabIndex = 2;
            this.picIdioms.TabStop = false;
            this.picIdioms.Click += new System.EventHandler(this.picHomonyms_Click);
            this.picIdioms.MouseLeave += new System.EventHandler(this.picSentences_MouseLeave);
            this.picIdioms.MouseHover += new System.EventHandler(this.picSentences_MouseHover);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(97, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Part of speech Points";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPartOfSpeechPoints
            // 
            this.lblPartOfSpeechPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPartOfSpeechPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPartOfSpeechPoints.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartOfSpeechPoints.ForeColor = System.Drawing.Color.Black;
            this.lblPartOfSpeechPoints.Location = new System.Drawing.Point(37, 8);
            this.lblPartOfSpeechPoints.Name = "lblPartOfSpeechPoints";
            this.lblPartOfSpeechPoints.Size = new System.Drawing.Size(171, 37);
            this.lblPartOfSpeechPoints.TabIndex = 9;
            this.lblPartOfSpeechPoints.Text = "0";
            this.lblPartOfSpeechPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(829, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Idioms Points";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FunEngGames.Properties.Resources.result;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblPartOfSpeechPoints);
            this.panel1.Location = new System.Drawing.Point(109, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 65);
            this.panel1.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::FunEngGames.Properties.Resources.result;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.lblIdiomsPoints);
            this.panel3.Location = new System.Drawing.Point(797, 524);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 65);
            this.panel3.TabIndex = 16;
            // 
            // lblIdiomsPoints
            // 
            this.lblIdiomsPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIdiomsPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblIdiomsPoints.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdiomsPoints.ForeColor = System.Drawing.Color.Black;
            this.lblIdiomsPoints.Location = new System.Drawing.Point(37, 8);
            this.lblIdiomsPoints.Name = "lblIdiomsPoints";
            this.lblIdiomsPoints.Size = new System.Drawing.Size(170, 37);
            this.lblIdiomsPoints.TabIndex = 9;
            this.lblIdiomsPoints.Text = "0";
            this.lblIdiomsPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::FunEngGames.Properties.Resources.phrasesMainTitle;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1026, 98);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::FunEngGames.Properties.Resources._lock;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(894, 615);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // phrasesLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FunEngGames.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 673);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picIdioms);
            this.Controls.Add(this.picSpelling);
            this.MinimumSize = new System.Drawing.Size(1166, 720);
            this.Name = "phrasesLevel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fun English Learning Games: Phrases Levels";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainLevels_FormClosed);
            this.Load += new System.EventHandler(this.phrasesLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSpelling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIdioms)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSpelling;
        private System.Windows.Forms.PictureBox picIdioms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblPartOfSpeechPoints;
        public System.Windows.Forms.Label lblIdiomsPoints;
    }
}