using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastDAmnTime
{
    public partial class партнеры1 : Form
    {
        public партнеры1()
        {
            InitializeComponent();
        }

        private void партнерыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.партнерыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.proninaLastLastDataSet);

        }

        private void партнеры1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.ID_типа_партнера". При необходимости она может быть перемещена или удалена.
            this.iD_типа_партнераTableAdapter.Fill(this.proninaLastLastDataSet.ID_типа_партнера);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Торговые_точки". При необходимости она может быть перемещена или удалена.
            this.торговые_точкиTableAdapter.Fill(this.proninaLastLastDataSet.Торговые_точки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "proninaLastLastDataSet.Партнеры". При необходимости она может быть перемещена или удалена.
            this.партнерыTableAdapter.Fill(this.proninaLastLastDataSet.Партнеры);

        }

        private void торговые_точкиDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            партнеры2 парт2 = new партнеры2();
            парт2.Show();
        }

        private void UpdateDiscountLabel(int partnerId, string partnerName)
        {
            string connectionString = "Data Source=ADCLG1;Initial Catalog=ProninaLastLast;Integrated Security=True;Encrypt=False";

            string query = @"
        SELECT ISNULL(SUM(Сумма_сделки), 0) AS TotalAmount
        FROM История_партнера 
        WHERE ID_партнера = @PartnerId";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PartnerId", partnerId);

                        decimal totalAmount = Convert.ToDecimal(command.ExecuteScalar());

                        // Расчет скидки
                        string discountText;
                        Color textColor;

                        if (totalAmount >= 1000000)
                        {
                            discountText = $" Скидка для {partnerName}: 15%";
                            textColor = Color.DarkGreen;
                        }
                        else if (totalAmount >= 300000)
                        {
                            discountText = $" Скидка для {partnerName}: 10%";
                            textColor = Color.Green;
                        }
                        else if (totalAmount >= 100000)
                        {
                            discountText = $" Скидка для {partnerName}: 5%";
                            textColor = Color.Blue;
                        }
                        else
                        {
                            discountText = $"Для {partnerName} скидка пока не доступна";
                            textColor = Color.Gray;
                        }

                        LabelDiscount.Text = $"{discountText} (Сумма заказов: {totalAmount:N2} руб.)";
                        LabelDiscount.ForeColor = textColor;
                    }
                }
            }
            catch (Exception ex)
            {
                LabelDiscount.Text = "Ошибка расчета скидки: " + ex.Message;
                LabelDiscount.ForeColor = Color.Red;
            }
        }

        private void партнерыDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (партнерыDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = партнерыDataGridView.SelectedRows[0];

                // Получаем ID и имя партнера из выбранной строки
                int partnerId = Convert.ToInt32(selectedRow.Cells["dataGridViewTextBoxColumn1"].Value); // Укажите правильное имя колонки с ID
                string partnerName = selectedRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString(); // Укажите правильное имя колонки с именем

                // Обновляем label со скидкой
                UpdateDiscountLabel(partnerId, partnerName);
            }
        }
    }
}
