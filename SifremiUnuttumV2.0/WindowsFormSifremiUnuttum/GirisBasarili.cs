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
    public partial class GirisBasarili : Form
    {
        WindowsFormSifremiUnuttumEntitiesConnectionDb db = new WindowsFormSifremiUnuttumEntitiesConnectionDb();
        public GirisBasarili()
        {
            InitializeComponent();
        }

        private void GirisBasarili_Load(object sender, EventArgs e)
        {
            label1.Text = $@"Hoş Geldiniz, Sayın { db.PersonelGirisTablosu.FirstOrDefault(x => x.id == Form1.Id).FirstName}
            { db.PersonelGirisTablosu.FirstOrDefault(x => x.id == Form1.Id).LastName}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
