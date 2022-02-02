
namespace Pieniądze
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BankToJoe = new System.Windows.Forms.Button();
            this.BobToBank = new System.Windows.Forms.Button();
            this.BobToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 6;
            // 
            // BankToJoe
            // 
            this.BankToJoe.Location = new System.Drawing.Point(60, 228);
            this.BankToJoe.Name = "BankToJoe";
            this.BankToJoe.Size = new System.Drawing.Size(128, 41);
            this.BankToJoe.TabIndex = 1;
            this.BankToJoe.Text = "Daj 10zł Joemu";
            this.BankToJoe.UseVisualStyleBackColor = true;
            this.BankToJoe.Click += new System.EventHandler(this.BankToJoe_Click);
            // 
            // BobToBank
            // 
            this.BobToBank.Location = new System.Drawing.Point(229, 228);
            this.BobToBank.Name = "BobToBank";
            this.BobToBank.Size = new System.Drawing.Size(127, 41);
            this.BobToBank.TabIndex = 2;
            this.BobToBank.Text = "Weź 5 zł od Boba";
            this.BobToBank.UseVisualStyleBackColor = true;
            this.BobToBank.Click += new System.EventHandler(this.BobToBank_Click);
            // 
            // BobToJoe
            // 
            this.BobToJoe.Location = new System.Drawing.Point(229, 284);
            this.BobToJoe.Name = "BobToJoe";
            this.BobToJoe.Size = new System.Drawing.Size(127, 41);
            this.BobToJoe.TabIndex = 3;
            this.BobToJoe.Text = "Bob daje 5zł Joemu";
            this.BobToJoe.UseVisualStyleBackColor = true;
            this.BobToJoe.Click += new System.EventHandler(this.BobToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 364);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BobToJoe);
            this.Controls.Add(this.BobToBank);
            this.Controls.Add(this.BankToJoe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BankToJoe;
        private System.Windows.Forms.Button BobToBank;
        private System.Windows.Forms.Button BobToJoe;
    }
}

