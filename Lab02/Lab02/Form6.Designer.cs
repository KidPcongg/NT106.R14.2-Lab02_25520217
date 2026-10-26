using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Lab02
{
    partial class Form6
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
            lstDanhSach = new ListBox();
            btnThem = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            txtMonAn = new TextBox();
            label1 = new Label();
            txtTimRandom = new Button();
            txtKetQuaHomNay = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            picMon = new PictureBox();
            btnChonHinh = new Button();
            lblHinh = new Label();
            cboNguoi = new ComboBox();
            txtTenNguoi = new TextBox();
            cboQuyen = new ComboBox();
            btnThemNguoi = new Button();
            ((System.ComponentModel.ISupportInitialize)picMon).BeginInit();
            SuspendLayout();
            // 
            // picMon
            // 
            picMon.BorderStyle = BorderStyle.FixedSingle;
            picMon.Location = new Point(30, 30);
            picMon.Name = "picMon";
            picMon.Size = new Size(150, 150);
            picMon.SizeMode = PictureBoxSizeMode.Zoom;
            picMon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 34);
            label1.Name = "label1";
            label1.Text = "Nhập món ăn";
            // 
            // txtMonAn
            // 
            txtMonAn.Location = new Point(312, 30);
            txtMonAn.Name = "txtMonAn";
            txtMonAn.Size = new Size(160, 27);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 78);
            label3.Name = "label3";
            label3.Text = "Hình ảnh";
            // 
            // btnChonHinh
            // 
            btnChonHinh.Location = new Point(312, 72);
            btnChonHinh.Name = "btnChonHinh";
            btnChonHinh.Size = new Size(110, 30);
            btnChonHinh.Text = "Chọn hình...";
            btnChonHinh.UseVisualStyleBackColor = true;
            // 
            // lblHinh
            // 
            lblHinh.AutoSize = true;
            lblHinh.Location = new Point(312, 108);
            lblHinh.Name = "lblHinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 143);
            label4.Name = "label4";
            label4.Text = "Người góp";
            // 
            // cboNguoi
            // 
            cboNguoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNguoi.Location = new Point(312, 140);
            cboNguoi.Name = "cboNguoi";
            cboNguoi.Size = new Size(160, 28);
            // 
            // btnThem
            // 
            btnThem.Location = new Point(312, 190);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(500, 31);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(280, 224);
            // 
            // txtTimRandom
            // 
            txtTimRandom.Location = new Point(226, 277);
            txtTimRandom.Name = "txtTimRandom";
            txtTimRandom.Size = new Size(94, 29);
            txtTimRandom.Text = "Tìm món ăn";
            txtTimRandom.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(369, 277);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.Text = "Xoá";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(502, 277);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 331);
            label2.Name = "label2";
            label2.Text = "Món ăn hôm nay là:";
            // 
            // txtKetQuaHomNay
            // 
            txtKetQuaHomNay.Location = new Point(270, 354);
            txtKetQuaHomNay.Name = "txtKetQuaHomNay";
            txtKetQuaHomNay.ReadOnly = true;
            txtKetQuaHomNay.Size = new Size(285, 27);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 435);
            label5.Name = "label5";
            label5.Text = "Họ và tên";
            // 
            // txtTenNguoi
            // 
            txtTenNguoi.Location = new Point(120, 432);
            txtTenNguoi.Name = "txtTenNguoi";
            txtTenNguoi.Size = new Size(180, 27);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(330, 435);
            label6.Name = "label6";
            label6.Text = "Quyền hạn";
            // 
            // cboQuyen
            // 
            cboQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboQuyen.Items.AddRange(new object[] { "User", "Admin" });
            cboQuyen.Location = new Point(430, 432);
            cboQuyen.Name = "cboQuyen";
            cboQuyen.Size = new Size(110, 28);
            // 
            // btnThemNguoi
            // 
            btnThemNguoi.Location = new Point(570, 431);
            btnThemNguoi.Name = "btnThemNguoi";
            btnThemNguoi.Size = new Size(130, 30);
            btnThemNguoi.Text = "Thêm người";
            btnThemNguoi.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(btnThemNguoi);
            Controls.Add(cboQuyen);
            Controls.Add(label6);
            Controls.Add(txtTenNguoi);
            Controls.Add(label5);
            Controls.Add(txtKetQuaHomNay);
            Controls.Add(label2);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(txtTimRandom);
            Controls.Add(lstDanhSach);
            Controls.Add(btnThem);
            Controls.Add(cboNguoi);
            Controls.Add(label4);
            Controls.Add(lblHinh);
            Controls.Add(btnChonHinh);
            Controls.Add(label3);
            Controls.Add(txtMonAn);
            Controls.Add(label1);
            Controls.Add(picMon);
            Name = "Form6";
            Text = "Bài 6 - Hôm nay ăn gì?";
            ((System.ComponentModel.ISupportInitialize)picMon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstDanhSach;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private TextBox txtMonAn;
        private Label label1;
        private Button txtTimRandom;
        private TextBox txtKetQuaHomNay;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox picMon;
        private Button btnChonHinh;
        private Label lblHinh;
        private ComboBox cboNguoi;
        private TextBox txtTenNguoi;
        private ComboBox cboQuyen;
        private Button btnThemNguoi;
    }
}