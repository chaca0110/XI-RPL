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

namespace AdminForm
{
    public partial class CustomerMainForm : Form
    {
        public CustomerMainForm()
        {
            InitializeComponent();
            LoadImages();
        }

        private void LoadImages()
        {
            string assetDir = Path.Combine(Application.StartupPath, "Assets");
            
            try 
            {
                picLogo.Image = Image.FromFile(Path.Combine(assetDir, "logoAPK.png"));
                picTicket.Image = Image.FromFile(Path.Combine(assetDir, "tiketAPK.png"));
                picLogout.Image = Image.FromFile(Path.Combine(assetDir, "outAPK.png"));
                picDepart.Image = Image.FromFile(Path.Combine(assetDir, "pswtAPK.png"));
                picDest.Image = Image.FromFile(Path.Combine(assetDir, "pswt2APK.png"));
                picDate.Image = Image.FromFile(Path.Combine(assetDir, "tglAPK.png"));
                picPassenger.Image = Image.FromFile(Path.Combine(assetDir, "orgAPK.png"));
                picMountain.Image = Image.FromFile(Path.Combine(assetDir, "iconGUNUNG.png"));

                PictureBox[] pics = { picLogo, picTicket, picLogout, picDepart, picDest, picDate, picPassenger, picMountain };
                foreach (var pic in pics)
                {
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.BorderStyle = BorderStyle.None;
                    pic.BackColor = Color.Transparent;
                }
            } 
            catch { } // Ignore if not found
        }
    }
}
