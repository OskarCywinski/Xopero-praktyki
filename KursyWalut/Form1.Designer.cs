
namespace KursyWalut
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
            this.tabela = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kurs = new System.Windows.Forms.Label();
            this.waluta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tabela.FormattingEnabled = true;
            this.tabela.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.tabela.Location = new System.Drawing.Point(13, 34);
            this.tabela.Name = "tabela";
            this.tabela.Size = new System.Drawing.Size(121, 23);
            this.tabela.TabIndex = 0;
            this.tabela.SelectedIndexChanged += new System.EventHandler(this.tabela_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz tabelę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 2;
            // 
            // Kurs
            // 
            this.Kurs.AutoSize = true;
            this.Kurs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kurs.Location = new System.Drawing.Point(214, 41);
            this.Kurs.Name = "Kurs";
            this.Kurs.Size = new System.Drawing.Size(0, 15);
            this.Kurs.TabIndex = 3;
            // 
            // waluta
            // 
            this.waluta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.waluta.FormattingEnabled = true;
            this.waluta.Location = new System.Drawing.Point(12, 78);
            this.waluta.Name = "waluta";
            this.waluta.Size = new System.Drawing.Size(121, 23);
            this.waluta.TabIndex = 4;
            this.waluta.SelectedIndexChanged += new System.EventHandler(this.waluta_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wybierz walutę";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 125);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.waluta);
            this.Controls.Add(this.Kurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabela);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox tabela;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Kurs;
        private System.Windows.Forms.ComboBox waluta;
        private System.Windows.Forms.Label label3;
    }
}

