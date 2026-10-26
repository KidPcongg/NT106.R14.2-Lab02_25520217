using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form4 : Form
    {
        private const string InputFile = "input4.txt";
        private const string OutputFile = "output4.txt";

        private List<Student> enteredStudents = new List<Student>();
        private List<Student> loadedStudents = new List<Student>();
        private int currentIndex = 0;

        public Form4()
        {
            InitializeComponent();
            ShowCurrentStudent();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name.Length == 0)
            {
                MessageBox.Show("Họ và tên không được để trống.");
                return;
            }

            if (!Regex.IsMatch(txtId.Text.Trim(), @"^\d{8}$"))
            {
                MessageBox.Show("MSSV phải là số gồm đúng 8 chữ số.");
                return;
            }

            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0.");
                return;
            }

            if (!TryParseScore(txtCourse1.Text, out float course1) ||
                !TryParseScore(txtCourse2.Text, out float course2) ||
                !TryParseScore(txtCourse3.Text, out float course3))
            {
                MessageBox.Show("Điểm từng học phần phải là số từ 0 đến 10.");
                return;
            }

            Student student = new Student();
            student.FullName = name;
            student.StudentId = int.Parse(txtId.Text.Trim());
            student.Phone = txtPhone.Text.Trim();
            student.Course1 = course1;
            student.Course2 = course2;
            student.Course3 = course3;
            enteredStudents.Add(student);

            rtbList.AppendText(student.FullName + "\n" + student.StudentId + "\n" + student.Phone + "\n" +
                FormatScore(course1) + "\n" + FormatScore(course2) + "\n" + FormatScore(course3) + "\n\n");

            txtName.Clear();
            txtId.Clear();
            txtPhone.Clear();
            txtCourse1.Clear();
            txtCourse2.Clear();
            txtCourse3.Clear();
            txtName.Focus();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(InputFile))
            {
                MessageBox.Show("Chưa có file " + InputFile + ". Hãy nhập sinh viên và bấm Write to a File trước.");
                return;
            }

            string json = File.ReadAllText(InputFile, Encoding.UTF8);
            loadedStudents = JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();

            foreach (Student student in loadedStudents)
            {
                student.Average = (float)Math.Round((student.Course1 + student.Course2 + student.Course3) / 3.0, 2);
            }

            using (StreamWriter writer = new StreamWriter(OutputFile, false, Encoding.UTF8))
            {
                foreach (Student student in loadedStudents)
                {
                    writer.WriteLine("Họ và tên: " + student.FullName);
                    writer.WriteLine("MSSV: " + student.StudentId);
                    writer.WriteLine("Điện thoại: " + student.Phone);
                    writer.WriteLine("Điểm môn 1: " + FormatScore(student.Course1));
                    writer.WriteLine("Điểm môn 2: " + FormatScore(student.Course2));
                    writer.WriteLine("Điểm môn 3: " + FormatScore(student.Course3));
                    writer.WriteLine("Điểm trung bình: " + FormatScore(student.Average));
                    writer.WriteLine();
                }
            }

            currentIndex = 0;
            ShowCurrentStudent();
        }


        private void MovePage(int step)
        {
            int newIndex = currentIndex + step;
            if (newIndex < 0 || newIndex >= loadedStudents.Count)
            {
                return;
            }

            currentIndex = newIndex;
            ShowCurrentStudent();
        }

        private void ShowCurrentStudent()
        {
            bool hasData = loadedStudents.Count > 0;
            btnBack.Enabled = hasData && currentIndex > 0;
            btnNext.Enabled = hasData && currentIndex < loadedStudents.Count - 1;
            lblPage.Text = hasData ? (currentIndex + 1) + " / " + loadedStudents.Count : "0 / 0";

            if (!hasData)
            {
                txtViewName.Clear();
                txtViewId.Clear();
                txtViewPhone.Clear();
                txtViewCourse1.Clear();
                txtViewCourse2.Clear();
                txtViewCourse3.Clear();
                txtViewAverage.Clear();
                return;
            }

            Student student = loadedStudents[currentIndex];
            txtViewName.Text = student.FullName;
            txtViewId.Text = student.StudentId.ToString();
            txtViewPhone.Text = student.Phone;
            txtViewCourse1.Text = FormatScore(student.Course1);
            txtViewCourse2.Text = FormatScore(student.Course2);
            txtViewCourse3.Text = FormatScore(student.Course3);
            txtViewAverage.Text = FormatScore(student.Average);
        }

        private bool TryParseScore(string text, out float score)
        {
            string normalized = text.Trim().Replace(',', '.');
            return float.TryParse(normalized, NumberStyles.Float, CultureInfo.InvariantCulture, out score)
                   && score >= 0 && score <= 10;
        }

        private string FormatScore(float score)
        {
            return score.ToString("0.##", CultureInfo.InvariantCulture);
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void btnWrite_Click_1(object sender, EventArgs e)
        {
            if (enteredStudents.Count == 0)
            {
                MessageBox.Show("Chưa có sinh viên nào. Hãy nhập rồi bấm Add.");
                return;
            }

            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;
            options.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;

            string json = JsonSerializer.Serialize(enteredStudents, options);
            File.WriteAllText(InputFile, json, Encoding.UTF8);

            MessageBox.Show("Đã ghi " + enteredStudents.Count + " sinh viên vào " + InputFile);
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            MovePage(1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MovePage(-1);
        }
    }
}