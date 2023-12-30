using System.Windows.Forms;
using System;
using System.Reflection.Emit;
using ProjektOOP.Forme;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;


namespace ProjektOOP
{
        partial class FormaZaUnosNaloga1
        {
            private string broj;
            private System.ComponentModel.IContainer components = null;
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
            private void InitializeComponent()
            {
                Korisnik korisnik = new Korisnik("Rino", "Tomic", 1234, "Marinići 15a", "Rijeka", 385996319003, 123, 456);
                string broj = korisnik.Pozivanje();
                this.buttonPrihvati = new System.Windows.Forms.Button();
                this.korisnickoIme = new System.Windows.Forms.TextBox();
                this.korisnickaLozinka = new System.Windows.Forms.TextBox();
                this.KorisnickoImeText = new System.Windows.Forms.Label();
                this.LozinkaText = new System.Windows.Forms.Label();
                this.IspravanUpis = new System.Windows.Forms.Label();
                this.brojPozivanja = new System.Windows.Forms.Label();
                this.SuspendLayout();
                // 
                // buttonPrihvati
                // 
                this.buttonPrihvati.Location = new System.Drawing.Point(156, 79);
                this.buttonPrihvati.Name = "buttonPrihvati";
                this.buttonPrihvati.Size = new System.Drawing.Size(75, 23);
                this.buttonPrihvati.TabIndex = 0;
                this.buttonPrihvati.Text = "Prijavi se";
                this.buttonPrihvati.Click += new System.EventHandler(this.ButtonPrihvati_Click);
                // 
                // korisnickoIme
                // 
                this.korisnickoIme.Location = new System.Drawing.Point(147, 27);
                this.korisnickoIme.Name = "korisnickoIme";
                this.korisnickoIme.Size = new System.Drawing.Size(100, 20);
                this.korisnickoIme.TabIndex = 1;
                // 
                // korisnickaLozinka
                // 
                this.korisnickaLozinka.Location = new System.Drawing.Point(147, 53);
                this.korisnickaLozinka.Name = "korisnickaLozinka";
                this.korisnickaLozinka.Size = new System.Drawing.Size(100, 20);
                this.korisnickaLozinka.TabIndex = 2;
                // 
                // KorisnickoImeText
                // 
                this.KorisnickoImeText.Location = new System.Drawing.Point(62, 30);
                this.KorisnickoImeText.Name = "KorisnickoImeText";
                this.KorisnickoImeText.Size = new System.Drawing.Size(79, 20);
                this.KorisnickoImeText.TabIndex = 3;
                this.KorisnickoImeText.Text = "Korisnicko ime:";
                // 
                // LozinkaText
                // 
                this.LozinkaText.Location = new System.Drawing.Point(95, 53);
                this.LozinkaText.Name = "LozinkaText";
                this.LozinkaText.Size = new System.Drawing.Size(46, 20);
                this.LozinkaText.TabIndex = 4;
                this.LozinkaText.Text = "Lozinka:";
                // 
                // IspravanUpis
                // 
                this.IspravanUpis.Location = new System.Drawing.Point(0, 0);
                this.IspravanUpis.Name = "IspravanUpis";
                this.IspravanUpis.Size = new System.Drawing.Size(100, 23);
                this.IspravanUpis.TabIndex = 0;
                // 
                // brojPozivanja
                // 
                this.brojPozivanja.Location = new System.Drawing.Point(62, 4);
                this.brojPozivanja.Name = "brojPozivanja";
                this.brojPozivanja.Size = new System.Drawing.Size(169, 20);
                this.brojPozivanja.TabIndex = 5;
                this.brojPozivanja.Text = "Broj pozivanja je:"+broj;
                // 
                // FormaZaUnosNaloga1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
                this.ClientSize = new System.Drawing.Size(325, 121);
                this.Controls.Add(this.buttonPrihvati);
                this.Controls.Add(this.korisnickoIme);
                this.Controls.Add(this.korisnickaLozinka);
                this.Controls.Add(this.KorisnickoImeText);
                this.Controls.Add(this.LozinkaText);
                this.Controls.Add(this.brojPozivanja);
                this.ForeColor = System.Drawing.SystemColors.Highlight;
                this.MaximizeBox = false;
                this.Name = "FormaZaUnosNaloga1";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "Forma za unos naloga";
                this.Load += new System.EventHandler(this.FormaZaUnosNaloga_Load);
                this.ResumeLayout(false);
                this.PerformLayout();

            }
            private void Provjera()
            {
                string ispravnoKorisnickoIme = "Marko";
                string ispravnaLozinka = "ana";
                if ((korisnickoIme.Text == ispravnoKorisnickoIme && korisnickaLozinka.Text == ispravnaLozinka))
                {
                    IspravanUpis.Text = "Ispravno";
                }
                else
                {
                    IspravanUpis.Text = "Neispravno";
                }
            }
            private void ButtonProvjera_Click(object sender, EventArgs e)
            {
                Provjera();
            }
            private void ButtonPrihvati_Click(object sender, EventArgs e)
            {
                Provjera();
                if (IspravanUpis.Text == "Ispravno")
                {
                    FormaZaUnosNaloga2 forma = new FormaZaUnosNaloga2();
                    forma.Show();
                }
                else
                {
                    MessageBox.Show("Molimo ispravno unesite korisničko ime i lozinku.", "Neispravan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            #endregion

            private System.Windows.Forms.Button buttonPrihvati;
            private System.Windows.Forms.TextBox korisnickoIme;
            private System.Windows.Forms.TextBox korisnickaLozinka;
            private System.Windows.Forms.Label KorisnickoImeText;
            private System.Windows.Forms.Label LozinkaText;
            private System.Windows.Forms.Label IspravanUpis;
            private System.Windows.Forms.Label brojPozivanja;
        }
}
