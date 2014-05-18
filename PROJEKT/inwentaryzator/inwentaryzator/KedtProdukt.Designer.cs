namespace inwentaryzator
{
    partial class KedtProdukt
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
            this.BUT_usnProd = new System.Windows.Forms.Button();
            this.BUT_dodajProd = new System.Windows.Forms.Button();
            this.txtbox_ean = new System.Windows.Forms.TextBox();
            this.txtbox_cena = new System.Windows.Forms.TextBox();
            this.txtbox_nazwa = new System.Windows.Forms.TextBox();
            this.txtbox_ilosc = new System.Windows.Forms.TextBox();
            this.txtbox_opis = new System.Windows.Forms.TextBox();
            this.EAN_label = new System.Windows.Forms.Label();
            this.label_cena = new System.Windows.Forms.Label();
            this.label_nazwa = new System.Windows.Forms.Label();
            this.label_opis = new System.Windows.Forms.Label();
            this.label_ilosc = new System.Windows.Forms.Label();
            this.BUT_wyszukaj = new System.Windows.Forms.Button();
            this.BUT_zapisz = new System.Windows.Forms.Button();
            this.BUT_wstecz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BUT_usnProd
            // 
            this.BUT_usnProd.Location = new System.Drawing.Point(144, 340);
            this.BUT_usnProd.Name = "BUT_usnProd";
            this.BUT_usnProd.Size = new System.Drawing.Size(100, 23);
            this.BUT_usnProd.TabIndex = 0;
            this.BUT_usnProd.Text = "Usuń produkt";
            this.BUT_usnProd.UseVisualStyleBackColor = true;
            this.BUT_usnProd.Click += new System.EventHandler(this.BUT_usnProd_Click);
            // 
            // BUT_dodajProd
            // 
            this.BUT_dodajProd.Location = new System.Drawing.Point(20, 340);
            this.BUT_dodajProd.Name = "BUT_dodajProd";
            this.BUT_dodajProd.Size = new System.Drawing.Size(100, 23);
            this.BUT_dodajProd.TabIndex = 1;
            this.BUT_dodajProd.Text = "Dodaj produkt";
            this.BUT_dodajProd.UseVisualStyleBackColor = true;
            // 
            // txtbox_ean
            // 
            this.txtbox_ean.Location = new System.Drawing.Point(73, 70);
            this.txtbox_ean.Name = "txtbox_ean";
            this.txtbox_ean.Size = new System.Drawing.Size(90, 20);
            this.txtbox_ean.TabIndex = 2;
            // 
            // txtbox_cena
            // 
            this.txtbox_cena.Location = new System.Drawing.Point(73, 106);
            this.txtbox_cena.Name = "txtbox_cena";
            this.txtbox_cena.Size = new System.Drawing.Size(90, 20);
            this.txtbox_cena.TabIndex = 3;
            // 
            // txtbox_nazwa
            // 
            this.txtbox_nazwa.Location = new System.Drawing.Point(72, 142);
            this.txtbox_nazwa.Name = "txtbox_nazwa";
            this.txtbox_nazwa.Size = new System.Drawing.Size(377, 20);
            this.txtbox_nazwa.TabIndex = 4;
            // 
            // txtbox_ilosc
            // 
            this.txtbox_ilosc.Location = new System.Drawing.Point(349, 70);
            this.txtbox_ilosc.Name = "txtbox_ilosc";
            this.txtbox_ilosc.Size = new System.Drawing.Size(100, 20);
            this.txtbox_ilosc.TabIndex = 5;
            // 
            // txtbox_opis
            // 
            this.txtbox_opis.Location = new System.Drawing.Point(73, 182);
            this.txtbox_opis.Multiline = true;
            this.txtbox_opis.Name = "txtbox_opis";
            this.txtbox_opis.Size = new System.Drawing.Size(376, 128);
            this.txtbox_opis.TabIndex = 6;
            // 
            // EAN_label
            // 
            this.EAN_label.AutoSize = true;
            this.EAN_label.Location = new System.Drawing.Point(19, 73);
            this.EAN_label.Name = "EAN_label";
            this.EAN_label.Size = new System.Drawing.Size(47, 13);
            this.EAN_label.TabIndex = 7;
            this.EAN_label.Text = "EAN-13:";
            // 
            // label_cena
            // 
            this.label_cena.AutoSize = true;
            this.label_cena.Location = new System.Drawing.Point(31, 109);
            this.label_cena.Name = "label_cena";
            this.label_cena.Size = new System.Drawing.Size(35, 13);
            this.label_cena.TabIndex = 8;
            this.label_cena.Text = "Cena:";
            // 
            // label_nazwa
            // 
            this.label_nazwa.AutoSize = true;
            this.label_nazwa.Location = new System.Drawing.Point(23, 145);
            this.label_nazwa.Name = "label_nazwa";
            this.label_nazwa.Size = new System.Drawing.Size(43, 13);
            this.label_nazwa.TabIndex = 9;
            this.label_nazwa.Text = "Nazwa:";
            // 
            // label_opis
            // 
            this.label_opis.AutoSize = true;
            this.label_opis.Location = new System.Drawing.Point(35, 185);
            this.label_opis.Name = "label_opis";
            this.label_opis.Size = new System.Drawing.Size(31, 13);
            this.label_opis.TabIndex = 10;
            this.label_opis.Text = "Opis:";
            // 
            // label_ilosc
            // 
            this.label_ilosc.AutoSize = true;
            this.label_ilosc.Location = new System.Drawing.Point(311, 73);
            this.label_ilosc.Name = "label_ilosc";
            this.label_ilosc.Size = new System.Drawing.Size(32, 13);
            this.label_ilosc.TabIndex = 11;
            this.label_ilosc.Text = "Ilość:";
            // 
            // BUT_wyszukaj
            // 
            this.BUT_wyszukaj.Location = new System.Drawing.Point(374, 340);
            this.BUT_wyszukaj.Name = "BUT_wyszukaj";
            this.BUT_wyszukaj.Size = new System.Drawing.Size(75, 23);
            this.BUT_wyszukaj.TabIndex = 12;
            this.BUT_wyszukaj.Text = "Wyszukaj";
            this.BUT_wyszukaj.UseVisualStyleBackColor = true;
            this.BUT_wyszukaj.Click += new System.EventHandler(this.BUT_wyszukaj_Click);
            // 
            // BUT_zapisz
            // 
            this.BUT_zapisz.Location = new System.Drawing.Point(275, 340);
            this.BUT_zapisz.Name = "BUT_zapisz";
            this.BUT_zapisz.Size = new System.Drawing.Size(75, 23);
            this.BUT_zapisz.TabIndex = 13;
            this.BUT_zapisz.Text = "Zapisz";
            this.BUT_zapisz.UseVisualStyleBackColor = true;
            this.BUT_zapisz.Click += new System.EventHandler(this.BUT_zapisz_Click);
            // 
            // BUT_wstecz
            // 
            this.BUT_wstecz.Location = new System.Drawing.Point(20, 12);
            this.BUT_wstecz.Name = "BUT_wstecz";
            this.BUT_wstecz.Size = new System.Drawing.Size(98, 31);
            this.BUT_wstecz.TabIndex = 14;
            this.BUT_wstecz.Text = "WSTECZ";
            this.BUT_wstecz.UseVisualStyleBackColor = true;
            this.BUT_wstecz.Click += new System.EventHandler(this.BUT_wstecz_Click);
            // 
            // KedtProdukt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 392);
            this.Controls.Add(this.BUT_wstecz);
            this.Controls.Add(this.BUT_zapisz);
            this.Controls.Add(this.BUT_wyszukaj);
            this.Controls.Add(this.label_ilosc);
            this.Controls.Add(this.label_opis);
            this.Controls.Add(this.label_nazwa);
            this.Controls.Add(this.label_cena);
            this.Controls.Add(this.EAN_label);
            this.Controls.Add(this.txtbox_opis);
            this.Controls.Add(this.txtbox_ilosc);
            this.Controls.Add(this.txtbox_nazwa);
            this.Controls.Add(this.txtbox_cena);
            this.Controls.Add(this.txtbox_ean);
            this.Controls.Add(this.BUT_dodajProd);
            this.Controls.Add(this.BUT_usnProd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KedtProdukt";
            this.Text = "KedtProdukt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BUT_usnProd;
        private System.Windows.Forms.Button BUT_dodajProd;
        private System.Windows.Forms.TextBox txtbox_ean;
        private System.Windows.Forms.TextBox txtbox_cena;
        private System.Windows.Forms.TextBox txtbox_nazwa;
        private System.Windows.Forms.TextBox txtbox_ilosc;
        private System.Windows.Forms.TextBox txtbox_opis;
        private System.Windows.Forms.Label EAN_label;
        private System.Windows.Forms.Label label_cena;
        private System.Windows.Forms.Label label_nazwa;
        private System.Windows.Forms.Label label_opis;
        private System.Windows.Forms.Label label_ilosc;
        private System.Windows.Forms.Button BUT_wyszukaj;
        private System.Windows.Forms.Button BUT_zapisz;
        private System.Windows.Forms.Button BUT_wstecz;
    }
}