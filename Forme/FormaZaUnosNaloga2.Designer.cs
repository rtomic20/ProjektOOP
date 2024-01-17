using System.Windows.Forms;
using System;
using ProjektOOP.Forme;
using Npgsql;
using System.Data;
namespace ProjektOOP.Forme
{
    partial class FormaZaUnosNaloga2 : Form
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
        private string Connection = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};"
        , "localhost", 5432, "postgres", "1234", "DataBazaZaUnosNaloga"
        );
        private NpgsqlConnection conn;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private bool pretragaUnesena = false;
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            DugmeDodaj = new Button();
            PrikazInformacija = new DataGridView();
            Pretraga = new TextBox();
            PretragaDugme = new Button();
            ((System.ComponentModel.ISupportInitialize)PrikazInformacija).BeginInit();
            Konekcija(this.PrikazInformacija, EventArgs.Empty);
            SuspendLayout();
            // 
            // DugmeDodaj
            // 
            DugmeDodaj.Location = new Point(879, 493);
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
            PrikazInformacija.ScrollBars = ScrollBars.None;
            PrikazInformacija.Size = new Size(942, 392);
            PrikazInformacija.TabIndex = 1;
            // 
            // Pretraga
            // 
            Pretraga.ForeColor = SystemColors.GrayText;
            Pretraga.Location = new Point(649, 26);
            Pretraga.Name = "Pretraga";
            Pretraga.Size = new Size(215, 23);
            Pretraga.TabIndex = 2;
            Pretraga.Text = "Unesi pretragu";
            Pretraga.TextChanged += Pretraga_TextChanged;
            Pretraga.Enter += Pretraga_Unos;
            Pretraga.Leave += Pretraga_Odlazak;
            // 
            // PretragaDugme
            // 
            PretragaDugme.Location = new Point(879, 25);
            PretragaDugme.Name = "PretragaDugme";
            PretragaDugme.Size = new Size(75, 23);
            PretragaDugme.TabIndex = 3;
            PretragaDugme.Text = "Pretraga";
            // 
            // FormaZaUnosNaloga2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(968, 564);
            Controls.Add(DugmeDodaj);
            Controls.Add(PrikazInformacija);
            Controls.Add(Pretraga);
            Controls.Add(PretragaDugme);
            ForeColor = SystemColors.Highlight;
            MaximizeBox = false;
            Name = "FormaZaUnosNaloga2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ispis naloga";
            ((System.ComponentModel.ISupportInitialize)PrikazInformacija).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Konekcija(object sender, EventArgs e)
         {
            conn=new NpgsqlConnection(Connection);
            Select();
        }
        private void Select()
        {
            try
            {
                conn.Open();
                sql=@"SELECT * FROM UcitajPodatke();";
                cmd=new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                conn.Close();
                PrikazInformacija.DataSource=null;
                PrikazInformacija.DataSource=dt;
            }
            catch (Exception ex)
            {
               
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                conn.Close();
            }
        }
        private void DodajElementUBazu(object sender, EventArgs e)
        {
            FormaZaUnosNaloga3 forma = new FormaZaUnosNaloga3();
            forma.Show();
        }
        private void Pretraga_Unos(object sender, EventArgs e)
        {
            if (!pretragaUnesena)
            {
                Pretraga.Text = "";
                Pretraga.ForeColor = SystemColors.WindowText;
                pretragaUnesena = true;
            }
        }
        private void Pretraga_Odlazak(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Pretraga.Text))
            {
                Pretraga.Text = "Unesi pretragu";
                Pretraga.ForeColor = SystemColors.GrayText;
                pretragaUnesena = false;
            }
        }
        #endregion
        private System.Windows.Forms.Button DugmeDodaj;
        private System.Windows.Forms.DataGridView PrikazInformacija;
        private System.Windows.Forms.TextBox Pretraga;
        private System.Windows.Forms.Button PretragaDugme;
    }
}