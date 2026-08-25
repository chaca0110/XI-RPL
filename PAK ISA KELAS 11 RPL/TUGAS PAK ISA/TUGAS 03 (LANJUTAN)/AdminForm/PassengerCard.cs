using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdminForm
{
    public partial class PassengerCard : UserControl
    {
        public PassengerCard()
        {
            InitializeComponent();
        }

        public string PassengerNumberText
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
    }
}
