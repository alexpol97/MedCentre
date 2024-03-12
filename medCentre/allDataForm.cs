using medCentre.basesqlDataSetTableAdapters;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static medCentre.Program;

namespace medCentre
{
    public partial class allDataForm : Form
    {
        // Подключение к базе данных:
        SqlDataAdapter dataAdapter;   // Адаптер выполнения команд.
        DataSet dataSet;                // Набор данных для загрузки.

        // Строка подключения к базе.
        string сonnString = ConnectionManager.ConnString;

        // Просмотр всех данных. Вызывается в том случае, если не указан параметр имени таблицы.
        public allDataForm()
        {
            InitializeComponent();
        }

        // Просмотр данных конкретной таблицы. Вызывается в том случае, если параметр имени таблицы указан явно.
        public allDataForm(string table)
        {
            InitializeComponent();

            // Из списка с таблицами выбирается нужное имя таблицы.
            tableCB.SelectedItem = table;

            // Загрузка данных из заданной таблицы. Параметр "имя таблицы" принимается из места вызова.
            string cmdText = "SELECT * FROM " + table + ";";

            try
            {
                dataAdapter = new SqlDataAdapter(cmdText, сonnString);
                dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения запроса.\r\n\r\n" + ex.ToString());
            }
        }

        // Просмотр данных для конкретного SQL-запроса. Вызывается в том случае, если параметр имени таблицы и строки запроса указаны явно.
        public allDataForm(string table, string cmdText)
        {
            InitializeComponent();

            // Из списка с таблицами выбирается нужное имя таблицы.
            tableCB.SelectedItem = table;

            try
            {
                dataAdapter = new SqlDataAdapter(cmdText, сonnString);
                dataSet = new DataSet();

                dataAdapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения запроса.\r\n\r\n" + ex.ToString());
            }
        }

        // Передвижение окна.
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        // Закрыть окно.
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Свернуть приложение.
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Если меняется выбранная в списке таблица, данные снова загружаются из базы данных.
        private void tableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableCB.SelectedIndex != -1)
            {
                string cmdText = "SELECT * FROM " + tableCB.SelectedItem.ToString() + ";";

                try
                {
                    dataAdapter = new SqlDataAdapter(cmdText, сonnString);
                    dataSet = new DataSet();

                    dataAdapter.Fill(dataSet);
                    dataGridView1.DataSource = dataSet.Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка выполнения запроса.\r\n\r\n" + ex.ToString());
                }
            }
        }

        // Удалить запись по двойному щелчку мыши в таблице.
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                string selectedTable = tableCB.SelectedItem as string;
                if (!string.IsNullOrEmpty(selectedTable))
                {
                    // Строка запроса.
                    string cmdText = "DELETE FROM " + selectedTable + " WHERE [Id] = @Id;";

                    DialogResult result = MessageBox.Show(
                        "Вы действительно хотите удалить эту строку из базы данных?",
                        "Вы уверены?",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection myConnection = new SqlConnection(сonnString))
                        {
                            myConnection.Open();
                            SqlCommand command = new SqlCommand(cmdText, myConnection);
                            command.Parameters.AddWithValue("@Id", dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString());

                            try
                            {
                                // Запуск выполнения запроса.
                                command.ExecuteNonQuery();

                                // Вывести уведомление о успешном удалении.
                                MessageBox.Show("Информация успешно удалена из базы данных.", "Успешно!",
                                    MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.ToString());
                                return;
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Не выбрана таблица.");
                }
            }
        }
    }
}
