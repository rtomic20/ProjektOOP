using System.Windows.Forms;
using System;
using System.Reflection.Emit;
using ProjektOOP.Forme;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using Npgsql;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.DataFormats;


namespace ProjektOOP
{
    partial class FormaPrijava : Form
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
        , "localhost", 5432, "postgres", "1234", "Korisnicka_imena_i_lozinke"
        );
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            buttonPrihvati = new System.Windows.Forms.Button();
            korisnickoIme = new System.Windows.Forms.TextBox();
            korisnickaLozinka = new System.Windows.Forms.TextBox();
            KorisnickoImeText = new System.Windows.Forms.Label();
            LozinkaText = new System.Windows.Forms.Label();
            PrikaziZaporku = new System.Windows.Forms.CheckBox();
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
            Controls.Add(buttonPrihvati);
            Controls.Add(korisnickoIme);
            Controls.Add(korisnickaLozinka);
            Controls.Add(KorisnickoImeText);
            Controls.Add(LozinkaText);
            Controls.Add(PrikaziZaporku);
            ClientSize = new Size(379, 165);
            ForeColor = SystemColors.Highlight;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FormaZaUnosNaloga1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forma za prijavu";
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
        private string DohvatiKategorijuKorisnika(string korisnickoIme)
        {
            try
            {
                conn.Open();
                sql = " SELECT * FROM DohvatiKategorijuDinamicki(@imeKorisnika);";
                cmd = new NpgsqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@imeKorisnika", korisnickoIme);

                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : null;
            }
            finally
            {
                conn.Close();
            }
        }
        private void OtvoriProzorCSSektora()
        {

            FormaZaUnosNaloga1 csProzor = new FormaZaUnosNaloga1();
            csProzor.Show();
        }

        private void OtvoriProzorSERSektora()
        {
            Forma_Serviser.FormaZaPregledNaloga1 serProzor = new Forma_Serviser.FormaZaPregledNaloga1();
            serProzor.Show();
        }
        private void ButtonPrihvati_Click(object sender, EventArgs e)
        {
            string unesenoKorisnickoIme = korisnickoIme.Text;
            string unesenaLozinka = korisnickaLozinka.Text;
            if (ProvjeraKorisnikaUBazi(unesenoKorisnickoIme, unesenaLozinka))
            {
                string kategorija = DohvatiKategorijuKorisnika(unesenoKorisnickoIme);
                if (kategorija=="CS ")
                {
                    OtvoriProzorCSSektora();
                }
                else if (kategorija=="SER")
                {
                    OtvoriProzorSERSektora();
                }
                else
                {
                    MessageBox.Show("SQL!", "Neuspješna prijava", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        private void BrisanjePozadine(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private System.Windows.Forms.CheckBox PrikaziZaporku;
        private System.Windows.Forms.Button buttonPrihvati;
        private System.Windows.Forms.TextBox korisnickoIme;
        private System.Windows.Forms.TextBox korisnickaLozinka;
        private System.Windows.Forms.Label KorisnickoImeText;
        private System.Windows.Forms.Label LozinkaText;
    }
}