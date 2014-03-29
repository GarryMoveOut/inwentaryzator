namespace inwentaryzator
{
    partial class wKierownik
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
            this.but_edt_pracownikow = new System.Windows.Forms.Button();
            this.but_edt_prod = new System.Windows.Forms.Button();
            this.but_wyloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_edt_pracownikow
            // 
            this.but_edt_pracownikow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.but_edt_pracownikow.Location = new System.Drawing.Point(67, 47);
            this.but_edt_pracownikow.Name = "but_edt_pracownikow";
            this.but_edt_pracownikow.Size = new System.Drawing.Size(150, 45);
            this.but_edt_pracownikow.TabIndex = 0;
            this.but_edt_pracownikow.Text = "Edytuj pracowników";
            this.but_edt_pracownikow.UseVisualStyleBackColor = true;
            this.but_edt_pracownikow.Click += new System.EventHandler(this.but_edt_pracownikow_Click);
            // 
            // but_edt_prod
            // 
            this.but_edt_prod.Location = new System.Drawing.Point(67, 114);
            this.but_edt_prod.Name = "but_edt_prod";
            this.but_edt_prod.Size = new System.Drawing.Size(150, 40);
            this.but_edt_prod.TabIndex = 1;
            this.but_edt_prod.Text = "Edytuj produkty";
            this.but_edt_prod.UseVisualStyleBackColor = true;
            this.but_edt_prod.Click += new System.EventHandler(this.but_edt_prod_Click);
            // 
            // but_wyloguj
            // 
            this.but_wyloguj.Location = new System.Drawing.Point(101, 184);
            this.but_wyloguj.Name = "but_wyloguj";
            this.but_wyloguj.Size = new System.Drawing.Size(75, 23);
            this.but_wyloguj.TabIndex = 2;
            this.but_wyloguj.Text = "WYLOGUJ";
            this.but_wyloguj.UseVisualStyleBackColor = true;
            this.but_wyloguj.Click += new System.EventHandler(this.but_wyloguj_Click);
            // 
            // wKierownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.but_wyloguj);
            this.Controls.Add(this.but_edt_prod);
            this.Controls.Add(this.but_edt_pracownikow);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wKierownik";
            this.Text = "Inwentaryzator: Kierownik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_edt_pracownikow;
        private System.Windows.Forms.Button but_edt_prod;
        private System.Windows.Forms.Button but_wyloguj;
    }
}