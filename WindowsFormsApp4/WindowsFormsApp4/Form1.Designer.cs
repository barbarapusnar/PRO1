namespace WindowsFormsApp4
{
    partial class Form1
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
            this.grpTecaji = new System.Windows.Forms.GroupBox();
            this.radUSD = new System.Windows.Forms.RadioButton();
            this.radCHF = new System.Windows.Forms.RadioButton();
            this.radGBP = new System.Windows.Forms.RadioButton();
            this.txtVnos = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.lblVnos = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.btnIzracun = new System.Windows.Forms.Button();
            this.btnIzhod = new System.Windows.Forms.Button();
            this.btnPocisti = new System.Windows.Forms.Button();
            this.grpTecaji.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTecaji
            // 
            this.grpTecaji.Controls.Add(this.radGBP);
            this.grpTecaji.Controls.Add(this.radCHF);
            this.grpTecaji.Controls.Add(this.radUSD);
            this.grpTecaji.Location = new System.Drawing.Point(68, 45);
            this.grpTecaji.Name = "grpTecaji";
            this.grpTecaji.Size = new System.Drawing.Size(83, 97);
            this.grpTecaji.TabIndex = 0;
            this.grpTecaji.TabStop = false;
            this.grpTecaji.Text = "Valute";
            // 
            // radUSD
            // 
            this.radUSD.AutoSize = true;
            this.radUSD.Location = new System.Drawing.Point(7, 20);
            this.radUSD.Name = "radUSD";
            this.radUSD.Size = new System.Drawing.Size(48, 17);
            this.radUSD.TabIndex = 0;
            this.radUSD.TabStop = true;
            this.radUSD.Text = "USD";
            this.radUSD.UseVisualStyleBackColor = true;
            // 
            // radCHF
            // 
            this.radCHF.AutoSize = true;
            this.radCHF.Location = new System.Drawing.Point(7, 44);
            this.radCHF.Name = "radCHF";
            this.radCHF.Size = new System.Drawing.Size(46, 17);
            this.radCHF.TabIndex = 1;
            this.radCHF.TabStop = true;
            this.radCHF.Text = "CHF";
            this.radCHF.UseVisualStyleBackColor = true;
            // 
            // radGBP
            // 
            this.radGBP.AutoSize = true;
            this.radGBP.Location = new System.Drawing.Point(7, 68);
            this.radGBP.Name = "radGBP";
            this.radGBP.Size = new System.Drawing.Size(47, 17);
            this.radGBP.TabIndex = 2;
            this.radGBP.TabStop = true;
            this.radGBP.Text = "GBP";
            this.radGBP.UseVisualStyleBackColor = true;
            // 
            // txtVnos
            // 
            this.txtVnos.Location = new System.Drawing.Point(224, 62);
            this.txtVnos.Name = "txtVnos";
            this.txtVnos.Size = new System.Drawing.Size(117, 20);
            this.txtVnos.TabIndex = 1;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(224, 113);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(117, 20);
            this.txtRezultat.TabIndex = 2;
            // 
            // lblVnos
            // 
            this.lblVnos.AutoSize = true;
            this.lblVnos.Location = new System.Drawing.Point(348, 65);
            this.lblVnos.Name = "lblVnos";
            this.lblVnos.Size = new System.Drawing.Size(30, 13);
            this.lblVnos.TabIndex = 3;
            this.lblVnos.Text = "EUR";
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.Location = new System.Drawing.Point(348, 120);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(0, 13);
            this.lblRezultat.TabIndex = 5;
            // 
            // btnIzracun
            // 
            this.btnIzracun.Location = new System.Drawing.Point(68, 172);
            this.btnIzracun.Name = "btnIzracun";
            this.btnIzracun.Size = new System.Drawing.Size(81, 26);
            this.btnIzracun.TabIndex = 6;
            this.btnIzracun.Text = "Izračunaj";
            this.btnIzracun.UseVisualStyleBackColor = true;
            this.btnIzracun.Click += new System.EventHandler(this.btnIzracun_Click);
            // 
            // btnIzhod
            // 
            this.btnIzhod.Location = new System.Drawing.Point(186, 173);
            this.btnIzhod.Name = "btnIzhod";
            this.btnIzhod.Size = new System.Drawing.Size(81, 25);
            this.btnIzhod.TabIndex = 7;
            this.btnIzhod.Text = "Izhod";
            this.btnIzhod.UseVisualStyleBackColor = true;
            this.btnIzhod.Click += new System.EventHandler(this.btnIzhod_Click);
            // 
            // btnPocisti
            // 
            this.btnPocisti.Location = new System.Drawing.Point(297, 172);
            this.btnPocisti.Name = "btnPocisti";
            this.btnPocisti.Size = new System.Drawing.Size(81, 26);
            this.btnPocisti.TabIndex = 8;
            this.btnPocisti.Text = "Počisti";
            this.btnPocisti.UseVisualStyleBackColor = true;
            this.btnPocisti.Click += new System.EventHandler(this.btnPocisti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 218);
            this.Controls.Add(this.btnPocisti);
            this.Controls.Add(this.btnIzhod);
            this.Controls.Add(this.btnIzracun);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblVnos);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.txtVnos);
            this.Controls.Add(this.grpTecaji);
            this.Name = "Form1";
            this.Text = "Tečajna lista";
            this.grpTecaji.ResumeLayout(false);
            this.grpTecaji.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTecaji;
        private System.Windows.Forms.RadioButton radGBP;
        private System.Windows.Forms.RadioButton radCHF;
        private System.Windows.Forms.RadioButton radUSD;
        private System.Windows.Forms.TextBox txtVnos;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label lblVnos;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.Button btnIzracun;
        private System.Windows.Forms.Button btnIzhod;
        private System.Windows.Forms.Button btnPocisti;
    }
}

