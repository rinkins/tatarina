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
    public partial class продукт2 : Form
    {
        public продукт2()
        {
            InitializeComponent();
        }

        private void материалыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.материалыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proninaLastLastDataSet);

        }

        private void продукт2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Тип_материала". При необходимости она может быть перемещена или удалена.
            this.тип_материалаTableAdapter.Fill(this.proninaLastLastDataSet.Тип_материала);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Материалы". При необходимости она может быть перемещена или удалена.
            this.материалыTableAdapter.Fill(this.proninaLastLastDataSet.Материалы);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            продукт1 пр1 = new продукт1();
            пр1.Show();
        }
    }
}
