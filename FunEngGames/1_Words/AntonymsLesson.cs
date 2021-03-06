﻿/*
 * Project Name:    Fun English learning Games
 * File Name:       AntonymsLesson.cs
 * Coded By:        Saleh Alzahrani & Sarah Aljabri
 * Coded On:        Fall 2017
 * About this File: This file handles all of Antonyms lesson logic, generate words with antonyms and pronunciations
 */

using System;
using System.Windows.Forms;
using System.Xml;

namespace FunEngGames
{
    public partial class AntonymsLesson : Form
    {
        public AntonymsLesson()
        {
            InitializeComponent();
        }

        //Variables wordLevelsForm and mainLevelsForm to store previous forms status        
        public wordsLevel wordLevelsForm;
        public mainLevels mainLevelsForm;

        //Storing XML content
        XmlDocument xmlDoc = new XmlDocument();
        public XmlNodeList nodeList;

        //CommonFunctions object
        CommonFunctions CommonFunctions = new CommonFunctions();

        //Setup lesson pages variables
        public int page = 0;
        public int lastPage = 0;
        public int lastNode = 0;

        //Start Antonyms level
        private void button1_Click(object sender, EventArgs e)
        {
            Antonyms antonyms = new Antonyms();
            antonyms.mainLevelsForm = this.mainLevelsForm;
            antonyms.wordLevelsForm = this.wordLevelsForm;
            antonyms.Show();
            this.Hide();
        }

        //Form closed event function: show the words level form
        private void SynonymsLesson_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.wordLevelsForm.Show();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);

            }
        }

        //Synonym lesson load event load all spelling questions from XML file
        private void SynonymsLesson_Load(object sender, EventArgs e)
        {

            xmlDoc.Load("XML/antonyms.xml");
            nodeList = xmlDoc.DocumentElement.SelectNodes("/Questions/antonyms");

            lastPage = nodeList.Count / 9;


            dataGridView1.Rows.Clear();
            GenerateAntonyms(lastNode);
            page++;
            lblPages.Text = "Page " + page + " out of " + lastPage;
            lblWordsCount.Text = nodeList.Count + " words";

            CommonFunctions.SortDataGridColumn(dataGridView1);
        }

        //Generate all questions by calling GenAntonym function;
        public void GenerateAntonyms(int start)
        {
            GenAntonym(start);
            GenAntonym(start + 1);
            GenAntonym(start + 2);
            GenAntonym(start + 3);
            GenAntonym(start + 4);
            GenAntonym(start + 5);
            GenAntonym(start + 6);
            GenAntonym(start + 7);
            GenAntonym(start + 8);
        }

        //Generate word, synonym from Antonym XML file
        public void GenAntonym(int start)
        {
            dataGridView1.Rows.Add(
                nodeList[start].SelectSingleNode("word").InnerText.Trim().ToLower(), 
                nodeList[start].SelectSingleNode("antonym").InnerText.Trim().ToLower()
                );
        }

        //Next page event if we have more than on page
        private void btnNext_Click(object sender, EventArgs e)
        {
            page++;
            lastNode += 9;
            dataGridView1.Rows.Clear();

            GenerateAntonyms(lastNode);


            if (page == lastPage)
            {

                btnNext.Enabled = false;

            }

            btnPrevious.Enabled = true;

            lblPages.Text = "Page " + page + " out of " + lastPage;


        }

        //Previous page event if we have more than on page and next page btn has been clicked
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            page--;
            lastNode -= 9;
            dataGridView1.Rows.Clear();

            GenerateAntonyms(lastNode);

            if (page < lastPage)
            {

                btnNext.Enabled = true;
                //lastNode -= 9;

            }

            if (page == 1)
            {
                btnPrevious.Enabled = false;
            }

            lblPages.Text = "Page " + page + " out of " + lastPage;
        }

        //Pronounce the word after clicking data grid cell
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                CommonFunctions.GenerateMoreInfo(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString(),  "antonyms");
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                CommonFunctions.Pronounce(senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim().ToLower());
            }
        }
    }
}
