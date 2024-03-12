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
using static medCentre.Program;

namespace medCentre
{
    public partial class findForm : Form
    {
        // Для подключения к базе:
        SqlConnection myConnection;   // Подключение.

        // Строка подключения к базе.
        string сonnString = ConnectionManager.ConnString;

        // Заготовка для SQL-запроса.
        string commandText = "SELECT * FROM ";

        public findForm()
        {
            InitializeComponent();
        }

        // Передвижение окна.
        private void mainMenuStrip_MouseDown(object sender, MouseEventArgs e)
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

        private void tableCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tableCB.SelectedIndex != -1)
            {
                okButton.Enabled = true;
                checkBox1.Enabled = true;
                checkBox1.Checked = true;
                checkBox1_CheckedChanged(this, null);

                fieldCB.Items.Clear();

                try
                {
                    // Открыть соединение.
                    myConnection = new SqlConnection(сonnString);
                    myConnection.Open();

                    SqlDataAdapter dbAdapter1 = new SqlDataAdapter("SELECT * FROM " + tableCB.SelectedItem.ToString(), myConnection);
                    DataTable dataTable = new DataTable();

                    dbAdapter1.Fill(dataTable);
                    myConnection.Close();

                    foreach (var item in dataTable.Columns)
                    {
                        fieldCB.Items.Add(item.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения к базе данных.\r\n\r\n" + ex.ToString());

                    return;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fieldCB.Enabled = checkBox1.Checked;
            compareTB.Enabled = checkBox1.Checked;
            filterCB.Enabled = checkBox1.Checked;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Здесь в соответствии с выбранными элементами в выпадающем списке
            // формируется SQL-запрос на выборку данных, удовлетворяющих этим условиям.
            commandText += "[" + tableCB.SelectedItem.ToString() + "]";

            // Если фильтр поиска включён, продолжить формирование SQL-запроса.
            if (checkBox1.Checked)
            {
                try
                {
                    commandText += "WHERE [" + fieldCB.SelectedItem.ToString() + "]";
                }
                catch
                {
                    MessageBox.Show("Фильтр поиска пуст!");
                    return;
                }

                if (filterCB.SelectedIndex == 0)        // Фильтр "равен".
                { commandText += " = " + "" + compareTB.Text.ToString() + ";"; }
                else if (filterCB.SelectedIndex == 1)   // "Не равен".
                { commandText += " != " + "" + compareTB.Text.ToString() + ";"; }
                else if (filterCB.SelectedIndex == 2)   // "Больше".
                { commandText += " > " + compareTB.Text.ToString() + ";"; }
                else if (filterCB.SelectedIndex == 3)   // "Меньше".
                { commandText += " < " + compareTB.Text.ToString() + ";"; }
                else if (filterCB.SelectedIndex == 4)   // "Содержит".
                { commandText += "LIKE '%" + compareTB.Text.ToString() + "%';"; }
                else if (filterCB.SelectedIndex == 5)   // "Не содержит".
                { commandText += " NOT LIKE '%" + compareTB.Text.ToString() + "%';"; }
            }

            try
            {
                allDataForm cF = new allDataForm(tableCB.SelectedItem.ToString(), commandText);
                cF.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка формирования поискового запроса!");
            }

            // Обнуление строки.
            commandText = "SELECT * FROM ";
        }
    }
}
