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
    public partial class продукт1 : Form
    {
        public продукт1()
        {
            InitializeComponent();
        }

        private void продукцияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.продукцияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proninaLastLastDataSet);

        }

        private void продукт1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Необход_материалы". При необходимости она может быть перемещена или удалена.
            this.необход_материалыTableAdapter.Fill(this.proninaLastLastDataSet.Необход_материалы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Продукция". При необходимости она может быть перемещена или удалена.
            this.продукцияTableAdapter.Fill(this.proninaLastLastDataSet.Продукция);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            продукт2 пр2 = new продукт2();
            пр2.Show();
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
