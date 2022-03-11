using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cbradioGUI
{
    public partial class Form1 : Form
    {
        List<CBAdas> adatok = new List<CBAdas>();
        string fajl = "cb.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader olvas=new StreamReader(fajl))
                {
                    olvas.ReadLine();
                    while (!olvas.EndOfStream)
                    {
                        string[] egysor = olvas.ReadLine().Split(';');
                        CBAdas tmp = new CBAdas(int.Parse(egysor[0]),int.Parse(egysor[1]),int.Parse(egysor[2]),egysor[3]);
                        adatok.Add(tmp);
                    }
                }
            }
            catch (IOException er)
            {
                MessageBox.Show(er.Message);
            }

            List<string> nevek = new List<string>();
            foreach (CBAdas item in adatok)
            {
                if (!nevek.Contains(item.SoforNev))
                {
                    nevek.Add(item.SoforNev);
                    comb_nev.Items.Add(item.SoforNev);
                }
            }
        }

        private void bt_mentes_Click(object sender, EventArgs e)
        {
            if (comb_nev.SelectedIndex!=-1 && tb_ido.Text!="")
            {
                int ora = int.Parse(tb_ido.Text.Substring(0, 2));
                int perc = int.Parse(tb_ido.Text.Substring(3,2));
                adatok.Add(new CBAdas(ora,perc,(int)nur_adas.Value,comb_nev.Text));
            }
            else
            {
                MessageBox.Show("Hibás adatbevitel!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_kereses_Click(object sender, EventArgs e)
        {
            string keresett = tb_kereses.Text;
            int i = 0;
            while (i<adatok.Count && adatok[i].SoforNev!=keresett)
            {
                i++;
            }
            if (tb_kereses.Text=="")
            {
                MessageBox.Show("Nem adott meg keresendő személyt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (i<adatok.Count)
            {
                MessageBox.Show(adatok[i].SoforNev);
                foreach (CBAdas item in adatok)
                {
                    if (item.SoforNev == keresett)
                    {
                        listb_adatok.Items.Add($"{item.AdasIdejeOra}:{item.AdasIdejePerc} {item.AdasSzam}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Nem található a keresendő személyt!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
