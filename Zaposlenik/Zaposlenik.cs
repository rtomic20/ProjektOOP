using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Zaposlenik : Osoba
{
    //public EnumeratorZaID.EnumeratorIDzaposlenik zaposlenikID;
    public EnumeratorZaOvlasti.EnumOvlasti zaposlenikOvlasti;
    public Zaposlenik(string Ime, string Prezime, int OIB, string adresa_stanovanja, string grad_stanovanja, EnumeratorZaOvlasti.EnumOvlasti zaposlenikOvlasti) : base(Ime, Prezime, OIB, adresa_stanovanja, grad_stanovanja)
    {
        this.zaposlenikOvlasti = zaposlenikOvlasti;
    }
}

