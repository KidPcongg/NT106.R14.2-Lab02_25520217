using System.IO;
namespace Lab02

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string content;

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("TextFile1.txt"))
            {
                content = reader.ReadToEnd();
            }
            rtbContent.Text = content;
        }



        private void btnWrite_Click_1(object sender, EventArgs e)
        {
            if (content == null)
            {
                MessageBox.Show("Hãy bấm ĐỌC FILE trước.");
                return;
            }

            using (StreamWriter writer = new StreamWriter("output1.txt"))
            {
                writer.Write(content.ToUpper());
            }
            MessageBox.Show("Đã ghi output1.txt");
        }
    }
}
