using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static medCentre.Program;

namespace medCentre
{
    public partial class addPacient : Form
    {
        string сonnString = ConnectionManager.ConnString;
        public addPacient()
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

        // Записать данные о новом пациенте в базу данных.
        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) ||
                string.IsNullOrEmpty(address.Text) ||
                string.IsNullOrEmpty(phone.Text))
            {
                MessageBox.Show("Ошибка: поля не могут быть пустыми!");
                return;
            }

            string cmdText = "INSERT INTO [Пациент] ( " +
                "[ФИО], " +
                "[Адрес], " +
                "[Дата рождения], " +
                "[Телефон] ) VALUES (" +
                "@" + "ФИО, " +
                "@" + "Адрес, " +
                "@" + "Дата_рождения, " +
                "@" + "Телефон " +
                ");";

            using (SqlConnection connection = new SqlConnection(сonnString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(cmdText, connection);
                    command.Parameters.AddWithValue("@ФИО", name.Text);
                    command.Parameters.AddWithValue("@Адрес", address.Text);
                    command.Parameters.AddWithValue("@Дата_рождения", birth.Value);
                    command.Parameters.AddWithValue("@Телефон", phone.Text);

                    // Запуск выполнения запроса.
                    command.ExecuteNonQuery();

                    MessageBox.Show(
                        "Пациент " + name.Text + " успешно добавлен в базу данных.",
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
