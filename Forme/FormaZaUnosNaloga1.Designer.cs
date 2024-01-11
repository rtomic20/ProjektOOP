using System.Windows.Forms;
using System;
using System.Reflection.Emit;
using ProjektOOP.Forme;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using Npgsql;
using System.Data;


namespace ProjektOOP
{
    partial class FormaZaUnosNaloga1:Form
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
        ,"localhost", 5432, "postgres", "1234", "Korisnicka_imena_i_lozinke"
        );
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            Random random = new Random();
            int devetoznamenkastiBroj = random.Next(100000000, 1000000000);
            buttonPrihvati = new Button();
            korisnickoIme = new TextBox();
            korisnickaLozinka = new TextBox();
            KorisnickoImeText = new System.Windows.Forms.Label();
            LozinkaText = new System.Windows.Forms.Label();
            brojPozivanja = new System.Windows.Forms.Label();
            PrikaziZaporku = new CheckBox();
            Konekcija();
            SuspendLayout();
            // 
            // buttonPrihvati
            // 
            buttonPrihvati.Location = new Point(181, 124);
            buttonPrihvati.Margin = new Padding(4, 3, 4, 3);
            buttonPrihvati.Name = "buttonPrihvati";
            buttonPrihvati.Size = new Size(88, 27);
            buttonPrihvati.TabIndex = 0;
            buttonPrihvati.Text = "Prijavi se";
            buttonPrihvati.Click += ButtonPrihvati_Click;
            // 
            // korisnickoIme
            // 
            korisnickoIme.Location = new Point(172, 31);
            korisnickoIme.Margin = new Padding(4, 3, 4, 3);
            korisnickoIme.Name = "korisnickoIme";
            korisnickoIme.Size = new Size(116, 23);
            korisnickoIme.TabIndex = 1;
            // 
            // korisnickaLozinka
            // 
            korisnickaLozinka.Location = new Point(172, 61);
            korisnickaLozinka.Margin = new Padding(4, 3, 4, 3);
            korisnickaLozinka.Name = "korisnickaLozinka";
            korisnickaLozinka.PasswordChar = '•';
            korisnickaLozinka.Size = new Size(116, 23);
            korisnickaLozinka.TabIndex = 2;
            // 
            // KorisnickoImeText
            // 
            KorisnickoImeText.Location = new Point(72, 35);
            KorisnickoImeText.Margin = new Padding(4, 0, 4, 0);
            KorisnickoImeText.Name = "KorisnickoImeText";
            KorisnickoImeText.Size = new Size(92, 23);
            KorisnickoImeText.TabIndex = 3;
            KorisnickoImeText.Text = "Korisnicko ime:";
            // 
            // LozinkaText
            // 
            LozinkaText.Location = new Point(111, 61);
            LozinkaText.Margin = new Padding(4, 0, 4, 0);
            LozinkaText.Name = "LozinkaText";
            LozinkaText.Size = new Size(54, 23);
            LozinkaText.TabIndex = 4;
            LozinkaText.Text = "Lozinka:";
            // 
            // brojPozivanja
            // 
            brojPozivanja.Location = new Point(72, 5);
            brojPozivanja.Margin = new Padding(4, 0, 4, 0);
            brojPozivanja.Name = "brojPozivanja";
            brojPozivanja.Size = new Size(197, 23);
            brojPozivanja.TabIndex = 5;
            brojPozivanja.Text = "Broj pozivanja je:385{devetoznamenkastiBroj}";
            // 
            // PrikaziZaporku
            // 
            PrikaziZaporku.Location = new Point(172, 90);
            PrikaziZaporku.Margin = new Padding(4, 3, 4, 3);
            PrikaziZaporku.Name = "PrikaziZaporku";
            PrikaziZaporku.Size = new Size(109, 28);
            PrikaziZaporku.TabIndex = 6;
            PrikaziZaporku.Text = "Prikaži zaporku";
            PrikaziZaporku.CheckedChanged += CheckBoxPrikaziZaporku_CheckedChanged;
            // 
            // FormaZaUnosNaloga1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(379, 165);
            Controls.Add(buttonPrihvati);
            Controls.Add(korisnickoIme);
            Controls.Add(korisnickaLozinka);
            Controls.Add(KorisnickoImeText);
            Controls.Add(LozinkaText);
            Controls.Add(brojPozivanja);
            Controls.Add(PrikaziZaporku);
            ForeColor = SystemColors.Highlight;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormaZaUnosNaloga1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forma za unos naloga";
            Load += FormaZaUnosNaloga_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Konekcija()
        {
            conn=new NpgsqlConnection(Connection);
        }
        #endregion
        private bool ProvjeraKorisnikaUBazi(string korisnickoIme, string lozinka)
        {
            try
            {
                conn.Open();
                sql = "SELECT * FROM KorisnickoImeiLozinka WHERE ime = @korisnickoIme AND lozinka = @lozinka";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@korisnickoIme", korisnickoIme);
                cmd.Parameters.AddWithValue("@lozinka", lozinka);

                dt = new DataTable();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                return dt.Rows.Count > 0;
            }
            catch (Exception ex)
            {
                // Obrada grešaka, možete dodati MessageBox ili logiranje
                Console.WriteLine("Greška: " + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void ButtonPrihvati_Click(object sender, EventArgs e)
        {
            string unesenoKorisnickoIme = korisnickoIme.Text;
            string unesenaLozinka = korisnickaLozinka.Text;
            if (ProvjeraKorisnikaUBazi(unesenoKorisnickoIme, unesenaLozinka))
            {
                FormaZaUnosNaloga2 forma = new FormaZaUnosNaloga2();
                forma.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka!", "Neuspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CheckBoxPrikaziZaporku_CheckedChanged(object sender, EventArgs e)
        {
            if (PrikaziZaporku.Checked)
            {
                korisnickaLozinka.PasswordChar = '\0';
            }
            else
            {
                korisnickaLozinka.PasswordChar = '\u2022';
            }
        }
        private System.Windows.Forms.CheckBox PrikaziZaporku;
        private System.Windows.Forms.Button buttonPrihvati;
        private System.Windows.Forms.TextBox korisnickoIme;
        private System.Windows.Forms.TextBox korisnickaLozinka;
        private System.Windows.Forms.Label KorisnickoImeText;
        private System.Windows.Forms.Label LozinkaText;
        private System.Windows.Forms.Label brojPozivanja;
    }
}