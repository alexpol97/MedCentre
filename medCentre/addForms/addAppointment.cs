using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using static medCentre.Program;

namespace medCentre
{
    public partial class addAppointment : Form
    {
        SqlConnection myConnection;
        string сonnString = ConnectionManager.ConnString;

        public addAppointment()
        {
            InitializeComponent();

            // Функция загрузки данных в выпадающие списки на форме.
            loadComboBoxes();
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

        // Функция загрузки данных в выпадающие списки на форме.
        private void loadComboBoxes()
        {
            // При открытии формы загрузить данные в comboBox на ней.
            try
            {
                // Открыть соединение.
                myConnection = new SqlConnection(сonnString);
                myConnection.Open();

                /*============ Подгрузить данные пациентов ============*/
                string cmdText = "SELECT [ID], [ФИО] FROM [Пациент]";

                SqlDataAdapter dbAdapter1 = new SqlDataAdapter(cmdText, myConnection);
                DataSet ds1 = new DataSet();

                dbAdapter1.Fill(ds1);

                foreach (DataRow DR in ds1.Tables[0].Rows)
                {
                    pacientCB.Items.Add(DR[0].ToString() + "," + DR[1].ToString());
                }

                ds1.Clear();
                /*=====================================================*/

                /*============= Подгрузить данные врачей ==============*/
                cmdText = "SELECT [ID], [ФИО] FROM [Сотрудники]";

                dbAdapter1.SelectCommand = new SqlCommand(cmdText, myConnection);
                dbAdapter1.Fill(ds1);

                foreach (DataRow DR in ds1.Tables[0].Rows)
                {
                    doctorCB.Items.Add(DR[0].ToString() + "," + DR[1].ToString());
                }

                ds1.Clear();
                /*=====================================================*/

                /*============ Подгрузить данные об услугах ===========*/
                cmdText = "SELECT [ID], [Название] FROM [Услуги]";

                dbAdapter1.SelectCommand = new SqlCommand(cmdText, myConnection);
                dbAdapter1.Fill(ds1);

                foreach (DataRow DR in ds1.Tables[0].Rows)
                {
                    servicesCB.Items.Add(DR[0].ToString() + "," + DR[1].ToString());
                }

                ds1.Clear();
                /*=====================================================*/

                // Закрыть соединение.
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения к базе данных.\r\n\r\n" + ex.ToString());
                return;
            }
        }

        // Функция проверкки доступного времени.
        private void loadDateTime()
        {
            // Ищем записи на выбранный день.
            string cmdText = "SELECT [Время] FROM [Запись] WHERE ([Дата]='" + dateTimePicker.Value.Date.ToString("yyyyMMdd") + "' AND [Сотрудник]=" + doctorCB.SelectedItem.ToString().Split(',')[0] + ")";

            try
            {
                SqlDataAdapter dbAdapter1 = new SqlDataAdapter(cmdText, myConnection);
                DataSet ds1 = new DataSet();

                dbAdapter1.Fill(ds1);

                // Если записи на этот день найдены, соответствующие пункты в списке удаляются.
                // Так, например, если найдена запись на 8:00, из timeCB будет удалён пункт с текстом "8:00".
                for (int i = 0; i < timeCB.Items.Count; i++)
                {
                    foreach (DataRow DR in ds1.Tables[0].Rows)
                    {
                        if (DR[0].ToString() == timeCB.Items[i].ToString())
                        {
                            timeCB.Items.Remove(DR[0].ToString());
                        }
                    }
                }

                ds1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка выполнения запроса.\r\n\r\n" + ex.ToString());
            }
        }

        // Происходит при изменении значения даты в "календарике".
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Функция проверки доступного времени.
            loadDateTime();
            timeCB.Enabled = true;
        }

        // Функция добавления данных по нажатию кнопки [OK].
        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            // Строка запроса.
            string cmdText = "INSERT INTO [Запись] ( " +
                "[Пациент], " +
                "[Сотрудник], " +
                "[Дата], " +
                "[Время], " +
                "[Услуга] ) VALUES ( " +
                "'" + pacientCB.SelectedItem.ToString().Split(',')[0].ToString() + "', " +
                "'" + doctorCB.SelectedItem.ToString().Split(',')[0].ToString() + "', " +
                "'" + dateTimePicker.Value.Date.ToString("yyyyMMdd") + "', " +
                "'" + timeCB.SelectedItem.ToString() + "', " +
                "'" + servicesCB.SelectedItem.ToString().Split(',')[0].ToString() + "' " +
                ");";

            myConnection = new SqlConnection(сonnString);
            myConnection.Open();

            SqlCommand command = new SqlCommand(cmdText, myConnection);

            try
            {
                // Запуск выполнения запроса.
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка!\r\n\r\n" + ex.ToString());
                return;
            }

            myConnection.Close();

            // Вывод сообщения об успешном выполнении.
            DialogResult result = MessageBox.Show(
                "Запись успешно добавлена в базу данных.",
                "Успешно!",
                MessageBoxButtons.OK,
                MessageBoxIcon.None,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);

            // Закрыть форму после закрытия сообщения.
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
