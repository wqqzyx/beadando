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
using System.Runtime.InteropServices;   

namespace Kerdesek
{
    public partial class Form1 : Form
    {
        public static Form1 Instance;
        public TextBox tbN;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
            tbN = tbNev;
        }
        Kerdesek a = new Kerdesek();
        string nev = "";
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
        public void Form1_Load(object sender, EventArgs e)
        {
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
            sr.Close();
           
        }
        public void tbNevH_Click(object sender, EventArgs e)
        {
            nev = tbNev.Text;
            if (nev != "")
            {
                tbAdd.Visible = false;
                tbNev.Visible = false;
                tbNevH.Visible = false;
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Először adj meg egy nevet, hogy játszhass!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}