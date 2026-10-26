using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            StringBuilder outputBuilder = new StringBuilder();
            rtbInput.Clear();

            using (StreamReader reader = new StreamReader("TextFile2.txt"))
            {
                string[] lines = reader.ReadToEnd().Split('\n');

                foreach (string rawLine in lines)
                {
                    string line = rawLine.Trim();
                    if (line.Length == 0)
                    {
                        continue;
                    }


                    rtbInput.AppendText(line + "\n");
                    outputBuilder.AppendLine(line + " = " + Calculate(line));
                }
            }

            using (StreamWriter writer = new StreamWriter("output3.txt"))
            {
                writer.Write(outputBuilder.ToString());
            }

            rtbOutput.Text = outputBuilder.ToString();
            MessageBox.Show("Đã ghi output3.txt");
        }

        private string Calculate(string expression)
        {
            try
            {
                double result = ExpressionEvaluator.Evaluate(expression);
                return result.ToString("0.######", CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                return "Lỗi (" + ex.Message + ")";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)

        {
        }

        private void rtbInput_TextChanged(object sender, EventArgs e)
        {
        }
    }
}