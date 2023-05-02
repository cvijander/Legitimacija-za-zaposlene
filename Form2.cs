using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Legitimacija_za_zaposlene
{
    public partial class Form2 : Form
    {
        private Radnik odabraniRadnik;
        private Graphics g;
        private Bitmap b;
        private Bitmap sablon;

        public Form2(Radnik odabraniRadnik)
        {
            InitializeComponent();
            this.odabraniRadnik = odabraniRadnik;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.Black);
            sablon = new Bitmap("idkarta.jpg");
            g.DrawImage(sablon, 0, 0);
            g.DrawString(odabraniRadnik.Ime + " " + odabraniRadnik.Prezime + " \n(" + odabraniRadnik.SfRadnik + ")",
            new Font("Consolas", 26, FontStyle.Bold), Brushes.White, 55, 300);
            g.DrawString("Sifra radnika: " + "(" + odabraniRadnik.SfRadnik + ")",
                new Font("Consolas", 16, FontStyle.Bold), Brushes.Black, 500, 200);
            g.DrawString("Datum zaposlenja: \n" + odabraniRadnik.DatumZaposlenja.ToShortDateString(),
                new Font("Consolas", 16, FontStyle.Bold), Brushes.Black, 500, 300);

            pictureBox1.Invalidate();
        }

        private void odaberiFotografijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Jpeg slika |*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                g.DrawImage(new Bitmap(ofd.FileName), 60, 50, 235, 235);
                pictureBox1.Invalidate();
            }
        }

        private void sacuvajLegitimacijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png fotografija |*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image.Save(sfd.FileName);
                    MessageBox.Show("Legitimacija je uspesno sacuvana.");
                }
                catch
                {
                    MessageBox.Show("Greska: Legitimacija nije sacuvana."); ;
                }
            }
        }
    }
}