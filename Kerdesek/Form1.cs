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

namespace Kerdesek {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        
        Kerdesek a = new Kerdesek();
        public void bMegnyitas_Click(object sender, EventArgs e) {
            
            
        }
        public void kiir() { }
        private void bMentes_Click(object sender, EventArgs e) {
            if (sfd.ShowDialog()==DialogResult.OK) {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                for (int i = 0; i < a.kerdesek.Count; i++) {
                    sw.WriteLine($"{a.kerdesek[i].kerdes};{a.kerdesek[i].a};{a.kerdesek[i].b};{a.kerdesek[i].c};{a.kerdesek[i].d};{a.kerdesek[i].helyesValasz}");
                }
                sw.Close();
            }
        }

        private void lbAdatok_SelectedIndexChanged(object sender, EventArgs e) {
            int index = lbAdatok.SelectedIndex;
            tbKerdes.Text = a.kerdesek[index].kerdes;
            tbA.Text = a.kerdesek[index].a;
            tbB.Text = a.kerdesek[index].b;
            tbC.Text = a.kerdesek[index].c;
            tbD.Text = a.kerdesek[index].d;
            tbHelyes.Text = a.kerdesek[index].helyesValasz.ToString();
        }

        private void bHozzaad_Click(object sender, EventArgs e) {
            Kerdes k = new Kerdes();
            k.kerdes = tbKerdes.Text;
            k.a = tbA.Text;
            k.b = tbB.Text;
            k.c = tbC.Text;
            k.d = tbD.Text;
            k.helyesValasz = Convert.ToInt32(tbHelyes.Text);
            a.kerdesek.Add(k);
            lbAdatok.Items.Add(k.kerdes);
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            //if (ofd.ShowDialog()==DialogResult.OK) {
                StreamReader sr = new StreamReader("kerdesek.txt");
                while (!sr.EndOfStream) {
                    List<string> adatok = sr.ReadLine().Split(';').ToList();
                    Kerdes k = new Kerdes();
                    k.kerdes = adatok[0];
                    k.a = adatok[1];
                    k.b = adatok[2];
                    k.c = adatok[3];
                    k.d = adatok[4];
                    k.helyesValasz = Convert.ToInt32(adatok[5]);
                    a.kerdesek.Add(k);
                    lbAdatok.Items.Add(k.kerdes);
                    
                }
                sr.Close();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v;
            Random r = new Random();
            v = r.Next(0, a.kerdesek.Count);
            Kerdes kerdes = a.kerdesek[v];
            label7.Text = kerdes.kerdes;
            label8.Text = kerdes.a;
            label9.Text = kerdes.b;
            label10.Text = kerdes.c;
            label11.Text = kerdes.d;
        }
    }
}
