
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
            this.tbKerdes = new System.Windows.Forms.TextBox();
            this.tbHelyes = new System.Windows.Forms.TextBox();
            this.tbD = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bHozzaad = new System.Windows.Forms.Button();
            this.lbAdatok = new System.Windows.Forms.ListBox();
            this.bMentes = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbKerdes
            // 
            this.tbKerdes.Location = new System.Drawing.Point(116, 16);
            this.tbKerdes.Name = "tbKerdes";
            this.tbKerdes.Size = new System.Drawing.Size(100, 20);
            this.tbKerdes.TabIndex = 0;
            this.tbKerdes.Text = "Kérdés";
            // 
            // tbHelyes
            // 
            this.tbHelyes.Location = new System.Drawing.Point(116, 146);
            this.tbHelyes.Name = "tbHelyes";
            this.tbHelyes.Size = new System.Drawing.Size(100, 20);
            this.tbHelyes.TabIndex = 1;
            this.tbHelyes.Text = "1";
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(116, 120);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(100, 20);
            this.tbD.TabIndex = 2;
            this.tbD.Text = "D";
            // 
            // tbC
            // 
            this.tbC.Location = new System.Drawing.Point(116, 94);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(100, 20);
            this.tbC.TabIndex = 3;
            this.tbC.Text = "C";
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(116, 68);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(100, 20);
            this.tbB.TabIndex = 4;
            this.tbB.Text = "B";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(116, 42);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(100, 20);
            this.tbA.TabIndex = 5;
            this.tbA.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Válasz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "helyes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "D:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "B:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "A:";
            // 
            // bHozzaad
            // 
            this.bHozzaad.Location = new System.Drawing.Point(18, 184);
            this.bHozzaad.Name = "bHozzaad";
            this.bHozzaad.Size = new System.Drawing.Size(198, 23);
            this.bHozzaad.TabIndex = 12;
            this.bHozzaad.Text = "Hozzáad";
            this.bHozzaad.UseVisualStyleBackColor = true;
            this.bHozzaad.Click += new System.EventHandler(this.bHozzaad_Click);
            // 
            // lbAdatok
            // 
            this.lbAdatok.FormattingEnabled = true;
            this.lbAdatok.Location = new System.Drawing.Point(254, 16);
            this.lbAdatok.Name = "lbAdatok";
            this.lbAdatok.Size = new System.Drawing.Size(234, 147);
            this.lbAdatok.TabIndex = 13;
            this.lbAdatok.SelectedIndexChanged += new System.EventHandler(this.lbAdatok_SelectedIndexChanged);
            // 
            // bMentes
            // 
            this.bMentes.Location = new System.Drawing.Point(377, 184);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(200, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 287);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(617, 287);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 420);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bMentes);
            this.Controls.Add(this.lbAdatok);
            this.Controls.Add(this.bHozzaad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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

        private System.Windows.Forms.TextBox tbKerdes;
        private System.Windows.Forms.TextBox tbHelyes;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bHozzaad;
        private System.Windows.Forms.ListBox lbAdatok;
        private System.Windows.Forms.Button bMentes;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

