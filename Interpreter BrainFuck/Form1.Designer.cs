
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.convertBinary = new System.Windows.Forms.Button();
            this.BrainCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NazwaPliku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Wynik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Zapis = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pokaż kod";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Zapis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.convertBinary);
            this.groupBox1.Controls.Add(this.button1);
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
            // convertBinary
            // 
            this.convertBinary.Location = new System.Drawing.Point(117, 421);
            this.convertBinary.Name = "convertBinary";
            this.convertBinary.Size = new System.Drawing.Size(114, 23);
            this.convertBinary.TabIndex = 5;
            this.convertBinary.Text = "Zapisz plik binarny";
            this.convertBinary.UseVisualStyleBackColor = true;
            this.convertBinary.Click += new System.EventHandler(this.convertBinary_Click);
            // 
            // BrainCode
            // 
            this.BrainCode.Location = new System.Drawing.Point(6, 91);
            this.BrainCode.Multiline = true;
            this.BrainCode.Name = "BrainCode";
            this.BrainCode.ReadOnly = true;
            this.BrainCode.Size = new System.Drawing.Size(225, 277);
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
            this.NazwaPliku.TextChanged += new System.EventHandler(this.NazwaPliku_TextChanged);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Podaj nazwę do zapisu w binarnym";
            // 
            // Zapis
            // 
            this.Zapis.Location = new System.Drawing.Point(6, 421);
            this.Zapis.Name = "Zapis";
            this.Zapis.Size = new System.Drawing.Size(100, 23);
            this.Zapis.TabIndex = 7;
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NazwaPliku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox BrainCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox Wynik;
        private System.Windows.Forms.Button convertBinary;
        private System.Windows.Forms.TextBox Zapis;
        private System.Windows.Forms.Label label3;
    }
}

