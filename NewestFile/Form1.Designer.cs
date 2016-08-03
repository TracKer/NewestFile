namespace NewestFile
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textNewestFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textNewestFileDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textOldestFileDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textOldestFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLastFile = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalProcessed = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textNewestFileDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textNewestFileName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Newest file";
            // 
            // textNewestFileName
            // 
            this.textNewestFileName.Location = new System.Drawing.Point(45, 19);
            this.textNewestFileName.Name = "textNewestFileName";
            this.textNewestFileName.ReadOnly = true;
            this.textNewestFileName.Size = new System.Drawing.Size(332, 20);
            this.textNewestFileName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File:";
            // 
            // textNewestFileDate
            // 
            this.textNewestFileDate.Location = new System.Drawing.Point(45, 45);
            this.textNewestFileDate.Name = "textNewestFileDate";
            this.textNewestFileDate.ReadOnly = true;
            this.textNewestFileDate.Size = new System.Drawing.Size(332, 20);
            this.textNewestFileDate.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textOldestFileDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textOldestFileName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 76);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oldest file";
            // 
            // textOldestFileDate
            // 
            this.textOldestFileDate.Location = new System.Drawing.Point(45, 45);
            this.textOldestFileDate.Name = "textOldestFileDate";
            this.textOldestFileDate.ReadOnly = true;
            this.textOldestFileDate.Size = new System.Drawing.Size(332, 20);
            this.textOldestFileDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date:";
            // 
            // textOldestFileName
            // 
            this.textOldestFileName.Location = new System.Drawing.Point(45, 19);
            this.textOldestFileName.Name = "textOldestFileName";
            this.textOldestFileName.ReadOnly = true;
            this.textOldestFileName.Size = new System.Drawing.Size(332, 20);
            this.textOldestFileName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "File:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelTotalProcessed);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.labelLastFile);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(383, 62);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Last processed:";
            // 
            // labelLastFile
            // 
            this.labelLastFile.AutoSize = true;
            this.labelLastFile.Location = new System.Drawing.Point(94, 16);
            this.labelLastFile.Name = "labelLastFile";
            this.labelLastFile.Size = new System.Drawing.Size(31, 13);
            this.labelLastFile.TabIndex = 1;
            this.labelLastFile.Text = "        ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total processed:";
            // 
            // labelTotalProcessed
            // 
            this.labelTotalProcessed.AutoSize = true;
            this.labelTotalProcessed.Location = new System.Drawing.Point(98, 39);
            this.labelTotalProcessed.Name = "labelTotalProcessed";
            this.labelTotalProcessed.Size = new System.Drawing.Size(13, 13);
            this.labelTotalProcessed.TabIndex = 3;
            this.labelTotalProcessed.Text = "0";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 247);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NewestFile";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textNewestFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNewestFileDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textOldestFileDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textOldestFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelTotalProcessed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelLastFile;
        private System.Windows.Forms.Label label5;
    }
}

