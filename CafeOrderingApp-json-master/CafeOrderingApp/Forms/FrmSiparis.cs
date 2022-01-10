using CafeOrderingApp.Business;
using CafeOrderingApp.Data;
using CafeOrderingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOrderingApp.Forms
{
    public partial class FrmSiparis : Form
    {
        public FrmSiparis()
        {
            InitializeComponent();
        }
        public Masa SeciliMasa { get; set; }
        public List<Siparis> MasaninSiparisleri { get; set; }
        public CafeContext Context { get; set; }
        private KategoriRepository _kategoriRepository;
        private SiparisRepository _siparisRepository;

        private void FrmSiparis_Load(object sender, EventArgs e)
        {
            _kategoriRepository = new KategoriRepository() { Context = Context };
            _siparisRepository = new SiparisRepository() { Context = Context };
            List<Kategori> kategoriler = _kategoriRepository.GetAll(x => x.Urunler.Count > 0);
            flpKategoriler.Controls.Clear();
            foreach (Kategori kategori in kategoriler)
            {
                Button btn = new Button()
                {
                    Text = kategori.Ad,
                    Size = new Size(220, 150),
                    BackgroundImage = Image.FromStream(new MemoryStream(kategori.Fotograf)),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    ForeColor = Color.White,
                    Font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Regular),
                    Tag = kategori
                };
                btn.Click += KategoriBtn_Click; ;
                flpKategoriler.Controls.Add(btn);
            }
           // lstSiparis.FullRowSelect = true;

            ListeyiDoldur();
        }

        private void ListeyiDoldur()
        {
            throw new NotImplementedException();
        }

        private void KategoriBtn_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
