namespace Lab02
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnWrite = new Button();
            txtName = new TextBox();
            txtId = new TextBox();
            txtCourse1 = new TextBox();
            txtPhone = new TextBox();
            txtCourse3 = new TextBox();
            txtCourse2 = new TextBox();
            btnAdd = new Button();
            rtbList = new RichTextBox();
            txtViewCourse3 = new TextBox();
            txtViewCourse2 = new TextBox();
            txtViewCourse1 = new TextBox();
            txtViewPhone = new TextBox();
            txtViewId = new TextBox();
            txtViewName = new TextBox();
            txtViewAverage = new TextBox();
            btnBack = new Button();
            btnNext = new Button();
            lblName = new Label();
            lblId = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            label13 = new Label();
            lblPage = new Label();
            SuspendLayout();
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(44, 7);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(180, 27);
            btnWrite.TabIndex = 0;
            btnWrite.Text = "Write to a File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click_1;
            // 
            // txtName
            // 
            txtName.Location = new Point(64, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.Location = new Point(64, 125);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 2;
            // 
            // txtCourse1
            // 
            txtCourse1.Location = new Point(64, 235);
            txtCourse1.Name = "txtCourse1";
            txtCourse1.Size = new Size(125, 27);
            txtCourse1.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(64, 179);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 3;
            // 
            // txtCourse3
            // 
            txtCourse3.Location = new Point(64, 346);
            txtCourse3.Name = "txtCourse3";
            txtCourse3.Size = new Size(125, 27);
            txtCourse3.TabIndex = 6;
            // 
            // txtCourse2
            // 
            txtCourse2.Location = new Point(64, 290);
            txtCourse2.Name = "txtCourse2";
            txtCourse2.Size = new Size(125, 27);
            txtCourse2.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(77, 395);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(99, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // rtbList
            // 
            rtbList.Location = new Point(269, 21);
            rtbList.Name = "rtbList";
            rtbList.ReadOnly = true;
            rtbList.Size = new Size(229, 397);
            rtbList.TabIndex = 8;
            rtbList.Text = "";
            // 
            // txtViewCourse3
            // 
            txtViewCourse3.Location = new Point(593, 289);
            txtViewCourse3.Name = "txtViewCourse3";
            txtViewCourse3.ReadOnly = true;
            txtViewCourse3.Size = new Size(125, 27);
            txtViewCourse3.TabIndex = 14;
            // 
            // txtViewCourse2
            // 
            txtViewCourse2.Location = new Point(593, 233);
            txtViewCourse2.Name = "txtViewCourse2";
            txtViewCourse2.ReadOnly = true;
            txtViewCourse2.Size = new Size(125, 27);
            txtViewCourse2.TabIndex = 13;
            // 
            // txtViewCourse1
            // 
            txtViewCourse1.Location = new Point(593, 178);
            txtViewCourse1.Name = "txtViewCourse1";
            txtViewCourse1.ReadOnly = true;
            txtViewCourse1.Size = new Size(125, 27);
            txtViewCourse1.TabIndex = 12;
            // 
            // txtViewPhone
            // 
            txtViewPhone.Location = new Point(593, 122);
            txtViewPhone.Name = "txtViewPhone";
            txtViewPhone.ReadOnly = true;
            txtViewPhone.Size = new Size(125, 27);
            txtViewPhone.TabIndex = 11;
            // 
            // txtViewId
            // 
            txtViewId.Location = new Point(593, 68);
            txtViewId.Name = "txtViewId";
            txtViewId.ReadOnly = true;
            txtViewId.Size = new Size(125, 27);
            txtViewId.TabIndex = 10;
            // 
            // txtViewName
            // 
            txtViewName.Location = new Point(593, 12);
            txtViewName.Name = "txtViewName";
            txtViewName.ReadOnly = true;
            txtViewName.Size = new Size(125, 27);
            txtViewName.TabIndex = 9;
            // 
            // txtViewAverage
            // 
            txtViewAverage.Location = new Point(593, 342);
            txtViewAverage.Name = "txtViewAverage";
            txtViewAverage.ReadOnly = true;
            txtViewAverage.Size = new Size(125, 27);
            txtViewAverage.TabIndex = 15;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(527, 395);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(739, 395);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 29);
            btnNext.TabIndex = 17;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click_1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(204, 75);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 18;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(214, 132);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 19;
            lblId.Text = "ID";
            lblId.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 186);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 20;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 346);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 23;
            label4.Text = "Course3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 297);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 22;
            label5.Text = "Course2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(201, 242);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 21;
            label6.Text = "Course1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(528, 285);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 29;
            label7.Text = "Course3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(524, 236);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 28;
            label8.Text = "Course2";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(524, 181);
            label9.Name = "label9";
            label9.Size = new Size(62, 20);
            label9.TabIndex = 27;
            label9.Text = "Course1";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(527, 125);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 26;
            label10.Text = "Phone";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(537, 71);
            label11.Name = "label11";
            label11.Size = new Size(24, 20);
            label11.TabIndex = 25;
            label11.Text = "ID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(527, 14);
            label12.Name = "label12";
            label12.Size = new Size(49, 20);
            label12.TabIndex = 24;
            label12.Text = "Name";
            // 
            // button1
            // 
            button1.Location = new Point(739, 169);
            button1.Name = "button1";
            button1.Size = new Size(168, 54);
            button1.TabIndex = 30;
            button1.Text = "Button to Read a file";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(518, 346);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 31;
            label13.Text = "Average";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Location = new Point(647, 399);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(58, 20);
            lblPage.TabIndex = 32;
            lblPage.Text = "label14";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 450);
            Controls.Add(lblPage);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(lblId);
            Controls.Add(lblName);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(txtViewAverage);
            Controls.Add(txtViewCourse3);
            Controls.Add(txtViewCourse2);
            Controls.Add(txtViewCourse1);
            Controls.Add(txtViewPhone);
            Controls.Add(txtViewId);
            Controls.Add(txtViewName);
            Controls.Add(rtbList);
            Controls.Add(btnAdd);
            Controls.Add(txtCourse3);
            Controls.Add(txtCourse2);
            Controls.Add(txtCourse1);
            Controls.Add(txtPhone);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Controls.Add(btnWrite);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWrite;
        private TextBox txtName;
        private TextBox txtId;
        private TextBox txtCourse1;
        private TextBox txtPhone;
        private TextBox txtCourse3;
        private TextBox txtCourse2;
        private Button btnAdd;
        private RichTextBox rtbList;
        private TextBox txtViewCourse3;
        private TextBox txtViewCourse2;
        private TextBox txtViewCourse1;
        private TextBox txtViewPhone;
        private TextBox txtViewId;
        private TextBox txtViewName;
        private TextBox txtViewAverage;
        private Button btnBack;
        private Button btnNext;
        private Label lblName;
        private Label lblId;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button1;
        private Label label13;
        private Label lblPage;
    }
}