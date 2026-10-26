using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form6 : Form
    {
        private readonly string connectionString =
            "Data Source=" + Path.Combine(AppContext.BaseDirectory, "foods.db") + ";Version=3;";

        private readonly Random random = new Random();
        private string selectedImagePath = "";

        public Form6()
        {
            InitializeComponent();

            btnChonHinh.Click += btnChonHinh_Click;
            btnThem.Click += btnThem_Click;
            txtTimRandom.Click += txtTimRandom_Click;
            btnXoa.Click += btnXoa_Click;
            btnThoat.Click += btnThoat_Click;
            btnThemNguoi.Click += btnThemNguoi_Click;
            lstDanhSach.SelectedIndexChanged += lstDanhSach_SelectedIndexChanged;

            cboQuyen.SelectedIndex = 0;

            try
            {
                InitializeDatabase();
                LoadContributors();
                LoadDishes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cơ sở dữ liệu SQLite:\n" + ex.Message);
            }
        }

        private void InitializeDatabase()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                Execute(connection,
                    "CREATE TABLE IF NOT EXISTS NguoiDung (" +
                    "IDNCC INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "HoVaTen TEXT NOT NULL, " +
                    "QuyenHan TEXT NOT NULL)");

                Execute(connection,
                    "CREATE TABLE IF NOT EXISTS MonAn (" +
                    "IDMA INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "TenMonAn TEXT NOT NULL, " +
                    "HinhAnh TEXT, " +
                    "IDNCC INTEGER NOT NULL, " +
                    "FOREIGN KEY (IDNCC) REFERENCES NguoiDung(IDNCC))");

                long userCount;
                using (SQLiteCommand command = new SQLiteCommand("SELECT COUNT(*) FROM NguoiDung", connection))
                {
                    userCount = (long)command.ExecuteScalar();
                }

                if (userCount == 0)
                {
                    Execute(connection,
                        "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES " +
                        "('Nguyễn Văn A', 'Admin'), ('Trần Thị B', 'User'), ('Lê Văn C', 'User')");

                    Execute(connection,
                        "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES " +
                        "('Bún riêu', '', 1), ('Bún thịt nướng', '', 2), ('Cơm tấm sườn trứng', '', 3), " +
                        "('Phở', '', 1), ('Gỏi cuốn', '', 2)");
                }
            }
        }

        private static void Execute(SQLiteConnection connection, string sql)
        {
            using (SQLiteCommand command = new SQLiteCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        private void LoadContributors()
        {
            cboNguoi.Items.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(
                    "SELECT IDNCC, HoVaTen FROM NguoiDung ORDER BY IDNCC", connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cboNguoi.Items.Add(new ContributorItem(reader.GetInt64(0), reader.GetString(1)));
                    }
                }
            }

            if (cboNguoi.Items.Count > 0)
            {
                cboNguoi.SelectedIndex = 0;
            }
        }

        private void LoadDishes()
        {
            lstDanhSach.Items.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(
                    "SELECT m.IDMA, m.TenMonAn, m.HinhAnh, n.HoVaTen " +
                    "FROM MonAn m JOIN NguoiDung n ON m.IDNCC = n.IDNCC ORDER BY m.IDMA", connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DishItem dish = new DishItem();
                        dish.Id = reader.GetInt64(0);
                        dish.Name = reader.GetString(1);
                        dish.ImagePath = reader.IsDBNull(2) ? "" : reader.GetString(2);
                        dish.Owner = reader.GetString(3);
                        lstDanhSach.Items.Add(dish);
                    }
                }
            }
        }

        private void ShowDish(DishItem dish)
        {
            txtKetQuaHomNay.Text = dish.Name + " (góp bởi " + dish.Owner + ")";

            if (picMon.Image != null)
            {
                picMon.Image.Dispose();
                picMon.Image = null;
            }

            if (dish.ImagePath.Length > 0 && File.Exists(dish.ImagePath))
            {
                using (Image original = Image.FromFile(dish.ImagePath))
                {
                    picMon.Image = new Bitmap(original);
                }
            }
        }

        private void lstDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            DishItem dish = lstDanhSach.SelectedItem as DishItem;
            if (dish != null)
            {
                ShowDish(dish);
            }
        }

        private void txtTimRandom_Click(object sender, EventArgs e)
        {
            if (lstDanhSach.Items.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn đang trống!");
                return;
            }

            lstDanhSach.SelectedIndex = random.Next(lstDanhSach.Items.Count);
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = dialog.FileName;
                    lblHinh.Text = Path.GetFileName(selectedImagePath);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string dishName = txtMonAn.Text.Trim();
            ContributorItem contributor = cboNguoi.SelectedItem as ContributorItem;

            if (dishName.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!");
                return;
            }

            if (contributor == null)
            {
                MessageBox.Show("Vui lòng chọn người đóng góp!");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(
                    "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@name, @image, @owner)", connection))
                {
                    command.Parameters.AddWithValue("@name", dishName);
                    command.Parameters.AddWithValue("@image", selectedImagePath);
                    command.Parameters.AddWithValue("@owner", contributor.Id);
                    command.ExecuteNonQuery();
                }
            }

            txtMonAn.Clear();
            selectedImagePath = "";
            lblHinh.Text = "";
            LoadDishes();
            txtMonAn.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DishItem dish = lstDanhSach.SelectedItem as DishItem;
            if (dish == null)
            {
                MessageBox.Show("Vui lòng chọn món cần xóa trong danh sách!");
                return;
            }

            DialogResult answer = MessageBox.Show(
                "Xoá món \"" + dish.Name + "\"?", "Xác nhận", MessageBoxButtons.YesNo);
            if (answer != DialogResult.Yes)
            {
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("DELETE FROM MonAn WHERE IDMA = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", dish.Id);
                    command.ExecuteNonQuery();
                }
            }

            txtKetQuaHomNay.Clear();
            if (picMon.Image != null)
            {
                picMon.Image.Dispose();
                picMon.Image = null;
            }
            LoadDishes();
        }

        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            string fullName = txtTenNguoi.Text.Trim();
            if (fullName.Length == 0)
            {
                MessageBox.Show("Họ và tên không được để trống.");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(
                    "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@name, @role)", connection))
                {
                    command.Parameters.AddWithValue("@name", fullName);
                    command.Parameters.AddWithValue("@role", cboQuyen.SelectedItem.ToString());
                    command.ExecuteNonQuery();
                }
            }

            txtTenNguoi.Clear();
            LoadContributors();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private class ContributorItem
        {
            public long Id { get; private set; }
            public string FullName { get; private set; }

            public ContributorItem(long id, string fullName)
            {
                Id = id;
                FullName = fullName;
            }

            public override string ToString()
            {
                return FullName;
            }
        }

        private class DishItem
        {
            public long Id { get; set; }
            public string Name { get; set; } = "";
            public string ImagePath { get; set; } = "";
            public string Owner { get; set; } = "";

            public override string ToString()
            {
                return Name + " - " + Owner;
            }
        }
    }
}