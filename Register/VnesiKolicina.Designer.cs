
namespace Register
{
    partial class VnesiKolicina
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
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.nudKolicina = new System.Windows.Forms.NumericUpDown();
            this.tbArtikl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCena = new System.Windows.Forms.TextBox();
            this.cenaKGparce = new System.Windows.Forms.TextBox();
            this.cenaKG = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazi.Location = new System.Drawing.Point(235, 198);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(90, 32);
            this.btnOtkazi.TabIndex = 17;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            // 
            // nudKolicina
            // 
            this.nudKolicina.Location = new System.Drawing.Point(205, 72);
            this.nudKolicina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudKolicina.Name = "nudKolicina";
            this.nudKolicina.Size = new System.Drawing.Size(120, 22);
            this.nudKolicina.TabIndex = 15;
            this.nudKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudKolicina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbArtikl
            // 
            this.tbArtikl.Location = new System.Drawing.Point(205, 34);
            this.tbArtikl.Name = "tbArtikl";
            this.tbArtikl.ReadOnly = true;
            this.tbArtikl.Size = new System.Drawing.Size(120, 22);
            this.tbArtikl.TabIndex = 14;
            this.tbArtikl.TextChanged += new System.EventHandler(this.tbArtikl_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Количина:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Артикл:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Цена:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbCena
            // 
            this.tbCena.Location = new System.Drawing.Point(205, 109);
            this.tbCena.Name = "tbCena";
            this.tbCena.ReadOnly = true;
            this.tbCena.Size = new System.Drawing.Size(120, 22);
            this.tbCena.TabIndex = 19;
            // 
            // cenaKGparce
            // 
            this.cenaKGparce.Location = new System.Drawing.Point(205, 148);
            this.cenaKGparce.Name = "cenaKGparce";
            this.cenaKGparce.ReadOnly = true;
            this.cenaKGparce.Size = new System.Drawing.Size(120, 22);
            this.cenaKGparce.TabIndex = 21;
            // 
            // cenaKG
            // 
            this.cenaKG.AutoSize = true;
            this.cenaKG.Location = new System.Drawing.Point(51, 153);
            this.cenaKG.Name = "cenaKG";
            this.cenaKG.Size = new System.Drawing.Size(132, 17);
            this.cenaKG.TabIndex = 20;
            this.cenaKG.Text = "Цена по КГ/парче:";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.Location = new System.Drawing.Point(89, 198);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(90, 32);
            this.btnPotvrdi.TabIndex = 22;
            this.btnPotvrdi.Text = "Потврди";
            this.btnPotvrdi.UseVisualStyleBackColor = true;
            this.btnPotvrdi.Click += new System.EventHandler(this.button1_Click);
            // 
            // VnesiKolicina
            // 
            this.AcceptButton = this.btnPotvrdi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(426, 252);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.cenaKGparce);
            this.Controls.Add(this.cenaKG);
            this.Controls.Add(this.tbCena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.nudKolicina);
            this.Controls.Add(this.tbArtikl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VnesiKolicina";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.VnesiKolicina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbArtikl;
        public System.Windows.Forms.TextBox cenaKGparce;
        public System.Windows.Forms.Label cenaKG;
        public System.Windows.Forms.TextBox tbCena;
        public System.Windows.Forms.NumericUpDown nudKolicina;
        private System.Windows.Forms.Button btnPotvrdi;
    }
}