using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Add_Track : Form
    {
        String playlist;
        myservice.Service1SoapClient abc;
        public Add_Track(myservice.Service1SoapClient abc,String ID)
        {
            InitializeComponent();
            this.abc = abc;
            this.playlist = ID;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(' ') != -1 || textBox2.Text.IndexOf(' ') != -1 || textBox3.Text.IndexOf(' ') != -1 || textBox4.Text.IndexOf(' ') != -1)
            {
                label5.Text = "No blank is permitted!";
            }
            else if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                label5.Text = "No box cannot be vacant!";
            }
            else if (abc.AddTrack(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,playlist,Public.Checked==true?"Y":"N") == 1)  
            {
               
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                label5.Text = "Fail to add or had been created!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void Public_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
