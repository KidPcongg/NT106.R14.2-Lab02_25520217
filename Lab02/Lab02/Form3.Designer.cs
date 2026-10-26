namespace Lab02
{
    partial class Form3
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
            label1 = new Label();
            btnCal = new Button();
            label2 = new Label();
            rtbOutput = new RichTextBox();
            rtbInput = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "input.txt";
            label1.Click += label1_Click;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(346, 147);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(97, 85);
            btnCal.TabIndex = 1;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 9);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "output.txt";
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(493, 32);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.ReadOnly = true;
            rtbOutput.Size = new Size(295, 389);
            rtbOutput.TabIndex = 5;
            rtbOutput.Text = "";
            // 
            // rtbInput
            // 
            rtbInput.Location = new Point(12, 47);
            rtbInput.Name = "rtbInput";
            rtbInput.ReadOnly = true;
            rtbInput.Size = new Size(297, 374);
            rtbInput.TabIndex = 6;
            rtbInput.Text = "";
            rtbInput.TextChanged += rtbInput_TextChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbInput);
            Controls.Add(rtbOutput);
            Controls.Add(label2);
            Controls.Add(btnCal);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCal;
        private Label label2;
        private RichTextBox rtbOutput;
        private RichTextBox rtbInput;
    }
}