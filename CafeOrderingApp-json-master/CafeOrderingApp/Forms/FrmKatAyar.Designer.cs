namespace CafeOrderingApp.Forms
{
    partial class FrmKatAyar
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtKatAdi = new System.Windows.Forms.TextBox();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.txtSira = new System.Windows.Forms.TextBox();
            this.txtMasaAdeti = new System.Windows.Forms.TextBox();
            this.btnKatKaydet = new System.Windows.Forms.Button();
            this.lstKatlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kat Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sıra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kod";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adet";
            // 
            // txtKatAdi
            // 
            this.txtKatAdi.Location = new System.Drawing.Point(127, 18);
            this.txtKatAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtKatAdi.Name = "txtKatAdi";
            this.txtKatAdi.Size = new System.Drawing.Size(188, 34);
            this.txtKatAdi.TabIndex = 4;
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(127, 102);
            this.txtKod.Margin = new System.Windows.Forms.Padding(4);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(188, 34);
            this.txtKod.TabIndex = 5;
            // 
            // txtSira
            // 
            this.txtSira.Location = new System.Drawing.Point(127, 60);
            this.txtSira.Margin = new System.Windows.Forms.Padding(4);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(188, 34);
            this.txtSira.TabIndex = 6;
            // 
            // txtMasaAdeti
            // 
            this.txtMasaAdeti.Location = new System.Drawing.Point(127, 144);
            this.txtMasaAdeti.Margin = new System.Windows.Forms.Padding(4);
            this.txtMasaAdeti.Name = "txtMasaAdeti";
            this.txtMasaAdeti.Size = new System.Drawing.Size(188, 34);
            this.txtMasaAdeti.TabIndex = 7;
            // 
            // btnKatKaydet
            // 
            this.btnKatKaydet.Location = new System.Drawing.Point(127, 186);
            this.btnKatKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKatKaydet.Name = "btnKatKaydet";
            this.btnKatKaydet.Size = new System.Drawing.Size(188, 86);
            this.btnKatKaydet.TabIndex = 8;
            this.btnKatKaydet.Text = "Kaydet";
            this.btnKatKaydet.UseVisualStyleBackColor = true;
            this.btnKatKaydet.Click += new System.EventHandler(this.btnKatKaydet_Click);
            // 
            // lstKatlar
            // 
            this.lstKatlar.FormattingEnabled = true;
            this.lstKatlar.ItemHeight = 28;
            this.lstKatlar.Location = new System.Drawing.Point(322, 20);
            this.lstKatlar.Name = "lstKatlar";
            this.lstKatlar.Size = new System.Drawing.Size(273, 564);
            this.lstKatlar.TabIndex = 9;
            // 
            // FrmKatAyar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 620);
            this.Controls.Add(this.lstKatlar);
            this.Controls.Add(this.btnKatKaydet);
            this.Controls.Add(this.txtMasaAdeti);
            this.Controls.Add(this.txtSira);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.txtKatAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmKatAyar";
            this.Text = "FrmKatAyar";
            this.Load += new System.EventHandler(this.FrmKatAyar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKatAdi;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.TextBox txtSira;
        private System.Windows.Forms.TextBox txtMasaAdeti;
        private System.Windows.Forms.Button btnKatKaydet;
        private System.Windows.Forms.ListBox lstKatlar;
    }
}