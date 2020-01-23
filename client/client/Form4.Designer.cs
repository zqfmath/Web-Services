namespace WindowsFormsApplication1
{
    partial class Mark
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mark));
            this.label1 = new System.Windows.Forms.Label();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please give your mark :";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(84, 136);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(219, 136);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(209, 70);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Mark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 214);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mark";
            this.Text = "Mark";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;

    }
}