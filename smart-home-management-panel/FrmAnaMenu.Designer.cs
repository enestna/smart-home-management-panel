namespace AkilliEvOtomasyonu
{
    partial class FrmAnaMenu
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
            this.btnCihazlar = new System.Windows.Forms.Button();
            this.btnAciklar = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.btnKapalilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCihazlar
            // 
            this.btnCihazlar.BackColor = System.Drawing.Color.Yellow;
            this.btnCihazlar.Location = new System.Drawing.Point(100, 125);
            this.btnCihazlar.Name = "btnCihazlar";
            this.btnCihazlar.Size = new System.Drawing.Size(110, 58);
            this.btnCihazlar.TabIndex = 0;
            this.btnCihazlar.Text = "CİHAZ YÖNETİMİ";
            this.btnCihazlar.UseVisualStyleBackColor = false;
            this.btnCihazlar.Click += new System.EventHandler(this.btnCihazlar_Click);
            // 
            // btnAciklar
            // 
            this.btnAciklar.BackColor = System.Drawing.Color.Lime;
            this.btnAciklar.Location = new System.Drawing.Point(411, 125);
            this.btnAciklar.Name = "btnAciklar";
            this.btnAciklar.Size = new System.Drawing.Size(110, 58);
            this.btnAciklar.TabIndex = 0;
            this.btnAciklar.Text = "AÇIK CİHAZLAR";
            this.btnAciklar.UseVisualStyleBackColor = false;
            this.btnAciklar.Click += new System.EventHandler(this.btnAciklar_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.BackColor = System.Drawing.Color.Blue;
            this.btnOdalar.Location = new System.Drawing.Point(261, 125);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(104, 58);
            this.btnOdalar.TabIndex = 0;
            this.btnOdalar.Text = "ODA YÖNETİMİ";
            this.btnOdalar.UseVisualStyleBackColor = false;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // btnKapalilar
            // 
            this.btnKapalilar.BackColor = System.Drawing.Color.Red;
            this.btnKapalilar.Location = new System.Drawing.Point(564, 125);
            this.btnKapalilar.Name = "btnKapalilar";
            this.btnKapalilar.Size = new System.Drawing.Size(110, 58);
            this.btnKapalilar.TabIndex = 0;
            this.btnKapalilar.Text = "KAPALI CİHAZLAR";
            this.btnKapalilar.UseVisualStyleBackColor = false;
            this.btnKapalilar.Click += new System.EventHandler(this.btnKapalilar_Click);
            // 
            // FrmAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(781, 364);
            this.Controls.Add(this.btnKapalilar);
            this.Controls.Add(this.btnOdalar);
            this.Controls.Add(this.btnAciklar);
            this.Controls.Add(this.btnCihazlar);
            this.Name = "FrmAnaMenu";
            this.Text = "FrmAnaMenu";
            this.Load += new System.EventHandler(this.FrmAnaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCihazlar;
        private System.Windows.Forms.Button btnAciklar;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.Button btnKapalilar;
    }
}