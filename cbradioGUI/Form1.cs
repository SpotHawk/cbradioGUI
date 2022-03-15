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
        int plussz = 0;

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
                throw;
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
            int ora=0;
            int perc=0;
            if (comb_nev.SelectedIndex!=-1 && tb_ido.Text.Length>2 && tb_ido.Text.Contains(':') && tb_ido.Text.Length<6 &&  (tb_ido.Text.IndexOf(':')!=0 || tb_ido.Text.IndexOf(':') !=tb_ido.Text.Length-1))
            {
                try
                {
                    ora = int.Parse(tb_ido.Text.Substring(0, tb_ido.Text.IndexOf(':')));
                    perc = int.Parse(tb_ido.Text.Substring(tb_ido.Text.IndexOf(':') + 1, tb_ido.Text.Length - (ora.ToString().Length + 1)));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Hibás adatbevitel!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ora > -1 && ora < 24 && perc>-1 && perc<60)
                {
                    adatok.Add(new CBAdas(ora, perc, (int)nur_adas.Value, comb_nev.Text));
                    plussz++;
                    comb_nev.SelectedIndex = -1;
                    tb_ido.Text = "";
                }
                else
                {
                    MessageBox.Show("Hibás adatbevitel!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hibás adatbevitel!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_kereses_Click(object sender, EventArgs e)
        {
            listb_adatok.Items.Clear();
            string keresett = tb_nev.Text;
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
                lb_adatlist.Text = $"{keresett} adásai";
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

        private void tb_fajlba_Click(object sender, EventArgs e)
        {
            if (plussz!=0)
            {
                try
                {
                    using (StreamWriter kiir = File.AppendText(fajl))
                    {
                        for (int i = adatok.Count - plussz; i < adatok.Count; i++)
                        {
                            kiir.WriteLine($"{adatok[i].AdasIdejeOra};{adatok[i].AdasIdejePerc};{adatok[i].AdasSzam};{adatok[i].SoforNev}");
                        }
                    }
                }
                catch (IOException er)
                {
                    MessageBox.Show(er.Message);
                }
                plussz = 0;
            }
        }
    }
}
