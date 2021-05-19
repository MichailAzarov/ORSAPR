using System;
using System.Windows.Forms;
using Flange;
using FlangeNew;

namespace FlangeUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр конектора
        /// </summary>
        private KompasConnector _kompasConnector;

        public MainForm(KompasConnector kompasConnector)
        {
            _kompasConnector = kompasConnector;
            InitializeComponent();
        }

        private void BuildModelButton_Click(object sender, EventArgs e)
        {
            _kompasConnector.Start();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            FlangeExternalDiameterTextBox.Text = "";
            FlangeCenterDistanceTextBox.Text = "";
            FlangeInnerDiameterTextBox.Text = "";
            FlangeLengthTextBox.Text = "";
            HoleDiameterTextBox.Text = "";
            HoleNumberTextBox.Text = "";
        }
    }
}
