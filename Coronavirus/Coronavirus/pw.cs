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

namespace Coronavirus
{
    public partial class Form1 : Form
    {

        


       


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kiiras
            string p = System.IO.File.ReadAllText(@"pass.txt");
            //feltvizsg
            if (textBox1.Text == p)
            {
                Main m = new Main();
                m.Show();
                this.Hide();
            }
            //err szoveg
            else
            {
                textBox1.Text = "Try an other pw...";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exit gomb
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
