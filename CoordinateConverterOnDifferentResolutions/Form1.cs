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
            numericUpDownCoordinate2_X.Value = numericUpDownCoordinate1_X.Value * numericUpDownResolution2_Width.Value / numericUpDownResolution1_Width.Value;
        }

        private void numericUpDownResolution1_Height_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCoordinate2_Y.Value = numericUpDownCoordinate1_Y.Value * numericUpDownResolution2_Height.Value / numericUpDownResolution1_Height.Value;
        }

        private void numericUpDownResolution2_Width_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCoordinate1_X.Value = numericUpDownCoordinate2_X.Value * numericUpDownResolution1_Width.Value / numericUpDownResolution2_Width.Value;
        }

        private void numericUpDownResolution2_Height_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownCoordinate1_Y.Value = numericUpDownCoordinate2_Y.Value * numericUpDownResolution1_Height.Value / numericUpDownResolution2_Height.Value;
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


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "1280*720":
                    {
                        numericUpDownResolution1_Width.Value = 1280;
                        numericUpDownResolution1_Height.Value = 720;
                    }
                    break;
                case "1366*768":
                    {
                        numericUpDownResolution1_Width.Value = 1366;
                        numericUpDownResolution1_Height.Value = 768;
                    }
                    break;
                case "1920*1080":
                    {
                        numericUpDownResolution1_Width.Value = 1920;
                        numericUpDownResolution1_Height.Value = 1080;
                    }
                    break;
                default:
                    break;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedItem.ToString())
            {
                case "1280*720":
                    {
                        numericUpDownResolution2_Width.Value = 1280;
                        numericUpDownResolution2_Height.Value = 720;
                    }
                    break;
                case "1366*768":
                    {
                        numericUpDownResolution2_Width.Value = 1366;
                        numericUpDownResolution2_Height.Value = 768;
                    }
                    break;
                case "1920*1080":
                    {
                        numericUpDownResolution2_Width.Value = 1920;
                        numericUpDownResolution2_Height.Value = 1080;
                    }
                    break;
                default:
                    break;
            }
        }

        private void button1Paste_Click(object sender, EventArgs e)
        {
            string[] resolutions = Clipboard.GetText().Split((char)Keys.Space);


            if (resolutions.Length == 2 && Int32.TryParse(resolutions[0], out int x) && Int32.TryParse(resolutions[1], out int y))
            {

                numericUpDownCoordinate1_X.Value = x;
                numericUpDownCoordinate1_Y.Value = y;
                Clipboard.SetText(x + " " + y);
            }
        }

        private void button2Paste_Click(object sender, EventArgs e)
        {
            string[] resolutions = Clipboard.GetText().Split((char)Keys.Space);


            if (resolutions.Length == 2 && Int32.TryParse(resolutions[0], out int x) && Int32.TryParse(resolutions[1], out int y))
            {

                numericUpDownCoordinate2_X.Value = x;
                numericUpDownCoordinate2_Y.Value = y;
            }
        }

        private void button1Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Convert.ToInt32(numericUpDownCoordinate1_X.Value) + " " + Convert.ToInt32(numericUpDownCoordinate1_Y.Value));
            Console.WriteLine(Clipboard.GetText());
        }

        private void button2Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Convert.ToInt32(numericUpDownCoordinate2_X.Value) + " " + Convert.ToInt32(numericUpDownCoordinate2_Y.Value));
            Console.WriteLine(Clipboard.GetText());
        }
    }
}
