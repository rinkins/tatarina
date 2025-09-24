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
    public partial class перс2 : Form
    {
        public перс2()
        {
            InitializeComponent();
        }

        private void система_турникетовBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.система_турникетовBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proninaLastLastDataSet);

        }

        private void перс2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Система_турникетов". При необходимости она может быть перемещена или удалена.
            this.система_турникетовTableAdapter.Fill(this.proninaLastLastDataSet.Система_турникетов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            перс1 п1 = new перс1();
            п1.Show();
        }
    }
}
