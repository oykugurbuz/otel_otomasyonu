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
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace otel_otomasyonu
{
    public partial class musteriler : Form
    {

        int id = 0;
        int yas;
        Boolean kontrolonsekiz;
        int price;
        DateTime check_in;
        DateTime check_out;
        string secilenOda = "";
        public musteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-UTB1M8P\SQLEXPRESS;Initial Catalog=GURBUZHOTEL;Integrated Security=True");

        #region Event
        private void btnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Customer where full_name like '%" + textBox1.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["full_name"].ToString());
                ekle.SubItems.Add(oku["identy_number"].ToString());
                ekle.SubItems.Add(oku["email"].ToString());
                ekle.SubItems.Add(oku["phone"].ToString());
                ekle.SubItems.Add(oku["gender"].ToString());
                ekle.SubItems.Add(oku["room_number"].ToString());
                ekle.SubItems.Add(oku["birthdate"].ToString());
                ekle.SubItems.Add(oku["price"].ToString());
                ekle.SubItems.Add(oku["check_in"].ToString());
                ekle.SubItems.Add(oku["check_out"].ToString());

                listView1.Items.Add(ekle);

            }
            oku.Close();
            baglanti.Close();
        }
        Boolean kontrol;
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            if (kontrol = true)
            {
                txtMusteriIsim.Clear();
                //txtMusteritcNo.Clear();
                txtMusteritcNo.Text = "";
                txtMusteriemail.Clear();
                txtMusteriTel.Clear();
                txtMusterigender.SelectedItem = null;
                txtOdaNo.Clear();
                dateTimePicker1.Text = "";
                txtprice.Clear();
                txtcheck_in.Text = "";
                txtcikisTarihi.Text = "";
                txtprice.Clear();
                kontrol = true;
            }

            DateTime bugun = DateTime.Today;

            // Yarının tarihini hesapla
            DateTime yarin = bugun.AddDays(1);
            string yrn = Convert.ToString(yarin);
            txtcikisTarihi.Text = yrn;
            MessageBox.Show("Textbox lar Temizlendi");

        }
        private void btnSil_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM Customer WHERE identy_number = @identy_number", baglanti);
                komut.Parameters.AddWithValue("@identy_number", txtMusteritcNo.Text);

                int affectedRows = komut.ExecuteNonQuery();

                if (affectedRows > 0)
                {
                    MessageBox.Show("Müşteri başarıyla silindi.");
                    btnTemizle_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Müşteri bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            verilerigoster();

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (secilenOda != "" && check_out != null && check_in != null && ((txtcikisTarihi.Value <= check_out && txtcikisTarihi.Value > check_in) || (txtcheck_in.Value < check_out && txtcheck_in.Value >= check_in)))
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
                    txtOdaNo.Clear();
                }



            }

            if (btnKaydet.Text == "Kaydet")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Customer(full_name,identy_number,email,phone,gender,birthdate,room_number,price,check_in,check_out) values('" + txtMusteriIsim.Text + "','" + txtMusteritcNo.Text + "','" + txtMusteriemail.Text + "','" + txtMusteriTel.Text + "','" + txtMusterigender.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + txtOdaNo.Text + "','" + txtprice.Text + "','" + txtcheck_in.Value.ToString("yyyy-MM-dd") + "','" + txtcikisTarihi.Value.ToString("yyyy-MM-dd") + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else if (btnKaydet.Text == "Güncelle")
            {
                baglanti.Open();

                int price;
                DateTime ilktarih = Convert.ToDateTime(txtcheck_in.Text);
                DateTime sontarih = Convert.ToDateTime(txtcikisTarihi.Text);
                if (sontarih < ilktarih)
                {
                    MessageBox.Show("Çıkış tarihi,giriş tarihinden sonra olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                TimeSpan fark = sontarih - ilktarih; //KALINACAK GÜN SAYISI
                label10.Text = fark.TotalDays.ToString();
                price = (Convert.ToInt32(label10.Text)) * 200;// günlük 200 tl
                txtprice.Text = price.ToString();

                SqlCommand komut = new SqlCommand("update Customer set full_name= '" + txtMusteriIsim.Text + "',identy_number='" + txtMusteritcNo.Text + "',email='" + txtMusteriemail.Text + "',phone='" + txtMusteriTel.Text + "',gender='" + txtMusterigender.Text + "',room_number='" + txtOdaNo.Text + "',birthdate='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',price='" + txtprice.Text + "',check_in='" + txtcheck_in.Value.ToString("yyyy-MM-dd") + "',check_out='" + txtcikisTarihi.Value.ToString("yyyy-MM-dd") + "' where id=" + id + "", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnTemizle_Click(sender, e);


            }

            btnKaydet.Text = "Kaydet";
            verilerigoster();
        }

        #endregion

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            using (SqlCommand komut = new SqlCommand("select * from [dbo].[Customer] ORDER BY id ASC", baglanti))
            {
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["id"].ToString();
                    ekle.SubItems.Add(oku["full_name"].ToString());
                    ekle.SubItems.Add(oku["identy_number"].ToString());
                    ekle.SubItems.Add(oku["email"].ToString());
                    ekle.SubItems.Add(oku["phone"].ToString());
                    ekle.SubItems.Add(oku["gender"].ToString());
                    ekle.SubItems.Add(oku["room_number"].ToString());
                    ekle.SubItems.Add(oku["birthdate"].ToString());
                    ekle.SubItems.Add(oku["price"].ToString());
                    ekle.SubItems.Add(oku["check_in"].ToString());
                    ekle.SubItems.Add(oku["check_out"].ToString());

                    listView1.Items.Add(ekle);

                }
                oku.Close();
            }

            baglanti.Close();
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            List<ListViewItem> listViewItems = new List<ListViewItem>();
            foreach (ListViewItem item in listView1.Items)
            {
                listViewItems.Add(item);
            }

            // ID'sine göre sırala
            listViewItems.Sort((x, y) => int.Parse(x.SubItems[0].Text).CompareTo(int.Parse(y.SubItems[0].Text)));


            listView1.Items.Clear();

            foreach (ListViewItem item in listViewItems)
            {
                listView1.Items.Add(item);
            }
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtMusteriIsim.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtMusteritcNo.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtMusteriemail.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtMusteriTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtMusterigender.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtOdaNo.Text = listView1.SelectedItems[0].SubItems[6].Text;
            dateTimePicker1.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtprice.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txtcheck_in.Text = listView1.SelectedItems[0].SubItems[9].Text;
            txtcikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
            btnKaydet.Text = "Güncelle";

        }
        private void musterilerBack_Click_1(object sender, EventArgs e)
        {
            frmadmin frmadmin = new frmadmin();
            frmadmin.Show();
            this.Hide();
        }
        private void musteriler_Load(object sender, EventArgs e)
        {
            verilerigoster();
            DateTime bugun = DateTime.Today;

            // Yarının tarihini hesapla
            DateTime yarin = bugun.AddDays(1);
            string yrn = Convert.ToString(yarin);
            txtcikisTarihi.Text = yrn;



        }
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
        private bool IsNumeric(string metin)
        {
            double sayi;
            return double.TryParse(metin, out sayi);
        }
        private void txtMusteriTel_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {
            string metintel = txtMusteriTel.Text;
            if (kontrol != true)
            {
                if (!IsNumeric(metintel))
                {
                    MessageBox.Show("Lütfen sadece sayı girişi yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMusteriTel.Clear();
                }
            }
        }
        private void dt_birth_date_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthdate = dateTimePicker1.Value;

            if (dateTimePicker1.Value > DateTime.Today)
            {

                dateTimePicker1.Value = DateTime.Today;
            }
            // Bugünün tarihi
            DateTime bugun = DateTime.Today;

            //  yıl farkı
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
                label13.Text = "18yaşında veya 18 yaşından büyük";
                kontrolonsekiz = false;
            }
            //txtcikisTarihi_ValueChanged_1(sender, e);


        }
        private void txtMusteriIsim_TextChanged_1(object sender, EventArgs e)
        {
            string metinisim = txtMusteriIsim.Text;

            if (ContainsNumber(metinisim))
            {
                MessageBox.Show("Lütfen sadece harf girişi yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }
        private void txtMusteritcNo_TextChanged_1(object sender, EventArgs e)
        {
            string metintc = txtMusteritcNo.Text;
            if (kontrol != true)
            {
                if (!IsNumeric(metintc))
                {
                    MessageBox.Show("Lütfen sadece sayı girişi yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        private void txtMusteriTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            string metintel = txtMusteriTel.Text;
            if (kontrol != true)
            {
                if (!IsNumeric(metintel) && !(metintel.Length > 10))
                {
                    MessageBox.Show("Lütfen sadece sayı girişi yapın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }
        private void txtcikisTarihi_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime ilktarih = Convert.ToDateTime(txtcheck_in.Text);
            DateTime sontarih = Convert.ToDateTime(txtcikisTarihi.Text);

            TimeSpan fark = sontarih - ilktarih;
            //KALINACAK GÜN SAYISI
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
                // MessageBox.Show("Giriş tarihi, çıkış tarihinden sonra olamaz!!!");
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

        private void txtcheck_in_ValueChanged(object sender, EventArgs e)
        {

            DateTime ilktarih = Convert.ToDateTime(txtcheck_in.Text);
            DateTime sontarih = Convert.ToDateTime(txtcikisTarihi.Text);

            TimeSpan fark = sontarih - ilktarih;
            //KALINACAK GÜN SAYISI
            label10.Text = fark.TotalDays.ToString();

            if (kontrolonsekiz == true)
            {
                price = ((Convert.ToInt32(label10.Text)) * 200) - 100;// günlük 200 tl -100
                txtprice.Text = price.ToString();
            }
            else

            {
                price = ((Convert.ToInt32(label10.Text)) * 200);// günlük 200 tl
                txtprice.Text = price.ToString();
            }
            if (sontarih < ilktarih)
            {
                //  MessageBox.Show("Giriş tarihi, çıkış tarihinden sonra olamaz!!!");
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

        private void btnAraSil_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            verilerigoster();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

