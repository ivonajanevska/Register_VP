
namespace Register
{
    partial class Naplata
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
            this.btnKes = new System.Windows.Forms.Button();
            this.btnGift = new System.Windows.Forms.Button();
            this.btnKarticka = new System.Windows.Forms.Button();
            this.lbProizvodiNaplata = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(373, 81);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(89, 30);
            this.btnKes.TabIndex = 0;
            this.btnKes.Text = "Кеш";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGift
            // 
            this.btnGift.Location = new System.Drawing.Point(373, 154);
            this.btnGift.Name = "btnGift";
            this.btnGift.Size = new System.Drawing.Size(140, 30);
            this.btnGift.TabIndex = 1;
            this.btnGift.Text = "Gift картичка";
            this.btnGift.UseVisualStyleBackColor = true;
            this.btnGift.Click += new System.EventHandler(this.btnGift_Click);
            // 
            // btnKarticka
            // 
            this.btnKarticka.Location = new System.Drawing.Point(373, 225);
            this.btnKarticka.Name = "btnKarticka";
            this.btnKarticka.Size = new System.Drawing.Size(100, 30);
            this.btnKarticka.TabIndex = 2;
            this.btnKarticka.Text = "Картичка";
            this.btnKarticka.UseVisualStyleBackColor = true;
            this.btnKarticka.Click += new System.EventHandler(this.btnKarticka_Click);
            // 
            // lbProizvodiNaplata
            // 
            this.lbProizvodiNaplata.FormattingEnabled = true;
            this.lbProizvodiNaplata.ItemHeight = 16;
            this.lbProizvodiNaplata.Location = new System.Drawing.Point(35, 34);
            this.lbProizvodiNaplata.Name = "lbProizvodiNaplata";
            this.lbProizvodiNaplata.Size = new System.Drawing.Size(286, 292);
            this.lbProizvodiNaplata.TabIndex = 3;
            this.lbProizvodiNaplata.SelectedIndexChanged += new System.EventHandler(this.lbProizvodiNaplata_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Вкупно:";
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(107, 342);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(214, 22);
            this.tbTotal.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 342);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Naplata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 406);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProizvodiNaplata);
            this.Controls.Add(this.btnKarticka);
            this.Controls.Add(this.btnGift);
            this.Controls.Add(this.btnKes);
            this.Name = "Naplata";
            this.Text = "Naplata";
            this.Load += new System.EventHandler(this.Naplata_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKes;
        private System.Windows.Forms.Button btnGift;
        private System.Windows.Forms.Button btnKarticka;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox lbProizvodiNaplata;
        public System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox textBox1;
    }
}