using CafeOrderingApp.Data;
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
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        private CafeContext _context;
        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
              _context = new CafeContext();
            _context.Load();
        }

        private FrmMenu frmMenu;
        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMenu == null || frmMenu.IsDisposed)
            {
                frmMenu = new FrmMenu();
            }
            frmMenu.Context = _context;
            //frmMenu.MdiParent = this;
            frmMenu.WindowState = FormWindowState.Maximized;
            frmMenu.Show();
        }

        private FrmKatAyar frmKatAyar;
        private void katMasaAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKatAyar == null || frmKatAyar.IsDisposed)
            {
                frmKatAyar = new FrmKatAyar();
            }
            frmKatAyar.Context = _context;
            //frmKatAyar.MdiParent = this;
            frmKatAyar.WindowState = FormWindowState.Maximized;
            frmKatAyar.Show();
        }

        private FrmKafeGorunum frmKafeGorunum;
        private void siparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKafeGorunum == null || frmKafeGorunum.IsDisposed)
            {
                frmKafeGorunum = new FrmKafeGorunum();
            }

            frmKafeGorunum.Context = _context;
            //frmKafeGorunum.MdiParent = this;
            frmKafeGorunum.WindowState = FormWindowState.Maximized;
            frmKafeGorunum.Show();
        }
    }
}
