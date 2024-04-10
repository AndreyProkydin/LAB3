using Lab3;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnTab1_Click(object sender, EventArgs e)
        {
            double[] mass = txtArr1.Text.Split(' ').Select(x => double.Parse(x)).ToArray();

            Buble buble = new Buble();
            buble.numArray = mass.ToArray();

            buble.Sort();
            lblTab1.Text = "Відсортований массив :";

            foreach (double i in buble.numArray)
            {
                lblTab1.Text += " "+i.ToString();
            }

            lblTab1.Text += '\n';
            buble.Foreach();
            lblTab1.Text += "Foreach массив :";
            foreach (double i in buble.numArray)
            {
                lblTab1.Text += " " + i.ToString("F2");
            }
        }

        private void bttnTab2_Click(object sender, EventArgs e)
        {
            double[] mass = txtArr2.Text.Split(' ').Select(x => double.Parse(x)).ToArray();

            Choice choice = new Choice();
            choice.numArray1 = mass.ToArray();

            choice.Sort();
            lblTab2.Text = "Відсортований массив :";

            foreach (double i in choice.numArray1)
            {
                lblTab2.Text += " " + i.ToString();
            }

            lblTab2.Text += '\n';
            choice.Foreach();
            lblTab2.Text += "Foreach массив :";
            foreach (double i in choice.numArray1)
            {
                lblTab2.Text += " " + i.ToString("F2");
            }
        }
    }
}
