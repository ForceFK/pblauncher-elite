/*
 * Criado por ForceFK
 * https://github.com/ForceFK
 * Force&Kuraio Dev
 * Última modificação: 11/08/2020
 */
using Core;
using PBLauncher.Utils;
using PBLauncher.Utils.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLauncher
{
    public static class Connect
    {
        /// <summary>
        /// URL of the configuration file hosted on the site
        /// URL do arquivo configuração hospedado no site
        /// </summary>
        private static readonly string HostURL = "https://forum.projectelite.net/launcher/settings.conf";
        public static string GameName = "Project Elite - Public";



        #region Modelo e processamento
        public static HostStatus _state = HostStatus.UNK;
        public static string _launcherVer, _message, _webURL, _upURL, _userList, _fileURL;
        public static int _version;
        public static bool  _keyHost, _useXCLoader;
        public static long _launcherKey;

        /// <summary>
        /// Leitura e processamento dos dados
        /// </summary>
        /// <returns></returns>
        public static async Task<HostStatus> GetHostInfo()
        {
            await Task.Delay(5);
            try
            {
                using (WebClient wc = new WebClient() { Encoding = Encoding.UTF8 })
                {
                    string[] all = wc.DownloadString(HostURL).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    Dictionary<string, object> config = new Dictionary<string, object>();
                    foreach (string line in all)
                    {
                        if (line.Contains("="))
                        {
                            string id = line.Split('=')[0];
                            switch (id)
                            {
                                case "launcherversion":
                                    _launcherVer = Get.Conf(line, id);
                                    break;
                                case "status":
                                    _state = (HostStatus)int.Parse(Get.Conf(line, id));
                                    break;
                                case "message":
                                    _message = Get.Conf(line, id);
                                    break;
                                case "webpage":
                                    _webURL = Get.Conf(line, id);
                                    break;
                                case "files":
                                    _fileURL = Get.Conf(line, id);
                                    break;
                                case "userlist":
                                    _userList = Get.Conf(line, id);
                                    break;
                                case "updateurl":
                                    _upURL = Get.Conf(line, id);
                                    break;
                                case "clienteversion":
                                    _version = int.Parse(Get.Conf(line, id));
                                    break;
                                case "keyhost":
                                    _keyHost = bool.Parse(Get.Conf(line, id));
                                    break;
                                case "key":
                                    _launcherKey = long.Parse(Get.Conf(line, id));
                                    break;
                                case "use_xingload":
                                    _useXCLoader = bool.Parse(Get.Conf(line, id));
                                    break;
                            }
                        }
                    }
                    //MessageBox.Show(_launcherVer+"\n"
                    //    +_state.ToString() + "\n"
                    //    + _message + "\n"
                    //    + _webURL + "\n"
                    //    + _fileURL + "\n"
                    //    + _userList + "\n"
                    //    + _upURL + "\n"
                    //    + _version + "\n"
                    //    + _keyHost.ToString() + "\n"
                    //    + _launcherKey + "\n"
                    //    + _useXCLoader);
                }
            }
            catch
            {
                _state = HostStatus.UNK;
            }
            return _state;
        }

        public static async Task<long> GetVersionUP()
        {
            await Task.Delay(5);
            try
            {
                using (WebClient wc = new WebClient() { Encoding = Encoding.UTF8 })
                {
                    string[] all = wc.DownloadString(HostURL).Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    Dictionary<string, object> config = new Dictionary<string, object>();
                    foreach (string line in all)
                    {
                        if (line.Contains("="))
                        {
                            string id = line.Split('=')[0];
                            switch (id)
                            {
                                case "clienteversion":
                                    _version = int.Parse(Get.Conf(line, id));
                                    return _version;
                                
                            }
                        }
                    }
                }
            }
            catch
            {
                _version = -1;
            }
            return _version;
        }
        #endregion

    }
}
