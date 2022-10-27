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

namespace WindowsFormSifremiUnuttum
{
    public partial class Form1 : Form
    {
        WindowsFormSifremiUnuttumEntitiesConnectionDb db = new WindowsFormSifremiUnuttumEntitiesConnectionDb();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public static int Id;
        private void button1_Click(object sender, EventArgs e)
        {
            var Durum = db.PersonelGirisTablosu.FirstOrDefault(x => x.MailAdress == textBox1.Text && x.Password == textBox2.Text);
            if (Durum != null)
            {
                Id = Durum.id;
                GirisBasarili gb = new GirisBasarili();
                gb.ShowDialog();
            }
            else
            {
                MessageBox.Show("Girilen bilgilere ait hesap blunmamaktadır.","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreYenile sy = new SifreYenile();
            sy.ShowDialog();
        }
    }
}
