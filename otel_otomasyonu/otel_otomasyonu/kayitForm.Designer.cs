using System.Windows.Forms;

using System.Drawing;
using System.Windows.Forms;

namespace otel_otomasyonu
{
    partial class kayitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayitForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtMusteriTel = new System.Windows.Forms.MaskedTextBox();
            this.txtcikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtMusterigender = new System.Windows.Forms.ComboBox();
            this.txtcheck_in = new System.Windows.Forms.DateTimePicker();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.txtMusteriemail = new System.Windows.Forms.TextBox();
            this.txtMusteritcNo = new System.Windows.Forms.TextBox();
            this.txtMusteriIsim = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kayitFormuBack = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button109 = new System.Windows.Forms.Button();
            this.button108 = new System.Windows.Forms.Button();
            this.button107 = new System.Windows.Forms.Button();
            this.button106 = new System.Windows.Forms.Button();
            this.button105 = new System.Windows.Forms.Button();
            this.button104 = new System.Windows.Forms.Button();
            this.button102 = new System.Windows.Forms.Button();
            this.button103 = new System.Windows.Forms.Button();
            this.button101 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kayitFormuBack)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giriş Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 546);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çıkış Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 27);
            this.label5.TabIndex = 4;
            this.label5.Text = "T.C Kimlik No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 27);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mail:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtprice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtMusteriTel);
            this.groupBox1.Controls.Add(this.txtcikisTarihi);
            this.groupBox1.Controls.Add(this.txtMusterigender);
            this.groupBox1.Controls.Add(this.txtcheck_in);
            this.groupBox1.Controls.Add(this.txtOdaNo);
            this.groupBox1.Controls.Add(this.txtMusteriemail);
            this.groupBox1.Controls.Add(this.txtMusteritcNo);
            this.groupBox1.Controls.Add(this.txtMusteriIsim);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(29, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(549, 701);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(449, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 27);
            this.label13.TabIndex = 22;
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(449, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 27);
            this.label12.TabIndex = 10;
            this.label12.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 10.2F);
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 10.2F);
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 170);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 27);
            this.dateTimePicker1.TabIndex = 21;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 27);
            this.label11.TabIndex = 20;
            this.label11.Text = "Doğum Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(153, 593);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 27);
            this.label10.TabIndex = 19;
            this.label10.Visible = false;
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Location = new System.Drawing.Point(205, 593);
            this.txtprice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtprice.Multiline = true;
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(242, 36);
            this.txtprice.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 596);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 27);
            this.label9.TabIndex = 17;
            this.label9.Text = "Ücret:";
            // 
            // btnEkle
            // 
            this.btnEkle.ForeColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(18, 647);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(429, 38);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtMusteriTel
            // 
            this.txtMusteriTel.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txtMusteriTel.Location = new System.Drawing.Point(203, 283);
            this.txtMusteriTel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriTel.Mask = "(999) 000-0000";
            this.txtMusteriTel.Name = "txtMusteriTel";
            this.txtMusteriTel.Size = new System.Drawing.Size(244, 34);
            this.txtMusteriTel.TabIndex = 15;
            this.txtMusteriTel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtMusteriTel_MaskInputRejected);
            // 
            // txtcikisTarihi
            // 
            this.txtcikisTarihi.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtcikisTarihi.Location = new System.Drawing.Point(203, 546);
            this.txtcikisTarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcikisTarihi.Name = "txtcikisTarihi";
            this.txtcikisTarihi.Size = new System.Drawing.Size(244, 27);
            this.txtcikisTarihi.TabIndex = 14;
            this.txtcikisTarihi.Value = new System.DateTime(2023, 9, 17, 16, 55, 0, 0);
            this.txtcikisTarihi.ValueChanged += new System.EventHandler(this.txtcikisTarihi_ValueChanged_1);
            // 
            // txtMusterigender
            // 
            this.txtMusterigender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMusterigender.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txtMusterigender.FormattingEnabled = true;
            this.txtMusterigender.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.txtMusterigender.Location = new System.Drawing.Point(203, 348);
            this.txtMusterigender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusterigender.Name = "txtMusterigender";
            this.txtMusterigender.Size = new System.Drawing.Size(244, 34);
            this.txtMusterigender.TabIndex = 8;
            // 
            // txtcheck_in
            // 
            this.txtcheck_in.Font = new System.Drawing.Font("Arial", 10.2F);
            this.txtcheck_in.Location = new System.Drawing.Point(203, 484);
            this.txtcheck_in.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcheck_in.Name = "txtcheck_in";
            this.txtcheck_in.Size = new System.Drawing.Size(244, 27);
            this.txtcheck_in.TabIndex = 13;
            this.txtcheck_in.ValueChanged += new System.EventHandler(this.txtcheck_in_ValueChanged);
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Enabled = false;
            this.txtOdaNo.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txtOdaNo.Location = new System.Drawing.Point(201, 406);
            this.txtOdaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOdaNo.Multiline = true;
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(246, 41);
            this.txtOdaNo.TabIndex = 12;
            // 
            // txtMusteriemail
            // 
            this.txtMusteriemail.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txtMusteriemail.Location = new System.Drawing.Point(203, 216);
            this.txtMusteriemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriemail.Multiline = true;
            this.txtMusteriemail.Name = "txtMusteriemail";
            this.txtMusteriemail.Size = new System.Drawing.Size(244, 38);
            this.txtMusteriemail.TabIndex = 10;
            // 
            // txtMusteritcNo
            // 
            this.txtMusteritcNo.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txtMusteritcNo.ForeColor = System.Drawing.Color.Black;
            this.txtMusteritcNo.Location = new System.Drawing.Point(200, 116);
            this.txtMusteritcNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteritcNo.MaxLength = 11;
            this.txtMusteritcNo.Multiline = true;
            this.txtMusteritcNo.Name = "txtMusteritcNo";
            this.txtMusteritcNo.Size = new System.Drawing.Size(247, 35);
            this.txtMusteritcNo.TabIndex = 9;
            this.txtMusteritcNo.TextChanged += new System.EventHandler(this.txtMusteritcNo_TextChanged);
            // 
            // txtMusteriIsim
            // 
            this.txtMusteriIsim.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txtMusteriIsim.ForeColor = System.Drawing.Color.Black;
            this.txtMusteriIsim.Location = new System.Drawing.Point(200, 51);
            this.txtMusteriIsim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriIsim.Multiline = true;
            this.txtMusteriIsim.Name = "txtMusteriIsim";
            this.txtMusteriIsim.Size = new System.Drawing.Size(247, 41);
            this.txtMusteriIsim.TabIndex = 8;
            this.txtMusteriIsim.TextChanged += new System.EventHandler(this.txtMusteriIsim_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 27);
            this.label8.TabIndex = 7;
            this.label8.Text = "Oda Numarası:";
            // 
            // kayitFormuBack
            // 
            this.kayitFormuBack.Image = global::otel_otomasyonu.Properties.Resources.indir__1_;
            this.kayitFormuBack.Location = new System.Drawing.Point(40, 23);
            this.kayitFormuBack.Name = "kayitFormuBack";
            this.kayitFormuBack.Size = new System.Drawing.Size(54, 45);
            this.kayitFormuBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kayitFormuBack.TabIndex = 9;
            this.kayitFormuBack.TabStop = false;
            this.kayitFormuBack.Click += new System.EventHandler(this.kayitFormuBack_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button109);
            this.groupBox3.Controls.Add(this.button108);
            this.groupBox3.Controls.Add(this.button107);
            this.groupBox3.Controls.Add(this.button106);
            this.groupBox3.Controls.Add(this.button105);
            this.groupBox3.Controls.Add(this.button104);
            this.groupBox3.Controls.Add(this.button102);
            this.groupBox3.Controls.Add(this.button103);
            this.groupBox3.Controls.Add(this.button101);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(596, 86);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 701);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Odalar";
            // 
            // button109
            // 
            this.button109.ForeColor = System.Drawing.Color.Black;
            this.button109.Location = new System.Drawing.Point(419, 548);
            this.button109.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button109.Name = "button109";
            this.button109.Size = new System.Drawing.Size(125, 121);
            this.button109.TabIndex = 9;
            this.button109.Text = "109";
            this.button109.UseVisualStyleBackColor = true;
            this.button109.Click += new System.EventHandler(this.button109_Click);
            // 
            // button108
            // 
            this.button108.ForeColor = System.Drawing.Color.Black;
            this.button108.Location = new System.Drawing.Point(224, 548);
            this.button108.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button108.Name = "button108";
            this.button108.Size = new System.Drawing.Size(125, 121);
            this.button108.TabIndex = 8;
            this.button108.Text = "108";
            this.button108.UseVisualStyleBackColor = true;
            this.button108.Click += new System.EventHandler(this.button108_Click);
            // 
            // button107
            // 
            this.button107.ForeColor = System.Drawing.Color.Black;
            this.button107.Location = new System.Drawing.Point(25, 548);
            this.button107.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button107.Name = "button107";
            this.button107.Size = new System.Drawing.Size(125, 121);
            this.button107.TabIndex = 7;
            this.button107.Text = "107";
            this.button107.UseVisualStyleBackColor = true;
            this.button107.Click += new System.EventHandler(this.button107_Click);
            // 
            // button106
            // 
            this.button106.ForeColor = System.Drawing.Color.Black;
            this.button106.Location = new System.Drawing.Point(419, 310);
            this.button106.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button106.Name = "button106";
            this.button106.Size = new System.Drawing.Size(125, 121);
            this.button106.TabIndex = 6;
            this.button106.Text = "106";
            this.button106.UseVisualStyleBackColor = true;
            this.button106.Click += new System.EventHandler(this.button106_Click);
            // 
            // button105
            // 
            this.button105.ForeColor = System.Drawing.Color.Black;
            this.button105.Location = new System.Drawing.Point(224, 310);
            this.button105.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button105.Name = "button105";
            this.button105.Size = new System.Drawing.Size(125, 121);
            this.button105.TabIndex = 5;
            this.button105.Text = "105";
            this.button105.UseVisualStyleBackColor = true;
            this.button105.Click += new System.EventHandler(this.button105_Click);
            // 
            // button104
            // 
            this.button104.ForeColor = System.Drawing.Color.Black;
            this.button104.Location = new System.Drawing.Point(25, 310);
            this.button104.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button104.Name = "button104";
            this.button104.Size = new System.Drawing.Size(125, 121);
            this.button104.TabIndex = 4;
            this.button104.Text = "104";
            this.button104.UseVisualStyleBackColor = true;
            this.button104.Click += new System.EventHandler(this.button104_Click);
            // 
            // button102
            // 
            this.button102.ForeColor = System.Drawing.Color.Black;
            this.button102.Location = new System.Drawing.Point(224, 66);
            this.button102.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button102.Name = "button102";
            this.button102.Size = new System.Drawing.Size(125, 121);
            this.button102.TabIndex = 3;
            this.button102.Text = "102";
            this.button102.UseVisualStyleBackColor = true;
            this.button102.Click += new System.EventHandler(this.button102_Click);
            // 
            // button103
            // 
            this.button103.ForeColor = System.Drawing.Color.Black;
            this.button103.Location = new System.Drawing.Point(429, 66);
            this.button103.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button103.Name = "button103";
            this.button103.Size = new System.Drawing.Size(125, 121);
            this.button103.TabIndex = 2;
            this.button103.Text = "103";
            this.button103.UseVisualStyleBackColor = true;
            this.button103.Click += new System.EventHandler(this.button103_Click);
            // 
            // button101
            // 
            this.button101.ForeColor = System.Drawing.Color.Black;
            this.button101.Location = new System.Drawing.Point(25, 66);
            this.button101.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button101.Name = "button101";
            this.button101.Size = new System.Drawing.Size(125, 121);
            this.button101.TabIndex = 1;
            this.button101.Text = "101";
            this.button101.UseVisualStyleBackColor = true;
            this.button101.Click += new System.EventHandler(this.button101_Click);
            // 
            // kayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1225, 812);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.kayitFormuBack);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kayitForm";
            this.Text = "Kayıt Formu";
            this.Load += new System.EventHandler(this.kayitForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kayitFormuBack)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox txtMusteriemail;
        private TextBox txtMusteritcNo;
        private TextBox txtMusteriIsim;
        private Label label8;
        private ComboBox txtMusterigender;
        private DateTimePicker txtcheck_in;
        private TextBox txtOdaNo;
        private DateTimePicker txtcikisTarihi;
        private MaskedTextBox txtMusteriTel;
        private Button btnEkle;
        private TextBox txtprice;
        private Label label9;
        private Label label10;
        private PictureBox kayitFormuBack;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private GroupBox groupBox3;
        private Button button109;
        private Button button108;
        private Button button107;
        private Button button106;
        private Button button105;
        private Button button104;
        private Button button102;
        private Button button103;
        private Button button101;
        private Label label13;
        private Label label12;
    }
}