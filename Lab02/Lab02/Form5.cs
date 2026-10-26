using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form5 : Form
    {
        private const string InputFile = "input5.txt";
        private const string OutputFile = "output5.txt";

        private List<MovieTicketInfo> movies = new List<MovieTicketInfo>();
        private CultureInfo vietnamese = new CultureInfo("vi-VN");

        public Form5()
        {
            InitializeComponent();

            btnThemPhim.Click += btnThemPhim_Click;
            btnDocFile.Click += btnDocFile_Click;
            btnGhiFile.Click += btnGhiFile_Click;
            btnXuat.Click += btnXuat_Click;
            cboPhim.SelectedIndexChanged += cboPhim_SelectedIndexChanged;

            LoadMoviesFromFile(false);
        }

        private bool LoadMoviesFromFile(bool showMessages)
        {
            if (!File.Exists(InputFile))
            {
                if (showMessages)
                {
                    MessageBox.Show("Chưa có file " + InputFile + " trong thư mục chạy chương trình.");
                }
                return false;
            }

            List<string> lines = new List<string>();
            using (StreamReader reader = new StreamReader(InputFile))
            {
                foreach (string rawLine in reader.ReadToEnd().Split('\n'))
                {
                    string line = rawLine.Trim();
                    if (line.Length > 0 && line != "...")
                    {
                        lines.Add(line);
                    }
                }
            }

            if (lines.Count == 0 || lines.Count % 3 != 0)
            {
                if (showMessages)
                {
                    MessageBox.Show("File phải gồm các bộ 3 dòng: tên phim, giá vé chuẩn, phòng chiếu.");
                }
                return false;
            }

            List<MovieTicketInfo> loaded = new List<MovieTicketInfo>();
            for (int i = 0; i < lines.Count; i += 3)
            {
                if (!TryParsePrice(lines[i + 1], out long price))
                {
                    if (showMessages)
                    {
                        MessageBox.Show("Giá vé không hợp lệ: \"" + lines[i + 1] + "\" (phim " + lines[i] + ").");
                    }
                    return false;
                }

                MovieTicketInfo movie = new MovieTicketInfo();
                movie.Name = lines[i];
                movie.StandardPrice = price;
                movie.Room = lines[i + 2];
                loaded.Add(movie);
            }

            movies = loaded;
            RefreshMovieCombo(0);
            lblTrangThai.Text = "Đã đọc " + movies.Count + " phim từ " + InputFile;
            return true;
        }

        private void RefreshMovieCombo(int selectedIndex)
        {
            cboPhim.Items.Clear();
            foreach (MovieTicketInfo movie in movies)
            {
                cboPhim.Items.Add(movie.Name);
            }

            if (movies.Count > 0)
            {
                cboPhim.SelectedIndex = selectedIndex;
            }
            else
            {
                cboPhong.Items.Clear();
            }
        }

        private bool TryParsePrice(string text, out long price)
        {
            string digitsOnly = Regex.Replace(text, @"[^\d]", "");
            return long.TryParse(digitsOnly, out price) && price > 0;
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            LoadMoviesFromFile(true);
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            if (movies.Count == 0)
            {
                MessageBox.Show("Chưa có phim nào để ghi.");
                return;
            }

            using (StreamWriter writer = new StreamWriter(InputFile, false, Encoding.UTF8))
            {
                foreach (MovieTicketInfo movie in movies)
                {
                    writer.WriteLine(movie.Name);
                    writer.WriteLine(movie.StandardPrice);
                    writer.WriteLine(movie.Room);
                }
            }

            MessageBox.Show("Đã ghi " + movies.Count + " phim vào " + InputFile);
        }

        private void btnThemPhim_Click(object sender, EventArgs e)
        {
            string name = txtTenPhim.Text.Trim();
            string room = txtPhongChieu.Text.Trim();

            if (name.Length == 0 || room.Length == 0)
            {
                MessageBox.Show("Tên phim và phòng chiếu không được để trống.");
                return;
            }

            if (!TryParsePrice(txtGia.Text, out long price))
            {
                MessageBox.Show("Giá vé chuẩn phải là số dương (ví dụ 75000).");
                return;
            }

            MovieTicketInfo movie = new MovieTicketInfo();
            movie.Name = name;
            movie.StandardPrice = price;
            movie.Room = room;
            movies.Add(movie);

            RefreshMovieCombo(movies.Count - 1);

            txtTenPhim.Clear();
            txtGia.Clear();
            txtPhongChieu.Clear();
            txtTenPhim.Focus();
        }

        private void cboPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboPhim.SelectedIndex;
            if (index >= 0 && index < movies.Count)
            {
                cboPhong.Items.Clear();
                cboPhong.Items.Add(movies[index].Room);
                cboPhong.SelectedIndex = 0;
            }

            for (int i = 0; i < clbGhe.Items.Count; i++)
            {
                clbGhe.SetItemChecked(i, false);
            }
        }

        private void btnMua_Click(object sender, EventArgs e)
        {
            if (txtHoTen.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng nhập họ tên.");
                return;
            }

            int movieIndex = cboPhim.SelectedIndex;
            if (movieIndex < 0)
            {
                MessageBox.Show("Chưa có phim nào. Hãy đọc file input5.txt hoặc thêm phim mới.");
                return;
            }

            if (clbGhe.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ghế.");
                return;
            }

            MovieTicketInfo movie = movies[movieIndex];

            List<string> chosenSeats = new List<string>();
            foreach (object item in clbGhe.CheckedItems)
            {
                chosenSeats.Add(item.ToString() ?? "");
            }

            foreach (string seat in chosenSeats)
            {
                if (movie.SoldSeats.Contains(seat))
                {
                    MessageBox.Show($"Ghế {seat} của phim này đã được mua. Vui lòng chọn ghế khác.");
                    return;
                }
            }

            long totalPrice = 0;
            foreach (string seat in chosenSeats)
            {
                totalPrice += GetSeatPrice(seat, movie.StandardPrice);
            }

            movie.SoldSeats.AddRange(chosenSeats);
            movie.Revenue += totalPrice;

            for (int i = 0; i < clbGhe.Items.Count; i++)
            {
                clbGhe.SetItemChecked(i, false);
            }

            rtbKetQua.Text = "---Thông tin đặt vé---\n";
            rtbKetQua.Text += $"Khách hàng: {txtHoTen.Text.Trim()}\n";
            rtbKetQua.Text += $"Phim: {movie.Name}\n";
            rtbKetQua.Text += $"Phòng chiếu: {movie.Room}\n";
            rtbKetQua.Text += $"Ghế đã chọn: {string.Join(" ", chosenSeats)}\n";
            rtbKetQua.Text += $"Tổng tiền: {FormatMoney(totalPrice)}\n";
        }

        private long GetSeatPrice(string seat, long standardPrice)
        {
            if (seat == "A1" || seat == "A5" || seat == "C1" || seat == "C5")
            {
                return (long)Math.Round(standardPrice * 0.25);
            }

            if (seat == "B2" || seat == "B3" || seat == "B4")
            {
                return standardPrice * 2;
            }

            return standardPrice;
        }

        private string FormatMoney(long amount)
        {
            return amount.ToString("N0", vietnamese) + " VNĐ";
        }

        private int GetRevenueRank(MovieTicketInfo target)
        {
            int rank = 1;
            foreach (MovieTicketInfo movie in movies)
            {
                if (movie.Revenue > target.Revenue)
                {
                    rank++;
                }
            }
            return rank;
        }

        private async void btnXuat_Click(object sender, EventArgs e)
        {
            if (movies.Count == 0)
            {
                MessageBox.Show("Chưa có phim nào để thống kê.");
                return;
            }

            btnXuat.Enabled = false;
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Value = 0;

            int totalSeats = clbGhe.Items.Count;

            using (StreamWriter writer = new StreamWriter(OutputFile, false, Encoding.UTF8))
            {
                for (int i = 0; i < movies.Count; i++)
                {
                    MovieTicketInfo movie = movies[i];
                    int sold = movie.SoldSeats.Count;
                    double soldRatio = totalSeats == 0 ? 0 : 100.0 * sold / totalSeats;

                    writer.WriteLine("Tên phim: " + movie.Name);
                    writer.WriteLine("Phòng chiếu: " + movie.Room);
                    writer.WriteLine("Số lượng vé bán ra: " + sold);
                    writer.WriteLine("Số lượng vé tồn: " + (totalSeats - sold));
                    writer.WriteLine("Tỉ lệ vé bán ra: " + soldRatio.ToString("0.##", CultureInfo.InvariantCulture) + "%");
                    writer.WriteLine("Doanh thu: " + FormatMoney(movie.Revenue));
                    writer.WriteLine("Xếp hạng doanh thu: " + GetRevenueRank(movie));
                    writer.WriteLine();

                    progressBar.Value = (i + 1) * 100 / movies.Count;
                    lblTrangThai.Text = "Đang ghi " + (i + 1) + "/" + movies.Count + "...";
                    await Task.Delay(150);
                }
            }

            lblTrangThai.Text = "Hoàn tất, đã ghi " + OutputFile;
            btnXuat.Enabled = true;
            MessageBox.Show("Đã xuất thống kê vào " + OutputFile);
        }
    }

    public class MovieTicketInfo
    {
        public string Name { get; set; } = "";
        public long StandardPrice { get; set; }
        public string Room { get; set; } = "";
        public List<string> SoldSeats { get; set; } = new List<string>();
        public long Revenue { get; set; }
    }
}