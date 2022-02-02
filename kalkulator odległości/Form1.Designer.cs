
namespace kalkulator_odległości
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
            this.button = new System.Windows.Forms.Button();
            this.stanpoczatkowy = new System.Windows.Forms.NumericUpDown();
            this.stankoncowy = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kwota = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stanpoczatkowy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stankoncowy)).BeginInit();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(135, 106);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 0;
            this.button.Text = "Oblicz";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // stanpoczatkowy
            // 
            this.stanpoczatkowy.Location = new System.Drawing.Point(240, 12);
            this.stanpoczatkowy.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.stanpoczatkowy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stanpoczatkowy.Name = "stanpoczatkowy";
            this.stanpoczatkowy.Size = new System.Drawing.Size(120, 23);
            this.stanpoczatkowy.TabIndex = 1;
            this.stanpoczatkowy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stankoncowy
            // 
            this.stankoncowy.Location = new System.Drawing.Point(240, 41);
            this.stankoncowy.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.stankoncowy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stankoncowy.Name = "stankoncowy";
            this.stankoncowy.Size = new System.Drawing.Size(120, 23);
            this.stankoncowy.TabIndex = 2;
            this.stankoncowy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Początkowy stan licznika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Końcowy stan licznika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kwota do zwrotu";
            // 
            // kwota
            // 
            this.kwota.AutoSize = true;
            this.kwota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kwota.ForeColor = System.Drawing.SystemColors.ControlText;
            this.kwota.Location = new System.Drawing.Point(135, 71);
            this.kwota.Name = "kwota";
            this.kwota.Size = new System.Drawing.Size(52, 21);
            this.kwota.TabIndex = 6;
            this.kwota.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 139);
            this.Controls.Add(this.kwota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stankoncowy);
            this.Controls.Add(this.stanpoczatkowy);
            this.Controls.Add(this.button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stanpoczatkowy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stankoncowy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.NumericUpDown stanpoczatkowy;
        private System.Windows.Forms.NumericUpDown stankoncowy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label kwota;
    }
}

