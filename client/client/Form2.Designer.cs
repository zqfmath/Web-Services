namespace WindowsFormsApplication1
{
    partial class Playlist_Specialist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playlist_Specialist));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myMarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.namelist = new System.Windows.Forms.ComboBox();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Delete_List = new System.Windows.Forms.Button();
            this.Add_List = new System.Windows.Forms.Button();
            this.Tracks = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Add_Track = new System.Windows.Forms.Button();
            this.Update_Track = new System.Windows.Forms.Button();
            this.Delete_Track = new System.Windows.Forms.Button();
            this.Mark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 165);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(284, 276);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.functionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.startToolStripMenuItem.Text = "System";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.logOffToolStripMenuItem.Text = "Log off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myMarksToolStripMenuItem,
            this.scoresToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.functionsToolStripMenuItem.Text = "Reports";
            // 
            // myMarksToolStripMenuItem
            // 
            this.myMarksToolStripMenuItem.Name = "myMarksToolStripMenuItem";
            this.myMarksToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.myMarksToolStripMenuItem.Text = "Mymarks";
            this.myMarksToolStripMenuItem.Click += new System.EventHandler(this.myMarksToolStripMenuItem_Click);
            // 
            // scoresToolStripMenuItem
            // 
            this.scoresToolStripMenuItem.Name = "scoresToolStripMenuItem";
            this.scoresToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.scoresToolStripMenuItem.Text = "Rankings";
            this.scoresToolStripMenuItem.Click += new System.EventHandler(this.scoresToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // namelist
            // 
            this.namelist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.namelist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.namelist.FormattingEnabled = true;
            this.namelist.Location = new System.Drawing.Point(39, 116);
            this.namelist.Name = "namelist";
            this.namelist.Size = new System.Drawing.Size(161, 20);
            this.namelist.Sorted = true;
            this.namelist.TabIndex = 5;
            this.namelist.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1106, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // Delete_List
            // 
            this.Delete_List.Location = new System.Drawing.Point(353, 399);
            this.Delete_List.Name = "Delete_List";
            this.Delete_List.Size = new System.Drawing.Size(75, 23);
            this.Delete_List.TabIndex = 7;
            this.Delete_List.Text = "Delete";
            this.Delete_List.UseVisualStyleBackColor = true;
            this.Delete_List.Click += new System.EventHandler(this.Delete_List_Click);
            // 
            // Add_List
            // 
            this.Add_List.Location = new System.Drawing.Point(353, 316);
            this.Add_List.Name = "Add_List";
            this.Add_List.Size = new System.Drawing.Size(75, 23);
            this.Add_List.TabIndex = 8;
            this.Add_List.Text = "Add";
            this.Add_List.UseVisualStyleBackColor = true;
            this.Add_List.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Tracks
            // 
            this.Tracks.Location = new System.Drawing.Point(353, 244);
            this.Tracks.Name = "Tracks";
            this.Tracks.Size = new System.Drawing.Size(75, 23);
            this.Tracks.TabIndex = 9;
            this.Tracks.Text = "Tracks";
            this.Tracks.UseVisualStyleBackColor = true;
            this.Tracks.Click += new System.EventHandler(this.Tracks_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(517, 128);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(537, 276);
            this.dataGridView2.TabIndex = 10;
            // 
            // Add_Track
            // 
            this.Add_Track.Enabled = false;
            this.Add_Track.Location = new System.Drawing.Point(574, 70);
            this.Add_Track.Name = "Add_Track";
            this.Add_Track.Size = new System.Drawing.Size(75, 23);
            this.Add_Track.TabIndex = 11;
            this.Add_Track.Text = "Add";
            this.Add_Track.UseVisualStyleBackColor = true;
            this.Add_Track.Click += new System.EventHandler(this.Add_Track_Click);
            // 
            // Update_Track
            // 
            this.Update_Track.Enabled = false;
            this.Update_Track.Location = new System.Drawing.Point(733, 70);
            this.Update_Track.Name = "Update_Track";
            this.Update_Track.Size = new System.Drawing.Size(75, 23);
            this.Update_Track.TabIndex = 12;
            this.Update_Track.Text = "Update";
            this.Update_Track.UseVisualStyleBackColor = true;
            this.Update_Track.Click += new System.EventHandler(this.Update_Track_Click);
            // 
            // Delete_Track
            // 
            this.Delete_Track.Enabled = false;
            this.Delete_Track.Location = new System.Drawing.Point(900, 70);
            this.Delete_Track.Name = "Delete_Track";
            this.Delete_Track.Size = new System.Drawing.Size(75, 23);
            this.Delete_Track.TabIndex = 13;
            this.Delete_Track.Text = "Delete";
            this.Delete_Track.UseVisualStyleBackColor = true;
            this.Delete_Track.Click += new System.EventHandler(this.Delete_Track_Click);
            // 
            // Mark
            // 
            this.Mark.Enabled = false;
            this.Mark.Location = new System.Drawing.Point(353, 165);
            this.Mark.Name = "Mark";
            this.Mark.Size = new System.Drawing.Size(75, 23);
            this.Mark.TabIndex = 14;
            this.Mark.Text = "Mark";
            this.Mark.UseVisualStyleBackColor = true;
            this.Mark.Click += new System.EventHandler(this.Mark_Click);
            // 
            // Playlist_Specialist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1106, 512);
            this.Controls.Add(this.Mark);
            this.Controls.Add(this.Delete_Track);
            this.Controls.Add(this.Update_Track);
            this.Controls.Add(this.Add_Track);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Tracks);
            this.Controls.Add(this.Add_List);
            this.Controls.Add(this.Delete_List);
            this.Controls.Add(this.namelist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Playlist_Specialist";
            this.Text = "Playlist_Specialist";
            this.Load += new System.EventHandler(this.Playlist_Specialist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ComboBox namelist;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button Delete_List;
        private System.Windows.Forms.Button Add_List;
        private System.Windows.Forms.Button Tracks;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button Add_Track;
        private System.Windows.Forms.Button Update_Track;
        private System.Windows.Forms.Button Delete_Track;
        private System.Windows.Forms.Button Mark;
        private System.Windows.Forms.ToolStripMenuItem myMarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scoresToolStripMenuItem;
    }
}