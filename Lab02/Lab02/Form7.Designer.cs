namespace Lab02
{
    partial class Form7
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
            tvFolder = new TreeView();
            grpContent = new GroupBox();
            picContent = new PictureBox();
            rtbContent = new RichTextBox();
            grpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picContent).BeginInit();
            SuspendLayout();
            // 
            // tvFolder
            // 
            tvFolder.Location = new Point(10, 10);
            tvFolder.Name = "tvFolder";
            tvFolder.Size = new Size(320, 540);
            tvFolder.TabIndex = 0;
            // 
            // grpContent
            // 
            grpContent.Controls.Add(rtbContent);
            grpContent.Controls.Add(picContent);
            grpContent.Location = new Point(340, 5);
            grpContent.Name = "grpContent";
            grpContent.Size = new Size(590, 548);
            grpContent.TabIndex = 1;
            grpContent.TabStop = false;
            grpContent.Text = "File Content";
            // 
            // picContent
            // 
            picContent.Dock = DockStyle.Fill;
            picContent.Location = new Point(3, 23);
            picContent.Name = "picContent";
            picContent.Size = new Size(584, 522);
            picContent.SizeMode = PictureBoxSizeMode.Zoom;
            picContent.TabIndex = 0;
            picContent.TabStop = false;
            picContent.Visible = false;
            // 
            // rtbContent
            // 
            rtbContent.Dock = DockStyle.Fill;
            rtbContent.Location = new Point(3, 23);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(584, 522);
            rtbContent.TabIndex = 1;
            rtbContent.Text = "";

            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 592);
            Controls.Add(grpContent);
            Controls.Add(tvFolder);
            Name = "Form7";
            Text = "Form7";
            grpContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picContent).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvFolder;
        private GroupBox grpContent;
        private PictureBox picContent;
        private RichTextBox rtbContent;
    }
}