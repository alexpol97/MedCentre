using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static medCentre.Program;

namespace medCentre
{
    public partial class mainForm : Form
    {
        string сonnString = ConnectionManager.ConnString;
        public mainForm()
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

        // Выход из приложения.
        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        // Свернуть приложение.
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Открыть форму для записи пациента.
        private void addAppointmentButton_Click(object sender, EventArgs e)
        {
            addAppointment aA = new addAppointment();
            aA.Show();
        }

        // Открыть форму для отмены записи.
        private void cancelAppointmentButton_Click(object sender, EventArgs e)
        {
            allDataForm aDF = new allDataForm("[Запись]");
            aDF.Show();
        }

        // Происходит при нажатии кнопки [Сотрудники] в разделе [Просмотр данных].
        private void viewEmployeesButton_Click(object sender, EventArgs e)
        {
            allDataForm aDF = new allDataForm("[Сотрудники]");
            aDF.Show();
        }

        // Происходит при нажатии кнопки [Пациенты] в разделе [Просмотр данных].
        private void viewPacientsButton_Click(object sender, EventArgs e)
        {
            allDataForm aDF = new allDataForm("[Пациент]");
            aDF.Show();
        }

        // Происходит при нажатии кнопки [Расписание] в разделе [Просмотр данных].
        private void viewScheduleButton_Click(object sender, EventArgs e)
        {
            allDataForm aDF = new allDataForm("[Запись]");
            aDF.Show();
        }

        // Происходит при нажатии кнопки [Удалить] в разделе [Работа с данными].
        private void deleteButton_Click(object sender, EventArgs e)
        {
            allDataForm aDF = new allDataForm();
            aDF.Show();
        }

        // Происходит при нажатии кнопки [Вывод в файл] в разделе [Экспорт / Импорт].
        // Вызывает появление контекстного меню [exportContext].
        private void exportButton_Click(object sender, EventArgs e)
        {
            exportContext.Show(ieGB, exportButton.Location.X, exportButton.Location.Y + 30);
        }

        // Происходит при нажатии кнопки [Записать из файла] в разделе [Экспорт / Импорт].
        // Вызывает появление контекстного меню [importContext].
        private void importButton_Click(object sender, EventArgs e)
        {
            importContext.Show(ieGB, importButton.Location.X, importButton.Location.Y + 30);
        }

        // Происходит при любом нажатии в контекстном меню [exportContext].
        private void exportTSMI_Click(object sender, EventArgs e)
        {
                exportData((ToolStripMenuItem)sender);
        }

        // Происходит при любом нажатии в контекстном меню [importContext].
        private void importTSMI_Click(object sender, EventArgs e)
        {
                importData((ToolStripMenuItem)sender);
        }

        // Функция экспорта данных из таблицы.
        private void exportData(object sender)
        {
            string table;
            ToolStripMenuItem TSMI = (ToolStripMenuItem)sender;
            table = TSMI.Text;

            // Строка запроса. Дополняется названием таблицы в 269 строке.
            string cmdTxt = "SELECT * FROM ";

            // Для сохранения файла.
            SaveFileDialog exportDataSFD = new SaveFileDialog();
            exportDataSFD.Filter = "Текстовые файлы (*.txt)|*.txt";
            exportDataSFD.FileName = table + ".txt";
            exportDataSFD.Title = "Экспорт данных";

            DialogResult result = exportDataSFD.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    // Заполнение набора данных в соответствии с запросом.
                    using (SqlConnection connection = new SqlConnection(сonnString))
                    {
                        connection.Open();
                        SqlDataAdapter dA = new SqlDataAdapter(cmdTxt + table, connection);
                        DataSet ds = new DataSet();

                        dA.Fill(ds);

                        int rowC = ds.Tables[0].Rows.Count;         // Количество строк.
                        int columnsC = ds.Tables[0].Columns.Count;  // Количество столбцов.

                        StringBuilder sb = new StringBuilder();

                        for (int j = 0; j < rowC; j++)
                        {
                            for (int i = 0; i < columnsC; i++)
                            {
                                // Формируем строку.
                                sb.Append(ds.Tables[0].Rows[j][i]);
                                sb.Append(";");
                            }

                            // Перенос строки, текущая строка закончилась.
                            sb.AppendLine();
                        }

                        // Запись данных в файл.
                        string filePath = exportDataSFD.FileName;
                        File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);

                        MessageBox.Show("Данные успешно экспортированы.\nФайл сохранен по пути: " + filePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка выполнения запроса.\r\n\r\n" + ex.ToString());
                }
            }
        }


