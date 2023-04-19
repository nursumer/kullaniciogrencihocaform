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
    public partial class Form3 : Form
    {
        public List<string> musteriler = new List<string>();
        public Form3(List<string> must)
        {
            InitializeComponent();
            this.musteriler = must;
        }
        

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriler.Add(textBox1.Text);
            musteriler.Add(textBox2.Text);
            musteriler.Add(textBox3.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Select();
        }
    }
}
