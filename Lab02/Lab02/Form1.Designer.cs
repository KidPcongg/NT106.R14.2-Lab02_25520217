namespace Lab02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRead = new Button();
            rtbContent = new RichTextBox();
            btnWrite = new Button();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.BackColor = SystemColors.ActiveCaption;
            btnRead.ForeColor = SystemColors.ActiveCaptionText;
            btnRead.Location = new Point(28, 34);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(94, 29);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = false;
            btnRead.Click += btnRead_Click;
            // 
            // rtbContent
            // 
            rtbContent.BackColor = SystemColors.GradientInactiveCaption;
            rtbContent.ForeColor = SystemColors.Desktop;
            rtbContent.Location = new Point(201, 21);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(545, 398);
            rtbContent.TabIndex = 1;
            rtbContent.Text = "";
            // 
            // btnWrite
            // 
            btnWrite.BackColor = SystemColors.ActiveCaption;
            btnWrite.Location = new Point(28, 103);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(94, 29);
            btnWrite.TabIndex = 2;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = false;
            btnWrite.Click += btnWrite_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWrite);
            Controls.Add(rtbContent);
            Controls.Add(btnRead);
            Name = "Form1";
            Opacity = 0.86D;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private RichTextBox rtbContent;
        private Button btnWrite;
    }
}
