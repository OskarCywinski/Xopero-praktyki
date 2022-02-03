
namespace Słonie
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lloyd = new System.Windows.Forms.Button();
            this.Lucinda = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lloyd
            // 
            this.Lloyd.Location = new System.Drawing.Point(85, 12);
            this.Lloyd.Name = "Lloyd";
            this.Lloyd.Size = new System.Drawing.Size(75, 23);
            this.Lloyd.TabIndex = 0;
            this.Lloyd.Text = "Lloyd";
            this.Lloyd.UseVisualStyleBackColor = true;
            this.Lloyd.Click += new System.EventHandler(this.Lloyd_Click);
            // 
            // Lucinda
            // 
            this.Lucinda.Location = new System.Drawing.Point(85, 41);
            this.Lucinda.Name = "Lucinda";
            this.Lucinda.Size = new System.Drawing.Size(75, 23);
            this.Lucinda.TabIndex = 1;
            this.Lucinda.Text = "Lucinda";
            this.Lucinda.UseVisualStyleBackColor = true;
            this.Lucinda.Click += new System.EventHandler(this.Lucinda_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(85, 70);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 23);
            this.change.TabIndex = 2;
            this.change.Text = "Zamień";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 119);
            this.Controls.Add(this.change);
            this.Controls.Add(this.Lucinda);
            this.Controls.Add(this.Lloyd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lloyd;
        private System.Windows.Forms.Button Lucinda;
        private System.Windows.Forms.Button change;
    }
}

