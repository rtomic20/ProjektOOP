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
            PrikazInformacija = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PrikazInformacija).BeginInit();
            SuspendLayout();
            // 
            // DugmeDodaj
            // 
            DugmeDodaj.Location = new Point(649, 490);
            DugmeDodaj.Name = "DugmeDodaj";
            DugmeDodaj.Size = new Size(75, 23);
            DugmeDodaj.TabIndex = 0;
            DugmeDodaj.Text = "Dodaj Element";
            DugmeDodaj.Click += DodajElementUBazu;
            // 
            // PrikazInformacija
            // 
            PrikazInformacija.Location = new Point(12, 70);
            PrikazInformacija.Name = "PrikazInformacija";
            PrikazInformacija.Size = new Size(776, 392);
            PrikazInformacija.TabIndex = 1;
            // 
            // FormaZaUnosNaloga2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 564);
            Controls.Add(DugmeDodaj);
            Controls.Add(PrikazInformacija);
            ForeColor = SystemColors.Highlight;
            MaximizeBox = false;
            Name = "FormaZaUnosNaloga2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ispis naloga";
            ((System.ComponentModel.ISupportInitialize)PrikazInformacija).EndInit();
            ResumeLayout(false);
        }

        private void DodajElementUBazu(object sender, EventArgs e)
        {
            FormaZaUnosNaloga3 forma = new FormaZaUnosNaloga3();
            forma.Show();
        }
        #endregion
        private System.Windows.Forms.Button DugmeDodaj;
        private System.Windows.Forms.DataGridView PrikazInformacija;
    }
}