namespace VKK
{
    partial class Inf
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.snm = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.nm = new System.Windows.Forms.Label();
            this.sr = new System.Windows.Forms.Label();
            this.ag = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 238);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(299, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 17);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // snm
            // 
            this.snm.AutoSize = true;
            this.snm.Location = new System.Drawing.Point(299, 74);
            this.snm.Name = "snm";
            this.snm.Size = new System.Drawing.Size(65, 17);
            this.snm.TabIndex = 2;
            this.snm.Text = "Surname";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(299, 136);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(21, 17);
            this.age.TabIndex = 3;
            this.age.Text = "ID";
            this.age.Click += new System.EventHandler(this.Age_Click);
            // 
            // nm
            // 
            this.nm.AutoSize = true;
            this.nm.Location = new System.Drawing.Point(400, 22);
            this.nm.Name = "nm";
            this.nm.Size = new System.Drawing.Size(42, 17);
            this.nm.TabIndex = 4;
            this.nm.Text = "None";
            this.nm.Click += new System.EventHandler(this.Nm_Click);
            // 
            // sr
            // 
            this.sr.AutoSize = true;
            this.sr.Location = new System.Drawing.Point(400, 74);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(42, 17);
            this.sr.TabIndex = 5;
            this.sr.Text = "None";
            // 
            // ag
            // 
            this.ag.AutoSize = true;
            this.ag.Location = new System.Drawing.Point(400, 136);
            this.ag.Name = "ag";
            this.ag.Size = new System.Drawing.Size(42, 17);
            this.ag.TabIndex = 6;
            this.ag.Text = "None";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 368);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 70);
            this.button2.TabIndex = 8;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(538, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(250, 250);
            this.webBrowser1.TabIndex = 9;
            // 
            // Inf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ag);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.nm);
            this.Controls.Add(this.age);
            this.Controls.Add(this.snm);
            this.Controls.Add(this.name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Inf";
            this.Text = "Inf";
            this.Load += new System.EventHandler(this.Inf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label snm;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label nm;
        private System.Windows.Forms.Label sr;
        private System.Windows.Forms.Label ag;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}