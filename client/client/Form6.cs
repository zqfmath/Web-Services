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
    public partial class Add_Playlist : Form
    {
        myservice.Service1SoapClient abc;
        public Add_Playlist(myservice.Service1SoapClient abc)
        {
            InitializeComponent();
            this.abc = abc;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(' ') != -1)
            {
                label2.Text = "No blank is permitted!";
            }
            else if (textBox1.Text == "")
            {
                label2.Text = "Name cannot be vacant!";
            }
            else if (abc.AddList(textBox1.Text) == 1)
            {
               
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                label2.Text = "Fail to add or had been created!";
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

    }
}
