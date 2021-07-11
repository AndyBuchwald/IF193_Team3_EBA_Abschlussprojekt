namespace Geometriemodul
{
    partial class Geometrierechner
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
            this.BtnGeoEinstellungen = new System.Windows.Forms.Button();
            this.BtnGeoSchliessen = new System.Windows.Forms.Button();
            this.BtnGeoParallelogramm = new System.Windows.Forms.Button();
            this.BtnGeoKreis = new System.Windows.Forms.Button();
            this.BtnGeoDreieck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGeoEinstellungen
            // 
            this.BtnGeoEinstellungen.Location = new System.Drawing.Point(393, 1);
            this.BtnGeoEinstellungen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGeoEinstellungen.Name = "BtnGeoEinstellungen";
            this.BtnGeoEinstellungen.Size = new System.Drawing.Size(43, 47);
            this.BtnGeoEinstellungen.TabIndex = 9;
            this.BtnGeoEinstellungen.Text = "⚙";
            this.BtnGeoEinstellungen.UseVisualStyleBackColor = true;
            this.BtnGeoEinstellungen.Click += new System.EventHandler(this.BtnGeoEinstellungen_Click);
            // 
            // BtnGeoSchliessen
            // 
            this.BtnGeoSchliessen.Location = new System.Drawing.Point(443, 1);
            this.BtnGeoSchliessen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGeoSchliessen.Name = "BtnGeoSchliessen";
            this.BtnGeoSchliessen.Size = new System.Drawing.Size(45, 47);
            this.BtnGeoSchliessen.TabIndex = 8;
            this.BtnGeoSchliessen.Text = "X";
            this.BtnGeoSchliessen.UseVisualStyleBackColor = true;
            this.BtnGeoSchliessen.Click += new System.EventHandler(this.BtnGeoSchliessen_Click);
            // 
            // BtnGeoParallelogramm
            // 
            this.BtnGeoParallelogramm.Location = new System.Drawing.Point(16, 250);
            this.BtnGeoParallelogramm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnGeoParallelogramm.Name = "BtnGeoParallelogramm";
            this.BtnGeoParallelogramm.Size = new System.Drawing.Size(263, 23);
            this.BtnGeoParallelogramm.TabIndex = 7;
            this.BtnGeoParallelogramm.Text = "Parallelogramm";
            this.BtnGeoParallelogramm.UseVisualStyleBackColor = true;
            this.BtnGeoParallelogramm.Click += new System.EventHandler(this.BtnGeoParallelogramm_Click);
            // 
            // BtnGeoKreis
            // 
            this.BtnGeoKreis.Location = new System.Drawing.Point(16, 186);
            this.BtnGeoKreis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGeoKreis.Name = "BtnGeoKreis";
            this.BtnGeoKreis.Size = new System.Drawing.Size(263, 28);
            this.BtnGeoKreis.TabIndex = 6;
            this.BtnGeoKreis.Text = "Kreis";
            this.BtnGeoKreis.UseVisualStyleBackColor = true;
            this.BtnGeoKreis.Click += new System.EventHandler(this.BtnGeoKreis_Click);
            // 
            // BtnGeoDreieck
            // 
            this.BtnGeoDreieck.Location = new System.Drawing.Point(16, 116);
            this.BtnGeoDreieck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnGeoDreieck.Name = "BtnGeoDreieck";
            this.BtnGeoDreieck.Size = new System.Drawing.Size(263, 28);
            this.BtnGeoDreieck.TabIndex = 5;
            this.BtnGeoDreieck.Text = "Dreieck";
            this.BtnGeoDreieck.UseVisualStyleBackColor = true;
            this.BtnGeoDreieck.Click += new System.EventHandler(this.BtnGeoDreieck_Click);
            // 
            // Geometrierechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 351);
            this.Controls.Add(this.BtnGeoEinstellungen);
            this.Controls.Add(this.BtnGeoSchliessen);
            this.Controls.Add(this.BtnGeoParallelogramm);
            this.Controls.Add(this.BtnGeoKreis);
            this.Controls.Add(this.BtnGeoDreieck);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Geometrierechner";
            this.Text = "Geometrierechner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnGeoEinstellungen;
        private System.Windows.Forms.Button BtnGeoSchliessen;
        private System.Windows.Forms.Button BtnGeoParallelogramm;
        private System.Windows.Forms.Button BtnGeoKreis;
        private System.Windows.Forms.Button BtnGeoDreieck;
    }
}