﻿using System;
using System.Windows.Forms;

namespace FunEngGames
{
    public partial class phrasesLevel : Form
    {
        public Form mainLevelsForm;

        public phrasesLevel()
        {
            InitializeComponent();
        }

        private void picSpelling_MouseHover(object sender, EventArgs e)
        {
            picSpelling.BackgroundImage = Properties.Resources.posTitleHover;
        }

        private void picSpelling_MouseLeave(object sender, EventArgs e)
        {
            picSpelling.BackgroundImage = Properties.Resources.posTitle;
        }


        private void picSentences_MouseHover(object sender, EventArgs e)
        {
            picIdioms.BackgroundImage = Properties.Resources.idiomsTitleHover;
        }

        private void picSentences_MouseLeave(object sender, EventArgs e)
        {
            picIdioms.BackgroundImage = Properties.Resources.idiomsTitle;
        }


        private void picSpelling_Click(object sender, EventArgs e)
        {
            /*
            spelling spelling = new spelling();
            spelling.mainLevelsForm = this;
            this.Hide();
            spelling.Show();
            */
            spellingLesson spellingLesson = new spellingLesson();
            //spellingLesson.mainLevelsForm = this;
            this.Hide();
            spellingLesson.Show();
        }

        private void mainLevels_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainLevelsForm.Show();
        }

        private void picHomonyms_Click(object sender, EventArgs e)
        {
            /*
            homonyms homonyms = new homonyms();
            homonyms.mainLevelsForm = this;
            this.Hide();
            homonyms.Show();
            */
            HomonymsLesson HomonymsLesson = new HomonymsLesson();
            //HomonymsLesson.mainLevelsForm = this;
            this.Hide();
            HomonymsLesson.Show();
        }

    }
}
