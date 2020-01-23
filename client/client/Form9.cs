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
    public partial class Rankings : Form
    {
        myservice.Service1SoapClient abc;
        public Rankings(myservice.Service1SoapClient abc)
        {
            //show tables
            InitializeComponent();
            this.abc = abc;
            dataGridView1.DataSource = abc.RankTrack();
            dataGridView2.DataSource = abc.RankList();
            chart1.DataSource = abc.RankTrackTop3();
            chart2.DataSource = abc.RankListTop3();
       //draw histograms
                chart1.Series["Series1"].XValueMember = "title";
                chart1.Series["Series1"].YValueMembers = "rank";
                chart2.Series["Series1"].XValueMember = "Playlist";
                chart2.Series["Series1"].YValueMembers = "rank";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; 
        }
    }
}
