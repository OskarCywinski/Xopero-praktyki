
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
            this.BankToJoe = new System.Windows.Forms.Button();
            this.BobToBank = new System.Windows.Forms.Button();
            this.BobToJoe = new System.Windows.Forms.Button();
            this.JoeToBob = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BankToJoe
            // 
            this.BankToJoe.Location = new System.Drawing.Point(60, 228);
            this.BankToJoe.Name = "BankToJoe";
            this.BankToJoe.Size = new System.Drawing.Size(128, 41);
            this.BankToJoe.TabIndex = 7;
            this.BankToJoe.Text = "Daj 10zł Joemu";
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
            // JoeToBob
            // 
            this.JoeToBob.Location = new System.Drawing.Point(60, 284);
            this.JoeToBob.Name = "JoeToBob";
            this.JoeToBob.Size = new System.Drawing.Size(128, 39);
            this.JoeToBob.TabIndex = 8;
            this.JoeToBob.Text = "Joe daje 10zł Bobowi";
            this.JoeToBob.UseVisualStyleBackColor = true;
            this.JoeToBob.Click += new System.EventHandler(this.JoeToBob_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 364);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JoeToBob);
            this.Controls.Add(this.BobToJoe);
            this.Controls.Add(this.BobToBank);
            this.Controls.Add(this.BankToJoe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BankToJoe;
        private System.Windows.Forms.Button BobToBank;
        private System.Windows.Forms.Button BobToJoe;
        private System.Windows.Forms.Button JoeToBob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

