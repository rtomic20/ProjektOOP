using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Osoba 
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public int OIB { get; set; }
    public string adresaStanovanja { get; set; }
    public string gradStanovanja { get; set; }
    public int brojOsobne { get; set; }
    public Osoba(string Ime,string Prezime,int OIB,string adresaStanovanja,string gradStanovanja) {
        this.Ime = Ime;
        this.Prezime = Prezime;
        this.OIB = OIB;
        this.adresaStanovanja = adresaStanovanja;
        this.gradStanovanja= gradStanovanja;
        //this.brojOsobne = brojOsobne;
    }
}
