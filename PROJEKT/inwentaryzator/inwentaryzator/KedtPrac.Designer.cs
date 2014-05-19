namespace inwentaryzator
{
    partial class KedtPrac
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
            this.cbox_Uprawnienia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_Imie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_Nazwisko = new System.Windows.Forms.TextBox();
            this.txtbox_login = new System.Windows.Forms.TextBox();
            this.txtbox_Haslo = new System.Windows.Forms.TextBox();
            this.txtbox_info = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dodaj_but = new System.Windows.Forms.Button();
            this.usun_but = new System.Windows.Forms.Button();
            this.wyszukaj_but = new System.Windows.Forms.Button();
            this.zapisz_but = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbox_Uprawnienia
            // 
            this.cbox_Uprawnienia.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbox_Uprawnienia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Uprawnienia.FormattingEnabled = true;
            this.cbox_Uprawnienia.Location = new System.Drawing.Point(187, 127);
            this.cbox_Uprawnienia.MaxDropDownItems = 3;
            this.cbox_Uprawnienia.Name = "cbox_Uprawnienia";
            this.cbox_Uprawnienia.Size = new System.Drawing.Size(155, 21);
            this.cbox_Uprawnienia.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imie:";
            // 
            // txtbox_Imie
            // 
            this.txtbox_Imie.Location = new System.Drawing.Point(62, 53);
            this.txtbox_Imie.Name = "txtbox_Imie";
            this.txtbox_Imie.Size = new System.Drawing.Size(119, 20);
            this.txtbox_Imie.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Login:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Haslo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Informacje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Uprawnienia: ";
            // 
            // txtbox_Nazwisko
            // 
            this.txtbox_Nazwisko.Location = new System.Drawing.Point(300, 53);
            this.txtbox_Nazwisko.Name = "txtbox_Nazwisko";
            this.txtbox_Nazwisko.Size = new System.Drawing.Size(142, 20);
            this.txtbox_Nazwisko.TabIndex = 7;
            // 
            // txtbox_login
            // 
            this.txtbox_login.Location = new System.Drawing.Point(62, 85);
            this.txtbox_login.Name = "txtbox_login";
            this.txtbox_login.Size = new System.Drawing.Size(119, 20);
            this.txtbox_login.TabIndex = 8;
            // 
            // txtbox_Haslo
            // 
            this.txtbox_Haslo.Location = new System.Drawing.Point(300, 85);
            this.txtbox_Haslo.Name = "txtbox_Haslo";
            this.txtbox_Haslo.Size = new System.Drawing.Size(142, 20);
            this.txtbox_Haslo.TabIndex = 9;
            this.txtbox_Haslo.UseSystemPasswordChar = true;
            // 
            // txtbox_info
            // 
            this.txtbox_info.Location = new System.Drawing.Point(30, 194);
            this.txtbox_info.Multiline = true;
            this.txtbox_info.Name = "txtbox_info";
            this.txtbox_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_info.Size = new System.Drawing.Size(412, 120);
            this.txtbox_info.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "WSTECZ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodaj_but
            // 
            this.dodaj_but.Location = new System.Drawing.Point(30, 344);
            this.dodaj_but.Name = "dodaj_but";
            this.dodaj_but.Size = new System.Drawing.Size(75, 23);
            this.dodaj_but.TabIndex = 13;
            this.dodaj_but.Text = "Dodaj";
            this.dodaj_but.UseVisualStyleBackColor = true;
            this.dodaj_but.Click += new System.EventHandler(this.dodaj_but_Click);
            // 
            // usun_but
            // 
            this.usun_but.Location = new System.Drawing.Point(141, 344);
            this.usun_but.Name = "usun_but";
            this.usun_but.Size = new System.Drawing.Size(75, 23);
            this.usun_but.TabIndex = 14;
            this.usun_but.Text = "Usuń";
            this.usun_but.UseVisualStyleBackColor = true;
            this.usun_but.Click += new System.EventHandler(this.usun_but_Click);
            // 
            // wyszukaj_but
            // 
            this.wyszukaj_but.Location = new System.Drawing.Point(367, 344);
            this.wyszukaj_but.Name = "wyszukaj_but";
            this.wyszukaj_but.Size = new System.Drawing.Size(75, 23);
            this.wyszukaj_but.TabIndex = 15;
            this.wyszukaj_but.Text = "Wyszukaj";
            this.wyszukaj_but.UseVisualStyleBackColor = true;
            this.wyszukaj_but.Click += new System.EventHandler(this.wyszukaj_but_Click);
            // 
            // zapisz_but
            // 
            this.zapisz_but.Location = new System.Drawing.Point(255, 344);
            this.zapisz_but.Name = "zapisz_but";
            this.zapisz_but.Size = new System.Drawing.Size(75, 23);
            this.zapisz_but.TabIndex = 16;
            this.zapisz_but.Text = "Zapisz";
            this.zapisz_but.UseVisualStyleBackColor = true;
            this.zapisz_but.Click += new System.EventHandler(this.zapisz_but_Click);
            // 
            // KedtPrac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 392);
            this.Controls.Add(this.zapisz_but);
            this.Controls.Add(this.wyszukaj_but);
            this.Controls.Add(this.usun_but);
            this.Controls.Add(this.dodaj_but);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbox_Uprawnienia);
            this.Controls.Add(this.txtbox_info);
            this.Controls.Add(this.txtbox_Haslo);
            this.Controls.Add(this.txtbox_login);
            this.Controls.Add(this.txtbox_Nazwisko);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_Imie);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KedtPrac";
            this.Text = "Inwentaryzator: Kierownik: Edytuj pracowników";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_Imie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_Nazwisko;
        private System.Windows.Forms.TextBox txtbox_login;
        private System.Windows.Forms.TextBox txtbox_Haslo;
        private System.Windows.Forms.TextBox txtbox_info;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dodaj_but;
        private System.Windows.Forms.Button usun_but;
        private System.Windows.Forms.Button wyszukaj_but;
        private System.Windows.Forms.Button zapisz_but;
        private System.Windows.Forms.ComboBox cbox_Uprawnienia;
    }
}