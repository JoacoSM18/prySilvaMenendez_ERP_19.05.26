using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_ERP_19._05._26
{
    internal static class Program
    {
        // Flag to indicate the user confirmed exiting the application
        public static bool SalirConfirmado = false;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmInicioSesion());
        }
    }
}
