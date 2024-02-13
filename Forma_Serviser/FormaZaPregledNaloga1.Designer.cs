using Npgsql;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ProjektOOP.Forma_Serviser
{
    partial class FormaZaPregledNaloga1
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
            PrikazNaloga = new DataGridView();
            UnosStanja = new Button();
            ((System.ComponentModel.ISupportInitialize)PrikazNaloga).BeginInit();
            Konekcija2();
            SuspendLayout();
            // 
            // PrikazNaloga
            // 
            PrikazNaloga.Location = new Point(12, 91);
            PrikazNaloga.Name = "PrikazNaloga";
            PrikazNaloga.Size = new Size(863, 348);
            PrikazNaloga.TabIndex = 0;
            // 
            // UnosStanja
            // 
            UnosStanja.Location = new Point(800, 467);
            UnosStanja.Name = "UnosStanja";
            UnosStanja.Size = new Size(75, 23);
            UnosStanja.TabIndex = 1;
            UnosStanja.Text = "Riješi";
            // 
            // FormaZaPregledNaloga1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(887, 519);
            Controls.Add(PrikazNaloga);
            Controls.Add(UnosStanja);
            ForeColor = SystemColors.Highlight;
            MaximizeBox = false;
            Name = "FormaZaPregledNaloga1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PregledNaloga";
            ((System.ComponentModel.ISupportInitialize)PrikazNaloga).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private System.Windows.Forms.DataGridView PrikazNaloga;
        private System.Windows.Forms.Button UnosStanja;
        private void Konekcija2()
        {
            conn=new NpgsqlConnection(Connection);
        }
    }
}