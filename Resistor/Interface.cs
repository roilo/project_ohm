using System;
using System.Windows.Forms;

namespace Resistor
{
    public partial class Interface : Form
    {
        int bands; // number of available bands

        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            // set to three band first and immediately calculate value
            bandDigit1.SelectedIndex = 0;
            bandDigit2.SelectedIndex = 0;
            bandMultiplier.SelectedIndex = 0;
            ThreeBands_Click(sender, e);
            CalculateButton_Click(sender, e);
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // expand help?
            MessageBox.Show("Select from the number of bands in the Bands tab.\n" +
                "Select the color of the resistor within the enabled text boxes.\n" +
                "Click Calculate button to find the resistance of the resistor " +
                "given the selected colors.\n" +
                "Note: The order of the bands within the resistor correspond " +
                "with the order of the textboxes.", "Help");
        }

        private void ThreeBands_Click(object sender, EventArgs e)
        {
            // disable textboxes
            // reset indices
            // set 3 bands available
            bandDigit3.Enabled = false;
            bandTolerance.Enabled = false;
            bandTempCo.Enabled = false;
            bandDigit3.SelectedIndex = -1;
            bandTolerance.SelectedIndex = -1;
            bandTempCo.SelectedIndex = -1;
            bands = 3;
        }

        private void FourBands_Click(object sender, EventArgs e)
        {
            // disable textboxes except tolerance
            // reset indices
            // set 4 bands available
            bandDigit3.Enabled = false;
            bandTolerance.Enabled = true;
            bandTempCo.Enabled = false;
            bandDigit3.SelectedIndex = -1;
            bandTolerance.SelectedIndex = 0;
            bandTempCo.SelectedIndex = -1;
            bands = 4;
        }

        private void FiveBands_Click(object sender, EventArgs e)
        {
            // enable textboxes except temp coefficient
            // reset indices
            // set 5 bands available
            bandDigit3.Enabled = true;
            bandTolerance.Enabled = true;
            bandTempCo.Enabled = false;
            bandDigit3.SelectedIndex = 0;
            bandTolerance.SelectedIndex = 0;
            bandTempCo.SelectedIndex = -1;
            bands = 5;
        }

        private void SixBands_Click(object sender, EventArgs e)
        {
            // enable all textboxes
            // reset indices
            // set 6 bands available
            bandDigit3.Enabled = true;
            bandTolerance.Enabled = true;
            bandTempCo.Enabled = true;
            bandDigit3.SelectedIndex = 0;
            bandTolerance.SelectedIndex = 0;
            bandTempCo.SelectedIndex = 0;
            bands = 6;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double result = 0; // resulting resistance

            // SelectedIndex returns -1, hence this is safe
            double b1 = Digit(bandDigit1);
            double b2 = Digit(bandDigit2);
            double b3 = Digit(bandDigit3);
            double bM = Multiplier(bandMultiplier);
            double bT = Tolerance(bandTolerance);
            double bTC = TemperatureCoefficient(bandTempCo);

            switch (bands)
            {
                // three band and four band are similar,
                // four band has tolerance while three band has none
                case 3:
                case 4:
                    result = (b1 + (b2 * 10)) * bM;
                    break;
                // five band and six band are also similar,
                // six band has temp coefficient while five band has tolerance only
                case 5:
                case 6:
                    result = (b1 + (b2 * 10) + (b3 * 100)) * bM;
                    break;
            }

            // display resistance
            resultResistance.Text = result.ToString() + " Ω";

            // do not display if its not available
            if (bT != -1)
            {
                resultTolerance.Text = "±" + (bT * 100).ToString() + "%";
            }
            if (bTC != -1)
            {
                resultTempCo.Text = bTC.ToString() + " ppm/K";
            }
        }

        private double Digit(ComboBox item)
        {
            switch (item.SelectedIndex)
            {
                case 0: return 0;
                case 1: return 1;
                case 2: return 2;
                case 3: return 3;
                case 4: return 4;
                case 5: return 5;
                case 6: return 6;
                case 7: return 7;
                case 8: return 8;
                case 9: return 9;
                default: return -1;
            }
        }

        private double Multiplier(ComboBox item)
        {
            switch (item.SelectedIndex)
            {
                case 0: return Math.Pow(10, 0);
                case 1: return Math.Pow(10, 1);
                case 2: return Math.Pow(10, 2);
                case 3: return Math.Pow(10, 3);
                case 4: return Math.Pow(10, 4);
                case 5: return Math.Pow(10, 5);
                case 6: return Math.Pow(10, 6);
                case 7: return Math.Pow(10, 7);
                case 8: return Math.Pow(10, 8);
                case 9: return Math.Pow(10, 9);
                case 10: return Math.Pow(10, -1);
                case 11: return Math.Pow(10, -2);
                default: return -1;
            }
        }

        private double Tolerance(ComboBox item)
        {
            switch (item.SelectedIndex)
            {
                case 0: return 0.01;
                case 1: return 0.02;
                case 2: return 0.03;
                case 3: return 0.04;
                case 4: return 0.005;
                case 5: return 0.0025;
                case 6: return 0.001;
                case 7: return 0.0005;
                case 8: return 0.05;
                case 9: return 0.1;
                default: return -1;
            }
        }

        private double TemperatureCoefficient(ComboBox item)
        {
            switch (item.SelectedIndex)
            {
                case 0: return 250;
                case 1: return 100;
                case 2: return 50;
                case 3: return 15;
                case 4: return 25;
                case 5: return 20;
                case 6: return 10;
                case 7: return 5;
                case 8: return 1;
                default: return -1;
            }
        }
    }
}
