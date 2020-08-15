/*
 * Criado por ForceFK
 * https://github.com/ForceFK
 * Force&Kuraio Dev
 * Última modificação: 14/08/2020
 */
using Core;
using PBLauncher.Utils;
using PBLauncher.Utils.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLauncher
{
    public partial class MainForm : Form
    {
        private bool Updat;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Logger.Log("[<<] Verificação do sistema concluída.");
            LTitulo.Text = Config.LOADING;
            LTotalFixo.Text = Config.TOTAL;
            LAquivoFixo.Text = Config.FILE;
            WEB_Announce.Navigate(Connect._webURL);
            WEB_Announce.Refresh(); 
            //Buttons_Enable(false, false, false);
            //Buttons_Visible(true, true, false);
            //CheckUpdate(1);
            CheckAnnounce();
        }

        private async void CheckAnnounce()
        {
            if (Connect._state == HostStatus.ONLINEALERT && !string.IsNullOrEmpty(Connect._message))
            {
                await Task.Delay(40);
                MessageBox.Show(Connect._message, Connect.GameName);
            }
        }

        private void ConfigPBox_Click(object sender, EventArgs e)
        {
            if (!Updat)
            {
                try
                {
                    Process.Start("PBConfig.exe");
                }
                catch
                {
                    MessageBox.Show(Config.CONFIG_ERROR, Connect.GameName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
