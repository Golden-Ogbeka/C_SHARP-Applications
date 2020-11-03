namespace FINAL_TEST_WITH_MENU_DRIVEN_APP
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.ApplicationStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TemperatureStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentGpaStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinput1 = new System.Windows.Forms.TextBox();
            this.txtinput2 = new System.Windows.Forms.TextBox();
            this.txtinput3 = new System.Windows.Forms.TextBox();
            this.txtinput4 = new System.Windows.Forms.TextBox();
            this.txtinput5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGPAoutput = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileStrip,
            this.ApplicationStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(567, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileStrip
            // 
            this.FileStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitStrip});
            this.FileStrip.Name = "FileStrip";
            this.FileStrip.Size = new System.Drawing.Size(37, 20);
            this.FileStrip.Text = "File";
            // 
            // ExitStrip
            // 
            this.ExitStrip.Name = "ExitStrip";
            this.ExitStrip.Size = new System.Drawing.Size(92, 22);
            this.ExitStrip.Text = "Exit";
            this.ExitStrip.Click += new System.EventHandler(this.ExitStrip_Click);
            // 
            // ApplicationStrip
            // 
            this.ApplicationStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TemperatureStrip,
            this.StudentGpaStrip});
            this.ApplicationStrip.Name = "ApplicationStrip";
            this.ApplicationStrip.Size = new System.Drawing.Size(85, 20);
            this.ApplicationStrip.Text = "Applications";
            // 
            // TemperatureStrip
            // 
            this.TemperatureStrip.Name = "TemperatureStrip";
            this.TemperatureStrip.Size = new System.Drawing.Size(152, 22);
            this.TemperatureStrip.Text = "Temperature";
            this.TemperatureStrip.Click += new System.EventHandler(this.TemperatureStrip_Click);
            // 
            // StudentGpaStrip
            // 
            this.StudentGpaStrip.Name = "StudentGpaStrip";
            this.StudentGpaStrip.Size = new System.Drawing.Size(152, 22);
            this.StudentGpaStrip.Text = "Student GPA";
            this.StudentGpaStrip.Click += new System.EventHandler(this.StudentGpaStrip_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Temperature in Fahrenheit is";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter temperature in Celcius";
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(243, 90);
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.Size = new System.Drawing.Size(100, 20);
            this.txtoutput.TabIndex = 4;
            this.txtoutput.TextChanged += new System.EventHandler(this.txtoutput_TextChanged);
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(243, 25);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(100, 20);
            this.txtinput.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtoutput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtinput);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 147);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGPAoutput);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtinput5);
            this.groupBox2.Controls.Add(this.txtinput4);
            this.groupBox2.Controls.Add(this.txtinput3);
            this.groupBox2.Controls.Add(this.txtinput2);
            this.groupBox2.Controls.Add(this.txtinput1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 236);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student GPA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Your scores\r\naccording to the\r\ncredit units";
            // 
            // txtinput1
            // 
            this.txtinput1.Location = new System.Drawing.Point(183, 54);
            this.txtinput1.Name = "txtinput1";
            this.txtinput1.Size = new System.Drawing.Size(24, 20);
            this.txtinput1.TabIndex = 1;
            // 
            // txtinput2
            // 
            this.txtinput2.Location = new System.Drawing.Point(213, 54);
            this.txtinput2.Name = "txtinput2";
            this.txtinput2.Size = new System.Drawing.Size(24, 20);
            this.txtinput2.TabIndex = 1;
            // 
            // txtinput3
            // 
            this.txtinput3.Location = new System.Drawing.Point(243, 54);
            this.txtinput3.Name = "txtinput3";
            this.txtinput3.Size = new System.Drawing.Size(24, 20);
            this.txtinput3.TabIndex = 1;
            // 
            // txtinput4
            // 
            this.txtinput4.Location = new System.Drawing.Point(273, 54);
            this.txtinput4.Name = "txtinput4";
            this.txtinput4.Size = new System.Drawing.Size(24, 20);
            this.txtinput4.TabIndex = 1;
            // 
            // txtinput5
            // 
            this.txtinput5.Location = new System.Drawing.Point(303, 54);
            this.txtinput5.Name = "txtinput5";
            this.txtinput5.Size = new System.Drawing.Size(24, 20);
            this.txtinput5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Credit Units:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(180, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(300, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Your GPA is";
            // 
            // txtGPAoutput
            // 
            this.txtGPAoutput.Location = new System.Drawing.Point(139, 127);
            this.txtGPAoutput.Name = "txtGPAoutput";
            this.txtGPAoutput.Size = new System.Drawing.Size(84, 20);
            this.txtGPAoutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileStrip;
        private System.Windows.Forms.ToolStripMenuItem ExitStrip;
        private System.Windows.Forms.ToolStripMenuItem ApplicationStrip;
        private System.Windows.Forms.ToolStripMenuItem TemperatureStrip;
        private System.Windows.Forms.ToolStripMenuItem StudentGpaStrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtinput1;
        private System.Windows.Forms.TextBox txtinput5;
        private System.Windows.Forms.TextBox txtinput4;
        private System.Windows.Forms.TextBox txtinput3;
        private System.Windows.Forms.TextBox txtinput2;
        private System.Windows.Forms.TextBox txtGPAoutput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

