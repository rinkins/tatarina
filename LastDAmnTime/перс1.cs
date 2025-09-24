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
    public partial class перс1 : Form
    {
        public перс1()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proninaLastLastDataSet);

        }

        private void перс1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Кадры". При необходимости она может быть перемещена или удалена.
            this.кадрыTableAdapter.Fill(this.proninaLastLastDataSet.Кадры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Должности". При необходимости она может быть перемещена или удалена.
            this.должностиTableAdapter.Fill(this.proninaLastLastDataSet.Должности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.proninaLastLastDataSet.Сотрудники);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            перс2 п2 = new перс2();
            п2.Show();
        }
    }
}
