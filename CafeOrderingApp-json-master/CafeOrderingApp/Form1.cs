using CafeOrderingApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOrderingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private FrmAnaEkran _frmAnaEkran;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (_frmAnaEkran==null || _frmAnaEkran.IsDisposed)
            {
               _frmAnaEkran= new FrmAnaEkran();
            }
            if (txtKullaniciAdi.Text == "admin" && txtParola.Text == "admin")
            {
                _frmAnaEkran.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre");
            }
        }
    }
}
