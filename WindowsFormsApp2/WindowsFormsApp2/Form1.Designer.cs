namespace WindowsFormsApp2
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
            this.textPrvo = new System.Windows.Forms.TextBox();
            this.textDrugo = new System.Windows.Forms.TextBox();
            this.textRez = new System.Windows.Forms.TextBox();
            this.btnRezultat = new System.Windows.Forms.Button();
            this.btnIzhod = new System.Windows.Forms.Button();
            this.groupBoxOp = new System.Windows.Forms.GroupBox();
            this.rbDeli = new System.Windows.Forms.RadioButton();
            this.rbMnozi = new System.Windows.Forms.RadioButton();
            this.rbOdstej = new System.Windows.Forms.RadioButton();
            this.rbSestej = new System.Windows.Forms.RadioButton();
            this.cbNeg = new System.Windows.Forms.CheckBox();
            this.groupBoxOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prvo število:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drugo število:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(39, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "REZULTAT";
            // 
            // textPrvo
            // 
            this.textPrvo.Location = new System.Drawing.Point(177, 26);
            this.textPrvo.Name = "textPrvo";
            this.textPrvo.Size = new System.Drawing.Size(100, 20);
            this.textPrvo.TabIndex = 3;
            // 
            // textDrugo
            // 
            this.textDrugo.Location = new System.Drawing.Point(177, 60);
            this.textDrugo.Name = "textDrugo";
            this.textDrugo.Size = new System.Drawing.Size(100, 20);
            this.textDrugo.TabIndex = 4;
            // 
            // textRez
            // 
            this.textRez.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textRez.Location = new System.Drawing.Point(177, 113);
            this.textRez.Name = "textRez";
            this.textRez.Size = new System.Drawing.Size(100, 26);
            this.textRez.TabIndex = 5;
            // 
            // btnRezultat
            // 
            this.btnRezultat.Location = new System.Drawing.Point(43, 166);
            this.btnRezultat.Name = "btnRezultat";
            this.btnRezultat.Size = new System.Drawing.Size(88, 36);
            this.btnRezultat.TabIndex = 6;
            this.btnRezultat.Text = "Rezultat";
            this.btnRezultat.UseVisualStyleBackColor = true;
            this.btnRezultat.Click += new System.EventHandler(this.btnRezultat_Click);
            // 
            // btnIzhod
            // 
            this.btnIzhod.Location = new System.Drawing.Point(370, 166);
            this.btnIzhod.Name = "btnIzhod";
            this.btnIzhod.Size = new System.Drawing.Size(85, 36);
            this.btnIzhod.TabIndex = 7;
            this.btnIzhod.Text = "Izhod";
            this.btnIzhod.UseVisualStyleBackColor = true;
            this.btnIzhod.Click += new System.EventHandler(this.btnIzhod_Click);
            // 
            // groupBoxOp
            // 
            this.groupBoxOp.Controls.Add(this.rbDeli);
            this.groupBoxOp.Controls.Add(this.rbMnozi);
            this.groupBoxOp.Controls.Add(this.rbOdstej);
            this.groupBoxOp.Controls.Add(this.rbSestej);
            this.groupBoxOp.Location = new System.Drawing.Point(370, 26);
            this.groupBoxOp.Name = "groupBoxOp";
            this.groupBoxOp.Size = new System.Drawing.Size(85, 114);
            this.groupBoxOp.TabIndex = 8;
            this.groupBoxOp.TabStop = false;
            this.groupBoxOp.Text = "Operacije";
            // 
            // rbDeli
            // 
            this.rbDeli.AutoSize = true;
            this.rbDeli.Location = new System.Drawing.Point(6, 90);
            this.rbDeli.Name = "rbDeli";
            this.rbDeli.Size = new System.Drawing.Size(63, 17);
            this.rbDeli.TabIndex = 3;
            this.rbDeli.TabStop = true;
            this.rbDeli.Text = "Deljenje";
            this.rbDeli.UseVisualStyleBackColor = true;
            // 
            // rbMnozi
            // 
            this.rbMnozi.AutoSize = true;
            this.rbMnozi.Location = new System.Drawing.Point(6, 67);
            this.rbMnozi.Name = "rbMnozi";
            this.rbMnozi.Size = new System.Drawing.Size(71, 17);
            this.rbMnozi.TabIndex = 2;
            this.rbMnozi.TabStop = true;
            this.rbMnozi.Text = "Množenje";
            this.rbMnozi.UseVisualStyleBackColor = true;
            // 
            // rbOdstej
            // 
            this.rbOdstej.AutoSize = true;
            this.rbOdstej.Location = new System.Drawing.Point(6, 43);
            this.rbOdstej.Name = "rbOdstej";
            this.rbOdstej.Size = new System.Drawing.Size(79, 17);
            this.rbOdstej.TabIndex = 1;
            this.rbOdstej.TabStop = true;
            this.rbOdstej.Text = "Odštevanje";
            this.rbOdstej.UseVisualStyleBackColor = true;
            // 
            // rbSestej
            // 
            this.rbSestej.AutoSize = true;
            this.rbSestej.Location = new System.Drawing.Point(6, 19);
            this.rbSestej.Name = "rbSestej";
            this.rbSestej.Size = new System.Drawing.Size(78, 17);
            this.rbSestej.TabIndex = 0;
            this.rbSestej.TabStop = true;
            this.rbSestej.Text = "Seštevanje";
            this.rbSestej.UseVisualStyleBackColor = true;
            // 
            // cbNeg
            // 
            this.cbNeg.AutoSize = true;
            this.cbNeg.Location = new System.Drawing.Point(283, 123);
            this.cbNeg.Name = "cbNeg";
            this.cbNeg.Size = new System.Drawing.Size(73, 17);
            this.cbNeg.TabIndex = 9;
            this.cbNeg.Text = "negativno";
            this.cbNeg.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 233);
            this.Controls.Add(this.cbNeg);
            this.Controls.Add(this.groupBoxOp);
            this.Controls.Add(this.btnIzhod);
            this.Controls.Add(this.btnRezultat);
            this.Controls.Add(this.textRez);
            this.Controls.Add(this.textDrugo);
            this.Controls.Add(this.textPrvo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Enostaven kalkulator";
            this.groupBoxOp.ResumeLayout(false);
            this.groupBoxOp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrvo;
        private System.Windows.Forms.TextBox textDrugo;
        private System.Windows.Forms.TextBox textRez;
        private System.Windows.Forms.Button btnRezultat;
        private System.Windows.Forms.Button btnIzhod;
        private System.Windows.Forms.GroupBox groupBoxOp;
        private System.Windows.Forms.RadioButton rbDeli;
        private System.Windows.Forms.RadioButton rbMnozi;
        private System.Windows.Forms.RadioButton rbOdstej;
        private System.Windows.Forms.RadioButton rbSestej;
        private System.Windows.Forms.CheckBox cbNeg;
    }
}

