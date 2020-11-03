namespace FIRST_GUI_LECTURE
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
            this.ClassButton = new System.Windows.Forms.Button();
            this.PracticalButton = new System.Windows.Forms.Button();
            this.OKbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClassButton
            // 
            this.ClassButton.Location = new System.Drawing.Point(102, 31);
            this.ClassButton.Name = "ClassButton";
            this.ClassButton.Size = new System.Drawing.Size(75, 23);
            this.ClassButton.TabIndex = 0;
            this.ClassButton.Text = "btnLecture";
            this.ClassButton.UseVisualStyleBackColor = true;
            this.ClassButton.Click += new System.EventHandler(this.ClassButton_Click);
            // 
            // PracticalButton
            // 
            this.PracticalButton.Location = new System.Drawing.Point(102, 115);
            this.PracticalButton.Name = "PracticalButton";
            this.PracticalButton.Size = new System.Drawing.Size(75, 23);
            this.PracticalButton.TabIndex = 1;
            this.PracticalButton.Text = "btnPractical";
            this.PracticalButton.UseVisualStyleBackColor = true;
            this.PracticalButton.Click += new System.EventHandler(this.PracticalButton_Click);
            // 
            // OKbutton
            // 
            this.OKbutton.Location = new System.Drawing.Point(102, 210);
            this.OKbutton.Name = "OKbutton";
            this.OKbutton.Size = new System.Drawing.Size(75, 23);
            this.OKbutton.TabIndex = 2;
            this.OKbutton.Text = "btnOK";
            this.OKbutton.UseVisualStyleBackColor = true;
            this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.OKbutton);
            this.Controls.Add(this.PracticalButton);
            this.Controls.Add(this.ClassButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClassButton;
        private System.Windows.Forms.Button PracticalButton;
        private System.Windows.Forms.Button OKbutton;
    }
}

