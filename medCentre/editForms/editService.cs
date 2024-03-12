using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static medCentre.Program;

namespace medCentre
{
    public partial class editService : Form
    {
        // Подключение к базе данных:
        SqlDataAdapter dataAdapter;   // Адаптер выполнения команд.
        DataSet dataSet;                // Набор данных для загрузки.

        // Строка подключения к базе.
        string сonnString = ConnectionManager.ConnString;

        public editService()
        {
            InitializeComponent();

            string cmdTxt = "SELECT * FROM [Услуги];";

            try
            {
                dataAdapter = new SqlDataAdapter(cmdTxt, сonnString);
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

        // Выход из приложения.
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Свернуть приложение.
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            price.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            description.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(price.Text) || string.IsNullOrWhiteSpace(description.Text))
            {
                MessageBox.Show("Ошибка: поля не могут быть пустыми!");
                return;
            }

            string cmdText = "UPDATE [Услуги] SET " +
                "[Название]=@Name, " +
                "[Стоимость]=@Price, " +
                "[Описание]=@Description " +
                "WHERE [ID]=@ID;";

            using (SqlConnection myConnection = new SqlConnection(сonnString))
            {
                myConnection.Open();

                using (SqlCommand command = new SqlCommand(cmdText, myConnection))
                {
                    // Добавление параметров запроса.
                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@Price", Convert.ToInt32(price.Text));
                    command.Parameters.AddWithValue("@Description", description.Text);
                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));

                    try
                    {
                        // Запуск выполнения запроса.
                        command.ExecuteNonQuery();

                        MessageBox.Show("Информация об услуге успешно обновлена в базе данных.",
                                        "Успешно!",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.None,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);

                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ошибка: " + ex.Message);
                    }
                }
            }
        }
    }
}
