
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
            this.tbAdd.Location = new System.Drawing.Point(202, 95);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(94, 13);
            this.tbAdd.TabIndex = 33;
            this.tbAdd.Text = "Add meg a neved:";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(302, 92);
            this.tbNev.Multiline = true;
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(233, 31);
            this.tbNev.TabIndex = 34;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // tbNevH
            // 
            this.tbNevH.Location = new System.Drawing.Point(205, 129);
            this.tbNevH.Name = "tbNevH";
            this.tbNevH.Size = new System.Drawing.Size(330, 54);
            this.tbNevH.TabIndex = 35;
            this.tbNevH.Text = "Regisztralas";
            this.tbNevH.UseVisualStyleBackColor = true;
            this.tbNevH.Click += new System.EventHandler(this.tbNevH_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 433);
            this.Controls.Add(this.tbNevH);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.tbAdd);
            this.Name = "Form1";
            this.Text = " ";
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

