namespace Lab02
{
    partial class Form2
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
            btnRead = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtFileName = new TextBox();
            txtSize = new TextBox();
            txtUrl = new TextBox();
            txtLines = new TextBox();
            txtWords = new TextBox();
            txtChars = new TextBox();
            rtbContent = new RichTextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(43, 12);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(201, 36);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read from file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 85);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "File name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 123);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 2;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 164);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 3;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 205);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 4;
            label4.Text = "Line count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 248);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 5;
            label5.Text = "Word count";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 290);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 6;
            label6.Text = "Character count";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(168, 82);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(173, 27);
            txtFileName.TabIndex = 7;
            // 
            // txtSize
            // 
            txtSize.Location = new Point(168, 120);
            txtSize.Name = "txtSize";
            txtSize.Size = new Size(173, 27);
            txtSize.TabIndex = 8;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(168, 161);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(173, 27);
            txtUrl.TabIndex = 9;
            // 
            // txtLines
            // 
            txtLines.Location = new Point(168, 202);
            txtLines.Name = "txtLines";
            txtLines.Size = new Size(173, 27);
            txtLines.TabIndex = 10;
            // 
            // txtWords
            // 
            txtWords.Location = new Point(168, 245);
            txtWords.Name = "txtWords";
            txtWords.Size = new Size(173, 27);
            txtWords.TabIndex = 11;
            // 
            // txtChars
            // 
            txtChars.Location = new Point(168, 290);
            txtChars.Name = "txtChars";
            txtChars.Size = new Size(173, 27);
            txtChars.TabIndex = 12;
            // 
            // rtbContent
            // 
            rtbContent.Location = new Point(360, 12);
            rtbContent.Name = "rtbContent";
            rtbContent.Size = new Size(419, 426);
            rtbContent.TabIndex = 13;
            rtbContent.Text = "";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(114, 359);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(rtbContent);
            Controls.Add(txtChars);
            Controls.Add(txtWords);
            Controls.Add(txtLines);
            Controls.Add(txtUrl);
            Controls.Add(txtSize);
            Controls.Add(txtFileName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRead);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFileName;
        private TextBox txtSize;
        private TextBox txtUrl;
        private TextBox txtLines;
        private TextBox txtWords;
        private TextBox txtChars;
        private RichTextBox rtbContent;
        private Button btnExit;
    }
}