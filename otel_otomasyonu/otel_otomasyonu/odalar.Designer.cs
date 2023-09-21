namespace otel_otomasyonu
{
    partial class odalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odalar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.odalarBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(146, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Odalar";
            // 
            // odalarBack
            // 
            this.odalarBack.Image = global::otel_otomasyonu.Properties.Resources.indir__1_;
            this.odalarBack.Location = new System.Drawing.Point(43, 12);
            this.odalarBack.Name = "odalarBack";
            this.odalarBack.Size = new System.Drawing.Size(54, 45);
            this.odalarBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.odalarBack.TabIndex = 40;
            this.odalarBack.TabStop = false;
            this.odalarBack.Click += new System.EventHandler(this.odalarBack_Click);
            // 
            // odalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(671, 650);
            this.Controls.Add(this.odalarBack);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "odalar";
            this.Text = "Odalar";
            this.Load += new System.EventHandler(this.odalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odalarBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox odalarBack;
    }
}