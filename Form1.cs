using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legitimacija_za_zaposlene
{
    public partial class Form1 : Form
    {
        private OleDbConnection konekcija = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= C:\Users\Cvijander\source\repos\Relja napredni kurs\Legitimacija za zaposlene\Legitimacija za zaposlene\bin\Debug\baza.mdb");
        private List<Radnik> listaRadnika = new List<Radnik>();
        private Radnik odabraniRadnik;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                konekcija.Open();
                string tekstKomande = "select * from Radnik order by sfRadnik";
                OleDbCommand komanda = new OleDbCommand(tekstKomande, konekcija);
                OleDbDataReader citac = komanda.ExecuteReader();
                while (citac.Read() == true)
                {
                    string sfRadnik = citac[0].ToString();
                    string ime = citac[1].ToString();
                    string prezime = citac[2].ToString();
                    DateTime datumZaposlenja = DateTime.Parse(citac[3].ToString());
                    int plata = int.Parse(citac[4].ToString());
                    int premija = int.Parse(citac[5].ToString());
                    Radnik noviRadnik = new Radnik(sfRadnik, ime, prezime, datumZaposlenja, plata, premija);
                    listaRadnika.Add(noviRadnik);
                    listBox1.Items.Add(noviRadnik.ToString());
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Greska " + x.Message);
            }
            finally
            {
                if (konekcija.State == ConnectionState.Open)
                    konekcija.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            odabraniRadnik = listaRadnika[index];
            richTextBox1.Text = "Sifra radnika:\t" + odabraniRadnik.SfRadnik + "\n" +
                "Ime radnika:\t" + odabraniRadnik.Ime + "\n" +
                "Prezime radnika:\t" + odabraniRadnik.Prezime + "\n" +
                "Datum zaposlenja:\t" + odabraniRadnik.DatumZaposlenja.ToShortDateString() + "\n" +
                "Plata radnika:\t" + odabraniRadnik.Plata + "\n" +
                "Premija radnika:\t" + odabraniRadnik.Premija;
        }

        private void btnPredji_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Greska morate da odaberete jednog radnika");
                return;
            }
            Form2 f2 = new Form2(odabraniRadnik);
            f2.Show();
        }
    }
}