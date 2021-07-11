namespace Prozentrechner
{
    partial class Prozentrechner
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
            this.BtnProEinstellungen = new System.Windows.Forms.Button();
            this.BtnProSchliessen = new System.Windows.Forms.Button();
            this.BtnProNetto = new System.Windows.Forms.Button();
            this.BtnProBrutto = new System.Windows.Forms.Button();
            this.BtnProSatz = new System.Windows.Forms.Button();
            this.BtnProVon = new System.Windows.Forms.Button();
            this.BtnProWeg = new System.Windows.Forms.Button();
            this.BtnProDazu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProEinstellungen
            // 
            this.BtnProEinstellungen.Location = new System.Drawing.Point(640, 116);
            this.BtnProEinstellungen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProEinstellungen.Name = "BtnProEinstellungen";
            this.BtnProEinstellungen.Size = new System.Drawing.Size(45, 47);
            this.BtnProEinstellungen.TabIndex = 15;
            this.BtnProEinstellungen.Text = "⚙";
            this.BtnProEinstellungen.UseVisualStyleBackColor = true;
            // 
            // BtnProSchliessen
            // 
            this.BtnProSchliessen.Location = new System.Drawing.Point(707, 116);
            this.BtnProSchliessen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProSchliessen.Name = "BtnProSchliessen";
            this.BtnProSchliessen.Size = new System.Drawing.Size(45, 47);
            this.BtnProSchliessen.TabIndex = 14;
            this.BtnProSchliessen.Text = "X";
            this.BtnProSchliessen.UseVisualStyleBackColor = true;
            // 
            // BtnProNetto
            // 
            this.BtnProNetto.Location = new System.Drawing.Point(315, 415);
            this.BtnProNetto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProNetto.Name = "BtnProNetto";
            this.BtnProNetto.Size = new System.Drawing.Size(141, 23);
            this.BtnProNetto.TabIndex = 13;
            this.BtnProNetto.Text = "Netto aus Brutto";
            this.BtnProNetto.UseVisualStyleBackColor = true;
            // 
            // BtnProBrutto
            // 
            this.BtnProBrutto.Location = new System.Drawing.Point(315, 373);
            this.BtnProBrutto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProBrutto.Name = "BtnProBrutto";
            this.BtnProBrutto.Size = new System.Drawing.Size(141, 23);
            this.BtnProBrutto.TabIndex = 12;
            this.BtnProBrutto.Text = "Brutto aus Netto";
            this.BtnProBrutto.UseVisualStyleBackColor = true;
            // 
            // BtnProSatz
            // 
            this.BtnProSatz.Location = new System.Drawing.Point(315, 331);
            this.BtnProSatz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProSatz.Name = "BtnProSatz";
            this.BtnProSatz.Size = new System.Drawing.Size(141, 23);
            this.BtnProSatz.TabIndex = 11;
            this.BtnProSatz.Text = "Prozentsatz";
            this.BtnProSatz.UseVisualStyleBackColor = true;
            // 
            // BtnProVon
            // 
            this.BtnProVon.Location = new System.Drawing.Point(315, 283);
            this.BtnProVon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProVon.Name = "BtnProVon";
            this.BtnProVon.Size = new System.Drawing.Size(141, 23);
            this.BtnProVon.TabIndex = 10;
            this.BtnProVon.Text = "Prozent von";
            this.BtnProVon.UseVisualStyleBackColor = true;
            // 
            // BtnProWeg
            // 
            this.BtnProWeg.Location = new System.Drawing.Point(315, 236);
            this.BtnProWeg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProWeg.Name = "BtnProWeg";
            this.BtnProWeg.Size = new System.Drawing.Size(141, 23);
            this.BtnProWeg.TabIndex = 9;
            this.BtnProWeg.Text = "Prozent weg";
            this.BtnProWeg.UseVisualStyleBackColor = true;
            // 
            // BtnProDazu
            // 
            this.BtnProDazu.Location = new System.Drawing.Point(315, 194);
            this.BtnProDazu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProDazu.Name = "BtnProDazu";
            this.BtnProDazu.Size = new System.Drawing.Size(141, 23);
            this.BtnProDazu.TabIndex = 8;
            this.BtnProDazu.Text = "Prozent dazu ";
            this.BtnProDazu.UseVisualStyleBackColor = true;
            // 
            // Prozentrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnProEinstellungen);
            this.Controls.Add(this.BtnProSchliessen);
            this.Controls.Add(this.BtnProNetto);
            this.Controls.Add(this.BtnProBrutto);
            this.Controls.Add(this.BtnProSatz);
            this.Controls.Add(this.BtnProVon);
            this.Controls.Add(this.BtnProWeg);
            this.Controls.Add(this.BtnProDazu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Prozentrechner";
            this.Text = "Prozentrechner";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProEinstellungen;
        private System.Windows.Forms.Button BtnProSchliessen;
        private System.Windows.Forms.Button BtnProNetto;
        private System.Windows.Forms.Button BtnProBrutto;
        private System.Windows.Forms.Button BtnProSatz;
        private System.Windows.Forms.Button BtnProVon;
        private System.Windows.Forms.Button BtnProWeg;
        private System.Windows.Forms.Button BtnProDazu;
    }
}