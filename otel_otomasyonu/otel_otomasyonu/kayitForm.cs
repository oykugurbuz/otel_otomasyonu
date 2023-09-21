using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using otel_otomasyonu;
using System.Reflection.Emit;

namespace otel_otomasyonu
{
    public partial class kayitForm : Form
    {
        public kayitForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UTB1M8P\\SQLEXPRESS;Initial Catalog=GURBUZHOTEL;Integrated Security=True");

        // Diğer değişkenler burada tanımlanır
        int price;
        int yas;
        bool kontrolonsekiz;
        DateTime check_in;
        DateTime check_out;
        string secilenOda = "";

        // Geri gitme düğmesine tıklanınca çağrılır
        private void kayitFormuBack_Click(object sender, EventArgs e)
        {
            home Home = new home();
            Home.Show();
            this.Hide();
        }

        // Sayısal bir değer olup olmadığını kontrol etmek için yardımcı bir fonksiyon
        private bool IsNumeric(string metin)
        {
            double sayi;
            return double.TryParse(metin, out sayi);
        }

        // Metin içinde sayı olup olmadığını kontrol etmek için yardımcı bir fonksiyon
        private bool ContainsNumber(string metinisim)
        {
            foreach (char karakter in metinisim)
            {
                if (char.IsDigit(karakter))
                {
                    return true; // Sayı bulundu, true döndür
                }
            }
            return false; // Sayı bulunamadı, false döndür
        }

        // Doğum tarihi seçildiğinde çağrılır
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Doğum tarihini al
            DateTime birthdate = dateTimePicker1.Value;

            if (dateTimePicker1.Value > DateTime.Today)
            {
                dateTimePicker1.Value = DateTime.Today;
            }

            // Bugünün tarihi
            DateTime bugun = DateTime.Today;

            // Yaşı hesapla
            yas = bugun.Year - birthdate.Year;

            if (bugun < birthdate.AddYears(yas))
            {
                yas--;
            }

            label12.Text = yas.ToString();

            if (yas < 18)
            {
                label13.Text = "18 yaşından küçük";
                kontrolonsekiz = true;
            }
            else
            {
                label13.Text = "18 yaşında veya 18 yaşından büyük";
                kontrolonsekiz = false;
            }

            txtcikisTarihi_ValueChanged_1(sender, e);
        }

        // Oda 101 seçildiğinde çağrılır

        private void button101_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Customer WHERE room_number=101 ", baglanti);
            int rezervasyonSayisi = 0;

            using (SqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    check_in = Convert.ToDateTime(reader["check_in"]);
                    check_out = Convert.ToDateTime(reader["check_out"]);
                    secilenOda = "101";
                    rezervasyonSayisi = 1;

                    if (secilenOda != "" && check_out != null && check_in != null && txtcheck_in.Value < check_out && txtcheck_in.Value >= check_in)
                    {
                        DialogResult result = MessageBox.Show(secilenOda + " numaralı oda seçilen tarihler arasında dolu.Yine de seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            txtOdaNo.Text = secilenOda;
                        }
                        else
                        {
                            secilenOda = "";
                            MessageBox.Show("Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtcheck_in.Value = check_out.AddDays(1);
                            txtcikisTarihi.Value = check_out.AddDays(2);
                            txtOdaNo.Clear();
                        }
                    }
                }

                reader.Close();
            }

            baglanti.Close();

