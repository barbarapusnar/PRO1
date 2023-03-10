namespace WindowsFormsApp5
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
            this.grpOdd = new System.Windows.Forms.GroupBox();
            this.radUPK = new System.Windows.Forms.RadioButton();
            this.radMehatronika = new System.Windows.Forms.RadioButton();
            this.radInformatika = new System.Windows.Forms.RadioButton();
            this.grpIme = new System.Windows.Forms.GroupBox();
            this.txtKoncna = new System.Windows.Forms.TextBox();
            this.txtVmesna = new System.Windows.Forms.TextBox();
            this.lblUstna = new System.Windows.Forms.Label();
            this.lblSeminar = new System.Windows.Forms.Label();
            this.lblKoncna = new System.Windows.Forms.Label();
            this.lblVmesna = new System.Windows.Forms.Label();
            this.txtSeminar = new System.Windows.Forms.TextBox();
            this.txtUstna = new System.Windows.Forms.TextBox();
            this.btnIzracunaj = new System.Windows.Forms.Button();
            this.btnPonastavi = new System.Windows.Forms.Button();
            this.lblOcena = new System.Windows.Forms.Label();
            this.lblPovp = new System.Windows.Forms.Label();
            this.grpOdd.SuspendLayout();
            this.grpIme.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOdd
            // 
            this.grpOdd.Controls.Add(this.radUPK);
            this.grpOdd.Controls.Add(this.radMehatronika);
            this.grpOdd.Controls.Add(this.radInformatika);
            this.grpOdd.Location = new System.Drawing.Point(31, 27);
            this.grpOdd.Name = "grpOdd";
            this.grpOdd.Size = new System.Drawing.Size(122, 97);
            this.grpOdd.TabIndex = 0;
            this.grpOdd.TabStop = false;
            this.grpOdd.Text = "Oddelek študenta";
            // 
            // radUPK
            // 
            this.radUPK.AutoSize = true;
            this.radUPK.Location = new System.Drawing.Point(6, 65);
            this.radUPK.Name = "radUPK";
            this.radUPK.Size = new System.Drawing.Size(47, 17);
            this.radUPK.TabIndex = 3;
            this.radUPK.TabStop = true;
            this.radUPK.Text = "UPK";
            this.radUPK.UseVisualStyleBackColor = true;
            this.radUPK.CheckedChanged += new System.EventHandler(this.radUPK_CheckedChanged);
            // 
            // radMehatronika
            // 
            this.radMehatronika.AutoSize = true;
            this.radMehatronika.Location = new System.Drawing.Point(6, 42);
            this.radMehatronika.Name = "radMehatronika";
            this.radMehatronika.Size = new System.Drawing.Size(84, 17);
            this.radMehatronika.TabIndex = 2;
            this.radMehatronika.TabStop = true;
            this.radMehatronika.Text = "Mehatronika";
            this.radMehatronika.UseVisualStyleBackColor = true;
            this.radMehatronika.CheckedChanged += new System.EventHandler(this.radMehatronika_CheckedChanged);
            // 
            // radInformatika
            // 
            this.radInformatika.AutoSize = true;
            this.radInformatika.Location = new System.Drawing.Point(6, 19);
            this.radInformatika.Name = "radInformatika";
            this.radInformatika.Size = new System.Drawing.Size(77, 17);
            this.radInformatika.TabIndex = 1;
            this.radInformatika.TabStop = true;
            this.radInformatika.Text = "Informatika";
            this.radInformatika.UseVisualStyleBackColor = true;
            this.radInformatika.CheckedChanged += new System.EventHandler(this.radInformatika_CheckedChanged);
            // 
            // grpIme
            // 
            this.grpIme.Controls.Add(this.txtUstna);
            this.grpIme.Controls.Add(this.txtSeminar);
            this.grpIme.Controls.Add(this.txtKoncna);
            this.grpIme.Controls.Add(this.txtVmesna);
            this.grpIme.Controls.Add(this.lblUstna);
            this.grpIme.Controls.Add(this.lblSeminar);
            this.grpIme.Controls.Add(this.lblKoncna);
            this.grpIme.Controls.Add(this.lblVmesna);
            this.grpIme.Location = new System.Drawing.Point(237, 27);
            this.grpIme.Name = "grpIme";
            this.grpIme.Size = new System.Drawing.Size(279, 130);
            this.grpIme.TabIndex = 1;
            this.grpIme.TabStop = false;
            // 
            // txtKoncna
            // 
            this.txtKoncna.Location = new System.Drawing.Point(160, 42);
            this.txtKoncna.Name = "txtKoncna";
            this.txtKoncna.Size = new System.Drawing.Size(100, 20);
            this.txtKoncna.TabIndex = 5;
            // 
            // txtVmesna
            // 
            this.txtVmesna.Location = new System.Drawing.Point(160, 19);
            this.txtVmesna.Name = "txtVmesna";
            this.txtVmesna.Size = new System.Drawing.Size(100, 20);
            this.txtVmesna.TabIndex = 4;
            // 
            // lblUstna
            // 
            this.lblUstna.AutoSize = true;
            this.lblUstna.Location = new System.Drawing.Point(6, 94);
            this.lblUstna.Name = "lblUstna";
            this.lblUstna.Size = new System.Drawing.Size(68, 13);
            this.lblUstna.TabIndex = 3;
            this.lblUstna.Text = "Ustna ocena";
            // 
            // lblSeminar
            // 
            this.lblSeminar.AutoSize = true;
            this.lblSeminar.Location = new System.Drawing.Point(7, 69);
            this.lblSeminar.Name = "lblSeminar";
            this.lblSeminar.Size = new System.Drawing.Size(86, 13);
            this.lblSeminar.TabIndex = 2;
            this.lblSeminar.Text = "Ocena seminarja";
            // 
            // lblKoncna
            // 
            this.lblKoncna.AutoSize = true;
            this.lblKoncna.Location = new System.Drawing.Point(6, 46);
            this.lblKoncna.Name = "lblKoncna";
            this.lblKoncna.Size = new System.Drawing.Size(104, 13);
            this.lblKoncna.TabIndex = 1;
            this.lblKoncna.Text = "Končna ocena izpita";
            // 
            // lblVmesna
            // 
            this.lblVmesna.AutoSize = true;
            this.lblVmesna.Location = new System.Drawing.Point(7, 19);
            this.lblVmesna.Name = "lblVmesna";
            this.lblVmesna.Size = new System.Drawing.Size(105, 13);
            this.lblVmesna.TabIndex = 0;
            this.lblVmesna.Text = "Vmesna ocena izpita";
            // 
            // txtSeminar
            // 
            this.txtSeminar.Location = new System.Drawing.Point(160, 66);
            this.txtSeminar.Name = "txtSeminar";
            this.txtSeminar.Size = new System.Drawing.Size(100, 20);
            this.txtSeminar.TabIndex = 6;
            // 
            // txtUstna
            // 
            this.txtUstna.Location = new System.Drawing.Point(160, 91);
            this.txtUstna.Name = "txtUstna";
            this.txtUstna.Size = new System.Drawing.Size(100, 20);
            this.txtUstna.TabIndex = 7;
            // 
            // btnIzracunaj
            // 
            this.btnIzracunaj.Location = new System.Drawing.Point(37, 167);
            this.btnIzracunaj.Name = "btnIzracunaj";
            this.btnIzracunaj.Size = new System.Drawing.Size(116, 34);
            this.btnIzracunaj.TabIndex = 2;
            this.btnIzracunaj.Text = "Izračunaj";
            this.btnIzracunaj.UseVisualStyleBackColor = true;
            this.btnIzracunaj.Click += new System.EventHandler(this.btnIzracunaj_Click);
            // 
            // btnPonastavi
            // 
            this.btnPonastavi.Location = new System.Drawing.Point(37, 222);
            this.btnPonastavi.Name = "btnPonastavi";
            this.btnPonastavi.Size = new System.Drawing.Size(116, 23);
            this.btnPonastavi.TabIndex = 3;
            this.btnPonastavi.Text = "Ponastavi";
            this.btnPonastavi.UseVisualStyleBackColor = true;
            this.btnPonastavi.Click += new System.EventHandler(this.btnPonastavi_Click);
            // 
            // lblOcena
            // 
            this.lblOcena.AutoSize = true;
            this.lblOcena.Location = new System.Drawing.Point(243, 232);
            this.lblOcena.Name = "lblOcena";
            this.lblOcena.Size = new System.Drawing.Size(0, 13);
            this.lblOcena.TabIndex = 4;
            // 
            // lblPovp
            // 
            this.lblPovp.AutoSize = true;
            this.lblPovp.Location = new System.Drawing.Point(244, 188);
            this.lblPovp.Name = "lblPovp";
            this.lblPovp.Size = new System.Drawing.Size(0, 13);
            this.lblPovp.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 285);
            this.Controls.Add(this.lblPovp);
            this.Controls.Add(this.lblOcena);
            this.Controls.Add(this.btnPonastavi);
            this.Controls.Add(this.btnIzracunaj);
            this.Controls.Add(this.grpIme);
            this.Controls.Add(this.grpOdd);
            this.Name = "Form1";
            this.Text = "Kalkulator ocen";
            this.grpOdd.ResumeLayout(false);
            this.grpOdd.PerformLayout();
            this.grpIme.ResumeLayout(false);
            this.grpIme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOdd;
        private System.Windows.Forms.RadioButton radUPK;
        private System.Windows.Forms.RadioButton radMehatronika;
        private System.Windows.Forms.RadioButton radInformatika;
        private System.Windows.Forms.GroupBox grpIme;
        private System.Windows.Forms.TextBox txtKoncna;
        private System.Windows.Forms.TextBox txtVmesna;
        private System.Windows.Forms.Label lblUstna;
        private System.Windows.Forms.Label lblSeminar;
        private System.Windows.Forms.Label lblKoncna;
        private System.Windows.Forms.Label lblVmesna;
        private System.Windows.Forms.TextBox txtUstna;
        private System.Windows.Forms.TextBox txtSeminar;
        private System.Windows.Forms.Button btnIzracunaj;
        private System.Windows.Forms.Button btnPonastavi;
        private System.Windows.Forms.Label lblOcena;
        private System.Windows.Forms.Label lblPovp;
    }
}

