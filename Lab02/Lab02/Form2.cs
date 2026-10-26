using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            using (FileStream fileStream = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string content = reader.ReadToEnd();

                txtFileName.Text = openFileDialog.SafeFileName;
                txtSize.Text = fileStream.Length + " bytes";
                txtUrl.Text = fileStream.Name;
                txtLines.Text = CountLines(content).ToString();
                txtWords.Text = CountWords(content).ToString();
                txtChars.Text = content.Length.ToString();
                rtbContent.Text = content;
            }
        }

        private int CountLines(string content)
        {
            if (content.Length == 0)
            {
                return 0;
            }

            string[] lines = content.Split('\n');
            int lineCount = lines.Length;

            if (lines[lineCount - 1].Length == 0)
            {
                lineCount--;
            }
            return lineCount;
        }

        private int CountWords(string content)
        {
            char[] separators = { ' ', '\t', '\r', '\n' };
            return content.Split(separators, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
