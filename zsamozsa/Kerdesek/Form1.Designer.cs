
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
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.tbAdd = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbNevH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // tbAdd
            // 
            this.tbAdd.AutoSize = true;
            this.tbAdd.BackColor = System.Drawing.Color.Transparent;
            this.tbAdd.Font = new System.Drawing.Font("Myanmar Text", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbAdd.Location = new System.Drawing.Point(113, 97);
            this.tbAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(150, 29);
            this.tbAdd.TabIndex = 33;
            this.tbAdd.Text = "Add meg a neved:";
            // 
            // tbNev
            // 
            this.tbNev.BackColor = System.Drawing.Color.DarkBlue;
            this.tbNev.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Bold);
            this.tbNev.ForeColor = System.Drawing.Color.White;
            this.tbNev.Location = new System.Drawing.Point(280, 89);
            this.tbNev.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNev.Multiline = true;
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(223, 38);
            this.tbNev.TabIndex = 34;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tbNevH
            // 
            this.tbNevH.BackColor = System.Drawing.Color.DarkBlue;
            this.tbNevH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tbNevH.Font = new System.Drawing.Font("Myanmar Text", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbNevH.ForeColor = System.Drawing.Color.White;
            this.tbNevH.Location = new System.Drawing.Point(119, 139);
            this.tbNevH.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNevH.Name = "tbNevH";
            this.tbNevH.Size = new System.Drawing.Size(385, 58);
            this.tbNevH.TabIndex = 35;
            this.tbNevH.Text = "Regisztráció";
            this.tbNevH.UseVisualStyleBackColor = false;
            this.tbNevH.Click += new System.EventHandler(this.tbNevH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(673, 263);
            this.Controls.Add(this.tbNevH);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbAdd);
            this.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Felvétel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label tbAdd;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Button tbNevH;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

