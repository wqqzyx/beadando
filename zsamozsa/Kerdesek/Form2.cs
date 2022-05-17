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
using System.Media;


namespace Kerdesek
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Kerdesek a = new Kerdesek();
        int v;
        int[] nyeremenyek = new int[] { 1000, 3000, 6000, 12000, 25000, 50000, 100000, 200000, 400000, 800000, 1500000, 3000000, 6000000, 12500000, 25000000 };
        int elnyertPenz = 0;
        int k = 0;
        int o = -1; 
        bool kozonseg = false;
        bool telefon = false;
        bool felezes = false;
        public void bMegnyitas_Click(object sender, EventArgs e)
        {
        }
        private void bMentes_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                for (int i = 0; i < a.kerdesek.Count; i++)
                {
                    sw.WriteLine($"{a.kerdesek[i].kerdes};{a.kerdesek[i].a};{a.kerdesek[i].b};{a.kerdesek[i].c};{a.kerdesek[i].d};{a.kerdesek[i].helyesValasz}");
                }
                sw.Close();
            }
        }
        private void lbAdatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lbAdatok.SelectedIndex;
            LKerdes.Text = a.kerdesek[index].kerdes;
            bA.Text = a.kerdesek[index].a;
            bB.Text = a.kerdesek[index].b;
            bC.Text = a.kerdesek[index].c;
            bD.Text = a.kerdesek[index].d;
            tbHelyes.Text = a.kerdesek[index].helyesValasz.ToString();
        }

        private void bHozzaad_Click(object sender, EventArgs e)
        {
            Kerdes k = new Kerdes();
            k.kerdes = LKerdes.Text;
            k.a = bA.Text;
            k.b = bB.Text;
            k.c = bC.Text;
            k.d = bD.Text;
            k.helyesValasz = Convert.ToChar(tbHelyes.Text);
            a.kerdesek.Add(k);
            lbAdatok.Items.Add(k.kerdes);
        }

        public void Form2_Load_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            LKerdes.ForeColor = Color.White;
            StreamReader sr = new StreamReader("kerdesek.txt");
            while (!sr.EndOfStream)
            {
                List<string> adatok = sr.ReadLine().Split(';').ToList();
                Kerdes k = new Kerdes();
                k.kerdes = adatok[0];
                k.a = adatok[1];
                k.b = adatok[2];
                k.c = adatok[3];
                k.d = adatok[4];
                k.helyesValasz = Convert.ToChar(adatok[5]);
                a.kerdesek.Add(k);
            }
            for (int i = 1; i < nyeremenyek.Length; i++)
            {
                Penz.Items.Add($"{i} " + nyeremenyek[i] + " Ft");
            }
            sr.Close();
            gen();
            mB.Visible = false;
        }
        public void gen()
        {
            Random r = new Random();
            v = r.Next(0, a.kerdesek.Count);
            Kerdes kerdes = a.kerdesek[v];
            LKerdes.Text = kerdes.kerdes;
            LKerdes.TextAlign = ContentAlignment.TopCenter;
            bA.Text = kerdes.a;
            bB.Text = kerdes.b;
            bC.Text = kerdes.c;
            bD.Text = kerdes.d;
            tbHelyes.Text = kerdes.helyesValasz.ToString();
        }
        private void bA_Click(object sender, EventArgs e)
        {
            string valasz = "1";
            Kerdes kerdes = a.kerdesek[v];
            string megoldas = kerdes.helyesValasz.ToString();
            if (valasz == megoldas && elnyertPenz != 25000000)
            {
                elnyertPenz = nyeremenyek[k];
                nyeremenyek[k] = nyeremenyek[k++];
                lbAdatok.Items.Add(elnyertPenz);
                o++;
                Penz.SelectedIndex = o;
                gen();
                //bA.BackColor = Color.DarkBlue;
            }
            else
            {
                MessageBox.Show("Válaszod helytelen, így kiestél a játékból, nyereményed pedig: " + elnyertPenz.ToString() + " Ft");
                Application.Exit();
            }
            if (elnyertPenz == 25000000 && o == 14 && lbAdatok.SelectedIndex == 13)
            {
                MessageBox.Show("Gratulálok, megnyerted a főnyereményt! A játék itt véget ér. Nyereményed: " + elnyertPenz.ToString() + " Ft");
                Application.Exit();
            }
            if (kozonseg == true)
            {
                koz.Visible = false;
            }
            if (telefon == true)
            {
                tel.Visible = false;
            }

        }

        private void bB_Click(object sender, EventArgs e)
        {
            bB.BackColor = Color.Orange;
            string valasz = "2";
            Kerdes kerdes = a.kerdesek[v];
            string megoldas = kerdes.helyesValasz.ToString();
            if (valasz == megoldas && elnyertPenz != 25000000)
            {
                elnyertPenz = nyeremenyek[k];
                nyeremenyek[k] = nyeremenyek[k++];
                lbAdatok.Items.Add(elnyertPenz);
                o++;
                Penz.SelectedIndex = o;
                gen();
            }
            else
            {
                MessageBox.Show("Válaszod helytelen, így kiestél a játékból, nyereményed pedig: " + elnyertPenz.ToString() + " Ft");
                Application.Exit();
            }
            if (elnyertPenz == 25000000 && o == 14 && lbAdatok.SelectedIndex == 13)
            {
                MessageBox.Show("Gratulálok, megnyerted a főnyereményt! A játék itt véget ér. Nyereményed: " + elnyertPenz.ToString() + " Ft");
                Application.Exit();
            }
            if (kozonseg == true)
            {
                koz.Visible = false;
            }
            if (telefon == true)
            {
                tel.Visible=false;
            }
            bB.BackColor = Color.DarkBlue;
        }

        private void bC_Click(object sender, EventArgs e)
        {
            bC.BackColor = Color.Orange;
            string valasz = "3";
            Kerdes kerdes = a.kerdesek[v];
            string megoldas = kerdes.helyesValasz.ToString();
            if (valasz == megoldas && elnyertPenz != 25000000)
            {
                elnyertPenz = nyeremenyek[k];
                nyeremenyek[k] = nyeremenyek[k++];
                lbAdatok.Items.Add(elnyertPenz);
                o++;
                Penz.SelectedIndex = o;
                gen();
            }
            else
            {
                
                MessageBox.Show("Válaszod helytelen, így kiestél a játékból, nyereményed pedig: " + elnyertPenz.ToString() + " Ft");
                Application.Exit();
            }
            if (elnyertPenz == 25000000 && o==14 && lbAdatok.SelectedIndex == 13)
            {
                MessageBox.Show("Gratulálok, megnyerted a főnyereményt! A játék itt véget ér. Nyereményed: " + elnyertPenz.ToString() + " Ft");
                Application.Exit();
            }
            if (kozonseg == true)
            {
                koz.Visible = false;
            }
            if (telefon == true)
            {
                tel.Visible = false;
            }
            bC.BackColor = Color.DarkBlue;
        }

        private void bD_Click(object sender, EventArgs e)
        {
            bD.BackColor = Color.Orange;
            string valasz = "4";
            Kerdes kerdes = a.kerdesek[v];
            string megoldas = kerdes.helyesValasz.ToString();
            if (valasz == megoldas && elnyertPenz != 25000000)
            {
                elnyertPenz = nyeremenyek[k];
                nyeremenyek[k] = nyeremenyek[k++];
                lbAdatok.Items.Add(elnyertPenz);
                o++;
                Penz.SelectedIndex = o;
                gen();
            }
            else
            {
                MessageBox.Show("Válaszod helytelen, így kiestél a játékból, nyereményed pedig: " + elnyertPenz.ToString() + " Ft");
                Application.Exit();
            }
            if (elnyertPenz == 25000000 && o == 14 && lbAdatok.SelectedIndex == 13)
            {
                MessageBox.Show("Gratulálok, megnyerted a főnyereményt! A játék itt véget ér. Nyereményed: " +elnyertPenz.ToString() + " Ft");
                Application.Exit();
            }
            if (kozonseg == true)
            {
                koz.Visible = false;
            }
            if (telefon == true)
            {
                tel.Visible = false;
            }
            bD.BackColor = Color.DarkBlue;
        }
        private void fel_Click(object sender, EventArgs e)
        {
            Kerdes k = new Kerdes();
            if (felezes == false)
            {
                List<string> maradek = new List<string>();
                switch (Convert.ToInt32(k.helyesValasz))
                {
                    case 1: maradek.Add(k.a); break;
                    case 2: maradek.Add(k.b); break;
                    case 3: maradek.Add(k.c); break;
                    case 4: maradek.Add(k.d); break;
                }
                int uj;
                Random r = new Random();
                do
                {
                    uj = r.Next(1, 4);
                } while (uj == k.helyesValasz);
                switch (uj)
                {
                    case 1: maradek.Add(k.a); break;
                    case 2: maradek.Add(k.b); break;
                    case 3: maradek.Add(k.c); break;
                    case 4: maradek.Add(k.d); break;
                }

                for (int j = 0; j < maradek.Count; j++)
                {
                    if (maradek[j] == k.a)
                    {
                        label6.Visible = false;
                        bA.Visible = false;
                    }
                    else if (maradek[j] == k.b)
                    {
                        label5.Visible = false;
                        bB.Visible = false;
                    }
                    else if (maradek[j] == k.c)
                    {
                        label4.Visible = false;
                        bC.Visible = false;
                    }
                    else
                    {
                        label3.Visible = false;
                        bD.Visible = false;
                    }
                }
            }
        }
        private void tel_Click(object sender, EventArgs e)
        {
            if (telefon == false)
            {
                int random;
                Random r = new Random();
                random = r.Next(1, 4);

                Kerdes kerdes = a.kerdesek[v];
                kell();
                switch (random)
                {
                    case 1:
                    MessageBox.Show("Jóska bácsi szerint a helyes megoldás a: " + kerdes.a);
                        break;
                    case 2:
                        MessageBox.Show("Jóska bácsi szerint a helyes megoldás a: " + kerdes.b);
                        break;
                    case 3:
                        MessageBox.Show("Jóska bácsi szerint a helyes megoldás a: " + kerdes.c);
                        break;
                    case 4:
                        MessageBox.Show("Jóska bácsi szerint a helyes megoldás a: " + kerdes.d);
                        break;
                }
                telefon = true;
                tel.Visible = false;
            }
            else
            {
                MessageBox.Show("Használtad már ezt a segítséget", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void koz_Click(object sender, EventArgs e)
        {
            if (kozonseg==false)
            {
            koz.Visible = false;
            Panel.Visible = true;

            idozito.Start();

            pA.Visible = true;
            pB.Visible = true;
            pC.Visible = true;
            pD.Visible = true;
            mB.Text= "A százalékok a közönség magabiztosságát jelzi az egyes válaszokban.";
            }
            else
            {
                MessageBox.Show("Használtad már ezt a segítséget", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int ido = 0;
        private void idozito_Tick(object sender, EventArgs e)
        {
            ido++;
            Random r = new Random();
            int[] szamok = Enumerable.Range(1, 4).Select(x => r.Next(0, 100)).ToArray();
            pbA.Increment(szamok[0]);
            pbB.Increment(szamok[1]);
            pbC.Increment(szamok[2]);
            pbD.Increment(szamok[3]);

            idozito.Stop();

            kA.Text = pbA.Value.ToString() + "%";
            kB.Text = pbB.Value.ToString() + "%";
            kC.Text = pbC.Value.ToString() + "%";
            kD.Text = pbD.Value.ToString() + "%";

            if (ido==2)
            {
                Application.Exit();
            }
        }
    }
}
