
namespace Register
{
    partial class GiftCard
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
            this.btnNaplati = new System.Windows.Forms.Button();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbSostojba = new System.Windows.Forms.TextBox();
            this.tbPreostanato = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDoplata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPlatiSi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Состојба:";
            // 
            // btnNaplati
            // 
            this.btnNaplati.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNaplati.Location = new System.Drawing.Point(24, 230);
            this.btnNaplati.Name = "btnNaplati";
            this.btnNaplati.Size = new System.Drawing.Size(176, 36);
            this.btnNaplati.TabIndex = 2;
            this.btnNaplati.Text = "Наплати";
            this.btnNaplati.UseVisualStyleBackColor = true;
            //this.btnNaplati.Click += new System.EventHandler(this.btnNaplati_Click);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(148, 48);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(180, 22);
            this.tbID.TabIndex = 3;
            // 
            // tbSostojba
            // 
            this.tbSostojba.Location = new System.Drawing.Point(148, 91);
            this.tbSostojba.Name = "tbSostojba";
            this.tbSostojba.ReadOnly = true;
            this.tbSostojba.Size = new System.Drawing.Size(180, 22);
            this.tbSostojba.TabIndex = 4;
            // 
            // tbPreostanato
            // 
            this.tbPreostanato.Location = new System.Drawing.Point(148, 184);
            this.tbPreostanato.Name = "tbPreostanato";
            this.tbPreostanato.ReadOnly = true;
            this.tbPreostanato.Size = new System.Drawing.Size(180, 22);
            this.tbPreostanato.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Преостанато:";
            // 
            // tbDoplata
            // 
            this.tbDoplata.Location = new System.Drawing.Point(148, 132);
            this.tbDoplata.Name = "tbDoplata";
            this.tbDoplata.ReadOnly = true;
            this.tbDoplata.Size = new System.Drawing.Size(180, 22);
            this.tbDoplata.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "За доплата:";
            // 
            // btnPlatiSi
            // 
            this.btnPlatiSi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlatiSi.Location = new System.Drawing.Point(251, 230);
            this.btnPlatiSi.Name = "btnPlatiSi";
            this.btnPlatiSi.Size = new System.Drawing.Size(176, 36);
            this.btnPlatiSi.TabIndex = 10;
            this.btnPlatiSi.Text = "Доплати";
            this.btnPlatiSi.UseVisualStyleBackColor = true;
            this.btnPlatiSi.Click += new System.EventHandler(this.btnPlatiSi_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(420, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 11;
            // 
            // GiftCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 287);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnPlatiSi);
            this.Controls.Add(this.tbDoplata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPreostanato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSostojba);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.btnNaplati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GiftCard";
            this.Text = "GiftCard";
            this.Load += new System.EventHandler(this.GiftCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbSostojba;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.Button btnNaplati;
        public System.Windows.Forms.TextBox tbPreostanato;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbDoplata;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Button btnDoplati;
        public System.Windows.Forms.Button btnPlatiSi;
        private System.Windows.Forms.TextBox textBox1;
    }
}