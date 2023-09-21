using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otel_otomasyonu
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

      
        private void btnadminGiris_Click(object sender, EventArgs e)
        {
            adminGiris AdminGiris = new adminGiris();
            AdminGiris.Show();
            this.Hide();
        }

        private void btnKayitFormu_Click(object sender, EventArgs e)
        {
            kayitForm KayitForm = new kayitForm();
            KayitForm.Show();
            this.Hide();
        }
    }
}
