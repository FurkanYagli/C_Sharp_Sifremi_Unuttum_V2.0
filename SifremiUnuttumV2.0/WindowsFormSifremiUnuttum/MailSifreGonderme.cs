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
    public partial class MailSifreGonderme : Form
    {
        public MailSifreGonderme()
        {
            InitializeComponent();
        }
        MailGonderme mg = new MailGonderme();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mg.Microsoft(textBox1.Text, textBox2.Text, textBox1.Text);
            MessageBox.Show("Girilen bilgiler eşleştiğinde mailinize yeni şifreniz gönderilecek", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            mg.Microsoft(textBox1.Text,textBox2.Text,textBox1.Text);
            MessageBox.Show("Girilen bilgiler eşleştiğinde mailinize yeni şifreniz gönderilecek", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
