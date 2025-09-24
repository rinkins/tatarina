using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastDAmnTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            партнеры1 парт1 = new партнеры1();
            парт1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            перс1 п1 = new перс1();
            п1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            продукт1 пр1 = new продукт1();
            пр1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            поставщик1 по1 = new поставщик1();
            по1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            склад1 ск1 = new склад1();
            ск1.Show();
        }
    }
}
