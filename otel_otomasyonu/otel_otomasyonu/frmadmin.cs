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
    public partial class frmadmin : Form
    {
        public frmadmin()
        {
            InitializeComponent();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {

            musteriler musteriler = new musteriler();
            musteriler.Show();
            this.Hide();

        }

        private void btnOdalar_Click(object sender, EventArgs e)
        {
            odalar odalar = new odalar();
            odalar.Show();
            this.Hide();
        }

        private void frmadminiBack_Click(object sender, EventArgs e)
        {
            adminGiris adminGiris = new adminGiris();
            adminGiris.Show();
            this.Hide();
        }
    }
}
