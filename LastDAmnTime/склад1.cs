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
    public partial class склад1 : Form
    {
        public склад1()
        {
            InitializeComponent();
        }

        private void складBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.складBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proninaLastLastDataSet);

        }

        private void склад1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.История_изменения_колва_материа". При необходимости она может быть перемещена или удалена.
            this.история_изменения_колва_материаTableAdapter.Fill(this.proninaLastLastDataSet.История_изменения_колва_материа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Колво_на_складе". При необходимости она может быть перемещена или удалена.
            this.колво_на_складеTableAdapter.Fill(this.proninaLastLastDataSet.Колво_на_складе);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Склад". При необходимости она может быть перемещена или удалена.
            this.складTableAdapter.Fill(this.proninaLastLastDataSet.Склад);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
