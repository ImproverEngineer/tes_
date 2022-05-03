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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Directory.GetCurrentDirectory() + @"\ImageViewText";
            if (openFileDialog.ShowDialog() == DialogResult.OK){
                
                picture.Image = Image.FromFile(openFileDialog.FileName);
            }
            FileName = openFileDialog.FileName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            picture.Image = null;
            FileName = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           DBase.DBase dBase = new DBase.DBase();
            foreach (var text in dBase.readDB())
            {              
                showText.Text +=  text + Environment.NewLine;
            }
        }
    }
}
