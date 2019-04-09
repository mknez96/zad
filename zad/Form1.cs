using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad
{
    public partial class Form1 : Form
    {
        Trosak trosak;
        List<Trosak> listaTroskova;

        public Form1()
        {
            InitializeComponent();
            trosak = new Trosak();
            listaTroskova = new List<Trosak>();
        }

        private void gumbUnesi_Click(object sender, EventArgs e)
        {
            if (textBoxUnosCijene.Text.Length > 0 && textBoxUnosVrste.Text.Length > 0)
            {
                textBoxIspis.Clear();
                trosak.Unos(textBoxUnosCijene.Text, textBoxUnosVrste.Text);
                listaTroskova.Add(trosak);
                trosak = new Trosak();

                foreach (Trosak tros in listaTroskova)
                {
                    textBoxIspis.Text += tros.Ispis(listaTroskova) + Environment.NewLine;
                }
                textBoxUnosCijene.Clear();
                textBoxUnosVrste.Clear();           
            }
        }

        private void gumbPretrazi_Click(object sender, EventArgs e)
        {
            textBoxIspis.Clear();
            string zeljenaPretraga = textBoxPretraga.Text;
            foreach (Trosak tros in listaTroskova)
            {
                if (zeljenaPretraga == tros.VrstaTroska)
                {
                    textBoxIspis.Text += tros.Ispis(listaTroskova) + Environment.NewLine;
                }
            }
        }
    }
}