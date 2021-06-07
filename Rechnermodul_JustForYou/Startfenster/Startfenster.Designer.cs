namespace Rechnermodul_JustForYou
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAusgabe = new System.Windows.Forms.ListBox();
            this.LblStrModulauswahl = new System.Windows.Forms.Label();
            this.BtnStrInformatik = new System.Windows.Forms.Button();
            this.BtnStrProzentrechnung = new System.Windows.Forms.Button();
            this.BtnStrGeometrie = new System.Windows.Forms.Button();
            this.BtnStrGrundrechner = new System.Windows.Forms.Button();
            this.BtnStrBeenden = new System.Windows.Forms.Button();
            this.BtnStrLoeschen = new System.Windows.Forms.Button();
            this.BtnStrEinstellungen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAusgabe
            // 
            this.lbAusgabe.FormattingEnabled = true;
            this.lbAusgabe.Location = new System.Drawing.Point(141, 41);
            this.lbAusgabe.Name = "lbAusgabe";
            this.lbAusgabe.Size = new System.Drawing.Size(243, 121);
            this.lbAusgabe.TabIndex = 19;
            // 
            // LblStrModulauswahl
            // 
            this.LblStrModulauswahl.AutoSize = true;
            this.LblStrModulauswahl.Location = new System.Drawing.Point(11, 39);
            this.LblStrModulauswahl.Name = "LblStrModulauswahl";
            this.LblStrModulauswahl.Size = new System.Drawing.Size(75, 13);
            this.LblStrModulauswahl.TabIndex = 18;
            this.LblStrModulauswahl.Text = "Modulauswahl";
            // 
            // BtnStrInformatik
            // 
            this.BtnStrInformatik.Location = new System.Drawing.Point(14, 142);
            this.BtnStrInformatik.Name = "BtnStrInformatik";
            this.BtnStrInformatik.Size = new System.Drawing.Size(110, 23);
            this.BtnStrInformatik.TabIndex = 17;
            this.BtnStrInformatik.Text = "Informatik";
            this.BtnStrInformatik.UseVisualStyleBackColor = true;
            this.BtnStrInformatik.Click += new System.EventHandler(this.btnInformatik_Click);
            // 
            // BtnStrProzentrechnung
            // 
            this.BtnStrProzentrechnung.Location = new System.Drawing.Point(14, 113);
            this.BtnStrProzentrechnung.Name = "BtnStrProzentrechnung";
            this.BtnStrProzentrechnung.Size = new System.Drawing.Size(110, 23);
            this.BtnStrProzentrechnung.TabIndex = 16;
            this.BtnStrProzentrechnung.Text = "Prozentrechnung";
            this.BtnStrProzentrechnung.UseVisualStyleBackColor = true;
            // 
            // BtnStrGeometrie
            // 
            this.BtnStrGeometrie.Location = new System.Drawing.Point(14, 84);
            this.BtnStrGeometrie.Name = "BtnStrGeometrie";
            this.BtnStrGeometrie.Size = new System.Drawing.Size(110, 23);
            this.BtnStrGeometrie.TabIndex = 15;
            this.BtnStrGeometrie.Text = "Geometrie";
            this.BtnStrGeometrie.UseVisualStyleBackColor = true;
            // 
            // BtnStrGrundrechner
            // 
            this.BtnStrGrundrechner.Location = new System.Drawing.Point(14, 55);
            this.BtnStrGrundrechner.Name = "BtnStrGrundrechner";
            this.BtnStrGrundrechner.Size = new System.Drawing.Size(110, 23);
            this.BtnStrGrundrechner.TabIndex = 14;
            this.BtnStrGrundrechner.Text = "Grundrechner";
            this.BtnStrGrundrechner.UseVisualStyleBackColor = true;
            // 
            // BtnStrBeenden
            // 
            this.BtnStrBeenden.Location = new System.Drawing.Point(271, 13);
            this.BtnStrBeenden.Name = "BtnStrBeenden";
            this.BtnStrBeenden.Size = new System.Drawing.Size(113, 23);
            this.BtnStrBeenden.TabIndex = 13;
            this.BtnStrBeenden.Text = "Beenden";
            this.BtnStrBeenden.UseVisualStyleBackColor = true;
            // 
            // BtnStrLoeschen
            // 
            this.BtnStrLoeschen.Location = new System.Drawing.Point(141, 13);
            this.BtnStrLoeschen.Name = "BtnStrLoeschen";
            this.BtnStrLoeschen.Size = new System.Drawing.Size(113, 23);
            this.BtnStrLoeschen.TabIndex = 12;
            this.BtnStrLoeschen.Text = "Ausgabe löschen";
            this.BtnStrLoeschen.UseVisualStyleBackColor = true;
            // 
            // BtnStrEinstellungen
            // 
            this.BtnStrEinstellungen.Location = new System.Drawing.Point(11, 13);
            this.BtnStrEinstellungen.Name = "BtnStrEinstellungen";
            this.BtnStrEinstellungen.Size = new System.Drawing.Size(113, 23);
            this.BtnStrEinstellungen.TabIndex = 11;
            this.BtnStrEinstellungen.Text = "Einstellungen";
            this.BtnStrEinstellungen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 179);
            this.Controls.Add(this.lbAusgabe);
            this.Controls.Add(this.LblStrModulauswahl);
            this.Controls.Add(this.BtnStrInformatik);
            this.Controls.Add(this.BtnStrProzentrechnung);
            this.Controls.Add(this.BtnStrGeometrie);
            this.Controls.Add(this.BtnStrGrundrechner);
            this.Controls.Add(this.BtnStrBeenden);
            this.Controls.Add(this.BtnStrLoeschen);
            this.Controls.Add(this.BtnStrEinstellungen);
            this.Name = "Form1";
            this.Text = "Rechnermodul \"JustForYou\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAusgabe;
        private System.Windows.Forms.Label LblStrModulauswahl;
        private System.Windows.Forms.Button BtnStrInformatik;
        private System.Windows.Forms.Button BtnStrProzentrechnung;
        private System.Windows.Forms.Button BtnStrGeometrie;
        private System.Windows.Forms.Button BtnStrGrundrechner;
        private System.Windows.Forms.Button BtnStrBeenden;
        private System.Windows.Forms.Button BtnStrLoeschen;
        private System.Windows.Forms.Button BtnStrEinstellungen;
    }
}

