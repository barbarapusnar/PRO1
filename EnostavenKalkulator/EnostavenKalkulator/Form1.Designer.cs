namespace EnostavenKalkulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrvo = new System.Windows.Forms.TextBox();
            this.txtDrugo = new System.Windows.Forms.TextBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.btnIzračunaj = new System.Windows.Forms.Button();
            this.btnPočisti = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radPlus = new System.Windows.Forms.RadioButton();
            this.radMinus = new System.Windows.Forms.RadioButton();
            this.radKrat = new System.Windows.Forms.RadioButton();
            this.radDeli = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prvo število";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drugo število";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rezultat";
            // 
            // txtPrvo
            // 
            this.txtPrvo.Location = new System.Drawing.Point(210, 28);
            this.txtPrvo.Name = "txtPrvo";
            this.txtPrvo.Size = new System.Drawing.Size(100, 29);
            this.txtPrvo.TabIndex = 3;
            // 
            // txtDrugo
            // 
            this.txtDrugo.Location = new System.Drawing.Point(210, 77);
            this.txtDrugo.Name = "txtDrugo";
            this.txtDrugo.Size = new System.Drawing.Size(100, 29);
            this.txtDrugo.TabIndex = 4;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(210, 126);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.ReadOnly = true;
            this.txtRezultat.Size = new System.Drawing.Size(100, 29);
            this.txtRezultat.TabIndex = 5;
            this.txtRezultat.TabStop = false;
            // 
            // btnIzračunaj
            // 
            this.btnIzračunaj.Location = new System.Drawing.Point(30, 310);
            this.btnIzračunaj.Name = "btnIzračunaj";
            this.btnIzračunaj.Size = new System.Drawing.Size(115, 33);
            this.btnIzračunaj.TabIndex = 6;
            this.btnIzračunaj.Text = "Izračunaj";
            this.btnIzračunaj.UseVisualStyleBackColor = true;
            this.btnIzračunaj.Click += new System.EventHandler(this.btnIzračunaj_Click);
            // 
            // btnPočisti
            // 
            this.btnPočisti.Location = new System.Drawing.Point(197, 310);
            this.btnPočisti.Name = "btnPočisti";
            this.btnPočisti.Size = new System.Drawing.Size(89, 33);
            this.btnPočisti.TabIndex = 7;
            this.btnPočisti.Text = "Počisti";
            this.btnPočisti.UseVisualStyleBackColor = true;
            this.btnPočisti.Click += new System.EventHandler(this.btnPočisti_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDeli);
            this.groupBox1.Controls.Add(this.radKrat);
            this.groupBox1.Controls.Add(this.radMinus);
            this.groupBox1.Controls.Add(this.radPlus);
            this.groupBox1.Location = new System.Drawing.Point(381, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 270);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacije";
            // 
            // radPlus
            // 
            this.radPlus.AutoSize = true;
            this.radPlus.Checked = true;
            this.radPlus.Location = new System.Drawing.Point(23, 46);
            this.radPlus.Name = "radPlus";
            this.radPlus.Size = new System.Drawing.Size(79, 28);
            this.radPlus.TabIndex = 0;
            this.radPlus.TabStop = true;
            this.radPlus.Text = "Seštej";
            this.radPlus.UseVisualStyleBackColor = true;
            // 
            // radMinus
            // 
            this.radMinus.AutoSize = true;
            this.radMinus.Location = new System.Drawing.Point(23, 92);
            this.radMinus.Name = "radMinus";
            this.radMinus.Size = new System.Drawing.Size(82, 28);
            this.radMinus.TabIndex = 1;
            this.radMinus.Text = "Odštej";
            this.radMinus.UseVisualStyleBackColor = true;
            // 
            // radKrat
            // 
            this.radKrat.AutoSize = true;
            this.radKrat.Location = new System.Drawing.Point(23, 138);
            this.radKrat.Name = "radKrat";
            this.radKrat.Size = new System.Drawing.Size(91, 28);
            this.radKrat.TabIndex = 2;
            this.radKrat.Text = "Zmnoži";
            this.radKrat.UseVisualStyleBackColor = true;
            // 
            // radDeli
            // 
            this.radDeli.AutoSize = true;
            this.radDeli.Location = new System.Drawing.Point(23, 189);
            this.radDeli.Name = "radDeli";
            this.radDeli.Size = new System.Drawing.Size(70, 28);
            this.radDeli.TabIndex = 3;
            this.radDeli.Text = "Zdeli";
            this.radDeli.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPočisti);
            this.Controls.Add(this.btnIzračunaj);
            this.Controls.Add(this.txtRezultat);
            this.Controls.Add(this.txtDrugo);
            this.Controls.Add(this.txtPrvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Enostaven kalkulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrvo;
        private System.Windows.Forms.TextBox txtDrugo;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Button btnIzračunaj;
        private System.Windows.Forms.Button btnPočisti;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radDeli;
        private System.Windows.Forms.RadioButton radKrat;
        private System.Windows.Forms.RadioButton radMinus;
        private System.Windows.Forms.RadioButton radPlus;
    }
}

