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
        int v;
        int pont = 0;
        string nev = "";
        int[] nyeremenyek = new int[] { 1000, 3000, 6000, 12000, 25000, 50000, 100000, 200000, 400000, 800000, 1500000, 3000000, 6000000, 12500000, 25000000 };
        int elnyertPenz = 0;
        bool kozonseg = false;
        bool telefon = false;
        bool felezes = false;
        public void bMegnyitas_Click(object sender, EventArgs e) {
            
            
        }
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
            LKerdes.Text = a.kerdesek[index].kerdes;
            tbA.Text = a.kerdesek[index].a;
            tbB.Text = a.kerdesek[index].b;
            tbC.Text = a.kerdesek[index].c;
            tbD.Text = a.kerdesek[index].d;
            tbHelyes.Text = a.kerdesek[index].helyesValasz.ToString();
        }

        private void bHozzaad_Click(object sender, EventArgs e) {
            Kerdes k = new Kerdes();
            k.kerdes = LKerdes.Text;
            k.a = tbA.Text;
            k.b = tbB.Text;
            k.c = tbC.Text;
            k.d = tbD.Text;
            k.helyesValasz = Convert.ToChar(tbHelyes.Text);
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
                    k.helyesValasz = Convert.ToChar(adatok[5]);
                    a.kerdesek.Add(k);
                    //lbAdatok.Items.Add(k.kerdes);
                }
            for (int i = 0; i < nyeremenyek.Length; i++)
            {
                Penz.Items.Add(nyeremenyek[i]+" Ft");
            }
                sr.Close();
            gen();
            tel.Visible = false;
            koz.Visible = false;
            fel.Visible = false;
            //}
        }
        public void gen()
        {
            Random r = new Random();
            v = r.Next(0, a.kerdesek.Count);
            Kerdes kerdes = a.kerdesek[v];
            LKerdes.Text = kerdes.kerdes;
            LKerdes.TextAlign = ContentAlignment.TopCenter;
            tbA.Text = kerdes.a;
            tbB.Text = kerdes.b;
            tbC.Text = kerdes.c;
            tbD.Text = kerdes.d;            

        }
        public void button1_Click(object sender, EventArgs e)
        {
            gen();
        }
        public void bBekuld_Click(object sender, EventArgs e)
        {
            if (nev!="")
            {
            string valasz = tbHelyes.Text;
            Kerdes kerdes = a.kerdesek[v];
            string megoldas = kerdes.helyesValasz.ToString();
            int k = 0;
            if (valasz == megoldas)
            {
                pont++;
                LPont.Text = pont.ToString();
                
                elnyertPenz = nyeremenyek[k];
                nyeremenyek[k] = nyeremenyek[k++];
                lbAdatok.Items.Add(elnyertPenz);
                 gen();
            }
            else
            {
                pont--;
                LPont.Text = pont.ToString();
                gen();
                tbHelyes.Text = "";
                
                    MessageBox.Show("Válaszod helytelen, így kiestél a játékból, nyereményed pedig: {0}");
                } 
            
            } 
            else
            {
                MessageBox.Show("Először adj meg egy nevet, hogy játszhass!");
            }
        }

        private void tbNevH_Click(object sender, EventArgs e)
        {
            nev = tbNevH.Text;
            tbAdd.Visible = false;
            tbNev.Visible = false;
            tbNevH.Visible = false;
            tbV.Location=new Point(265,106);
            tbHelyes.Location = new Point(320, 106);
            bBekuld.Location = new Point(490, 105);
        }

        private void bSegítség_Click(object sender, EventArgs e)
        {
            bSegítség.Visible = false;
            tel.Visible = true;
            koz.Visible = true;
            fel.Visible = true;
        }

        private void tel_Click(object sender, EventArgs e)
        {
            if (telefon==false)
            {
            int random;
            Random r = new Random();
            random=r.Next(0, 3);
            TelHelp.Text = "Jóska bácsi szerint a helyes megoldás a: " + random;
            telefon = true;
            } 
            else
            {
                MessageBox.Show( "Használtad már ezt a segítséget","Hiba",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void koz_Click(object sender, EventArgs e)
        {
            if (kozonseg == false)
            {
                int random;
                Random r = new Random();
                random = r.Next(0, 3);
                TelHelp.Text = "A közönség szavazatai szerint a helyes megoldás a: " + random;
                kozonseg = true;
            }
            else
            {
                MessageBox.Show("Használtad már ezt a segítséget", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
