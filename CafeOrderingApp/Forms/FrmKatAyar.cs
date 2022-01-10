using CafeOrderingApp.Business;
using CafeOrderingApp.Data;
using CafeOrderingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOrderingApp.Forms
{
    public partial class FrmKatAyar : Form
    {
        public FrmKatAyar()
        {
            InitializeComponent();
        }

        public CafeContext Context;
        private KatRepository repository = new KatRepository();
        private void btnKatKaydet_Click(object sender, EventArgs e)
        {
            Kat yeniKat = new Kat()
            {
                Ad = txtKatAdi.Text,
                Kod =txtKod.Text,
                Sira = int.Parse(txtSira.Text)
            };
            int adet = int.Parse(txtMasaAdeti.Text);

            for (int i = 0; i < adet; i++)
            {
                Masa yeniMasa = new Masa()
                {
                    Sira = i + 1,
                    Ad = $"{yeniKat.Kod}/Masa {i + 1}"
                };
                yeniKat.Masalar.Add(yeniMasa);
            }
            repository.Add(yeniKat);
            lstKatlar.DataSource = null;
            lstKatlar.DataSource = repository.GetAll().OrderBy(x => x.Sira).ToList();
        }

        private void FrmKatAyar_Load(object sender, EventArgs e)
        {
            repository.Context = Context;
        }
    }
}