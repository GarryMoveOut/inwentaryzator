namespace inwentaryzator
{
    partial class Logowanie
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda wsparcia projektanta - nie należy modyfikować
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_login = new System.Windows.Forms.Button();
            this.textbox_login = new System.Windows.Forms.TextBox();
            this.textbox_haslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(72, 130);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(125, 45);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Loguj";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // textbox_login
            // 
            this.textbox_login.Location = new System.Drawing.Point(108, 45);
            this.textbox_login.Name = "textbox_login";
            this.textbox_login.Size = new System.Drawing.Size(125, 20);
            this.textbox_login.TabIndex = 2;
            // 
            // textbox_haslo
            // 
            this.textbox_haslo.Location = new System.Drawing.Point(108, 80);
            this.textbox_haslo.Name = "textbox_haslo";
            this.textbox_haslo.PasswordChar = '*';
            this.textbox_haslo.Size = new System.Drawing.Size(125, 20);
            this.textbox_haslo.TabIndex = 3;
            this.textbox_haslo.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasło:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Witaj! Wpisz login i hasło aby zalogować się do aplikacji";
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 212);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox_haslo);
            this.Controls.Add(this.textbox_login);
            this.Controls.Add(this.button_login);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Logowanie";
            this.Text = "Inwentaryzator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textbox_login;
        private System.Windows.Forms.TextBox textbox_haslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

