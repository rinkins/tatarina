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
    public partial class партнеры3 : Form
    {
        public партнеры3()
        {
            InitializeComponent();
        }

        private void история_рейтингаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.история_рейтингаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proninaLastLastDataSet);

        }

        private void партнеры3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.История_рейтинга". При необходимости она может быть перемещена или удалена.
            this.история_рейтингаTableAdapter.Fill(this.proninaLastLastDataSet.История_рейтинга);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            партнеры2 парт2 = new партнеры2();
            парт2.Show();

        }
    }
}