            if (rezervasyonSayisi == 0)
            {
                txtOdaNo.Text = "101";
            }
        }


        private void button102_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Customer WHERE room_number=102 ", baglanti);
            int rezervasyonSayisi = 0;

            using (SqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    check_in = Convert.ToDateTime(reader["check_in"]);
                    check_out = Convert.ToDateTime(reader["check_out"]);
                    secilenOda = "102";
                    rezervasyonSayisi = 1;

                    if (secilenOda != "" && check_out != null && check_in != null && txtcheck_in.Value < check_out && txtcheck_in.Value >= check_in)
                    {
                        DialogResult result = MessageBox.Show(secilenOda + " numaralı oda seçilen tarihler arasında dolu.Yine de seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            txtOdaNo.Text = secilenOda;
                        }
                        else
                        {
                            secilenOda = "";
                            MessageBox.Show("Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtcheck_in.Value = check_out.AddDays(1);
                            txtcikisTarihi.Value = check_out.AddDays(2);
                            txtOdaNo.Clear();
                        }
                    }
                }

                reader.Close();
            }

            baglanti.Close();

            if (rezervasyonSayisi == 0)
            {
                txtOdaNo.Text = "102";
            }
        }

        private void button103_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Customer WHERE room_number=103 ", baglanti);
            int rezervasyonSayisi = 0;

            using (SqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    check_in = Convert.ToDateTime(reader["check_in"]);
                    check_out = Convert.ToDateTime(reader["check_out"]);
                    secilenOda = "103";
                    rezervasyonSayisi = 1;

                    if (secilenOda != "" && check_out != null && check_in != null && txtcheck_in.Value < check_out && txtcheck_in.Value >= check_in)
                    {
                        DialogResult result = MessageBox.Show(secilenOda + " numaralı oda seçilen tarihler arasında dolu.Yine de seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            txtOdaNo.Text = secilenOda;
                        }
                        else
                        {
                            secilenOda = "";
                            MessageBox.Show("Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtcheck_in.Value = check_out.AddDays(1);
                            txtcikisTarihi.Value = check_out.AddDays(2);
                            txtOdaNo.Clear();
                        }
                    }
                }

                reader.Close();
            }

            baglanti.Close();

            if (rezervasyonSayisi == 0)
            {
                txtOdaNo.Text = "103";
            }
        }

        private void button104_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Customer WHERE room_number=104 ", baglanti);
            int rezervasyonSayisi = 0;

            using (SqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    check_in = Convert.ToDateTime(reader["check_in"]);
                    check_out = Convert.ToDateTime(reader["check_out"]);
                    secilenOda = "104";
                    rezervasyonSayisi = 1;

                    if (secilenOda != "" && check_out != null && check_in != null && txtcheck_in.Value < check_out && txtcheck_in.Value >= check_in)
                    {
                        DialogResult result = MessageBox.Show(secilenOda + " numaralı oda seçilen tarihler arasında dolu.Yine de seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            txtOdaNo.Text = secilenOda;
                        }
                        else
                        {
                            secilenOda = "";
                            MessageBox.Show("Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtcheck_in.Value = check_out.AddDays(1);
                            txtcikisTarihi.Value = check_out.AddDays(2);
                            txtOdaNo.Clear();
                        }
                    }
                }

                reader.Close();
            }

            baglanti.Close();

            if (rezervasyonSayisi == 0)
            {
                txtOdaNo.Text = "104";
            }
        }

        private void button105_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Customer WHERE room_number=105 ", baglanti);
            int rezervasyonSayisi = 0;

            using (SqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    check_in = Convert.ToDateTime(reader["check_in"]);
                    check_out = Convert.ToDateTime(reader["check_out"]);
                    secilenOda = "105";
                    rezervasyonSayisi = 1;

                    if (secilenOda != "" && check_out != null && check_in != null && txtcheck_in.Value < check_out && txtcheck_in.Value >= check_in)
                    {
                        DialogResult result = MessageBox.Show(secilenOda + " numaralı oda seçilen tarihler arasında dolu.Yine de seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            txtOdaNo.Text = secilenOda;
                        }
                        else
                        {
                            secilenOda = "";
                            MessageBox.Show("Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtcheck_in.Value = check_out.AddDays(1);
                            txtcikisTarihi.Value = check_out.AddDays(2);
                            txtOdaNo.Clear();
                        }
                    }
                }

                reader.Close();
            }

            baglanti.Close();

            if (rezervasyonSayisi == 0)
            {
                txtOdaNo.Text = "105";
            }
        }

        private void button106_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Customer WHERE room_number=106 ", baglanti);
            int rezervasyonSayisi = 0;

            using (SqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    check_in = Convert.ToDateTime(reader["check_in"]);
                    check_out = Convert.ToDateTime(reader["check_out"]);
                    secilenOda = "106";
                    rezervasyonSayisi = 1;

                    if (secilenOda != "" && check_out != null && check_in != null && txtcheck_in.Value < check_out && txtcheck_in.Value >= check_in)
                    {
                        DialogResult result = MessageBox.Show(secilenOda + " numaralı oda seçilen tarihler arasında dolu.Yine de seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            txtOdaNo.Text = secilenOda;
                        }
                        else
                        {
                            secilenOda = "";
                            MessageBox.Show("Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtcheck_in.Value = check_out.AddDays(1);
                            txtcikisTarihi.Value = check_out.AddDays(2);
                            txtOdaNo.Clear();
                        }
                    }
                }

                reader.Close();
            }

            baglanti.Close();

            if (rezervasyonSayisi == 0)
            {
                txtOdaNo.Text = "106";
            }
        }

        private void button107_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Customer WHERE room_number=107 ", baglanti);
            int rezervasyonSayisi = 0;

            using (SqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    check_in = Convert.ToDateTime(reader["check_in"]);
                    check_out = Convert.ToDateTime(reader["check_out"]);
                    secilenOda = "107";
                    rezervasyonSayisi = 1;

                    if (secilenOda != "" && check_out != null && check_in != null && txtcheck_in.Value < check_out && txtcheck_in.Value >= check_in)
                    {
                        DialogResult result = MessageBox.Show(secilenOda + " numaralı oda seçilen tarihler arasında dolu.Yine de seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            txtOdaNo.Text = secilenOda;
                        }
                        else
                        {
                            secilenOda = "";
                            MessageBox.Show("Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtcheck_in.Value = check_out.AddDays(1);
                            txtcikisTarihi.Value = check_out.AddDays(2);
                            txtOdaNo.Clear();
                        }
                    }
                }

                reader.Close();
            }

            baglanti.Close();

            if (rezervasyonSayisi == 0)
            {
                txtOdaNo.Text = "107";
            }
        }

        private void button108_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Customer WHERE room_number=108 ", baglanti);
            int rezervasyonSayisi = 0;

            using (SqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    check_in = Convert.ToDateTime(reader["check_in"]);
                    check_out = Convert.ToDateTime(reader["check_out"]);
                    secilenOda = "108";
                    rezervasyonSayisi = 1;

                    if (secilenOda != "" && check_out != null && check_in != null && txtcheck_in.Value < check_out && txtcheck_in.Value >= check_in)
                    {
                        DialogResult result = MessageBox.Show(secilenOda + " numaralı oda seçilen tarihler arasında dolu.Yine de seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            txtOdaNo.Text = secilenOda;
                        }
                        else
                        {
                            secilenOda = "";
                            MessageBox.Show("Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtcheck_in.Value = check_out.AddDays(1);
                            txtcikisTarihi.Value = check_out.AddDays(2);
                            txtOdaNo.Clear();
                        }
                    }
                }

                reader.Close();
            }

            baglanti.Close();

            if (rezervasyonSayisi == 0)
            {
                txtOdaNo.Text = "108";
            }
        }

        private void button109_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Customer WHERE room_number=109 ", baglanti);
            int rezervasyonSayisi = 0;

            using (SqlDataReader reader = komut.ExecuteReader())
            {
                while (reader.Read())
                {
                    check_in = Convert.ToDateTime(reader["check_in"]);
                    check_out = Convert.ToDateTime(reader["check_out"]);
                    secilenOda = "109";
                    rezervasyonSayisi = 1;

                    if (secilenOda != "" && check_out != null && check_in != null && txtcheck_in.Value < check_out && txtcheck_in.Value >= check_in)
                    {
                        DialogResult result = MessageBox.Show(secilenOda + " numaralı oda seçilen tarihler arasında dolu.Yine de seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            txtOdaNo.Text = secilenOda;
                        }
                        else
                        {
                            secilenOda = "";
                            MessageBox.Show("Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtcheck_in.Value = check_out.AddDays(1);
                            txtcikisTarihi.Value = check_out.AddDays(2);
                            txtOdaNo.Clear();
                        }
                    }
                }

                reader.Close();
            }

            baglanti.Close();

            if (rezervasyonSayisi == 0)
            {
                txtOdaNo.Text = "109";
            }
        }

        private void txtMusteriIsim_TextChanged(object sender, EventArgs e)
        {
            string metinisim = txtMusteriIsim.Text;

            // Metin içerisinde sayı varsa uyarı ver
            if (ContainsNumber(metinisim))
            {
                MessageBox.Show("Lütfen sadece harf girişi yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMusteriIsim.Clear(); // TextBox'ı temizle
            }
        }

        // MusteritcNo TextBox'ına metin girildiğinde çağrılır
        private void txtMusteritcNo_TextChanged(object sender, EventArgs e)
        {
            string metintc = txtMusteritcNo.Text;
            if (!IsNumeric(metintc))
            {
                MessageBox.Show("Lütfen sadece sayı girişi yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMusteritcNo.Clear();
            }
        }

        // MusteriTel TextBox'ına metin girildiğinde çağrılır
        private void txtMusteriTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string metintel = txtMusteriTel.Text;
            if (!IsNumeric(metintel) && !(metintel.Length > 10))
            {
                MessageBox.Show("Lütfen sadece sayı girişi yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMusteriTel.Clear();
            }

        }

        // Çıkış tarihi değiştiğinde çağrılır
        private void txtcikisTarihi_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime ilktarih = Convert.ToDateTime(txtcheck_in.Text);
            DateTime sontarih = Convert.ToDateTime(txtcikisTarihi.Text);

            TimeSpan fark = sontarih - ilktarih;

            // Kalınacak gün sayısı
            label10.Text = fark.TotalDays.ToString();

            if (kontrolonsekiz == true)
            {
                price = ((Convert.ToInt32(label10.Text)) * 200) - 100;
                txtprice.Text = price.ToString();
            }
            else
            {
                price = ((Convert.ToInt32(label10.Text)) * 200);
                txtprice.Text = price.ToString();
            }

            if (sontarih < ilktarih)
            {
                MessageBox.Show("Giriş tarihi, çıkış tarihinden sonra olamaz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprice.Text = "";
            }

            if (secilenOda != "" && check_out != null && check_in != null && txtcikisTarihi.Value <= check_out && txtcikisTarihi.Value > check_in)
            {
                DialogResult result = MessageBox.Show(secilenOda + " numaralı oda seçilen tarihler arasında dolu.Yine de seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    txtOdaNo.Text = secilenOda;
                    txtcheck_in.Value = check_out.AddDays(1);
                    txtcikisTarihi.Value = check_out.AddDays(2);
                }
                else
                {
                    secilenOda = "";
                    MessageBox.Show("Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOdaNo.Clear();
                }
            }
        }

        // Giriş tarihi değiştiğinde çağrılır
        private void txtcheck_in_ValueChanged(object sender, EventArgs e)
        {
            DateTime ilktarih = Convert.ToDateTime(txtcheck_in.Text);
            DateTime sontarih = Convert.ToDateTime(txtcikisTarihi.Text);

            TimeSpan fark = sontarih - ilktarih;

            // Kalınacak gün sayısı
            label10.Text = fark.TotalDays.ToString();

            if (kontrolonsekiz == true)
            {
                price = ((Convert.ToInt32(label10.Text)) * 200) - 100;
                txtprice.Text = price.ToString();
            }
            else
            {
                price = ((Convert.ToInt32(label10.Text)) * 200);
                txtprice.Text = price.ToString();
            }

            if (sontarih < ilktarih)
            {
                MessageBox.Show("Giriş tarihi, çıkış tarihinden sonra olamaz!!!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprice.Text = "";
            }

            if (secilenOda != "" && check_out != null && check_in != null && txtcheck_in.Value < check_out && txtcheck_in.Value >= check_in)
            {
                DialogResult result = MessageBox.Show(secilenOda + " numaralı oda seçilen tarihler arasında dolu.Yine de seçmek istiyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    txtOdaNo.Text = secilenOda;
                    txtcheck_in.Value = check_out.AddDays(1);
                    txtcikisTarihi.Value = check_out.AddDays(2);
                }
                else
                {
                    secilenOda = "";
                    MessageBox.Show("Lütfen başka bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOdaNo.Clear();
                }
            }
        }

        // Kayıt ekle butonuna tıklanınca çağrılır
        private void btnEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kayıt yapıldı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Customer(full_name,identy_number,email,phone,gender,birthdate,room_number,price,check_in,check_out) values('" + txtMusteriIsim.Text + "','" + txtMusteritcNo.Text + "','" + txtMusteriemail.Text + "','" + txtMusteriTel.Text + "','" + txtMusterigender.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + txtOdaNo.Text + "','" + txtprice.Text + "','" + txtcheck_in.Value.ToString("yyyy-MM-dd") + "','" + txtcikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void kayitForm_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            // Yarının tarihini hesapla
            DateTime yarin = bugun.AddDays(1);
            string yrn = Convert.ToString(yarin);
            txtcikisTarihi.Text = yrn;
        }


    }
}



