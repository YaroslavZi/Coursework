using Ambulance.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance
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
            var avtoriz = new Authorization();

            if (avtoriz.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }


        }
    }
}
