namespace VKK
{
    partial class Auth
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
            this.log = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.log_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.MaskedTextBox();
            this.AH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(110, 94);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(43, 17);
            this.log.TabIndex = 0;
            this.log.Text = "Login";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(110, 126);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(69, 17);
            this.pass.TabIndex = 1;
            this.pass.Text = "Password";
            // 
            // log_box
            // 
            this.log_box.Location = new System.Drawing.Point(189, 89);
            this.log_box.Name = "log_box";
            this.log_box.Size = new System.Drawing.Size(100, 22);
            this.log_box.TabIndex = 2;
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(189, 126);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(100, 22);
            this.pass_box.TabIndex = 3;
            this.pass_box.UseSystemPasswordChar = true;
            // 
            // AH
            // 
            this.AH.Location = new System.Drawing.Point(157, 211);
            this.AH.Name = "AH";
            this.AH.Size = new System.Drawing.Size(176, 34);
            this.AH.TabIndex = 4;
            this.AH.Text = "Login in VK";
            this.AH.UseVisualStyleBackColor = true;
            this.AH.Click += new System.EventHandler(this.AH_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(121, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Post";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 458);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AH);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.log_box);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.log);
            this.Name = "Auth";
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.TextBox log_box;
        private System.Windows.Forms.MaskedTextBox pass_box;
        private System.Windows.Forms.Button AH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

