
namespace Register
{
    partial class Кеш
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
            this.components = new System.ComponentModel.Container();
            this.tbKes = new System.Windows.Forms.TextBox();
            this.btnKes1 = new System.Windows.Forms.Button();
            this.btnKes2 = new System.Windows.Forms.Button();
            this.btnKes3 = new System.Windows.Forms.Button();
            this.btnNaplati = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPomalaSuma = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbKusur = new System.Windows.Forms.Label();
            this.btnOtkazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPomalaSuma)).BeginInit();
            this.SuspendLayout();
            // 
            // tbKes
            // 
            this.tbKes.Location = new System.Drawing.Point(112, 144);
            this.tbKes.Name = "tbKes";
            this.tbKes.Size = new System.Drawing.Size(289, 22);
            this.tbKes.TabIndex = 0;
            this.tbKes.TextChanged += new System.EventHandler(this.tbKes_TextChanged);
            // 
            // btnKes1
            // 
            this.btnKes1.Location = new System.Drawing.Point(112, 190);
            this.btnKes1.Name = "btnKes1";
            this.btnKes1.Size = new System.Drawing.Size(75, 23);
            this.btnKes1.TabIndex = 1;
            this.btnKes1.UseVisualStyleBackColor = true;
            this.btnKes1.Click += new System.EventHandler(this.btnKes1_Click);
            // 
            // btnKes2
            // 
            this.btnKes2.Location = new System.Drawing.Point(218, 190);
            this.btnKes2.Name = "btnKes2";
            this.btnKes2.Size = new System.Drawing.Size(75, 23);
            this.btnKes2.TabIndex = 2;
            this.btnKes2.Text = "button2";
            this.btnKes2.UseVisualStyleBackColor = true;
            this.btnKes2.Click += new System.EventHandler(this.btnKes2_Click);
            // 
            // btnKes3
            // 
            this.btnKes3.Location = new System.Drawing.Point(326, 190);
            this.btnKes3.Name = "btnKes3";
            this.btnKes3.Size = new System.Drawing.Size(75, 23);
            this.btnKes3.TabIndex = 3;
            this.btnKes3.Text = "button3";
            this.btnKes3.UseVisualStyleBackColor = true;
            this.btnKes3.Click += new System.EventHandler(this.btnKes3_Click);
            // 
            // btnNaplati
            // 
            this.btnNaplati.Location = new System.Drawing.Point(156, 250);
            this.btnNaplati.Name = "btnNaplati";
            this.btnNaplati.Size = new System.Drawing.Size(187, 23);
            this.btnNaplati.TabIndex = 4;
            this.btnNaplati.Text = "НАПЛАТИ";
            this.btnNaplati.UseVisualStyleBackColor = true;
            this.btnNaplati.Click += new System.EventHandler(this.btnNaplati_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Вкупно:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(282, 25);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 17);
            this.lbTotal.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Внесете сума на пари која Ви ја примивте од купувачот:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProviderPomalaSuma
            // 
            this.errorProviderPomalaSuma.ContainerControl = this;
            // 
            // lbKusur
            // 
            this.lbKusur.AutoSize = true;
            this.lbKusur.Location = new System.Drawing.Point(183, 78);
            this.lbKusur.Name = "lbKusur";
            this.lbKusur.Size = new System.Drawing.Size(0, 17);
            this.lbKusur.TabIndex = 8;
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOtkazi.Location = new System.Drawing.Point(186, 295);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(126, 28);
            this.btnOtkazi.TabIndex = 9;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // Кеш
            // 
            this.AcceptButton = this.btnNaplati;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnOtkazi;
            this.ClientSize = new System.Drawing.Size(543, 367);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.lbKusur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNaplati);
            this.Controls.Add(this.btnKes3);
            this.Controls.Add(this.btnKes2);
            this.Controls.Add(this.btnKes1);
            this.Controls.Add(this.tbKes);
            this.Name = "Кеш";
            this.Text = "Кеш";
            this.Load += new System.EventHandler(this.Кеш_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPomalaSuma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNaplati;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnKes1;
        public System.Windows.Forms.Button btnKes2;
        public System.Windows.Forms.Button btnKes3;
        public System.Windows.Forms.TextBox tbKes;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProviderPomalaSuma;
        private System.Windows.Forms.Label lbKusur;
        private System.Windows.Forms.Button btnOtkazi;
    }
}