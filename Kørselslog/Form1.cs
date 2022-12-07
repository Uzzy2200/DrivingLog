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
using MySql.Data.MySqlClient;
namespace Kørselslog

{
    public partial class Form1 : Form
    {
        private DialogResult savedata;
         
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {

            
            iExit = MessageBox.Show("Confirm if you want to exit","MySql Connector",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Form3 popup = new Form3();
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                Console.WriteLine("You clicked OK");
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                Console.WriteLine("You clicked either Cancel or X button in the top right corner");
            }
            popup.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult = savedata;
            savedata = MessageBox.Show("Do you wanna save the data?", "MySql Connector", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            try
            {
                if (savedata == DialogResult.Yes)
                    
                MessageBox.Show("You have saved the data");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception Save)
            {
                MessageBox.Show(Save.Message);  
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2();
            DialogResult dialogresult = popup.ShowDialog();
            
            popup.Dispose();

        }
    }
}
