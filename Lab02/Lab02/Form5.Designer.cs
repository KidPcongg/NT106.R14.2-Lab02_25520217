using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtHoTen = new TextBox();
            label1 = new Label();
            cboPhim = new ComboBox();
            cboPhong = new ComboBox();
            clbGhe = new CheckedListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rtbKetQua = new RichTextBox();
            btnMua = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTenPhim = new TextBox();
            txtGia = new TextBox();
            txtPhongChieu = new TextBox();
            btnThemPhim = new Button();
            btnDocFile = new Button();
            btnGhiFile = new Button();
            btnXuat = new Button();
            progressBar = new ProgressBar();
            lblTrangThai = new Label();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(162, 84);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 27);
            txtHoTen.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 87);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ và Tên";
            // 
            // cboPhim
            // 
            cboPhim.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhim.FormattingEnabled = true;
            cboPhim.Location = new Point(162, 137);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(151, 28);
            cboPhim.TabIndex = 2;
            // 
            // cboPhong
            // 
            cboPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPhong.FormattingEnabled = true;
            cboPhong.Location = new Point(162, 198);
            cboPhong.Name = "cboPhong";
            cboPhong.Size = new Size(151, 28);
            cboPhong.TabIndex = 3;
            // 
            // clbGhe
            // 
            clbGhe.FormattingEnabled = true;
            clbGhe.Items.AddRange(new object[] { "A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5", "C1", "C2", "C3", "C4", "C5", "D1", "D2", "D3", "D4", "D5", "E1", "E2", "E3", "E4", "E5" });
            clbGhe.Location = new Point(344, 51);
            clbGhe.Name = "clbGhe";
            clbGhe.Size = new Size(72, 268);
            clbGhe.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 140);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 5;
            label2.Text = "Chọn phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 201);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 6;
            label3.Text = "Chọn Phòng";
            // 
            // label4
            // 
            label4.Location = new Point(344, 28);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 7;
            label4.Text = "Chọn ghế";
            // 
            // rtbKetQua
            // 
            rtbKetQua.Location = new Point(449, 51);
            rtbKetQua.Name = "rtbKetQua";
            rtbKetQua.ReadOnly = true;
            rtbKetQua.Size = new Size(297, 276);
            rtbKetQua.TabIndex = 8;
            rtbKetQua.Text = "";
            // 
            // btnMua
            // 
            btnMua.Location = new Point(162, 257);
            btnMua.Name = "btnMua";
            btnMua.Size = new Size(94, 29);
            btnMua.TabIndex = 9;
            btnMua.Text = "Mua vé";
            btnMua.UseVisualStyleBackColor = true;
            btnMua.Click += btnMua_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(449, 28);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 10;
            label5.Text = "Thông tin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 365);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 11;
            label6.Text = "Tên phim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 405);
            label7.Name = "label7";
            label7.Size = new Size(93, 20);
            label7.TabIndex = 12;
            label7.Text = "Giá vé chuẩn";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 445);
            label8.Name = "label8";
            label8.Size = new Size(90, 20);
            label8.TabIndex = 13;
            label8.Text = "Phòng chiếu";
            // 
            // txtTenPhim
            // 
            txtTenPhim.Location = new Point(130, 362);
            txtTenPhim.Name = "txtTenPhim";
            txtTenPhim.Size = new Size(190, 27);
            txtTenPhim.TabIndex = 14;
            // 
            // txtGia
            // 
            txtGia.Location = new Point(130, 402);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(190, 27);
            txtGia.TabIndex = 15;
            // 
            // txtPhongChieu
            // 
            txtPhongChieu.Location = new Point(130, 442);
            txtPhongChieu.Name = "txtPhongChieu";
            txtPhongChieu.Size = new Size(190, 27);
            txtPhongChieu.TabIndex = 16;
            // 
            // btnThemPhim
            // 
            btnThemPhim.Location = new Point(344, 360);
            btnThemPhim.Name = "btnThemPhim";
            btnThemPhim.Size = new Size(130, 30);
            btnThemPhim.TabIndex = 17;
            btnThemPhim.Text = "Thêm phim";
            btnThemPhim.UseVisualStyleBackColor = true;
            // 
            // btnDocFile
            // 
            btnDocFile.Location = new Point(344, 400);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(130, 30);
            btnDocFile.TabIndex = 18;
            btnDocFile.Text = "Đọc input5.txt";
            btnDocFile.UseVisualStyleBackColor = true;
            // 
            // btnGhiFile
            // 
            btnGhiFile.Location = new Point(344, 440);
            btnGhiFile.Name = "btnGhiFile";
            btnGhiFile.Size = new Size(130, 30);
            btnGhiFile.TabIndex = 19;
            btnGhiFile.Text = "Ghi output5.txt";
            btnGhiFile.UseVisualStyleBackColor = true;
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(500, 360);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(246, 30);
            btnXuat.TabIndex = 20;
            btnXuat.Text = "Xuất thống kê ";
            btnXuat.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(500, 405);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(246, 23);
            progressBar.TabIndex = 21;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(500, 445);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(0, 20);
            lblTrangThai.TabIndex = 22;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(lblTrangThai);
            Controls.Add(progressBar);
            Controls.Add(btnXuat);
            Controls.Add(btnGhiFile);
            Controls.Add(btnDocFile);
            Controls.Add(btnThemPhim);
            Controls.Add(txtPhongChieu);
            Controls.Add(txtGia);
            Controls.Add(txtTenPhim);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnMua);
            Controls.Add(rtbKetQua);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(clbGhe);
            Controls.Add(cboPhong);
            Controls.Add(cboPhim);
            Controls.Add(label1);
            Controls.Add(txtHoTen);
            Name = "Form5";
            Text = "Bài 5 - Quản lý phòng vé";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private Label label1;
        private ComboBox cboPhim;
        private ComboBox cboPhong;
        private CheckedListBox clbGhe;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox rtbKetQua;
        private Button btnMua;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtTenPhim;
        private TextBox txtGia;
        private TextBox txtPhongChieu;
        private Button btnThemPhim;
        private Button btnDocFile;
        private Button btnGhiFile;
        private Button btnXuat;
        private ProgressBar progressBar;
        private Label lblTrangThai;
    }
}