using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.Drawing.Imaging;
namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                var img = new Bitmap(openFileDialog1.FileName);
                using (var ocr = new TesseractEngine(@"C:\Users\GMC\Desktop\tesseract-ocr-3.02.eng\tesseract-ocr\tessdata", "eng", EngineMode.TesseractAndCube))
                {
                    var page = ocr.Process(img);
                    textBox1.Text = page.GetText();
                }
            }
        }
    }
}
