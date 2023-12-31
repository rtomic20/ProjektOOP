using System.Windows.Forms;
using System;
using ProjektOOP.Forme;
namespace ProjektOOP.Forme
{
    partial class FormaZaUnosNaloga2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            DugmeDodaj = new Button();
            SuspendLayout();
            // 
            // DugmeDodaj
            // 
            DugmeDodaj.Location = new Point(318, 434);
            DugmeDodaj.Name = "DugmeDodaj";
            DugmeDodaj.Size = new Size(75, 23);
            DugmeDodaj.TabIndex = 0;
            DugmeDodaj.Text = "Dodaj Element";
            DugmeDodaj.Click += DodajElementUBazu;
            // 
            // FormaZaUnosNaloga2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 564);
            Controls.Add(DugmeDodaj);
            ForeColor = SystemColors.Highlight;
            MaximizeBox = false;
            Name = "FormaZaUnosNaloga2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unos Naloga";
            ResumeLayout(false);
        }

        private void DodajElementUBazu(object sender, EventArgs e)
        {
           
        }
        #endregion
        private System.Windows.Forms.Button DugmeDodaj;
    }
}