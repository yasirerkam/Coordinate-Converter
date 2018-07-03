using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoordinateConverterOnDifferentResolutions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }


        private void numericUpDownCoordinate1_X_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCoordinate2_X.Value = numericUpDownCoordinate1_X.Value * numericUpDownResolution2_Width.Value / numericUpDownResolution1_Width.Value;
        }

        private void numericUpDownCoordinate1_Y_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCoordinate2_Y.Value = numericUpDownCoordinate1_Y.Value * numericUpDownResolution2_Height.Value / numericUpDownResolution1_Height.Value;
        }

        private void numericUpDownCoordinate2_X_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCoordinate1_X.Value = numericUpDownCoordinate2_X.Value * numericUpDownResolution1_Width.Value / numericUpDownResolution2_Width.Value;
        }

        private void numericUpDownCoordinate2_Y_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCoordinate1_Y.Value = numericUpDownCoordinate2_Y.Value * numericUpDownResolution1_Height.Value / numericUpDownResolution2_Height.Value;
        }
    }
}
