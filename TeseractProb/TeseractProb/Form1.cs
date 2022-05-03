using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tesseract;
namespace TeseractProb
{
    public partial class TsForm : Form
    {
        private string FileName =""; 
        public TsForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Добавить картинку на форму.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddImage_Click(object sender, EventArgs e)
        {
            cleareImage();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + @"\ImageViewText";
            if (openFileDialog.ShowDialog() == DialogResult.OK){
                //работа tesseract
                showText.Text = teseractRead(openFileDialog.FileName);
                picture.Image = Image.FromFile(openFileDialog.FileName);
            }
            FileName = openFileDialog.FileName;
        }
        
        /// <summary>
        /// читаем из файла
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        private string teseractRead(string fileName) 
        {
            var img = new Bitmap(FileName);
            var ocr = new TesseractEngine("./dataset", "rus", EngineMode.LstmOnly);
            var page = ocr.Process(img);
            return page.GetText();            
        }


        private void cleareImage() 
        {
            picture.Image = null;
            FileName = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cleareImage();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           DBase.DBase dBase = new DBase.DBase();
            foreach (var text in dBase.readDB())
            {              
                showText.Text +=  text + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
