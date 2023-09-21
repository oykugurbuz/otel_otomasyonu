using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_otomasyonu
{
    public partial class adminGiris : Form
    {
        public adminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-UTB1M8P\\SQLEXPRESS;Initial Catalog=GURBUZHOTEL;Integrated Security=True");

      

        private void passwordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheck.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = true;

            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;


            }
        }

        private void adminGiris_Load(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = false;



            // Enter olayını tanımla
            txtKullanıcıAdı.KeyDown += new KeyEventHandler(txtKullanıcıAdı_KeyDown);
            txtpassword.KeyDown += new KeyEventHandler(txtKullanıcıAdı_KeyDown);
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "select * from [dbo].[User] where user_name=@user_name AND password=@password";
                SqlParameter prm1 = new SqlParameter("user_name", txtKullanıcıAdı.Text.Trim());
                SqlParameter prm2 = new SqlParameter("password", txtpassword.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    frmadmin frmadmin = new frmadmin();
                    frmadmin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş! Kullanıcı Adınız veya Şifreniz yanlış girildi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtKullanıcıAdı.Clear();
                    txtpassword.Clear();
                }
                baglanti.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtKullanıcıAdı_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGirisYap_Click(sender, e);
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonGirisYap_Click(sender, e);
            }
        }

        private void adminGirisiBack_Click_1(object sender, EventArgs e)
        {
            home Home = new home();
            Home.Show();
            this.Hide();
        }
    }
}
