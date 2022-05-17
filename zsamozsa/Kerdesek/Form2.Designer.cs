namespace Kerdesek
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TelHelp = new System.Windows.Forms.Label();
            this.Penz = new System.Windows.Forms.ListBox();
            this.LKerdes = new System.Windows.Forms.Label();
            this.lbAdatok = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.fel = new System.Windows.Forms.Label();
            this.koz = new System.Windows.Forms.Label();
            this.tel = new System.Windows.Forms.Label();
            this.bA = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bD = new System.Windows.Forms.Button();
            this.bB = new System.Windows.Forms.Button();
            this.tbHelyes = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Panel = new System.Windows.Forms.Panel();
            this.kD = new System.Windows.Forms.Label();
            this.kA = new System.Windows.Forms.Label();
            this.kB = new System.Windows.Forms.Label();
            this.kC = new System.Windows.Forms.Label();
            this.pbD = new System.Windows.Forms.ProgressBar();
            this.pbC = new System.Windows.Forms.ProgressBar();
            this.pbB = new System.Windows.Forms.ProgressBar();
            this.pbA = new System.Windows.Forms.ProgressBar();
            this.pD = new System.Windows.Forms.Label();
            this.pC = new System.Windows.Forms.Label();
            this.pB = new System.Windows.Forms.Label();
            this.pA = new System.Windows.Forms.Label();
            this.idozito = new System.Windows.Forms.Timer(this.components);
            this.mB = new System.Windows.Forms.Label();
            this.bMentes = new System.Windows.Forms.Button();
            this.bHozzaad = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TelHelp
            // 
            this.TelHelp.AutoSize = true;
            this.TelHelp.Location = new System.Drawing.Point(61, 273);
            this.TelHelp.Name = "TelHelp";
            this.TelHelp.Size = new System.Drawing.Size(0, 13);
            this.TelHelp.TabIndex = 75;
            // 
            // Penz
            // 
            this.Penz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Penz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Penz.Font = new System.Drawing.Font("Myanmar Text", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Penz.ForeColor = System.Drawing.Color.Gold;
            this.Penz.FormattingEnabled = true;
            this.Penz.ItemHeight = 18;
            this.Penz.Location = new System.Drawing.Point(709, 23);
            this.Penz.Name = "Penz";
            this.Penz.Size = new System.Drawing.Size(123, 272);
            this.Penz.TabIndex = 75;
            // 
            // LKerdes
            // 
            this.LKerdes.Font = new System.Drawing.Font("Myanmar Text", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LKerdes.Location = new System.Drawing.Point(92, 149);
            this.LKerdes.Name = "LKerdes";
            this.LKerdes.Size = new System.Drawing.Size(500, 47);
            this.LKerdes.TabIndex = 72;
            this.LKerdes.Text = "Kérdés";
            // 
            // lbAdatok
            // 
            this.lbAdatok.FormattingEnabled = true;
            this.lbAdatok.Location = new System.Drawing.Point(721, 402);
            this.lbAdatok.Name = "lbAdatok";
            this.lbAdatok.Size = new System.Drawing.Size(133, 56);
            this.lbAdatok.TabIndex = 63;
            this.lbAdatok.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(98, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 29);
            this.label6.TabIndex = 61;
            this.label6.Text = "A:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(388, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 29);
            this.label5.TabIndex = 60;
            this.label5.Text = "B:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(98, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 29);
            this.label4.TabIndex = 59;
            this.label4.Text = "C:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(387, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 29);
            this.label3.TabIndex = 58;
            this.label3.Text = "D:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fel
            // 
            this.fel.Image = global::Kerdesek.Properties.Resources.felezes;
            this.fel.Location = new System.Drawing.Point(527, 9);
            this.fel.Name = "fel";
            this.fel.Size = new System.Drawing.Size(165, 100);
            this.fel.TabIndex = 80;
            this.fel.Text = " ";
            this.fel.Click += new System.EventHandler(this.fel_Click);
            // 
            // koz
            // 
            this.koz.Image = global::Kerdesek.Properties.Resources.kozonseg;
            this.koz.Location = new System.Drawing.Point(268, 9);
            this.koz.Name = "koz";
            this.koz.Size = new System.Drawing.Size(165, 100);
            this.koz.TabIndex = 79;
            this.koz.Click += new System.EventHandler(this.koz_Click);
            // 
            // tel
            // 
            this.tel.Image = global::Kerdesek.Properties.Resources.telefon;
            this.tel.Location = new System.Drawing.Point(12, 9);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(165, 100);
            this.tel.TabIndex = 0;
            this.tel.Click += new System.EventHandler(this.tel_Click);
            // 
            // bA
            // 
            this.bA.BackColor = System.Drawing.Color.DarkBlue;
            this.bA.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bA.ForeColor = System.Drawing.Color.White;
            this.bA.Location = new System.Drawing.Point(122, 220);
            this.bA.Name = "bA";
            this.bA.Size = new System.Drawing.Size(180, 43);
            this.bA.TabIndex = 81;
            this.bA.Text = "Válasz";
            this.bA.UseVisualStyleBackColor = false;
            this.bA.Click += new System.EventHandler(this.bA_Click);
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.Color.DarkBlue;
            this.bC.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bC.ForeColor = System.Drawing.Color.White;
            this.bC.Location = new System.Drawing.Point(122, 291);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(180, 42);
            this.bC.TabIndex = 82;
            this.bC.Text = "Válasz";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bD
            // 
            this.bD.BackColor = System.Drawing.Color.DarkBlue;
            this.bD.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bD.ForeColor = System.Drawing.Color.White;
            this.bD.Location = new System.Drawing.Point(412, 291);
            this.bD.Name = "bD";
            this.bD.Size = new System.Drawing.Size(180, 43);
            this.bD.TabIndex = 83;
            this.bD.Text = "Válasz";
            this.bD.UseVisualStyleBackColor = false;
            this.bD.Click += new System.EventHandler(this.bD_Click);
            // 
            // bB
            // 
            this.bB.BackColor = System.Drawing.Color.DarkBlue;
            this.bB.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bB.ForeColor = System.Drawing.Color.White;
            this.bB.Location = new System.Drawing.Point(412, 220);
            this.bB.Name = "bB";
            this.bB.Size = new System.Drawing.Size(180, 43);
            this.bB.TabIndex = 84;
            this.bB.Text = "Válasz";
            this.bB.UseVisualStyleBackColor = false;
            this.bB.Click += new System.EventHandler(this.bB_Click);
            // 
            // tbHelyes
            // 
            this.tbHelyes.Location = new System.Drawing.Point(231, 356);
            this.tbHelyes.Name = "tbHelyes";
            this.tbHelyes.Size = new System.Drawing.Size(164, 20);
            this.tbHelyes.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(248, 340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 13);
            this.label17.TabIndex = 66;
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.kD);
            this.Panel.Controls.Add(this.kA);
            this.Panel.Controls.Add(this.kB);
            this.Panel.Controls.Add(this.kC);
            this.Panel.Controls.Add(this.pbD);
            this.Panel.Controls.Add(this.pbC);
            this.Panel.Controls.Add(this.pbB);
            this.Panel.Controls.Add(this.pbA);
            this.Panel.Controls.Add(this.pD);
            this.Panel.Controls.Add(this.pC);
            this.Panel.Controls.Add(this.pB);
            this.Panel.Controls.Add(this.pA);
            this.Panel.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.Panel.Location = new System.Drawing.Point(183, 9);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(338, 137);
            this.Panel.TabIndex = 85;
            this.Panel.Visible = false;
            // 
            // kD
            // 
            this.kD.AutoSize = true;
            this.kD.ForeColor = System.Drawing.Color.White;
            this.kD.Location = new System.Drawing.Point(256, 101);
            this.kD.Name = "kD";
            this.kD.Size = new System.Drawing.Size(53, 25);
            this.kD.TabIndex = 8;
            this.kD.Text = "label1";
            // 
            // kA
            // 
            this.kA.AutoSize = true;
            this.kA.ForeColor = System.Drawing.Color.White;
            this.kA.Location = new System.Drawing.Point(256, 21);
            this.kA.Name = "kA";
            this.kA.Size = new System.Drawing.Size(53, 25);
            this.kA.TabIndex = 86;
            this.kA.Text = "label8";
            // 
            // kB
            // 
            this.kB.AutoSize = true;
            this.kB.ForeColor = System.Drawing.Color.White;
            this.kB.Location = new System.Drawing.Point(256, 46);
            this.kB.Name = "kB";
            this.kB.Size = new System.Drawing.Size(53, 25);
            this.kB.TabIndex = 86;
            this.kB.Text = "label7";
            // 
            // kC
            // 
            this.kC.AutoSize = true;
            this.kC.ForeColor = System.Drawing.Color.White;
            this.kC.Location = new System.Drawing.Point(256, 75);
            this.kC.Name = "kC";
            this.kC.Size = new System.Drawing.Size(53, 25);
            this.kC.TabIndex = 86;
            this.kC.Text = "label2";
            // 
            // pbD
            // 
            this.pbD.Location = new System.Drawing.Point(61, 101);
            this.pbD.Name = "pbD";
            this.pbD.Size = new System.Drawing.Size(172, 23);
            this.pbD.TabIndex = 3;
            // 
            // pbC
            // 
            this.pbC.Location = new System.Drawing.Point(61, 72);
            this.pbC.Name = "pbC";
            this.pbC.Size = new System.Drawing.Size(172, 23);
            this.pbC.TabIndex = 2;
            // 
            // pbB
            // 
            this.pbB.Location = new System.Drawing.Point(61, 43);
            this.pbB.Name = "pbB";
            this.pbB.Size = new System.Drawing.Size(172, 23);
            this.pbB.TabIndex = 1;
            // 
            // pbA
            // 
            this.pbA.Location = new System.Drawing.Point(61, 14);
            this.pbA.Name = "pbA";
            this.pbA.Size = new System.Drawing.Size(172, 23);
            this.pbA.TabIndex = 0;
            // 
            // pD
            // 
            this.pD.AutoSize = true;
            this.pD.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.pD.ForeColor = System.Drawing.Color.White;
            this.pD.Location = new System.Drawing.Point(34, 101);
            this.pD.Name = "pD";
            this.pD.Size = new System.Drawing.Size(26, 25);
            this.pD.TabIndex = 7;
            this.pD.Text = "D:";
            // 
            // pC
            // 
            this.pC.AutoSize = true;
            this.pC.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.pC.ForeColor = System.Drawing.Color.White;
            this.pC.Location = new System.Drawing.Point(34, 72);
            this.pC.Name = "pC";
            this.pC.Size = new System.Drawing.Size(25, 25);
            this.pC.TabIndex = 6;
            this.pC.Text = "C:";
            // 
            // pB
            // 
            this.pB.AutoSize = true;
            this.pB.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.pB.ForeColor = System.Drawing.Color.White;
            this.pB.Location = new System.Drawing.Point(34, 43);
            this.pB.Name = "pB";
            this.pB.Size = new System.Drawing.Size(25, 25);
            this.pB.TabIndex = 5;
            this.pB.Text = "B:";
            // 
            // pA
            // 
            this.pA.AutoSize = true;
            this.pA.Font = new System.Drawing.Font("Myanmar Text", 10F, System.Drawing.FontStyle.Bold);
            this.pA.ForeColor = System.Drawing.Color.White;
            this.pA.Location = new System.Drawing.Point(34, 14);
            this.pA.Name = "pA";
            this.pA.Size = new System.Drawing.Size(26, 25);
            this.pA.TabIndex = 4;
            this.pA.Text = "A:";
            // 
            // idozito
            // 
            this.idozito.Tick += new System.EventHandler(this.idozito_Tick);
            // 
            // mB
            // 
            this.mB.AutoSize = true;
            this.mB.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold);
            this.mB.ForeColor = System.Drawing.Color.White;
            this.mB.Location = new System.Drawing.Point(164, -1);
            this.mB.Name = "mB";
            this.mB.Size = new System.Drawing.Size(52, 21);
            this.mB.TabIndex = 86;
            this.mB.Text = "asdasda";
            // 
            // bMentes
            // 
            this.bMentes.Location = new System.Drawing.Point(284, 402);
            this.bMentes.Name = "bMentes";
            this.bMentes.Size = new System.Drawing.Size(111, 23);
            this.bMentes.TabIndex = 64;
            this.bMentes.Text = "Mentés";
            this.bMentes.UseVisualStyleBackColor = true;
            // 
            // bHozzaad
            // 
            this.bHozzaad.Location = new System.Drawing.Point(61, 402);
            this.bHozzaad.Name = "bHozzaad";
            this.bHozzaad.Size = new System.Drawing.Size(198, 23);
            this.bHozzaad.TabIndex = 62;
            this.bHozzaad.Text = "Hozzáad";
            this.bHozzaad.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 480);
            this.Controls.Add(this.mB);
            this.Controls.Add(this.bB);
            this.Controls.Add(this.bD);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bA);
            this.Controls.Add(this.fel);
            this.Controls.Add(this.koz);
            this.Controls.Add(this.tel);
            this.Controls.Add(this.TelHelp);
            this.Controls.Add(this.Penz);
            this.Controls.Add(this.LKerdes);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.bMentes);
            this.Controls.Add(this.lbAdatok);
            this.Controls.Add(this.bHozzaad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHelyes);
            this.Controls.Add(this.Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Legyen Ön is Milliomos!";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TelHelp;
        private System.Windows.Forms.ListBox Penz;
        private System.Windows.Forms.Label LKerdes;
        private System.Windows.Forms.ListBox lbAdatok;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label tel;
        private System.Windows.Forms.Label koz;
        private System.Windows.Forms.Label fel;
        private System.Windows.Forms.Button bA;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bD;
        private System.Windows.Forms.Button bB;
        private System.Windows.Forms.TextBox tbHelyes;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.ProgressBar pbB;
        private System.Windows.Forms.ProgressBar pbA;
        private System.Windows.Forms.Label pD;
        private System.Windows.Forms.Label pC;
        private System.Windows.Forms.Label pB;
        private System.Windows.Forms.Label pA;
        private System.Windows.Forms.ProgressBar pbD;
        private System.Windows.Forms.ProgressBar pbC;
        private System.Windows.Forms.Timer idozito;
        private System.Windows.Forms.Label kD;
        private System.Windows.Forms.Label kA;
        private System.Windows.Forms.Label kB;
        private System.Windows.Forms.Label kC;
        private System.Windows.Forms.Label mB;
        private System.Windows.Forms.Button bMentes;
        private System.Windows.Forms.Button bHozzaad;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}