
namespace Register
{
    partial class GIFT
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbSostojba = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNovaSostojba = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDoplata = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNaplati = new System.Windows.Forms.Button();
            this.btnDoplati = new System.Windows.Forms.Button();
            this.lbVkupno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(229, 98);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(155, 22);
            this.tbID.TabIndex = 1;
            // 
            // tbSostojba
            // 
            this.tbSostojba.Location = new System.Drawing.Point(229, 140);
            this.tbSostojba.Name = "tbSostojba";
            this.tbSostojba.Size = new System.Drawing.Size(155, 22);
            this.tbSostojba.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Состојба";
            // 
            // tbNovaSostojba
            // 
            this.tbNovaSostojba.Location = new System.Drawing.Point(229, 182);
            this.tbNovaSostojba.Name = "tbNovaSostojba";
            this.tbNovaSostojba.Size = new System.Drawing.Size(155, 22);
            this.tbNovaSostojba.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Нова состојба";
            // 
            // tbDoplata
            // 
            this.tbDoplata.Location = new System.Drawing.Point(229, 222);
            this.tbDoplata.Name = "tbDoplata";
            this.tbDoplata.Size = new System.Drawing.Size(155, 22);
            this.tbDoplata.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Доплата:";
            // 
            // btnNaplati
            // 
            this.btnNaplati.Location = new System.Drawing.Point(118, 278);
            this.btnNaplati.Name = "btnNaplati";
            this.btnNaplati.Size = new System.Drawing.Size(93, 35);
            this.btnNaplati.TabIndex = 8;
            this.btnNaplati.Text = "Наплати";
            this.btnNaplati.UseVisualStyleBackColor = true;
            this.btnNaplati.Click += new System.EventHandler(this.btnNaplati_Click);
            // 
            // btnDoplati
            // 
            this.btnDoplati.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDoplati.Location = new System.Drawing.Point(291, 278);
            this.btnDoplati.Name = "btnDoplati";
            this.btnDoplati.Size = new System.Drawing.Size(93, 35);
            this.btnDoplati.TabIndex = 9;
            this.btnDoplati.Text = "Доплати";
            this.btnDoplati.UseVisualStyleBackColor = true;
            this.btnDoplati.Click += new System.EventHandler(this.btnDoplati_Click);
            // 
            // lbVkupno
            // 
            this.lbVkupno.AutoSize = true;
            this.lbVkupno.Location = new System.Drawing.Point(258, 50);
            this.lbVkupno.Name = "lbVkupno";
            this.lbVkupno.Size = new System.Drawing.Size(46, 17);
            this.lbVkupno.TabIndex = 10;
            this.lbVkupno.Text = "label5";
            // 
            // GIFT
            // 
            this.AcceptButton = this.btnNaplati;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDoplati;
            this.ClientSize = new System.Drawing.Size(523, 374);
            this.Controls.Add(this.lbVkupno);
            this.Controls.Add(this.btnDoplati);
            this.Controls.Add(this.btnNaplati);
            this.Controls.Add(this.tbDoplata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNovaSostojba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSostojba);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Name = "GIFT";
            this.Text = "GIFT";
            this.Load += new System.EventHandler(this.GIFT_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbVkupno;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.TextBox tbSostojba;
        public System.Windows.Forms.TextBox tbNovaSostojba;
        public System.Windows.Forms.TextBox tbDoplata;
        public System.Windows.Forms.Button btnNaplati;
        public System.Windows.Forms.Button btnDoplati;
    }
}