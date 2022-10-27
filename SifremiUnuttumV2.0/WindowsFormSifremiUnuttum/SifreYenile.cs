using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormSifremiUnuttum.Models;
using Microsoft;

namespace WindowsFormSifremiUnuttum
{
    public partial class SifreYenile : Form
    {
        WindowsFormSifremiUnuttumEntitiesConnectionDb db = new WindowsFormSifremiUnuttumEntitiesConnectionDb();
        
        public SifreYenile()
        {
            //PersonelGirisTablosu p = db.PersonelGirisTablosu.FirstOrDefault();
            //p.GüvenlikSorusu = label1.Text;

            InitializeComponent();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelGirisTablosu p = db.PersonelGirisTablosu.FirstOrDefault();
            if (textBox1.Text == p.GüvenlikSorusuCevabi) {
                MessageBox.Show($@"Şifreniz: {p.Password}" ,"Durum",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Hatalı ya da eksik tuşlama yaptınız","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void SifreYenile_Load(object sender, EventArgs e)
        {
            PersonelGirisTablosu p = db.PersonelGirisTablosu.FirstOrDefault();
            label1.Text = p.GüvenlikSorusu;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MailSifreGonderme msg = new MailSifreGonderme();
            msg.ShowDialog();
        }
    }
}