        // Функция импорта данных в таблицу.
        private void importData(object sender)
        {
            string table;
            ToolStripMenuItem TSMI = (ToolStripMenuItem)sender;
            table = TSMI.Text;

            // Для открытия файла.
            OpenFileDialog importDataOFD = new OpenFileDialog();
            importDataOFD.Filter = "Текстовые файлы (*.txt)|*.txt";
            importDataOFD.Title = "Импорт данных";

            if (importDataOFD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Открыть соединение.
                    using (SqlConnection myConnection = new SqlConnection(сonnString))
                    {
                        myConnection.Open();

                        // Формирование строки запроса INSERT.
                        string cmdText = "INSERT INTO " + table + " (";

                        // Получение списка полей таблицы.
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT TOP 1 * FROM " + table, myConnection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        int columnsC = dataTable.Columns.Count;

                        for (int i = 0; i < columnsC; i++)
                        {
                            cmdText += "[" + dataTable.Columns[i].ColumnName + "]";
                            if (i != columnsC - 1)
                            {
                                cmdText += ", ";
                            }
                        }

                        cmdText += ") VALUES (";

                        // Чтение данных из файла.
                        string[] allLines = File.ReadAllLines(importDataOFD.FileName);

                        foreach (string line in allLines)
                        {
                            string[] values = line.Split(';');

                            for (int i = 0; i < columnsC; i++)
                            {
                                cmdText += "@" + i;

                                if (i != columnsC - 1)
                                {
                                    cmdText += ", ";
                                }
                            }

                            cmdText += ");";

                            using (SqlCommand cmd = new SqlCommand(cmdText, myConnection))
                            {
                                for (int i = 0; i < columnsC; i++)
                                {
                                    cmd.Parameters.AddWithValue("@" + i, values[i]);
                                }

                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Данные успешно импортированы.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка выполнения запроса.\r\n\r\n" + ex.ToString());
                }
            }
        }

// Происходит при нажатии кнопки [Поиск] в  разделе [Другие]. Вызывает форму [findForm].
        private void searchButton_Click(object sender, EventArgs e)
        {
            findForm fF = new findForm();
            fF.ShowDialog();
        }

        // Происходит при нажатии на кнопку [Добавить] в разделе [Работа с данными].
        // Вызывает появление контекстного меню [addContext].
        private void addButton_Click(object sender, EventArgs e)
        {
            addContext.Show(dbWorkGB, addButton.Location.X, addButton.Location.Y + 30);
        }

        // Происходит при нажатии на кнопку [Изменить] в разделе [Работа с данными].
        // Вызывает появление контекстного меню [editContext].
        private void editButton_Click(object sender, EventArgs e)
        {
            editContext.Show(dbWorkGB, editButton.Location.X, editButton.Location.Y + 30);
        }

        // Происходит при нажатии на пункт меню [Данные сотрудника] в контекстном меню [Изменить].
        private void editPersonalTSMI_Click(object sender, EventArgs e)
        {
            editEmployee eE = new editEmployee();
            eE.ShowDialog();
        }

        // Происходит при нажатии на пункт меню [Данные пациента] в контекстном меню [Изменить].
        private void editPacientTSMI_Click(object sender, EventArgs e)
        {
            editPacient eP = new editPacient();
            eP.ShowDialog();
        }

        // Происходит при нажатии на пункт меню [Данные об услуге] в контекстном меню [Изменить].
        private void editServiceTSMI_Click(object sender, EventArgs e)
        {
            editService eS = new editService();
            eS.ShowDialog();
        }

        // Происходит при нажатии на пункт меню [Добавить сотрудника] в контекстном меню [Добавить].
        private void addPersonalTSMI_Click(object sender, EventArgs e)
        {
            addEmployee aE = new addEmployee();
            aE.ShowDialog();
        }

        // Происходит при нажатии на пункт меню [Добавить пациента] в контекстном меню [Добавить].
        private void addPacientTSMI_Click(object sender, EventArgs e)
        {
            addPacient aP = new addPacient();
            aP.ShowDialog();
        }

        // Происходит при нажатии на пункт меню [Добавить услугу] в контекстном меню [Добавить].
        private void addServiceTSMI_Click(object sender, EventArgs e)
        {
            addService aS = new addService();
            aS.ShowDialog();
        }
    }
}