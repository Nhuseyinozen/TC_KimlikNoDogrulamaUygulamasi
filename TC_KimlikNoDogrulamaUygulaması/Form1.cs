using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_KimlikNoDogrulamaUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {

            long tc = long.Parse(txtTC.Text);
            string isim = txtIsim.Text.ToUpper();
            string soyisim = txtSoyisim.Text.ToUpper();
            int yil = int.Parse(txtYil.Text);



            TCKimlikDogrulama.KPSPublic kps = new TCKimlikDogrulama.KPSPublic();

            bool control = kps.TCKimlikNoDogrula(tc, isim, soyisim, yil);

            if (control)
            {
                MessageBox.Show("Bilgileriniz doğrulandı !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bilgileriniz HATALI !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
