using System;

namespace Legitimacija_za_zaposlene
{
    public class Radnik
    {
        private string sfRadnik;
        private string ime;
        private string prezime;
        private DateTime datumZaposlenja;
        private int plata;
        private int premija;

        public Radnik(string sfRadnik, string ime, string prezime, DateTime datumZaposlenja, int plata, int premija)
        {
            this.SfRadnik = sfRadnik;
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumZaposlenja = datumZaposlenja;
            this.Plata = plata;
            this.Premija = premija;
        }

        public string SfRadnik { get => sfRadnik; set => sfRadnik = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime DatumZaposlenja { get => datumZaposlenja; set => datumZaposlenja = value; }
        public int Plata { get => plata; set => plata = value; }
        public int Premija { get => premija; set => premija = value; }

        public override string ToString()
        {
            return sfRadnik + " " + ime + " " + prezime;
        }
    }
}