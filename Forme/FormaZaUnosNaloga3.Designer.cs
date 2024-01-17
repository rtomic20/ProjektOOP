using Npgsql;
using System.Data;
using System.Runtime.CompilerServices;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProjektOOP.Forme
{
    partial class FormaZaUnosNaloga3
    {
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
        private string Connection = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};"
       , "localhost", 5432, "postgres", "1234", "DataBazaZaUnosNaloga"
       );
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            garancija = new Label();
            garancija_Da = new CheckBox();
            garancija_Ne = new CheckBox();
            opis_greske = new Label();
            ime = new Label();
            prezime = new Label();
            adresa_stanovanja = new Label();
            grad_stanovanja = new Label();
            model_proizvoda = new Label();
            Greska = new TextBox();
            Ime_krosinika = new TextBox();
            Prezime_korisnika = new TextBox();
            Adresa_stanovanja_korisnika = new TextBox();
            Grad_stanovanja_korisnika = new TextBox();
            Model_proizvoda_korisnika = new TextBox();
            Prihvati_Unos = new Button();
            SuspendLayout();
            // 
            // garancija
            // 
            garancija.Location = new Point(130, 67);
            garancija.Name = "garancija";
            garancija.Size = new Size(63, 23);
            garancija.TabIndex = 0;
            garancija.Text = "Garancija:";
            // 
            // garancija_Da
            // 
            garancija_Da.Location = new Point(206, 67);
            garancija_Da.Name = "garancija_Da";
            garancija_Da.Size = new Size(40, 23);
            garancija_Da.TabIndex = 1;
            garancija_Da.Text = "Da";
            // 
            // garancija_Ne
            // 
            garancija_Ne.Location = new Point(259, 67);
            garancija_Ne.Name = "garancija_Ne";
            garancija_Ne.Size = new Size(46, 23);
            garancija_Ne.TabIndex = 2;
            garancija_Ne.Text = "Ne";
            // 
            // opis_greske
            // 
            opis_greske.Location = new Point(130, 347);
            opis_greske.Name = "opis_greske";
            opis_greske.Size = new Size(100, 23);
            opis_greske.TabIndex = 3;
            opis_greske.Text = "Opis greske:";
            // 
            // ime
            // 
            ime.Location = new Point(130, 93);
            ime.Name = "ime";
            ime.Size = new Size(100, 22);
            ime.TabIndex = 4;
            ime.Text = "Ime:";
            // 
            // prezime
            // 
            prezime.Location = new Point(130, 143);
            prezime.Name = "prezime";
            prezime.Size = new Size(100, 23);
            prezime.TabIndex = 5;
            prezime.Text = "Prezime:";
            // 
            // adresa_stanovanja
            // 
            adresa_stanovanja.Location = new Point(130, 193);
            adresa_stanovanja.Name = "adresa_stanovanja";
            adresa_stanovanja.Size = new Size(116, 23);
            adresa_stanovanja.TabIndex = 6;
            adresa_stanovanja.Text = "Adresa stanovanja:";
            // 
            // grad_stanovanja
            // 
            grad_stanovanja.Location = new Point(130, 243);
            grad_stanovanja.Name = "grad_stanovanja";
            grad_stanovanja.Size = new Size(100, 23);
            grad_stanovanja.TabIndex = 7;
            grad_stanovanja.Text = "Grad stanovanja:";
            // 
            // model_proizvoda
            // 
            model_proizvoda.Location = new Point(130, 295);
            model_proizvoda.Name = "model_proizvoda";
            model_proizvoda.Size = new Size(100, 23);
            model_proizvoda.TabIndex = 8;
            model_proizvoda.Text = "Model proizvoda:";
            // 
            // Greska
            // 
            Greska.Location = new Point(130, 118);
            Greska.Multiline = true;
            Greska.Name = "Greska";
            Greska.Size = new Size(120, 22);
            Greska.TabIndex = 9;
            Greska.TextChanged += Greska_TextChanged;
            // 
            // Ime_krosinika
            // 
            Ime_krosinika.Location = new Point(130, 373);
            Ime_krosinika.Multiline = true;
            Ime_krosinika.Name = "Ime_krosinika";
            Ime_krosinika.Size = new Size(191, 65);
            Ime_krosinika.TabIndex = 10;
            // 
            // Prezime_korisnika
            // 
            Prezime_korisnika.Location = new Point(130, 169);
            Prezime_korisnika.Multiline = true;
            Prezime_korisnika.Name = "Prezime_korisnika";
            Prezime_korisnika.Size = new Size(120, 21);
            Prezime_korisnika.TabIndex = 11;
            // 
            // Adresa_stanovanja_korisnika
            // 
            Adresa_stanovanja_korisnika.Location = new Point(130, 219);
            Adresa_stanovanja_korisnika.Multiline = true;
            Adresa_stanovanja_korisnika.Name = "Adresa_stanovanja_korisnika";
            Adresa_stanovanja_korisnika.Size = new Size(120, 21);
            Adresa_stanovanja_korisnika.TabIndex = 12;
            // 
            // Grad_stanovanja_korisnika
            // 
            Grad_stanovanja_korisnika.Location = new Point(130, 269);
            Grad_stanovanja_korisnika.Name = "Grad_stanovanja_korisnika";
            Grad_stanovanja_korisnika.Size = new Size(130, 23);
            Grad_stanovanja_korisnika.TabIndex = 13;
            // 
            // Model_proizvoda_korisnika
            // 
            Model_proizvoda_korisnika.Location = new Point(130, 321);
            Model_proizvoda_korisnika.Name = "Model_proizvoda_korisnika";
            Model_proizvoda_korisnika.Size = new Size(130, 23);
            Model_proizvoda_korisnika.TabIndex = 14;
            // 
            // Prihvati_Unos
            // 
            Prihvati_Unos.Location = new Point(259, 484);
            Prihvati_Unos.Name = "Prihvati_Unos";
            Prihvati_Unos.Size = new Size(130, 23);
            Prihvati_Unos.TabIndex = 14;
            Prihvati_Unos.Text = "Prihvati unos";
            // 
            // FormaZaUnosNaloga3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(411, 519);
            Controls.Add(garancija);
            Controls.Add(garancija_Da);
            Controls.Add(garancija_Ne);
            Controls.Add(ime);
            Controls.Add(prezime);
            Controls.Add(adresa_stanovanja);
            Controls.Add(grad_stanovanja);
            Controls.Add(model_proizvoda);
            Controls.Add(opis_greske);
            Controls.Add(Greska);
            Controls.Add(Ime_krosinika);
            Controls.Add(Prezime_korisnika);
            Controls.Add(Adresa_stanovanja_korisnika);
            Controls.Add(Grad_stanovanja_korisnika);
            Controls.Add(Model_proizvoda_korisnika);
            Controls.Add(Prihvati_Unos);
            ForeColor = SystemColors.Highlight;
            MaximizeBox = false;
            Name = "FormaZaUnosNaloga3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Unos naloga";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Konekcija1()
        {
            conn=new NpgsqlConnection(Connection);
        }
        #endregion
        private System.Windows.Forms.Label garancija;
        private System.Windows.Forms.CheckBox garancija_Da;
        private System.Windows.Forms.CheckBox garancija_Ne;
        private System.Windows.Forms.Label opis_greske;
        private System.Windows.Forms.Label ime;
        private System.Windows.Forms.Label prezime;
        private System.Windows.Forms.Label adresa_stanovanja;
        private System.Windows.Forms.Label grad_stanovanja;
        private System.Windows.Forms.Label model_proizvoda;
        private System.Windows.Forms.TextBox Greska;
        private System.Windows.Forms.TextBox Ime_krosinika;
        private System.Windows.Forms.TextBox Prezime_korisnika;
        private System.Windows.Forms.TextBox Adresa_stanovanja_korisnika;
        private System.Windows.Forms.TextBox Grad_stanovanja_korisnika;
        private System.Windows.Forms.TextBox Model_proizvoda_korisnika;
        private System.Windows.Forms.Button Prihvati_Unos;
    }
}