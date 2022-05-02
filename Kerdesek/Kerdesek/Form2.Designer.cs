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
            this.TelHelp = new System.Windows.Forms.Label();
            this.Penz = new System.Windows.Forms.ListBox();
            this.LKerdes = new System.Windows.Forms.Label();
            this.bMentes = new System.Windows.Forms.Button();
            this.lbAdatok = new System.Windows.Forms.ListBox();
            this.bHozzaad = new System.Windows.Forms.Button();
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
            this.Penz.FormattingEnabled = true;
            this.Penz.Location = new System.Drawing.Point(654, 110);
            this.Penz.Name = "Penz";
            this.Penz.Size = new System.Drawing.Size(133, 212);
            this.Penz.TabIndex = 74;
            // 
            // LKerdes
            // 
            this.LKerdes.Location = new System.Drawing.Point(92, 158);
            this.LKerdes.Name = "LKerdes";
            this.LKerdes.Size = new System.Drawing.Size(500, 13);
            this.LKerdes.TabIndex = 72;
            this.LKerdes.Text = "Kérdés";
            // 
            // bMentes
            // 
            this.bMentes.Location = new System.Drawing.Point(265, 370);
            this.bMentes.Name = "bMentes";
            this.bMentes.Size = new System.Drawing.Size(111, 23);
            this.bMentes.TabIndex = 64;
            this.bMentes.Text = "Mentés";
            this.bMentes.UseVisualStyleBackColor = true;
            // 
            // lbAdatok
            // 
            this.lbAdatok.FormattingEnabled = true;
            this.lbAdatok.Location = new System.Drawing.Point(654, 369);
            this.lbAdatok.Name = "lbAdatok";
            this.lbAdatok.Size = new System.Drawing.Size(133, 56);
            this.lbAdatok.TabIndex = 63;
            // 
            // bHozzaad
            // 
            this.bHozzaad.Location = new System.Drawing.Point(61, 370);
            this.bHozzaad.Name = "bHozzaad";
            this.bHozzaad.Size = new System.Drawing.Size(198, 23);
            this.bHozzaad.TabIndex = 62;
            this.bHozzaad.Text = "Hozzáad";
            this.bHozzaad.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(331, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "D:";
            // 
            // fel
            // 
            this.fel.Image = global::Kerdesek.Properties.Resources.felezes;
            this.fel.Location = new System.Drawing.Point(440, 18);
            this.fel.Name = "fel";
            this.fel.Size = new System.Drawing.Size(165, 100);
            this.fel.TabIndex = 80;
            this.fel.Text = " ";
            // 
            // koz
            // 
            this.koz.Image = global::Kerdesek.Properties.Resources.kozonseg;
            this.koz.Location = new System.Drawing.Point(248, 18);
            this.koz.Name = "koz";
            this.koz.Size = new System.Drawing.Size(165, 100);
            this.koz.TabIndex = 79;
            // 
            // tel
            // 
            this.tel.Image = global::Kerdesek.Properties.Resources.telefon;
            this.tel.Location = new System.Drawing.Point(58, 18);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(165, 100);
            this.tel.TabIndex = 0;
            this.tel.Click += new System.EventHandler(this.tel_Click);
            // 
            // bA
            // 
            this.bA.Location = new System.Drawing.Point(95, 192);
            this.bA.Name = "bA";
            this.bA.Size = new System.Drawing.Size(164, 23);
            this.bA.TabIndex = 81;
            this.bA.Text = "Válasz";
            this.bA.UseVisualStyleBackColor = true;
            this.bA.Click += new System.EventHandler(this.bA_Click);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(95, 255);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(164, 23);
            this.bC.TabIndex = 82;
            this.bC.Text = "Válasz";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bD
            // 
            this.bD.Location = new System.Drawing.Point(355, 255);
            this.bD.Name = "bD";
            this.bD.Size = new System.Drawing.Size(164, 23);
            this.bD.TabIndex = 83;
            this.bD.Text = "Válasz";
            this.bD.UseVisualStyleBackColor = true;
            this.bD.Click += new System.EventHandler(this.bD_Click);
            // 
            // bB
            // 
            this.bB.Location = new System.Drawing.Point(355, 192);
            this.bB.Name = "bB";
            this.bB.Size = new System.Drawing.Size(164, 23);
            this.bB.TabIndex = 84;
            this.bB.Text = "Válasz";
            this.bB.UseVisualStyleBackColor = true;
            this.bB.Click += new System.EventHandler(this.bB_Click);
            // 
            // tbHelyes
            // 
            this.tbHelyes.Location = new System.Drawing.Point(231, 317);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "Form2";
            this.Text = "Legyen Ön is Milliomos!";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TelHelp;
        private System.Windows.Forms.ListBox Penz;
        private System.Windows.Forms.Label LKerdes;
        private System.Windows.Forms.Button bMentes;
        private System.Windows.Forms.ListBox lbAdatok;
        private System.Windows.Forms.Button bHozzaad;
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
    }
}