namespace TinyPngStockHelper
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
            this.filesRTB = new System.Windows.Forms.RichTextBox();
            this.outputFolderBrowseBtn = new System.Windows.Forms.Button();
            this.folderPathTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tinyPngCB = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.apiKeyTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pythonPathTB = new System.Windows.Forms.TextBox();
            this.pythonPathDialog = new System.Windows.Forms.OpenFileDialog();
            this.outputFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.filesConterLabel = new System.Windows.Forms.Label();
            this.tinyPngCB.SuspendLayout();
            this.SuspendLayout();
            // 
            // filesRTB
            // 
            this.filesRTB.AllowDrop = true;
            this.filesRTB.EnableAutoDragDrop = true;
            this.filesRTB.Font = new System.Drawing.Font("Consolas", 10F);
            this.filesRTB.Location = new System.Drawing.Point(15, 91);
            this.filesRTB.Name = "filesRTB";
            this.filesRTB.Size = new System.Drawing.Size(852, 273);
            this.filesRTB.TabIndex = 2;
            this.filesRTB.Text = "";
            // 
            // outputFolderBrowseBtn
            // 
            this.outputFolderBrowseBtn.Location = new System.Drawing.Point(783, 22);
            this.outputFolderBrowseBtn.Name = "outputFolderBrowseBtn";
            this.outputFolderBrowseBtn.Size = new System.Drawing.Size(81, 24);
            this.outputFolderBrowseBtn.TabIndex = 21;
            this.outputFolderBrowseBtn.Text = "Browse...";
            this.outputFolderBrowseBtn.UseVisualStyleBackColor = true;
            this.outputFolderBrowseBtn.Click += new System.EventHandler(this.outputFolderBrowseBtn_Click);
            // 
            // folderPathTB
            // 
            this.folderPathTB.AllowDrop = true;
            this.folderPathTB.Location = new System.Drawing.Point(54, 24);
            this.folderPathTB.Name = "folderPathTB";
            this.folderPathTB.Size = new System.Drawing.Size(723, 20);
            this.folderPathTB.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Folder";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(425, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "show files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(425, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 22;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tinyPngCB
            // 
            this.tinyPngCB.Controls.Add(this.button3);
            this.tinyPngCB.Controls.Add(this.label3);
            this.tinyPngCB.Controls.Add(this.apiKeyTB);
            this.tinyPngCB.Controls.Add(this.label4);
            this.tinyPngCB.Controls.Add(this.pythonPathTB);
            this.tinyPngCB.Location = new System.Drawing.Point(170, 370);
            this.tinyPngCB.Name = "tinyPngCB";
            this.tinyPngCB.Size = new System.Drawing.Size(560, 100);
            this.tinyPngCB.TabIndex = 23;
            this.tinyPngCB.TabStop = false;
            this.tinyPngCB.Text = "Pic Compressor";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(466, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Browse...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "API Key";
            // 
            // apiKeyTB
            // 
            this.apiKeyTB.AllowDrop = true;
            this.apiKeyTB.Location = new System.Drawing.Point(123, 63);
            this.apiKeyTB.Name = "apiKeyTB";
            this.apiKeyTB.Size = new System.Drawing.Size(337, 20);
            this.apiKeyTB.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Python Path";
            // 
            // pythonPathTB
            // 
            this.pythonPathTB.AllowDrop = true;
            this.pythonPathTB.Location = new System.Drawing.Point(123, 26);
            this.pythonPathTB.Name = "pythonPathTB";
            this.pythonPathTB.Size = new System.Drawing.Size(337, 20);
            this.pythonPathTB.TabIndex = 20;
            // 
            // pythonPathDialog
            // 
            this.pythonPathDialog.FileName = "pythonPathDialog";
            this.pythonPathDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.pythonPathDialog_FileOk);
            // 
            // filesConterLabel
            // 
            this.filesConterLabel.AutoSize = true;
            this.filesConterLabel.ForeColor = System.Drawing.Color.Gray;
            this.filesConterLabel.Location = new System.Drawing.Point(780, 370);
            this.filesConterLabel.Name = "filesConterLabel";
            this.filesConterLabel.Size = new System.Drawing.Size(0, 13);
            this.filesConterLabel.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 527);
            this.Controls.Add(this.filesConterLabel);
            this.Controls.Add(this.tinyPngCB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.outputFolderBrowseBtn);
            this.Controls.Add(this.folderPathTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filesRTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tinyPngCB.ResumeLayout(false);
            this.tinyPngCB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox filesRTB;
        private System.Windows.Forms.Button outputFolderBrowseBtn;
        private System.Windows.Forms.TextBox folderPathTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox tinyPngCB;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox apiKeyTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pythonPathTB;
        private System.Windows.Forms.OpenFileDialog pythonPathDialog;
        private System.Windows.Forms.FolderBrowserDialog outputFolderDialog;
        private System.Windows.Forms.Label filesConterLabel;
    }
}

