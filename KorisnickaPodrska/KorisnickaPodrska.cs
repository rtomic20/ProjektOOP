using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class KorisnickaPodrska : Osoba
{
    //public EnumeratorZaID.EnumeratorIDzaposlenik zaposlenikStatus;
    public EnumeratorZaOvlasti.EnumOvlasti zaposlenikOvlasti;
    public KorisnickaPodrska(string Ime, string Prezime, int OIB, string adresaStanovanja, string gradStanovanja,EnumeratorZaOvlasti.EnumOvlasti zaposlenikOvlasti) : base(Ime, Prezime, OIB, adresaStanovanja, gradStanovanja)
    {
        this.zaposlenikOvlasti = zaposlenikOvlasti;
    }
    public void UnosPodataka()
    {

    }
}
