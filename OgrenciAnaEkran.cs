using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinavSistemi
{
    public partial class ogrenciAnaEkran : Form
    {
        public ogrenciAnaEkran()
        {
            InitializeComponent();
        }
        public string kullaniiciadi;
        private void ogrenciAnaEkran_Load(object sender, EventArgs e)
        {
            label1.Text = kullaniiciadi.ToString();
        }
    }
}
