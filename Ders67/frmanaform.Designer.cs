namespace Ders67
{
    partial class frmanaform
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
            this.BtnKategori = new System.Windows.Forms.Button();
            this.BtnUrun = new System.Windows.Forms.Button();
            this.BtnIst = new System.Windows.Forms.Button();
            this.BtnMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKategori
            // 
            this.BtnKategori.Location = new System.Drawing.Point(12, 12);
            this.BtnKategori.Name = "BtnKategori";
            this.BtnKategori.Size = new System.Drawing.Size(179, 128);
            this.BtnKategori.TabIndex = 0;
            this.BtnKategori.Text = "KATEGORİ İŞLEMLERİ";
            this.BtnKategori.UseVisualStyleBackColor = true;
            this.BtnKategori.Click += new System.EventHandler(this.BtnKategori_Click);
            // 
            // BtnUrun
            // 
            this.BtnUrun.Location = new System.Drawing.Point(197, 12);
            this.BtnUrun.Name = "BtnUrun";
            this.BtnUrun.Size = new System.Drawing.Size(179, 128);
            this.BtnUrun.TabIndex = 1;
            this.BtnUrun.Text = "ÜRÜN \r\nİŞLEMLERİ";
            this.BtnUrun.UseVisualStyleBackColor = true;
            this.BtnUrun.Click += new System.EventHandler(this.BtnUrun_Click);
            // 
            // BtnIst
            // 
            this.BtnIst.Location = new System.Drawing.Point(567, 12);
            this.BtnIst.Name = "BtnIst";
            this.BtnIst.Size = new System.Drawing.Size(179, 128);
            this.BtnIst.TabIndex = 2;
            this.BtnIst.Text = "İSTATİSLİKLER";
            this.BtnIst.UseVisualStyleBackColor = true;
            this.BtnIst.Click += new System.EventHandler(this.BtnIst_Click);
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.Location = new System.Drawing.Point(382, 12);
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.Size = new System.Drawing.Size(179, 128);
            this.BtnMusteri.TabIndex = 3;
            this.BtnMusteri.Text = "MÜŞTERİ\r\nİŞLEMLERİ";
            this.BtnMusteri.UseVisualStyleBackColor = true;
            this.BtnMusteri.Click += new System.EventHandler(this.BtnMusteri_Click);
            // 
            // frmanaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(761, 153);
            this.Controls.Add(this.BtnMusteri);
            this.Controls.Add(this.BtnIst);
            this.Controls.Add(this.BtnUrun);
            this.Controls.Add(this.BtnKategori);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmanaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmanaform_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKategori;
        private System.Windows.Forms.Button BtnUrun;
        private System.Windows.Forms.Button BtnIst;
        private System.Windows.Forms.Button BtnMusteri;
    }
}