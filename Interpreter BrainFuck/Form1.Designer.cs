
namespace Interpreter_BrainFuck
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dekommpresuj = new System.Windows.Forms.Button();
            this.convertBinary = new System.Windows.Forms.Button();
            this.BrainCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NazwaPliku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Wynik = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dekommpresuj);
            this.groupBox1.Controls.Add(this.convertBinary);
            this.groupBox1.Controls.Add(this.BrainCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NazwaPliku);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BrainFuck";
            // 
            // dekommpresuj
            // 
            this.dekommpresuj.Location = new System.Drawing.Point(128, 415);
            this.dekommpresuj.Name = "dekommpresuj";
            this.dekommpresuj.Size = new System.Drawing.Size(110, 23);
            this.dekommpresuj.TabIndex = 6;
            this.dekommpresuj.Text = "Dekompresuj";
            this.dekommpresuj.UseVisualStyleBackColor = true;
            this.dekommpresuj.Click += new System.EventHandler(this.dekommpresuj_Click);
            // 
            // convertBinary
            // 
            this.convertBinary.Location = new System.Drawing.Point(0, 415);
            this.convertBinary.Name = "convertBinary";
            this.convertBinary.Size = new System.Drawing.Size(114, 23);
            this.convertBinary.TabIndex = 5;
            this.convertBinary.Text = "Kompresuj";
            this.convertBinary.UseVisualStyleBackColor = true;
            this.convertBinary.Click += new System.EventHandler(this.convertBinary_Click);
            // 
            // BrainCode
            // 
            this.BrainCode.Location = new System.Drawing.Point(6, 91);
            this.BrainCode.Multiline = true;
            this.BrainCode.Name = "BrainCode";
            this.BrainCode.ReadOnly = true;
            this.BrainCode.Size = new System.Drawing.Size(225, 314);
            this.BrainCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zawartość pliku";
            // 
            // NazwaPliku
            // 
            this.NazwaPliku.Location = new System.Drawing.Point(7, 42);
            this.NazwaPliku.Name = "NazwaPliku";
            this.NazwaPliku.Size = new System.Drawing.Size(142, 23);
            this.NazwaPliku.TabIndex = 2;
            this.NazwaPliku.Leave += new System.EventHandler(this.NazwaPliku_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj nazwę pliku";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.Wynik);
            this.groupBox2.Location = new System.Drawing.Point(245, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 450);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wynik";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Zinterpretuj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Wynik
            // 
            this.Wynik.Location = new System.Drawing.Point(6, 20);
            this.Wynik.Multiline = true;
            this.Wynik.Name = "Wynik";
            this.Wynik.ReadOnly = true;
            this.Wynik.Size = new System.Drawing.Size(225, 385);
            this.Wynik.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NazwaPliku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox BrainCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox Wynik;
        private System.Windows.Forms.Button convertBinary;
        private System.Windows.Forms.Button dekommpresuj;
    }
}

