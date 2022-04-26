
namespace Kerdesek {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.bHozzaad = new System.Windows.Forms.Button();
            this.bMentes = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbAdatok = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbV = new System.Windows.Forms.Label();
            this.tbHelyes = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbKerdes = new System.Windows.Forms.TextBox();
            this.bBekuld = new System.Windows.Forms.Button();
            this.LPont = new System.Windows.Forms.Label();
            this.tbAdd = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbNevH = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // bHozzaad
            // 
            this.bHozzaad.Location = new System.Drawing.Point(282, 298);
            this.bHozzaad.Name = "bHozzaad";
            this.bHozzaad.Size = new System.Drawing.Size(198, 23);
            this.bHozzaad.TabIndex = 12;
            this.bHozzaad.Text = "Hozzáad";
            this.bHozzaad.UseVisualStyleBackColor = true;
            this.bHozzaad.Click += new System.EventHandler(this.bHozzaad_Click);
            // 
            // bMentes
            // 
            this.bMentes.Location = new System.Drawing.Point(333, 241);
            this.bMentes.Name = "bMentes";
            this.bMentes.Size = new System.Drawing.Size(111, 23);
            this.bMentes.TabIndex = 15;
            this.bMentes.Text = "Mentés";
            this.bMentes.UseVisualStyleBackColor = true;
            this.bMentes.Click += new System.EventHandler(this.bMentes_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(265, 182);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Elért pont:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(251, 336);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 30;
            // 
            // lbAdatok
            // 
            this.lbAdatok.FormattingEnabled = true;
            this.lbAdatok.Location = new System.Drawing.Point(486, 261);
            this.lbAdatok.Name = "lbAdatok";
            this.lbAdatok.Size = new System.Drawing.Size(234, 147);
            this.lbAdatok.TabIndex = 13;
            this.lbAdatok.SelectedIndexChanged += new System.EventHandler(this.lbAdatok_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(602, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "D:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "C:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Válasz:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "A:";
            // 
            // tbV
            // 
            this.tbV.AutoSize = true;
            this.tbV.Location = new System.Drawing.Point(265, 141);
            this.tbV.Name = "tbV";
            this.tbV.Size = new System.Drawing.Size(53, 13);
            this.tbV.TabIndex = 7;
            this.tbV.Text = "Válaszod:";
            // 
            // tbHelyes
            // 
            this.tbHelyes.Location = new System.Drawing.Point(333, 141);
            this.tbHelyes.Name = "tbHelyes";
            this.tbHelyes.Size = new System.Drawing.Size(164, 20);
            this.tbHelyes.TabIndex = 1;
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(626, 61);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(164, 20);
            this.tbD.TabIndex = 2;
            this.tbD.Text = "D";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(432, 61);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(164, 20);
            this.tbC.TabIndex = 3;
            this.tbC.Text = "C";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(239, 61);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(164, 20);
            this.tbB.TabIndex = 4;
            this.tbB.Text = "B";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(39, 61);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(164, 20);
            this.tbA.TabIndex = 5;
            this.tbA.Text = "A";
            // 
            // tbKerdes
            // 
            this.tbKerdes.Location = new System.Drawing.Point(268, 12);
            this.tbKerdes.Multiline = true;
            this.tbKerdes.Name = "tbKerdes";
            this.tbKerdes.Size = new System.Drawing.Size(270, 39);
            this.tbKerdes.TabIndex = 0;
            this.tbKerdes.Text = "Kérdés";
            // 
            // bBekuld
            // 
            this.bBekuld.Location = new System.Drawing.Point(503, 139);
            this.bBekuld.Name = "bBekuld";
            this.bBekuld.Size = new System.Drawing.Size(135, 23);
            this.bBekuld.TabIndex = 31;
            this.bBekuld.Text = "Válasz beküldése";
            this.bBekuld.UseVisualStyleBackColor = true;
            this.bBekuld.Click += new System.EventHandler(this.bBekuld_Click);
            // 
            // LPont
            // 
            this.LPont.AutoSize = true;
            this.LPont.Location = new System.Drawing.Point(330, 182);
            this.LPont.Name = "LPont";
            this.LPont.Size = new System.Drawing.Size(0, 13);
            this.LPont.TabIndex = 32;
            // 
            // tbAdd
            // 
            this.tbAdd.AutoSize = true;
            this.tbAdd.Location = new System.Drawing.Point(265, 106);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(94, 13);
            this.tbAdd.TabIndex = 33;
            this.tbAdd.Text = "Add meg a neved:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(365, 106);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(132, 20);
            this.tbNev.TabIndex = 34;
            // 
            // tbNevH
            // 
            this.tbNevH.Location = new System.Drawing.Point(504, 106);
            this.tbNevH.Name = "tbNevH";
            this.tbNevH.Size = new System.Drawing.Size(134, 23);
            this.tbNevH.TabIndex = 35;
            this.tbNevH.Text = "Regisztrálás";
            this.tbNevH.UseVisualStyleBackColor = true;
            this.tbNevH.Click += new System.EventHandler(this.tbNevH_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 433);
            this.Controls.Add(this.tbNevH);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.LPont);
            this.Controls.Add(this.bBekuld);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.bMentes);
            this.Controls.Add(this.lbAdatok);
            this.Controls.Add(this.bHozzaad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbD);
            this.Controls.Add(this.tbHelyes);
            this.Controls.Add(this.tbKerdes);
            this.Name = "Form1";
            this.Text = "Kérdések";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bHozzaad;
        private System.Windows.Forms.Button bMentes;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ListBox lbAdatok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tbV;
        private System.Windows.Forms.TextBox tbHelyes;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbKerdes;
        private System.Windows.Forms.Button bBekuld;
        private System.Windows.Forms.Label LPont;
        private System.Windows.Forms.Label tbAdd;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Button tbNevH;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

