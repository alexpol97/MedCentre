using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static medCentre.Program;

namespace medCentre
{
    public partial class addService : Form
    {
        string сonnString = ConnectionManager.ConnString;
        public addService()
        {
            InitializeComponent();
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

        // Записать данные о новой услуге в базу данных.
        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) ||
                string.IsNullOrEmpty(price.Text) ||
                string.IsNullOrEmpty(description.Text))
            {
                MessageBox.Show("Ошибка: поля не могут быть пустыми!");
                return;
            }

            string cmdText = "INSERT INTO [Услуги] ( " +
                "[Название], " +
                "[Стоимость], " +
                "[Описание] ) VALUES (" +
                "@Название, " +
                "@Стоимость, " +
                "@Описание " +
                ");";

            using (SqlConnection connection = new SqlConnection(сonnString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(cmdText, connection);
                    command.Parameters.AddWithValue("@Название", name.Text);
                    command.Parameters.AddWithValue("@Стоимость", Convert.ToInt32(price.Text));
                    command.Parameters.AddWithValue("@Описание", description.Text);

                    // Запуск выполнения запроса.
                    command.ExecuteNonQuery();

                    MessageBox.Show(
                        "Услуга " + name.Text + " успешно добавлена в базу данных.",
                        "Успешно!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.None,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                }
            }

            this.Close();
        }
    }
}