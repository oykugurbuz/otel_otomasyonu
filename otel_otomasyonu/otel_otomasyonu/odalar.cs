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

namespace otel_otomasyonu
{
    public partial class odalar : Form
    {
        public odalar()
        {
            InitializeComponent();
        }

        // Veritabanı bağlantısı için SqlConnection nesnesi
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UTB1M8P\\SQLEXPRESS;Initial Catalog=GURBUZHOTEL;Integrated Security=True");

        // Geri gitme düğmesine tıklanınca çağrılır
        private void odalarBack_Click(object sender, EventArgs e)
        {
            // frmadmin formunu oluşturup gösterir, bu formu gizler
            frmadmin frmadmin = new frmadmin();
            frmadmin.Show();
            this.Hide();
        }

        // Form yüklendiğinde çağrılır
        private void odalar_Load(object sender, EventArgs e)
        {
            // Odaları oluşturan fonksiyonu çağırır
            odaolustur();
        }

        // Odaları oluşturan fonksiyon
        private void odaolustur()
        {
            // Başlangıç oda numarası
            int oda = 100;

            // Butonların dikey mesafesi
            int mesafe = 0;

            // Butonların yatay mesafesi
            int x = -30;

            // 3x3'lük döngü ile butonlar oluşturulur
            for (int i = 1; i <= 3; i++)
            {
                mesafe = mesafe + 65;
                for (int j = 1; j <= 3; j++)
                {
                    // Yeni bir buton oluşturulur
                    Button button = new Button
                    {
                        Text = (oda + (i - 1) * 3 + j).ToString(),
                        Location = new System.Drawing.Point(j * 65 + x, mesafe),
                        Height = 55,
                        Width = 55,
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat
                    };

                    // Veritabanı bağlantısı açılır
                    using (SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UTB1M8P\\SQLEXPRESS;Initial Catalog=GURBUZHOTEL;Integrated Security=True"))
                    {
                        baglanti.Open();

                        // Veritabanından oda durumları kontrol edilir
                        string sorgu = "SELECT [check_in],[check_out] FROM Customer WHERE [room_number] = @deger";

                        // Parametreli sorgu çalıştırılır
                        using (SqlCommand command = new SqlCommand(sorgu, baglanti))
                        {
                            command.Parameters.AddWithValue("@deger", (i - 1) * 3 + j + oda);
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                DateTime today = DateTime.Now;
                                DateTime check_in = Convert.ToDateTime(reader["check_in"]);
                                DateTime check_out = Convert.ToDateTime(reader["check_out"]);
                                check_in = check_in.Date.AddHours(12);
                                check_out = check_out.Date.AddHours(12);

                                // Oda doluysa arka plan rengi kırmızı yapılır, boşsa mavi yapılır
                                if ((today >= check_in && today <= check_out))
                                {
                                    button.BackColor = Color.Red;
                                }
                                else
                                {
                                    button.BackColor = Color.RoyalBlue;
                                }
                            }
                            else
                            {
                                button.BackColor = Color.RoyalBlue;
                            }

                            // Butona tıklanma eventi atanır
                            button.Click += button_Click;

                            // Buton groupBox kontrolüne eklenir
                            groupBox1.Controls.Add(button);

                            // Reader kapatılır
                            reader.Close();
                        }

                        // Veritabanı bağlantısı kapatılır
                        baglanti.Close();
                    }
                }
            }
        }

        // Bir oda butonuna tıklandığında çağrılır
        private void button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            odalar rez = new odalar(btn);
        }
        public odalar(Button btn) : this()
        {
            // Yapılandırıcı kodu buraya eklenir
        }

    }
}

