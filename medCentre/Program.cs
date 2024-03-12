using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medCentre
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainForm());
        }
        public static class ConnectionManager
        {
            public static string ConnString { get; } = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexp\source\repos\MedCentre\medCentre\basesql.mdf;Integrated Security=True;Persist Security Info=False;Connect Timeout=30";
        }
    }
}
