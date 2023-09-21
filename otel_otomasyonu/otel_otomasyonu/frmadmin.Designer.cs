namespace otel_otomasyonu
{
    partial class frmadmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin));
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnOdalar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.frmadminiBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmadminiBack)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnMusteriler.Location = new System.Drawing.Point(412, 63);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(335, 161);
            this.btnMusteriler.TabIndex = 0;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnOdalar
            // 
            this.btnOdalar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnOdalar.Location = new System.Drawing.Point(412, 252);
            this.btnOdalar.Name = "btnOdalar";
            this.btnOdalar.Size = new System.Drawing.Size(335, 161);
            this.btnOdalar.TabIndex = 1;
            this.btnOdalar.Text = "Odalar";
            this.btnOdalar.UseVisualStyleBackColor = true;
            this.btnOdalar.Click += new System.EventHandler(this.btnOdalar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::otel_otomasyonu.Properties.Resources.Protea_Hotel_Booking__All_About_Protea_Hotel_Owerri_Online_Booking_;
            this.pictureBox1.Location = new System.Drawing.Point(40, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmadminiBack
            // 
            this.frmadminiBack.Image = global::otel_otomasyonu.Properties.Resources.indir__1_;
            this.frmadminiBack.Location = new System.Drawing.Point(12, 12);
            this.frmadminiBack.Name = "frmadminiBack";
            this.frmadminiBack.Size = new System.Drawing.Size(54, 45);
            this.frmadminiBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frmadminiBack.TabIndex = 11;
            this.frmadminiBack.TabStop = false;
            this.frmadminiBack.Click += new System.EventHandler(this.frmadminiBack_Click);
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmadminiBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOdalar);
            this.Controls.Add(this.btnMusteriler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmadmin";
            this.Text = "Admin Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmadminiBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.Button btnOdalar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox frmadminiBack;
    }
}