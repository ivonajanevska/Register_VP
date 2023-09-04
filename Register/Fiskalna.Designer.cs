
namespace Register
{
    partial class Fiskalna
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbSeriskiBroj = new System.Windows.Forms.Label();
            this.lbProizvodi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbProizvodiNaplata = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сметка број:";
            // 
            // lbSeriskiBroj
            // 
            this.lbSeriskiBroj.AutoSize = true;
            this.lbSeriskiBroj.Location = new System.Drawing.Point(281, 9);
            this.lbSeriskiBroj.Name = "lbSeriskiBroj";
            this.lbSeriskiBroj.Size = new System.Drawing.Size(0, 17);
            this.lbSeriskiBroj.TabIndex = 3;
            // 
            // lbProizvodi
            // 
            this.lbProizvodi.FormattingEnabled = true;
            this.lbProizvodi.ItemHeight = 16;
            this.lbProizvodi.Location = new System.Drawing.Point(12, 50);
            this.lbProizvodi.Name = "lbProizvodi";
            this.lbProizvodi.Size = new System.Drawing.Size(295, 356);
            this.lbProizvodi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Издадена на:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(171, 427);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 17);
            this.lbDate.TabIndex = 7;
            // 
            // lbProizvodiNaplata
            // 
            this.lbProizvodiNaplata.FormattingEnabled = true;
            this.lbProizvodiNaplata.ItemHeight = 16;
            this.lbProizvodiNaplata.Location = new System.Drawing.Point(12, 51);
            this.lbProizvodiNaplata.Name = "lbProizvodiNaplata";
            this.lbProizvodiNaplata.Size = new System.Drawing.Size(295, 356);
            this.lbProizvodiNaplata.TabIndex = 8;
            // 
            // Fiskalna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 499);
            this.Controls.Add(this.lbProizvodiNaplata);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProizvodi);
            this.Controls.Add(this.lbSeriskiBroj);
            this.Controls.Add(this.label2);
            this.Name = "Fiskalna";
            this.Text = "Fiskalna";
            this.Load += new System.EventHandler(this.Fiskalna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSeriskiBroj;
        public System.Windows.Forms.ListBox lbProizvodi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDate;
        public System.Windows.Forms.ListBox lbProizvodiNaplata;
    }
}