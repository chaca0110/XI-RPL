using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AdminForm
{
    public partial class ListPenerbanganForm : Form
    {
        public ListPenerbanganForm()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            string assetDir = Path.Combine(Application.StartupPath, "Assets");
            try 
            {
                picBack.Image = Image.FromFile(Path.Combine(assetDir, "iconAPK.png"));
                
                picBack.SizeMode = PictureBoxSizeMode.Zoom;
                picBack.BorderStyle = BorderStyle.None;
                picBack.BackColor = Color.Transparent;
            } 
            catch { }
        }
    }
}
