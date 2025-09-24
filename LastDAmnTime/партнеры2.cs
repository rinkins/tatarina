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
    public partial class партнеры2 : Form
    {
        public партнеры2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            партнеры1 парт1 = new партнеры1();
            парт1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            партнеры3 парт3 = new партнеры3();
            парт3.Show();
        }

        private void история_партнераBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.история_партнераBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proninaLastLastDataSet);

        }

        private void партнеры2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Состав_сделки". При необходимости она может быть перемещена или удалена.
            this.состав_сделкиTableAdapter.Fill(this.proninaLastLastDataSet.Состав_сделки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.История_партнера". При необходимости она может быть перемещена или удалена.
            this.история_партнераTableAdapter.Fill(this.proninaLastLastDataSet.История_партнера);

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
