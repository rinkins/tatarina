using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LastDAmnTime.Tests
{
    [TestClass]
    public class PartnerDiscountTests
    {
        private string connectionString = "Data Source=ADCLG1;Initial Catalog=ProninaLastLast;Integrated Security=True;Encrypt=False";

        // ТЕСТ 1: Расчет скидки 5% для партнера
        [TestMethod]
        public void CalculateDiscount_ForFirstPartner_Returns5Percent()
        {
            var form = new партнеры1();

            form.партнерыDataGridView.Rows[0].Selected = true;

            StringAssert.Contains(form.LabelDiscount.Text, "5%");
        }
    }

    [TestClass]
    public class SupplierTests
    {
        private string connectionString = "Data Source=ADCLG1;Initial Catalog=ProninaLastLast;Integrated Security=True;Encrypt=False";

        // ТЕСТ 2: Добавление поставщика
        [TestMethod]
        public void AddSupplier_ValidData_SavesToDatabase()
        {
            var form = new поставщик1();
            int testId = 999;

            AddTestSupplier(testId, "1234567890", "Москва", "123");

            bool exists = CheckSupplierExists(testId);
            Assert.IsTrue(exists, "Поставщик должен быть добавлен в базу данных");

            DeleteTestSupplier(testId);
        }

        // ТЕСТ 3: Ошибка при дублировании первичного ключа
        [TestMethod]
        public void AddSupplier_DuplicateId_ThrowsException()
        {
            int existingId = 1; 

            var ex = Assert.ThrowsException<SqlException>(() =>
                AddTestSupplier(existingId, "123", "Москва", "123"));

            StringAssert.Contains(ex.Message, "ограничение по уникальности");
        }

        // ТЕСТ 4: Ошибка при незаполненных полях
        [TestMethod]
        public void AddSupplier_MissingRequiredFields_ThrowsException()
        {
            int testId = 998;

            var ex = Assert.ThrowsException<SqlException>(() =>
                AddTestSupplier(testId, null, null, null));

            StringAssert.Contains(ex.Message, "NULL");
        }

        private void AddTestSupplier(int id, string inn, string address, string contacts)
        {
            string query = "INSERT INTO Поставщики (ID_поставщика, ИНН, Юридический_адрес, Контактные_данные) " +
                           "VALUES (@Id, @Inn, @Address, @Contacts)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Inn", (object)inn ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Address", (object)address ?? DBNull.Value);
                    command.Parameters.AddWithValue("@Contacts", (object)contacts ?? DBNull.Value);

                    command.ExecuteNonQuery();
                }
            }
        }

        private bool CheckSupplierExists(int id)
        {
            string query = "SELECT COUNT(*) FROM Поставщики WHERE ID_поставщика = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        private void DeleteTestSupplier(int id)
        {
            string query = "DELETE FROM Поставщики WHERE ID_поставщика = @Id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    [TestClass]
    public class DealTests
    {
        private string connectionString = "Data Source=ADCLG1;Initial Catalog=ProninaLastLast;Integrated Security=True;Encrypt=False";

        // ТЕСТ 5: Удаление сделки
        [TestMethod]
        public void DeleteDeal_ValidDeal_RemovesFromDatabase()
        {
            int testDealId = 999; 
            AddTestDeal(testDealId);

            DeleteTestDeal(testDealId);

            bool exists = CheckDealExists(testDealId);
            Assert.IsFalse(exists, "Сделка должна быть удалена из базы данных");
        }

        private void AddTestDeal(int dealId)
        {
            string query = "INSERT INTO История_партнера (ID_сделки, ID_партнера, ID_сотрудника, Сумма_сделки, Дата_сделки) " +
                           "VALUES (@DealId, 1, 1, 10000, GETDATE())";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DealId", dealId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void DeleteTestDeal(int dealId)
        {
            string query = "DELETE FROM История_партнера WHERE ID_сделки = @DealId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DealId", dealId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private bool CheckDealExists(int dealId)
        {
            string query = "SELECT COUNT(*) FROM История_партнера WHERE ID_сделки = @DealId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DealId", dealId);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }

    [TestClass]
    public class ForeignKeyTests
    {
        // ТЕСТ 6: Проверка внешнего ключа
        [TestMethod]
        public void AddPartner_InvalidType_ThrowsException()
        {
            int invalidTypeId = 9999; 


            var ex = Assert.ThrowsException<SqlException>(() =>
                AddTestPartnerWithInvalidType(invalidTypeId));

            StringAssert.Contains(ex.Message, "foreign key");
        }

        private void AddTestPartnerWithInvalidType(int typeId)
        {
            string query = "INSERT INTO Партнеры (ID_партнера, Тип, Наименование, Юридический_адрес, ИНН, ФИО_директора, Телефон, Почта) " +
                           "VALUES (9999, @TypeId, 'Test', 'Address', '123', 'Director', '123', 'test@test.com')";

            using (SqlConnection connection = new SqlConnection("Data Source=ADCLG1;Initial Catalog=ProninaLastLast;Integrated Security=True;Encrypt=False"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TypeId", typeId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}