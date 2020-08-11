/*
 * Criado por ForceFK
 * https://github.com/ForceFK
 * Force&Kuraio Dev
 * Última modificação: 11/08/2020
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLauncher.Utils
{
    public static class Logger
    {
        public static void Log(string texto)
        {
            string str = string.Concat(Application.StartupPath, "\\PBLauncher.log");
            DateTime now = DateTime.Now;
            StreamWriter streamWriter = new StreamWriter(str, true);
            texto = texto == "" ? "" : "[" + now.ToString("yyyy/MM/dd HH:mm:ss") + "] " + texto;
            streamWriter.WriteLine(texto);
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
