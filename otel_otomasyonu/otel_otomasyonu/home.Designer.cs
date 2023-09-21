using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace otel_otomasyonu
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.label1 = new System.Windows.Forms.Label();
            this.btnKayitFormu = new System.Windows.Forms.Button();
            this.btnadminGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Elephant", 24F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(727, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "GÜRBÜZ OTEL OTOMASYONU";
            // 
            // btnKayitFormu
            // 
            this.btnKayitFormu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnKayitFormu.Location = new System.Drawing.Point(537, 96);
            this.btnKayitFormu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKayitFormu.Name = "btnKayitFormu";
            this.btnKayitFormu.Size = new System.Drawing.Size(335, 161);
            this.btnKayitFormu.TabIndex = 2;
            this.btnKayitFormu.Text = "Müşteri Kaydı";
            this.btnKayitFormu.UseVisualStyleBackColor = true;
            this.btnKayitFormu.Click += new System.EventHandler(this.btnKayitFormu_Click);
            // 
            // btnadminGiris
            // 
            this.btnadminGiris.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.btnadminGiris.Location = new System.Drawing.Point(537, 360);
            this.btnadminGiris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnadminGiris.Name = "btnadminGiris";
            this.btnadminGiris.Size = new System.Drawing.Size(335, 161);
            this.btnadminGiris.TabIndex = 6;
            this.btnadminGiris.Text = "Admin Girişi";
            this.btnadminGiris.UseVisualStyleBackColor = true;
            this.btnadminGiris.Click += new System.EventHandler(this.btnadminGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::otel_otomasyonu.Properties.Resources.indir__2_;
            this.pictureBox1.Location = new System.Drawing.Point(28, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 425);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(894, 553);
            this.Controls.Add(this.btnadminGiris);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnKayitFormu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "home";
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnKayitFormu;
        private PictureBox pictureBox1;
        private Button btnadminGiris;

    }
}
