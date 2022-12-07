using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kørselslog
{
    public partial class Form2 : Form
    {
        private DialogResult Deletee;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult = Deletee;
            Deletee = MessageBox.Show("Do you wanna create the driver?", "MySql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (Deletee == DialogResult.Yes)

                    MessageBox.Show("You have created the driver");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception Save)
            {
                MessageBox.Show(Save.Message);
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult = Deletee;
            Deletee = MessageBox.Show("Do you wanna delete driver?", "MySql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            try
            {
                if (Deletee == DialogResult.Yes)

                    MessageBox.Show("You have deleted the driver");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch (Exception Save)
            {
                MessageBox.Show(Save.Message);
            }

        }
    }
}
