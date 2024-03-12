using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using static medCentre.Program;

namespace medCentre
{
    public partial class addEmployee : Form
    {
        string сonnString = ConnectionManager.ConnString;

        public addEmployee()
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

        // Записать данные о новом сотруднике в базу данных.
        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(name.Text) ||
                string.IsNullOrEmpty(spec.Text) ||
                string.IsNullOrEmpty(cab.Text))
            {
                MessageBox.Show("Ошибка: поля не могут быть пустыми!");
                return;
            }

            string cmdText = "INSERT INTO [Сотрудники] ([ФИО], [Специализация], [Кабинет]) " +
                             "VALUES (@Name, @Specialization, @Cabinet)";

            using (SqlConnection myConnection = new SqlConnection(сonnString))
            {
                myConnection.Open();

                using (SqlCommand command = new SqlCommand(cmdText, myConnection))
                {
                    // Добавление параметров запроса.
                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@Specialization", spec.Text);
                    command.Parameters.AddWithValue("@Cabinet", cab.Text);

                    try
                    {
                        // Запуск выполнения запроса.
                        command.ExecuteNonQuery();

                        MessageBox.Show("Сотрудник " + name.Text + " успешно добавлен в базу данных.",
                                        "Успешно!",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.None,
                                        MessageBoxDefaultButton.Button1,
                                        MessageBoxOptions.DefaultDesktopOnly);

                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Ошибка: поля не могут быть пустыми!\r\n\r\n" + ex.ToString());
                    }
                }
            }
        }
    }
}