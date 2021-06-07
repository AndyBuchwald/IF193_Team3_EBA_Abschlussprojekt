namespace Informatikmodul
{
    partial class Informatikrechner
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
            this.BtnInfPraefixumrechnung = new System.Windows.Forms.Button();
            this.BtnInfZahlensystemumrechnung = new System.Windows.Forms.Button();
            this.BtnInfGrafikspeichergroeße = new System.Windows.Forms.Button();
            this.BtnInfEinstellungen = new System.Windows.Forms.Button();
            this.BtnInfSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInfPraefixumrechnung
            // 
            this.BtnInfPraefixumrechnung.Location = new System.Drawing.Point(325, 264);
            this.BtnInfPraefixumrechnung.Name = "BtnInfPraefixumrechnung";
            this.BtnInfPraefixumrechnung.Size = new System.Drawing.Size(151, 23);
            this.BtnInfPraefixumrechnung.TabIndex = 11;
            this.BtnInfPraefixumrechnung.Text = "Präfixumrechnung";
            this.BtnInfPraefixumrechnung.UseVisualStyleBackColor = true;
            // 
            // BtnInfZahlensystemumrechnung
            // 
            this.BtnInfZahlensystemumrechnung.Location = new System.Drawing.Point(325, 235);
            this.BtnInfZahlensystemumrechnung.Name = "BtnInfZahlensystemumrechnung";
            this.BtnInfZahlensystemumrechnung.Size = new System.Drawing.Size(151, 23);
            this.BtnInfZahlensystemumrechnung.TabIndex = 10;
            this.BtnInfZahlensystemumrechnung.Text = "Zahlensystemumrechnung";
            this.BtnInfZahlensystemumrechnung.UseVisualStyleBackColor = true;
            // 
            // BtnInfGrafikspeichergroeße
            // 
            this.BtnInfGrafikspeichergroeße.Location = new System.Drawing.Point(325, 206);
            this.BtnInfGrafikspeichergroeße.Name = "BtnInfGrafikspeichergroeße";
            this.BtnInfGrafikspeichergroeße.Size = new System.Drawing.Size(151, 23);
            this.BtnInfGrafikspeichergroeße.TabIndex = 9;
            this.BtnInfGrafikspeichergroeße.Text = "Grafikspeichergröße";
            this.BtnInfGrafikspeichergroeße.UseVisualStyleBackColor = true;
            // 
            // BtnInfEinstellungen
            // 
            this.BtnInfEinstellungen.Location = new System.Drawing.Point(405, 164);
            this.BtnInfEinstellungen.Name = "BtnInfEinstellungen";
            this.BtnInfEinstellungen.Size = new System.Drawing.Size(33, 23);
            this.BtnInfEinstellungen.TabIndex = 8;
            this.BtnInfEinstellungen.Text = "⚙";
            this.BtnInfEinstellungen.UseVisualStyleBackColor = true;
            // 
            // BtnInfSchliessen
            // 
            this.BtnInfSchliessen.Location = new System.Drawing.Point(443, 164);
            this.BtnInfSchliessen.Name = "BtnInfSchliessen";
            this.BtnInfSchliessen.Size = new System.Drawing.Size(33, 23);
            this.BtnInfSchliessen.TabIndex = 7;
            this.BtnInfSchliessen.Text = "X";
            this.BtnInfSchliessen.UseVisualStyleBackColor = true;
            // 
            // Informatikrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnInfPraefixumrechnung);
            this.Controls.Add(this.BtnInfZahlensystemumrechnung);
            this.Controls.Add(this.BtnInfGrafikspeichergroeße);
            this.Controls.Add(this.BtnInfEinstellungen);
            this.Controls.Add(this.BtnInfSchliessen);
            this.Name = "Informatikrechner";
            this.Text = "Informatikrechner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInfPraefixumrechnung;
        private System.Windows.Forms.Button BtnInfZahlensystemumrechnung;
        private System.Windows.Forms.Button BtnInfGrafikspeichergroeße;
        private System.Windows.Forms.Button BtnInfEinstellungen;
        private System.Windows.Forms.Button BtnInfSchliessen;
    }
}