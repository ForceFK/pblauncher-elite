using PBLauncher.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLauncher
{
    static class Program
    {
        public static readonly string Credits = "https://github.com/ForceFK";
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists(string.Concat(Application.StartupPath, "\\launcher_core.dll")))
            {
                Logger.Log("[ERROR] Launcher_core.dll not found.");
                MessageBox.Show("launcher_core.dll not found.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
                Application.Run(new PleaseWait());
        }
    }
}
