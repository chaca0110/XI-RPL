using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AdminForm
{
    public partial class DetailPenumpangForm : Form
    {
        public DetailPenumpangForm()
        {
            InitializeComponent();
            LoadPassengerCards();
            LoadImages();
        }

        private void LoadImages()
        {
            string assetDir = Path.Combine(Application.StartupPath, "Assets");
            try 
            {
                picBack.Image = Image.FromFile(Path.Combine(assetDir, "iconAPK.png"));
                picDate.Image = Image.FromFile(Path.Combine(assetDir, "tglAPK.png"));
                picTime.Image = Image.FromFile(Path.Combine(assetDir, "jamAPK.png"));
                picPass.Image = Image.FromFile(Path.Combine(assetDir, "orgAPK.png"));

                PictureBox[] pics = { picBack, picDate, picTime, picPass };
                foreach (var pic in pics)
                {
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.BorderStyle = BorderStyle.None;
                    pic.BackColor = Color.Transparent;
                }
            } 
            catch { }
        }

        private void LoadPassengerCards()
        {
            for (int i = 1; i <= 3; i++)
            {
                PassengerCard card = new PassengerCard();
                card.PassengerNumberText = "Penumpang #" + i;
                flowLayoutPanelPassengers.Controls.Add(card);
            }
        }
    }
}
