namespace inwentaryzator
{
    partial class pracownik
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
            this.label1 = new System.Windows.Forms.Label();
            this.ean_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ilosc_textBox = new System.Windows.Forms.TextBox();
            this.cena_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nazwa_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.opis_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.but_wyszukaj = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.wyloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "EAN-13:";
            // 
            // ean_textBox
            // 
            this.ean_textBox.Location = new System.Drawing.Point(79, 18);
            this.ean_textBox.Name = "ean_textBox";
            this.ean_textBox.Size = new System.Drawing.Size(91, 20);
            this.ean_textBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(34, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ilość: ";
            // 
            // ilosc_textBox
            // 
            this.ilosc_textBox.Location = new System.Drawing.Point(79, 52);
            this.ilosc_textBox.Name = "ilosc_textBox";
            this.ilosc_textBox.Size = new System.Drawing.Size(91, 20);
            this.ilosc_textBox.TabIndex = 2;
            // 
            // cena_textBox
            // 
            this.cena_textBox.Location = new System.Drawing.Point(79, 84);
            this.cena_textBox.Name = "cena_textBox";
            this.cena_textBox.ReadOnly = true;
            this.cena_textBox.Size = new System.Drawing.Size(55, 20);
            this.cena_textBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(29, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cena:";
            // 
            // nazwa_textBox
            // 
            this.nazwa_textBox.Location = new System.Drawing.Point(79, 116);
            this.nazwa_textBox.Name = "nazwa_textBox";
            this.nazwa_textBox.ReadOnly = true;
            this.nazwa_textBox.Size = new System.Drawing.Size(416, 20);
            this.nazwa_textBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(20, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nazwa: ";
            // 
            // opis_textBox
            // 
            this.opis_textBox.Location = new System.Drawing.Point(79, 157);
            this.opis_textBox.Multiline = true;
            this.opis_textBox.Name = "opis_textBox";
            this.opis_textBox.ReadOnly = true;
            this.opis_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.opis_textBox.Size = new System.Drawing.Size(434, 152);
            this.opis_textBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(28, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Opis: ";
            // 
            // but_wyszukaj
            // 
            this.but_wyszukaj.Location = new System.Drawing.Point(158, 331);
            this.but_wyszukaj.Name = "but_wyszukaj";
            this.but_wyszukaj.Size = new System.Drawing.Size(75, 23);
            this.but_wyszukaj.TabIndex = 9;
            this.but_wyszukaj.Text = "Wyszukaj";
            this.but_wyszukaj.UseVisualStyleBackColor = true;
            this.but_wyszukaj.Click += new System.EventHandler(this.but_wyszukaj_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(316, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Zapisz";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wyloguj
            // 
            this.wyloguj.Location = new System.Drawing.Point(419, 18);
            this.wyloguj.Name = "wyloguj";
            this.wyloguj.Size = new System.Drawing.Size(94, 36);
            this.wyloguj.TabIndex = 11;
            this.wyloguj.Text = "WYLOGUJ";
            this.wyloguj.UseVisualStyleBackColor = true;
            this.wyloguj.Click += new System.EventHandler(this.wyloguj_Click);
            // 
            // pracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 382);
            this.Controls.Add(this.wyloguj);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.but_wyszukaj);
            this.Controls.Add(this.opis_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nazwa_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cena_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ilosc_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ean_textBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "pracownik";
            this.Text = "pracownik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ean_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ilosc_textBox;
        private System.Windows.Forms.TextBox cena_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nazwa_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox opis_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button but_wyszukaj;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button wyloguj;
    }
}