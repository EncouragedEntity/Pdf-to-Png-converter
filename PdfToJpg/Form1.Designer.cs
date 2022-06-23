namespace PdfToJpg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonInputFolderSelect = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOutputFolderSelect = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input PDF file:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(284, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Folder not selected!";
            // 
            // buttonInputFolderSelect
            // 
            this.buttonInputFolderSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInputFolderSelect.BackgroundImage")));
            this.buttonInputFolderSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInputFolderSelect.Location = new System.Drawing.Point(302, 44);
            this.buttonInputFolderSelect.Name = "buttonInputFolderSelect";
            this.buttonInputFolderSelect.Size = new System.Drawing.Size(55, 50);
            this.buttonInputFolderSelect.TabIndex = 2;
            this.buttonInputFolderSelect.UseVisualStyleBackColor = true;
            this.buttonInputFolderSelect.Click += new System.EventHandler(this.buttonInputFolderSelect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output JPG/PNG folder:";
            // 
            // buttonOutputFolderSelect
            // 
            this.buttonOutputFolderSelect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonOutputFolderSelect.BackgroundImage")));
            this.buttonOutputFolderSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonOutputFolderSelect.Location = new System.Drawing.Point(302, 143);
            this.buttonOutputFolderSelect.Name = "buttonOutputFolderSelect";
            this.buttonOutputFolderSelect.Size = new System.Drawing.Size(55, 50);
            this.buttonOutputFolderSelect.TabIndex = 5;
            this.buttonOutputFolderSelect.UseVisualStyleBackColor = true;
            this.buttonOutputFolderSelect.Click += new System.EventHandler(this.buttonOutputFolderSelect_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 155);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(284, 27);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Folder not selected!";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonConvert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonConvert.Location = new System.Drawing.Point(0, 254);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(367, 36);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(19, 204);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(94, 29);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 290);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.buttonOutputFolderSelect);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonInputFolderSelect);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pdf to Jpg convertor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Button buttonInputFolderSelect;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label2;
        private Button buttonOutputFolderSelect;
        private TextBox textBox2;
        private FolderBrowserDialog folderBrowserDialog2;
        private Button buttonConvert;
        private Button buttonClear;
        private OpenFileDialog openFileDialog1;
    }
}