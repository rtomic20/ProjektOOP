using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Serviser : Zaposlenik
{
    public int brojNaloga = 0;
    public Serviser(string Ime, string Prezime, int OIB, string adresa_stanovanja, string grad_stanovanja, EnumeratorZaOvlasti.EnumOvlasti zaposlenikOvlasti) : base(Ime, Prezime, OIB, adresa_stanovanja, grad_stanovanja, zaposlenikOvlasti)
    {
    }
    public void ObaviRad()
    {

    }
}

