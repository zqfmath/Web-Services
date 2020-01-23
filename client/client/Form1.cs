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
    public partial class Form1 : Form
    {
        //define object abc
        myservice.Service1SoapClient abc = new myservice.Service1SoapClient();
        
        public Form1()
        {
            
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //judge whether Text box input is legal or not
            if (textBox1.Text.IndexOf(' ') != -1 || textBox2.Text.IndexOf(' ') != -1)
            {
                label1.Text = "No blank is permitted!";
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                label1.Text = "UserID or Password cannot be vacant!";
            }
            else if (abc.Login(textBox1.Text, textBox2.Text) == 1)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                label1.Text = "UserID or Password is wrong or not register!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.IndexOf(' ') != -1 || textBox2.Text.IndexOf(' ') != -1)
            {
                label1.Text = "No blank is permitted!";
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                label1.Text = "UserID or Password cannot be vacant!";
            }
            else if (abc.Register(textBox1.Text, textBox2.Text) == 1)
            {
                MessageBox.Show("Register successful!");
                // go back to primary form
                this.DialogResult = DialogResult.OK;
            }
            else 
            {
                label1.Text="UserID has been occupied!";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

   

}
