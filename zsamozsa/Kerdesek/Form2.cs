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
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance=this;
        }
        string nev = Form1.Instance.tbN.Text;
        Kerdesek a = new Kerdesek();
        int v;
        int[] nyeremenyek = new int[] { 1000, 3000, 6000, 12000, 25000, 50000, 100000, 200000, 400000, 800000, 1500000, 3000000, 6000000, 12500000, 25000000 };
        int elnyertPenz = 0;
        int k = 0;
        int o = -1; 
        bool kozonseg = false;
        bool telefon = false;
        bool felezes = false;
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
        public void kiiras()
        {
            StreamWriter sw = new StreamWriter("nyertes.txt"); 
            sw.WriteLine("{0} nevű játékos {1} Ft-t nyert", nev, elnyertPenz);
            sw.Close();
        }
        private void bA_Click(object sender, EventArgs e)
        {
            string valasz = "1";
            Kerdes kerdes = a.kerdesek[v];
            string megoldas = kerdes.helyesValasz.ToString();
            if (valasz == megoldas)
            {
                elnyertPenz = nyeremenyek[k];
                nyeremenyek[k] = nyeremenyek[k++];
                lbAdatok.Items.Add(elnyertPenz);
                if (elnyertPenz == 25000000)
                {
                    MessageBox.Show("Gratulálok, megnyerted a főnyereményt! A játék itt véget ér. Nyereményed: " + elnyertPenz.ToString() + " Ft");
                    Application.Exit();
                }
                else
                {
                    o++;
                    Penz.SelectedIndex = o;
                }
                gen();
                elrejt();
                kiiras();
                megjelen();
            }
            else
            {
                MessageBox.Show("Válaszod helytelen, így kiestél a játékból, nyereményed pedig: " + elnyertPenz.ToString() + " Ft");
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
            string valasz = "2";
            Kerdes kerdes = a.kerdesek[v];
            string megoldas = kerdes.helyesValasz.ToString();
            if (valasz == megoldas)
            {
                elnyertPenz = nyeremenyek[k];
                nyeremenyek[k] = nyeremenyek[k++];
                lbAdatok.Items.Add(elnyertPenz);
                if (elnyertPenz == 25000000)
                {
                    MessageBox.Show("Gratulálok, megnyerted a főnyereményt! A játék itt véget ér. Nyereményed: " + elnyertPenz.ToString() + " Ft");
                    Application.Exit();
                }
                else
                {
                    o++;
                    Penz.SelectedIndex = o;
                }
                gen();
                elrejt();
                kiiras();
                megjelen();
            }
            else
            {
                MessageBox.Show("Válaszod helytelen, így kiestél a játékból, nyereményed pedig: " + elnyertPenz.ToString() + " Ft");
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
            
        }

        private void bC_Click(object sender, EventArgs e)
        {
            string valasz = "3";
            Kerdes kerdes = a.kerdesek[v];
            string megoldas = kerdes.helyesValasz.ToString();
            if (valasz == megoldas)
            {
                elnyertPenz = nyeremenyek[k];
                nyeremenyek[k] = nyeremenyek[k++];
                lbAdatok.Items.Add(elnyertPenz);
                if (elnyertPenz == 25000000)
                {
                    MessageBox.Show("Gratulálok, megnyerted a főnyereményt! A játék itt véget ér. Nyereményed: " + elnyertPenz.ToString() + " Ft");
                    Application.Exit();
                }
                else
                {
                    o++;
                    Penz.SelectedIndex = o;
                }
                gen();
                elrejt();
                kiiras();
                megjelen();
            }
            else
            {
                MessageBox.Show("Válaszod helytelen, így kiestél a játékból, nyereményed pedig: " + elnyertPenz.ToString() + " Ft");
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

        private void bD_Click(object sender, EventArgs e)
        {
            
            string valasz = "4";
            Kerdes kerdes = a.kerdesek[v];
            string megoldas = kerdes.helyesValasz.ToString();
            if (valasz == megoldas)
            {
                elnyertPenz = nyeremenyek[k];
                nyeremenyek[k] = nyeremenyek[k++];
                lbAdatok.Items.Add(elnyertPenz);
                if (elnyertPenz == 25000000)
                {
                    MessageBox.Show("Gratulálok, megnyerted a főnyereményt! A játék itt véget ér. Nyereményed: " + elnyertPenz.ToString() + " Ft");
                    Application.Exit();
                }
                else
                {
                    o++;
                    Penz.SelectedIndex = o;
                }
                gen();
                elrejt();
                kiiras();
                megjelen();
            }
            else
            {
                MessageBox.Show("Válaszod helytelen, így kiestél a játékból, nyereményed pedig: " + elnyertPenz.ToString() + " Ft");
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
        private void fel_Click(object sender, EventArgs e)
        {
            Kerdes kerdes = a.kerdesek[v];
            string lakatos = kerdes.helyesValasz.ToString();
            Random q = new Random();
            if (felezes==false)
            {
                int x = q.Next(1,3);
                int y = q.Next(1,3);
                while (y == x)
                    y = q.Next(1,3);
                latszik = true;
                if (lakatos =="1")
                {
                    switch (y)
                    {
                        case 1:
                            bB.Hide();
                            label5.Hide();
                            break;
                        case 2:
                            bC.Hide();
                            label4.Hide();
                            break;
                        case 3:
                            bD.Hide();
                            label3.Hide();
                            break;
                    }
                    switch (x)
                    {
                        case 1:
                            bB.Hide();
                            label5.Hide();
                            break;
                        case 2:
                            bC.Hide();
                            label4.Hide();
                            break;
                        case 3:
                            bD.Hide();
                            label3.Hide();
                            break;
                    }
                }
                else if (lakatos == "2")
                {
                    switch (y)
                    {
                        case 1:
                            bA.Hide();
                            label6.Hide();
                            break;
                        case 2:
                            bC.Hide();
                            label4.Hide();
                            break;
                        case 3:
                            bD.Hide();
                            label3.Hide();
                            break;
                    }
                    switch (x)
                    {
                        case 1:
                            bA.Hide();
                            label6.Hide();
                            break;
                        case 2:
                            bC.Hide();
                            label4.Hide();
                            break;
                        case 3:
                            bD.Hide();
                            label3.Hide();
                            break;
                    }
                }
                else if (lakatos == "3")
                {
                    switch (y)
                    {
                        case 1:
                            bA.Hide();
                            label6.Hide();
                            break;
                        case 2:
                            bB.Hide();
                            label5.Hide();
                            break;
                        case 3:
                            bD.Hide();
                            label3.Hide();
                            break;
                    }
                    switch (x)
                    {
                        case 1:
                            bA.Hide();
                            label6.Hide();
                            break;
                        case 2:
                            bB.Hide();
                            label5.Hide();
                            break;
                        case 3:
                            bD.Hide();
                            label3.Hide();
                            break;
                    }
                }
                else 
                {
                    switch (y)
                    {
                        case 1:
                            bA.Hide();
                            label6.Hide();
                            break;
                        case 2:
                            bB.Hide();
                            label5.Hide();
                            break;
                        case 3:
                            bC.Hide();
                            label4.Hide();
                            break;
                    }
                    switch (x)
                    {
                        case 1:
                            bA.Hide();
                            label6.Hide();
                            break;
                        case 2:
                            bB.Hide();
                            label5.Hide();
                            break;
                        case 3:
                            bC.Hide();
                            label4.Hide();
                            break;
                    }
                }
                fel.Visible = false;
            }
        }
        bool latszik = false;
        private void megjelen()
        {
            if (latszik)
            {
                bA.Show();
                label6.Show();
                bB.Show();
                label5.Show();
                bC.Show();
                label4.Show();
                bD.Show();
                label3.Show();
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
                
                switch (random)
                {
                    case 1:
                    MessageBox.Show("Jóska bácsi szerint a helyes megoldás: " + kerdes.a);
                        break;
                    case 2:
                        MessageBox.Show("Jóska bácsi szerint a helyes megoldás: " + kerdes.b);
                        break;
                    case 3:
                        MessageBox.Show("Jóska bácsi szerint a helyes megoldás: " + kerdes.c);
                        break;
                    case 4:
                        MessageBox.Show("Jóska bácsi szerint a helyes megoldás: " + kerdes.d);
                        break;
                }
                telefon = true;
                tel.Visible = false;
            }
        }
        bool latszodikAdiagram = false;
        private void elrejt()
        {
            if (latszodikAdiagram)
            {
                koz.Visible = false;
                Panel.Visible = false;
                pA.Visible = false;
                pB.Visible = false;
                pC.Visible = false;
                pD.Visible = false;
                mB.Visible = false;
            }   
        }

        private void koz_Click(object sender, EventArgs e)
        {
            latszodikAdiagram = true;
            if (kozonseg==false)
            {
            koz.Visible = false;
            Panel.Visible = true;
            idozito.Start();
            pA.Visible = true;
            pB.Visible = true;
            pC.Visible = true;
            pD.Visible = true;
            mB.Visible = true;
            }
        }
        private void idozito_Tick(object sender, EventArgs e)
        {
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
        }
    }
}