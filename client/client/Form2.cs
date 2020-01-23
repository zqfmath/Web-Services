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
    public partial class Playlist_Specialist : Form
    {
        //define object abc
        public  myservice.Service1SoapClient abc = new myservice.Service1SoapClient();
       

        public Playlist_Specialist()
        {
            
            Form1 form1 = new Form1();
        
          //Load form1
            if (form1.ShowDialog() != DialogResult.OK)   
          {
              Environment.Exit(Environment.ExitCode);    
              return;
          }
          
          InitializeComponent();

          label1.Text = "Welcome," + abc.Name() + "!";

          DataTable name = abc.GetName();
          //ergodic process,which loads all the usersID.
            foreach (DataRow row in name.Rows)
          {
              foreach (DataColumn column in name.Columns)
              {
                  this.namelist.Items.Add(row[column]);
              }
          }

        
          
              DataTable dt1 = abc.GetList(abc.Name());
              dataGridView1.DataSource = dt1;
            // if the list is vacant, some buttons are not available.
              if (dt1.Rows.Count ==0)
              {
                  Tracks.Enabled = false;
                  Delete_List.Enabled = false;
              }
          this.namelist.Text = abc.Name();
        }

         

            
        
             private void label1_Click(object sender, EventArgs e)
            {

            }

            

            public void button1_Click(object sender, EventArgs e)
            {


           
          
            }

            private void closeToolStripMenuItem_Click(object sender, EventArgs e)
            {
               
               
                this.Close();
            }

            private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
            {
              // log off process
                abc.Logoff();
                Form1 form2 = new Form1();
               this.Hide();
                if (form2.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(Environment.ExitCode);
                    return;
                }
                label1.Text = "Welcome," + abc.Name() + "!";
                dataGridView1.DataSource = abc.GetList(abc.Name());
                this.namelist.Text = abc.Name();
                DataTable dt = new DataTable();
                dataGridView2.DataSource = dt;
                this.Show();
 
            }

            private void label1_Click_1(object sender, EventArgs e)
            {

            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
               
                DataTable dt1=abc.GetList(this.namelist.SelectedItem.ToString());
                dataGridView1.DataSource = dt1;
                // if the selection is changed, some buttons are not available.
                if (this.namelist.SelectedItem.ToString() == abc.Name() || dt1.Rows.Count==0)
                {
                    Mark.Enabled = false;
                }
                else
                {
                    Mark.Enabled = true;
                }
                 if (dt1.Rows.Count ==0)
              {
                  Tracks.Enabled = false;
                 
              }
                 else
                 {
                  Tracks.Enabled = true;
         
                 }
                 if (this.namelist.SelectedItem.ToString() == abc.Name())
                 {
                     Add_List.Enabled = true;
                 }
                 else
                 {
                     Add_List.Enabled = false;
                 }
                 if (this.namelist.SelectedItem.ToString() != abc.Name() || dt1.Rows.Count == 0)
                 {
                     Delete_List.Enabled = false;
                 }
                 else
                 {
                     Delete_List.Enabled = true;
                 }
                 if (dt1.Rows.Count == 0 || this.namelist.SelectedItem.ToString() != abc.Name())
                 {

                     Update_Track.Enabled = false;
                     Delete_Track.Enabled = false;
                 }
                 else
                 {
                     Update_Track.Enabled = true;
                     Delete_Track.Enabled = true;
                 }
                 if (this.namelist.SelectedItem.ToString() != abc.Name())
                 {
                     Add_Track.Enabled = false;
                 }
                 else
                 {
                     Add_Track.Enabled = true;
                 }
            }

            private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }

           

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void button1_Click_1(object sender, EventArgs e)
            {
              //add a playlist
                Add_Playlist form6 = new Add_Playlist(abc);
                if (form6.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt1 = abc.GetList(abc.Name());
                    dataGridView1.DataSource = dt1;
                    MessageBox.Show("Add successfully!");


                }
            }

            private void Tracks_Click(object sender, EventArgs e)
            {
                // check the track of a selected playlist
                String ID = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["playlist"].Value.ToString();
                DataTable dt1 = abc.GetTrack(ID);
                dataGridView2.DataSource = dt1;
                if (dt1.Rows.Count == 0 || this.namelist.SelectedItem.ToString() != abc.Name())
                {
                 
                    Update_Track.Enabled = false;
                    Delete_Track.Enabled = false;
                }
                else
                {
                    Update_Track.Enabled = true;
                    Delete_Track.Enabled = true;
                }
                if (this.namelist.SelectedItem.ToString() != abc.Name())
                {
                    Add_Track.Enabled = false;
                }
                else
                {
                    Add_Track.Enabled = true;
                }

            }

            private void Delete_List_Click(object sender, EventArgs e)
            {
                // delete selected list.
                String ID = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["playlist"].Value.ToString();
                int k = abc.DeleteList(ID);
                DataTable dt1 = abc.GetList(abc.Name());
                dataGridView1.DataSource = dt1;
                if (k == 1)
                {
                   
                    MessageBox.Show("Delete successfully!");
                }
                else
                {
                    MessageBox.Show("Fail to delete or non-exist!");
                }
            }

            private void Mark_Click(object sender, EventArgs e)
            {
               // mark the playlist
                Mark form4 = new Mark();
              
                if (form4.ShowDialog() == DialogResult.OK)
               {
                   String playlist = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["playlist"].Value.ToString();
                   String nickname = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["nickname"].Value.ToString();
                   if (abc.AddScore(playlist, nickname, form4.score) == 1)
                   {
                       MessageBox.Show("Mark successfully!");
                   }
                   else
                   {
                       MessageBox.Show("Fail to mark or had marked!");
                   
                   }
               }
            }

            private void myMarksToolStripMenuItem_Click(object sender, EventArgs e)
            {
                DataTable dt = abc.Mymarks();
                MyMarks form5 = new MyMarks(dt);
               
                form5.ShowDialog();
            }

            private void Add_Track_Click(object sender, EventArgs e)
            {
                String ID = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["playlist"].Value.ToString();
             //convey the object abc and ID as parameters
                Add_Track form7 = new Add_Track(abc,ID);
                if (form7.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Add successfully!");
                    DataTable dt1 = abc.GetTrack(ID);
                    dataGridView2.DataSource = dt1;

                }
                

            }

            private void Delete_Track_Click(object sender, EventArgs e)
            {
                String ID = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["playlist"].Value.ToString();
                String title = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells["title"].Value.ToString();
                String artist = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells["artist"].Value.ToString();

                int k = abc.DeleteTrack(title,artist,ID);
                DataTable dt1 = abc.GetTrack(ID);
                dataGridView2.DataSource = dt1;
                if (k == 1)
                {

                    MessageBox.Show("Delete successfully!");
                }
                else
                {
                    MessageBox.Show("Fail to delete or non-exist!");
                }
            }

            private void Update_Track_Click(object sender, EventArgs e)
            {
                String ID = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["playlist"].Value.ToString();
                String title = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells["title"].Value.ToString();
                String artist = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells["artist"].Value.ToString();
                String genre = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells["genre"].Value.ToString();
                String album = dataGridView2.Rows[dataGridView2.CurrentRow.Index].Cells["album"].Value.ToString();
                Update form8 = new Update(abc,ID,title,artist,album,genre);
                if (form8.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Update successfully!");
                    DataTable dt1 = abc.GetTrack(ID);
                    dataGridView2.DataSource = dt1;

                }

            }

            private void scoresToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Rankings form9 = new Rankings(abc);

                form9.ShowDialog();
            }

            private void Playlist_Specialist_Load(object sender, EventArgs e)
            {

            }

           

          



        }
    }

