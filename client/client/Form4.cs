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
    public partial class Mark : Form
    {
       public int score;
        public Mark()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            score = (int)numericUpDown1.Value;


            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
         
            this.DialogResult = DialogResult.No;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
