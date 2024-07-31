using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mass;
            double weight;
            int Gravity;
            double Gravitation = 9.8;
            Gravity = (int)Gravitation;


            mass = int.Parse(massTxtBox.Text);

            weight = mass * Gravity;

            if (weight > 1000)
            {
                Outputlbl.Text = "It is too heavy";
                Outputlbl.BackColor = Color.Red;
            }
            else if (weight < 10)
            {
                Outputlbl.Text = "It is too light";
                Outputlbl.BackColor = Color.Blue;
            }
            else
            {
                Outputlbl.Text = "The weight is " + weight;
                Outputlbl.BackColor = Color.Green;
            }

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
