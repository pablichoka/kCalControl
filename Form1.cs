using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kCalControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double kcalFinal;
        Double kcalMB;
        Double exerCoef;
        Double protPercentage;
        Double carbsPercentage;
        Double fatsPercentage;
        Boolean check;

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    exerCoef = 1.2;
                    break;
                case 1:
                    exerCoef = 1.26;
                    break;
                case 2:
                    exerCoef = 1.32;
                    break;
                case 3:
                    exerCoef = 1.37;
                    break;
                case 4:
                    exerCoef = 1.46;
                    break;
                case 5:
                    exerCoef = 1.55;
                    break;
                case 6:
                    exerCoef = 1.72;
                    break;
                case 7:
                    exerCoef = 1.75;
                    break;
                default:
                    exerCoef = 0;
                    break;
            }

            if (radioButton1.Checked)
            {
                try
                {
                    kcalMB = (66 + (13.7 * Convert.ToDouble(textBox3.Text))) + ((5 * Convert.ToDouble(textBox2.Text))
                    - (6.8 * Convert.ToDouble(textBox1.Text)));
                    if (checkBox1.Checked)
                    {
                        kcalFinal = kcalMB * 1.9;
                    }
                    else
                    {
                        kcalFinal = kcalMB * exerCoef;
                    }
                    label9.Text = Math.Round(kcalFinal, 2, MidpointRounding.ToEven).ToString() + " kCal";
                    label8.Show();
                    check = true;
                }
                catch
                {
                    MessageBox.Show("Debes rellenar toda la información.", "Información incompleta.", MessageBoxButtons.OK);
                    check = false;
                }
            }
            else if (radioButton2.Checked)
            {
                try
                {
                    kcalMB = (655 + (9.6 * Convert.ToDouble(textBox3.Text))) + ((1.8 * Convert.ToDouble(textBox2.Text))
                    - (4.7 * Convert.ToDouble(textBox1.Text)));
                    if (checkBox1.Checked)
                    {
                        kcalFinal = kcalMB * 1.9;
                    }
                    else
                    {
                        kcalFinal = kcalMB * exerCoef;
                    }
                    label9.Text = Math.Round(kcalFinal, 2, MidpointRounding.ToEven).ToString() + " kCal";
                    label8.Show();
                    check = true;
                }
                catch
                {
                    MessageBox.Show("Debes rellenar toda la información.", "Información incompleta.", MessageBoxButtons.OK);
                    check = false;
                }
            }
            else if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Debes rellenar toda la información.", "Información incompleta.", MessageBoxButtons.OK);
                check = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                label5.ForeColor = System.Drawing.Color.FromArgb(100, 119, 119, 119);
                label7.ForeColor = System.Drawing.Color.FromArgb(100, 119, 119, 119);
                comboBox1.Enabled = false;
            }
            else
            {
                label5.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
                label7.ForeColor = System.Drawing.Color.FromArgb(255, 0, 0, 0);
                comboBox1.Enabled = true;
            }        
        }
        //revisar estos valores y ajustarlos
        private void radioButton3_Checked(object sender, EventArgs e)
        {
            protPercentage = 0.30;
            carbsPercentage = 0.50;
            fatsPercentage = 0.20;
        }

        private void radioButton4_Checked(object sender, EventArgs e)
        {
            protPercentage = 0.30;
            carbsPercentage = 0.50;
            fatsPercentage = 0.20;
        }

        private void radioButton5_Checked(object sender, EventArgs e)
        {
            protPercentage = 0.30;
            carbsPercentage = 0.50;
            fatsPercentage = 0.20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (check != true)
            {
                MessageBox.Show("Se debe realizar el cálculo de las kCal necesarias.", "Objetivo desconocido", MessageBoxButtons.OK);
            }
            else
            {

            }
        }
    }
}
