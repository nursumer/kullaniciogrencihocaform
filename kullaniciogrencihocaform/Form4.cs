using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kullaniciogrencihocaform
{
    public partial class Form4 : Form
    {
        public List<string> musteriler = new List<string>();
        public Form4(List<string> must)
        {
            InitializeComponent();
            this.musteriler = must;
        }
       
        private void Form4_Load(object sender, EventArgs e)
        {
            int y = 0;
            for (int i = 0; i < musteriler.Count()/3; i++) // bölü 3 ile kaç adet giirş var
            {
                string ad, soyad, tel;
                ad = musteriler[i+y];
                soyad = musteriler[i+y];
                tel = musteriler[i+y];
                y = y + 2;
                string[] satır = { ad, soyad, tel };
                ListViewItem item = new ListViewItem(satır);
                listView1.Items.Add(item);  
            }
        }
    }
}
