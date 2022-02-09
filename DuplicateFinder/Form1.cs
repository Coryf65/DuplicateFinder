using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DuplicateFinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
            List<string> dupeWords = FindDuplicates(inputTextBox.Text, ' ');

            foreach (string item in dupeWords)
            {
                Highlight(inputTextBox, item, Color.Green);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
            List<string> dupeSentences = FindDuplicates(inputTextBox.Text, '.');

            foreach (string item in dupeSentences)
            {
                Highlight(inputTextBox, item, Color.Green);
            }
        }

        void Clear()
        {
            inputTextBox.SelectAll();
            inputTextBox.SelectionBackColor = Color.White;
            outputTextBox.Text = "";
        }

        static void Highlight(RichTextBox box, string word, Color color)
        {
            int position = 0;
            string allText = box.Text;
            for (int i = 0; ;)
            {
                int j = allText.IndexOf(word, i, StringComparison.CurrentCultureIgnoreCase);
                if (j < 0) break;
                box.SelectionStart = j;
                box.SelectionLength = word.Length;
                box.SelectionBackColor = color;
                i = j + 1;
            }
            box.SelectionStart = position;
            box.SelectionLength = 0;
        }

        private List<string> FindDuplicates(string textToSearch, char filter)
        {
            string result = "";
            int count = 0;
            string[] searchTerms = textToSearch.ToLower().Split(filter);
            List<string> dupeWords = new List<string>();

            for (int i = 0; i < searchTerms.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < searchTerms.Length; j++)
                {
                    if (searchTerms[i].Trim().Equals(searchTerms[j].Trim()))
                    {
                        count++;
                        searchTerms[j] = "0";
                    }
                }
                if (count > 1 && searchTerms[i] != "0")
                {
                    result += searchTerms[i] + " count: (" + count + ")\n";
                    dupeWords.Add(searchTerms[i]);
                }
            }
            outputTextBox.Text = result;

            return dupeWords;
        }       

        void WriteDebugInfo(string info)
        {
            debugInfoBox.Text += info + "\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}