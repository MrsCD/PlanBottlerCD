using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanBottler
{
    public partial class Form1 : Form
    {
        Beer beer = new Beer();

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                if (comboBox1.SelectedIndex == 0)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Water");
                    comboBox2.Items.Add("Juice");
                    comboBox2.Items.Add("Milk");
                    comboBox2.Items.Add("Soft Drinks");

                }

                if (comboBox1.SelectedIndex == 1)
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("Beer");
                    comboBox2.Items.Add("Cidar");
                    comboBox2.Items.Add("Wine");
                    comboBox2.Items.Add("Spirits");
                }

                if (comboBox1.SelectedIndex == 2)
                {
                comboBox2.Items.Clear();
                    comboBox2.Items.Add("Coffee");
                    comboBox2.Items.Add("Hot Chocolate");
                    comboBox2.Items.Add("Tea");
                }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Non Alcoholic Drinks");          
            comboBox1.Items.Add("Alcoholic Drinks");
            comboBox1.Items.Add("Hot Drinks");



        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
    }
}
