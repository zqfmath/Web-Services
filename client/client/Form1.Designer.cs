namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Login = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Button();
            this.UserID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(108, 236);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(255, 236);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(75, 23);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Location = new System.Drawing.Point(91, 87);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(41, 12);
            this.UserID.TabIndex = 2;
            this.UserID.Text = "UserID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(181, 21);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(79, 154);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 12);
            this.Password.TabIndex = 5;
            this.Password.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(79, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(162, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Playlist Specialist";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 314);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

