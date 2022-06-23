using Patagames.Pdf.Enums;
using Patagames.Pdf.Net;
using Patagames.Pdf.Net.Exceptions;
using System.Drawing.Imaging;
namespace PdfToJpg
{
    public partial class Form1 : Form
    {
        List<string> _fileFullNames;
        List<string?> _fileNames;
        string inputFolder;
        string outputFolder;
        
        string? notSelected;

        public Form1()
        {
            InitializeComponent();
            _fileFullNames = new List<string>();
            _fileNames = new List<string>();
            inputFolder = string.Empty;
            outputFolder = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notSelected = textBox1.Text;
            MessageBox.Show("Make sure, that your output folder if empty!","Attention!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void buttonInputFolderSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog1.SelectedPath != String.Empty)
                {
                    inputFolder = folderBrowserDialog1.SelectedPath;
                    textBox1.Text = inputFolder;
                }
            }
        }

        private void buttonOutputFolderSelect_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                if (folderBrowserDialog2.SelectedPath != String.Empty)
                {
                    outputFolder = folderBrowserDialog2.SelectedPath;
                    textBox2.Text = outputFolder;
                }
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text == notSelected || textBox2.Text==notSelected && inputFolder==String.Empty || outputFolder == String.Empty)
            {
                MessageBox.Show("Folders are not selected. Try again!","Folder not selected!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                _fileNames = Directory.GetFiles(inputFolder, "*.pdf").Select(Path.GetFileName).ToList();

                _fileFullNames = Directory.GetFiles(inputFolder, "*.pdf").ToList();

                int number = 1;
                foreach (string file in _fileFullNames)
                {
                    string documentOutputFolder = string.Empty;
                    Directory.CreateDirectory(outputFolder + @"\" + _fileNames[number - 1]);
                    documentOutputFolder = outputFolder + @"\" + _fileNames[number - 1];
                    try
                    {
                        using (var document = PdfDocument.Load(file))
                        {
                            foreach (var documentPage in document.Pages)
                            {
                                int width = (int)(documentPage.Width / 72.0 * 96);
                                int height = (int)(documentPage.Height / 72.0 * 96);
                                using (var bitmap = new PdfBitmap(width, height, true))
                                {
                                    bitmap.FillRect(0, 0, width, height, Patagames.Pdf.FS_COLOR.White);
                                    documentPage.Render(bitmap, 0, 0, width, height, PageRotate.Normal, RenderFlags.FPDF_LCD_TEXT);
                                    bitmap.Image.Save(documentOutputFolder + @"\" + (documentPage.PageIndex + 1).ToString() + ".png", ImageFormat.Png);
                                }
                            }
                        }
                    }
                    catch (NoLicenseException)
                    {
                        #region Error Message Box 
                        MessageBox.Show("The documents which size is smaller than 1024 Kb, or greater than 10 Mb can be loaded without any restrictions. For other documents the allowed ranges is 1.5 - 2 Mb; 2.5 - 3 Mb; 3.5 - 4 Mb and so on.","File size error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        continue;
                        #endregion
                    }
                    number++;
                }
                _fileFullNames.Clear();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = notSelected;
            textBox2.Text = notSelected;
            inputFolder = String.Empty;
            outputFolder = String.Empty;
        }
    }
}