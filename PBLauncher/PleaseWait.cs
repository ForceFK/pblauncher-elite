/*
 * Criado por ForceFK
 * https://github.com/ForceFK
 * Force&Kuraiyo Dev
 * Última modificação: 18/08/2020
 */
using Core;
using Ionic.Zip;
using PBLauncher.Properties;
using PBLauncher.Utils;
using PBLauncher.Utils.Enum;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLauncher
{
    public partial class PleaseWait : Form
    {
        public PleaseWait()
        {
            InitializeComponent();

            //Uncomment the desired language
            //Remova o comentário da linguagem desejada

            //Language BRAZIL = Config.LanguageBRAZILIAN()
            //Language ENGLISH = Config.LanguageEN();

            Config.LanguagePTBR();
            //Config.LanguageEN();
        }

        private async void PleaseWait_Load(object sender, EventArgs e)
        {
            //GetBackgroundImage(); //Remover comentario caso queira ativar a troca do background no carregamento
            lb_loading.Text = Config.LOADING;
            Logger.Log("");
            Logger.Log("[<>] PBLauncher [" + Connect.GameName + "] iniciado.");
            Logger.Log("[!] Launcher Versão:" + Application.ProductVersion);
            if (!CheckLF())
                Close();
            else
            {
                await Task.Delay(50);
                lb_loading.Text = Config.CONNECTING_TO_SERVER;
                Status(await Connect.GetHostInfo());
            }

        }

        /// <summary>
        /// Verifica se já existe um processo do launcher ou do jogo aberto
        /// </summary>
        /// <returns></returns>
        private bool CheckLF()
        {
            lb_loading.Text = Config.CHECK_IMPORTANT_FILES;
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                Logger.Log("[!] Já existe uma janela do Launcher aberta.");
                MessageBox.Show(Config.LAUNCHER_RUNNING, Connect.GameName);
                return false;
            }
            else if (Process.GetProcessesByName("PointBlank").Length > 0)
            {
                Logger.Log("[!] Já existe uma janela do jogo aberta.");
                MessageBox.Show(Config.GAME_RUNNING, Connect.GameName);
                return false;
            }
            else if (!File.Exists(string.Concat(Application.StartupPath, "\\UserFileList.dat")))
            {
                StreamWriter streamWriter = new StreamWriter(string.Concat(Application.StartupPath, "\\UserFileList.dat"));
                streamWriter.Close();
            }
            lb_loading.Text = Config.CONNECTING_TO_SERVER;
            Logger.Log("[>>] Conectando-se ao servidor...");
            return true;
        }

        private void Status(HostStatus p)
        {
            lb_loading.Text = Config.CHECK_SERVER_STATUS;
            //await Task.Delay(20);
            Logger.Log("[>>] Verificando status do servidor...");
            switch (p)
            {
                case HostStatus.MAINTENANCE:
                    Logger.Log("[<<] O jogo está em manutenção no momento");
                    MessageBox.Show(Config.SERVER_MAINTENANCE, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    break;
                case HostStatus.MAINTENANCEALERT:
                    if (string.IsNullOrEmpty(Connect._message))
                        goto case HostStatus.MAINTENANCE;
                    Logger.Log("[<<] O jogo está em manutenção no momento");
                    MessageBox.Show(Connect._message, "MAINTENANCE - " + Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                    Close();
                    break;
                case HostStatus.ONLINE:
                case HostStatus.ONLINEALERT:
                    Userlist_check();
                    break;
                case HostStatus.OFFLINE:
                    Logger.Log("[<<] Conexão com o servidor interrompida");
                    MessageBox.Show(Config.CONNECTION_LOST, "MAINTENANCE - " + Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    break;
                default:
                    Logger.Log("[<<] Não foi possível conectar-se ao servidor");
                    MessageBox.Show(Config.SERVER_CONNECTION_UNKNOWN, "MAINTENANCE - " + Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    break;

            }
        }

        public async void Userlist_check()
        {
            try
            {
                string LocalMD5checksum = Get.FileMD5(string.Concat(Application.StartupPath, "\\UserFileList.dat"));
                if (Connect._userList.Equals(LocalMD5checksum))
                {
                    lb_loading.Text = Config.DELET_TRASH;
                    await Clear.Trash();
                    OpenMain();
                }
                else
                {
                    lb_loading.Text = Config.DOWNLOAD_FILE;
                    await Task.Delay(100);
                    using (WebClient WCU = new WebClient())
                    {
                        Logger.Log("[!] Baixando novo UserFileList.");
                        Directory.CreateDirectory(string.Concat(Application.StartupPath, "\\_LauncherPatchFiles"));
                        Uri uri = new Uri(Connect._fileURL + "//UserFileList.zip");
                        object[] startupPath = new object[] { Application.StartupPath, "\\_LauncherPatchFiles\\UserFileList.zip" };
                        WCU.DownloadFile(uri, string.Concat(startupPath));
                        lb_loading.Text = Config.EXTRACT_FILE;
                        Unzip(Application.StartupPath, string.Concat(Application.StartupPath, "\\_LauncherPatchFiles\\UserFileList.zip"));
                        await Task.Delay(100);
                        lb_loading.Text = Config.DELET_TRASH;
                        await Clear.Trash(); 
                        OpenMain();
                    }
                }
            }
            catch
            {
                Logger.Log("[!] Erro ao baixar novo UserFileList.");
                MessageBox.Show(Config.DOWNLOAD_USERLIST_ERROR, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        public void Unzip(string TargetDir, string ZipToUnpack)
        {
            try
            {
                ZipFile zipFile = ZipFile.Read(ZipToUnpack);
                try
                {
                    foreach (ZipEntry zipEntry in zipFile)
                    {
                        zipEntry.Extract(TargetDir, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
                finally
                {
                    if (zipFile != null)
                    {
                        zipFile.Dispose();
                    }
                }
            }
            catch 
            {
               
            }
        }

        private void OpenMain()
        {
            Form f = new MainForm()
            {
                BackgroundImage = Core.Properties.Resources.bg
            };
            Hide();
            f.Closed += (s, args) => Close();
            f.Show();
        }

        /// <summary>
        /// Sorteia uma imagem da lista e define como background do formulário.
        /// </summary>
        private void GetBackgroundImage()
        {
            Random r = new Random();
            if (GetBackground.GetImage())
                BackgroundImage = GetBackground.list[r.Next(0, GetBackground.list.Count + 1)];

        }
    }
}
