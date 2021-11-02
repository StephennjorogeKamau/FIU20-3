using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persoen
{
    public partial class Form1 : Form
    {
        private List<Kunde> kdListe = new List<Kunde>();
        private string suche;

        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Anlegen_Click(object sender, EventArgs e)
        {
            Kunde k = new Kunde(int.Parse(txtb_KdNr.Text), txtb_Firma.Text);
            kdListe.Add(k);
            txtb_KdNr.Clear();
            txtb_Firma.Clear();
            bt_Anzeigen_Click(this, EventArgs.Empty);
        }

        private void bt_Anzeigen_Click(object sender, EventArgs e)
        {
            if (kdListe.Count != 0)
            {
                lv_Anzeige.Visible = true;
                lv_Anzeige.Items.Clear();
                foreach (Kunde item in kdListe)
                {
                    ListViewItem it = new ListViewItem(item.kdNr.ToString());
                    it.SubItems.Add(item.firmenName);
                    lv_Anzeige.Items.Add(it);
                }
            }
            else
                lv_Anzeige.Visible = false;
        }

        private void bt_Loeschen_Click(object sender, EventArgs e)
        {
            if (txtb_KdNr.Text != null)
            {
                int counter = 0;
                int index = -1;
                foreach (Kunde item in kdListe)
                {
                    if (item.kdNr == int.Parse(txtb_KdNr.Text))
                    {
                        index = counter;
                        break;
                    }
                    counter++;
                }

                if (index > -1)
                {
                    kdListe.RemoveAt(index);
                    bt_Speichern_Click(this, EventArgs.Empty);
                    bt_Anzeigen_Click(this, EventArgs.Empty);
                    txtb_KdNr.Clear();
                    MessageBox.Show("Löschung erfolgreich");
                }
                else
                {
                    MessageBox.Show("Kundenummer nicht gefunden!");
                    txtb_KdNr.Clear();
                }
            }
        }

        private void bt_Speichern_Click(object sender, EventArgs e)
        {
            string pfad = @"C:\Test\kdliste.csv";

            using (StreamWriter sw = new StreamWriter(pfad, false))
            {
                if (kdListe.Count != 0)
                {
                    foreach (Kunde item in kdListe)
                    {
                        sw.WriteLine($"{item.kdNr};{item.firmenName}");
                    }
                }
                MessageBox.Show("Speichern erfolgreich!");
            }
        }

        private void bt_Laden_Click(object sender, EventArgs e)
        {
            string pfad = @"C:\Test\kdliste.csv";

            if (File.Exists(pfad))
            {
                kdListe.Clear();
                using (StreamReader sr = new StreamReader(pfad))
                {
                    string auslesen;
                    string[] arr;

                    while ((auslesen = sr.ReadLine()) != null)
                    {
                        arr = auslesen.Split(';');
                        kdListe.Add(new Kunde(int.Parse(arr[0]), arr[1]));
                    }
                }
                bt_Anzeigen_Click(this, EventArgs.Empty);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bt_Laden_Click(this, EventArgs.Empty);
        }

        private void bt_LoeschenLV_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lv_Anzeige.Items.Count; i++)
            {
                if (lv_Anzeige.Items[i].Selected)
                {
                    lv_Anzeige.Items[i].Remove();
                    kdListe.RemoveAt(i);
                }
            }
        }

        private void bt_Suchen_Click(object sender, EventArgs e)
        {
            if (txtb_Suchen.Text != null)
            {
                lv_Anzeige.Items.Clear();
                foreach (Kunde item in kdListe)
                {
                    if (item.kdNr.ToString().Contains(txtb_Suchen.Text))
                    {
                        ListViewItem lvi = new ListViewItem(item.kdNr.ToString());
                        lvi.SubItems.Add(item.firmenName);
                        lv_Anzeige.Items.Add(lvi);
                    }
                    else if (item.firmenName.Contains(txtb_Suchen.Text))
                    {
                        ListViewItem lvi = new ListViewItem(item.kdNr.ToString());
                        lvi.SubItems.Add(item.firmenName);
                        lv_Anzeige.Items.Add(lvi);
                    }
                }
            }
        }
    }
}
