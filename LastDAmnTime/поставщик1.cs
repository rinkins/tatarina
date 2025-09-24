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
    public partial class поставщик1 : Form
    {
        public поставщик1()
        {
            InitializeComponent();
        }

        private void поставщикиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.поставщикиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proninaLastLastDataSet);

        }

        private void поставщик1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Состав_поставки". При необходимости она может быть перемещена или удалена.
            this.состав_поставкиTableAdapter.Fill(this.proninaLastLastDataSet.Состав_поставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.proninaLastLastDataSet.Поставки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.proninaLastLastDataSet.Поставщики);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
