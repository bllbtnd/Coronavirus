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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd1 = new OpenFileDialog();
            fd1.Filter = "Just One File Avaliable|*pass.txt";
            String Fname = "";

            if (fd1.ShowDialog().Equals(DialogResult.OK))
            {
                Fname = fd1.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            
            this.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://windy.app/coronavirus_map");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.who.int/emergencies/diseases/novel-coronavirus-2019");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string p = System.IO.File.ReadAllText(@"jgyz.txt");
            textBox2.Text = p;


            string[] line ={
                            p + textBox1.Text
                          };

            File.WriteAllLines("jgyz.txt", line);

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string p = System.IO.File.ReadAllText(@"jgyz.txt");
            textBox2.Text = p;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string[] line ={
                            ""
                          };

            File.WriteAllLines("jgyz.txt", line);
        }
    }
}
