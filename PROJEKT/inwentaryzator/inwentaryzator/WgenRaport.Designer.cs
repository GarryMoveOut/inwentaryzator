namespace inwentaryzator
{
    partial class WgenRaport
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
            this.label_raport = new System.Windows.Forms.Label();
            this.combox_raport = new System.Windows.Forms.ComboBox();
            this.but_wysRaport = new System.Windows.Forms.Button();
            this.but_eksportXML = new System.Windows.Forms.Button();
            this.but_wyloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_raport
            // 
            this.label_raport.AutoSize = true;
            this.label_raport.Location = new System.Drawing.Point(40, 68);
            this.label_raport.Name = "label_raport";
            this.label_raport.Size = new System.Drawing.Size(42, 13);
            this.label_raport.TabIndex = 0;
            this.label_raport.Text = "Raport:";
            // 
            // combox_raport
            // 
            this.combox_raport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_raport.FormattingEnabled = true;
            this.combox_raport.Location = new System.Drawing.Point(43, 84);
            this.combox_raport.Name = "combox_raport";
            this.combox_raport.Size = new System.Drawing.Size(166, 21);
            this.combox_raport.TabIndex = 1;
            // 
            // but_wysRaport
            // 
            this.but_wysRaport.Location = new System.Drawing.Point(43, 130);
            this.but_wysRaport.Name = "but_wysRaport";
            this.but_wysRaport.Size = new System.Drawing.Size(166, 40);
            this.but_wysRaport.TabIndex = 2;
            this.but_wysRaport.Text = "Wyświetl";
            this.but_wysRaport.UseVisualStyleBackColor = true;
            // 
            // but_eksportXML
            // 
            this.but_eksportXML.Location = new System.Drawing.Point(43, 195);
            this.but_eksportXML.Name = "but_eksportXML";
            this.but_eksportXML.Size = new System.Drawing.Size(166, 40);
            this.but_eksportXML.TabIndex = 3;
            this.but_eksportXML.Text = "Eksportuj do XML";
            this.but_eksportXML.UseVisualStyleBackColor = true;
            // 
            // but_wyloguj
            // 
            this.but_wyloguj.Location = new System.Drawing.Point(13, 13);
            this.but_wyloguj.Name = "but_wyloguj";
            this.but_wyloguj.Size = new System.Drawing.Size(95, 35);
            this.but_wyloguj.TabIndex = 4;
            this.but_wyloguj.Text = "Wyloguj";
            this.but_wyloguj.UseVisualStyleBackColor = true;
            this.but_wyloguj.Click += new System.EventHandler(this.but_wyloguj_Click);
            // 
            // WgenRaport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 262);
            this.Controls.Add(this.but_wyloguj);
            this.Controls.Add(this.but_eksportXML);
            this.Controls.Add(this.but_wysRaport);
            this.Controls.Add(this.combox_raport);
            this.Controls.Add(this.label_raport);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WgenRaport";
            this.Text = "Inwentaryzator: Właściciel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_raport;
        private System.Windows.Forms.ComboBox combox_raport;
        private System.Windows.Forms.Button but_wysRaport;
        private System.Windows.Forms.Button but_eksportXML;
        private System.Windows.Forms.Button but_wyloguj;
    }
}