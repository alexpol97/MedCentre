﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static medCentre.Program;

namespace medCentre
{
    public partial class editPacient : Form
    {
        // Подключение к базе данных:
        SqlDataAdapter dataAdapter;   // Адаптер выполнения команд.
        DataSet dataSet;                // Набор данных для загрузки.

        // Строка подключения к базе.
        string сonnString = ConnectionManager.ConnString;

        public editPacient()
        {
            InitializeComponent();

            string cmdTxt = "SELECT * FROM [Пациент];";

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
            address.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            birth.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            phone.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(address.Text) || string.IsNullOrWhiteSpace(phone.Text))
            {
                MessageBox.Show("Ошибка: поля не могут быть пустыми!");
                return;
            }

            string cmdText = "UPDATE [Пациент] SET " +
                "[ФИО]=@Name, " +
                "[Адрес]=@Address, " +
                "[Дата рождения]=@Birth, " +
                "[Телефон]=@Phone " +
                "WHERE [ID]=@ID;";

            using (SqlConnection myConnection = new SqlConnection(сonnString))
            {
                myConnection.Open();

                using (SqlCommand command = new SqlCommand(cmdText, myConnection))
                {
                    // Добавление параметров запроса.
                    command.Parameters.AddWithValue("@Name", name.Text);
                    command.Parameters.AddWithValue("@Address", address.Text);
                    command.Parameters.AddWithValue("@Birth", birth.Value);
                    command.Parameters.AddWithValue("@Phone", phone.Text);
                    command.Parameters.AddWithValue("@ID", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));

                    try
                    {
                        // Запуск выполнения запроса.
                        command.ExecuteNonQuery();

                        MessageBox.Show("Информация о пациенте успешно обновлена в базе данных.",
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
