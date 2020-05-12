using System;
using System.Windows.Forms;
using Selector_Colores.Formularios;

namespace Selector_Colores {

    internal static class Program {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [ STAThread ]
        private static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal());
        }

    }

}