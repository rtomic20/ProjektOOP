using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Korisnik : Osoba
{
    public long kontaktBroj {  get; set; }
    public long brojRacuna { get; set; }
    public long serijskiBroj { get; set; }
    public Korisnik(string Ime, string Prezime, int OIB, string adresa_stanovanja, string grad_stanovanja,long  kontaktBroj,long brojRacuna,long serijskiBroj) : base(Ime, Prezime, OIB, adresa_stanovanja, grad_stanovanja)
    {
        this.kontaktBroj=kontaktBroj;
        this.brojRacuna=brojRacuna;
        this.serijskiBroj=serijskiBroj;
    }
    public string Pozivanje()
    {
        Random randomBroj = new Random();
        int devetoZnamenkastiDodatakBroja = randomBroj.Next(100000000, 1000000000);
        long kontaktBrojPozivatelja = devetoZnamenkastiDodatakBroja;//+385 u ispisu
        return $"385{kontaktBrojPozivatelja}";
    }
}
   
