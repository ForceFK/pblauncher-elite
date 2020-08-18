namespace PBLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_top = new System.Windows.Forms.Panel();
            this.ConfigPBox = new System.Windows.Forms.PictureBox();
            this.MinPBox = new System.Windows.Forms.PictureBox();
            this.ExitPBox = new System.Windows.Forms.PictureBox();
            this.panel_end = new System.Windows.Forms.Panel();
            this.StartPBox = new System.Windows.Forms.PictureBox();
            this.CheckPBox = new System.Windows.Forms.PictureBox();
            this.UpdatePBox = new System.Windows.Forms.PictureBox();
            this.LDownload = new System.Windows.Forms.Label();
            this.Total_Bar = new System.Windows.Forms.PictureBox();
            this.Arquivo_Bar = new System.Windows.Forms.PictureBox();
            this.LTotalFixo = new System.Windows.Forms.Label();
            this.LAquivoFixo = new System.Windows.Forms.Label();
            this.LTitulo = new System.Windows.Forms.Label();
            this.Total_BarFixo = new System.Windows.Forms.PictureBox();
            this.Arquivo_BarFixo = new System.Windows.Forms.PictureBox();
            this.LArquivo = new System.Windows.Forms.Label();
            this.WEB_Announce = new System.Windows.Forms.WebBrowser();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPBox)).BeginInit();
            this.panel_end.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatePBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_BarFixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_BarFixo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Transparent;
            this.panel_top.Controls.Add(this.ConfigPBox);
            this.panel_top.Controls.Add(this.MinPBox);
            this.panel_top.Controls.Add(this.ExitPBox);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(714, 33);
            this.panel_top.TabIndex = 0;
            this.panel_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // ConfigPBox
            // 
            this.ConfigPBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConfigPBox.Image = global::PBLauncher.Properties.Resources.config;
            this.ConfigPBox.Location = new System.Drawing.Point(619, 4);
            this.ConfigPBox.Name = "ConfigPBox";
            this.ConfigPBox.Size = new System.Drawing.Size(25, 25);
            this.ConfigPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConfigPBox.TabIndex = 10;
            this.ConfigPBox.TabStop = false;
            this.ConfigPBox.Click += new System.EventHandler(this.ConfigPBox_Click);
            this.ConfigPBox.MouseLeave += new System.EventHandler(this.ConfigPBox_MouseLeave);
            this.ConfigPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ConfigPBox_MouseMove);
            // 
            // MinPBox
            // 
            this.MinPBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinPBox.Image = global::PBLauncher.Properties.Resources.minim;
            this.MinPBox.Location = new System.Drawing.Point(655, 4);
            this.MinPBox.Name = "MinPBox";
            this.MinPBox.Size = new System.Drawing.Size(25, 25);
            this.MinPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinPBox.TabIndex = 9;
            this.MinPBox.TabStop = false;
            this.MinPBox.Click += new System.EventHandler(this.MinPBox_Click);
            this.MinPBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinPBox_MouseDown);
            this.MinPBox.MouseLeave += new System.EventHandler(this.MinPBox_MouseLeave);
            this.MinPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MinPBox_MouseMove);
            // 
            // ExitPBox
            // 
            this.ExitPBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitPBox.Image = global::PBLauncher.Properties.Resources.exit;
            this.ExitPBox.Location = new System.Drawing.Point(685, 4);
            this.ExitPBox.Name = "ExitPBox";
            this.ExitPBox.Size = new System.Drawing.Size(25, 25);
            this.ExitPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPBox.TabIndex = 8;
            this.ExitPBox.TabStop = false;
            this.ExitPBox.Click += new System.EventHandler(this.ExitPBox_Click);
            this.ExitPBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitPBox_MouseDown);
            this.ExitPBox.MouseLeave += new System.EventHandler(this.ExitPBox_MouseLeave);
            this.ExitPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ExitPBox_MouseMove);
            // 
            // panel_end
            // 
            this.panel_end.BackColor = System.Drawing.Color.Transparent;
            this.panel_end.Controls.Add(this.StartPBox);
            this.panel_end.Controls.Add(this.CheckPBox);
            this.panel_end.Controls.Add(this.UpdatePBox);
            this.panel_end.Controls.Add(this.LDownload);
            this.panel_end.Controls.Add(this.Total_Bar);
            this.panel_end.Controls.Add(this.Arquivo_Bar);
            this.panel_end.Controls.Add(this.LTotalFixo);
            this.panel_end.Controls.Add(this.LAquivoFixo);
            this.panel_end.Controls.Add(this.LTitulo);
            this.panel_end.Controls.Add(this.Total_BarFixo);
            this.panel_end.Controls.Add(this.Arquivo_BarFixo);
            this.panel_end.Controls.Add(this.LArquivo);
            this.panel_end.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_end.Location = new System.Drawing.Point(0, 461);
            this.panel_end.Name = "panel_end";
            this.panel_end.Size = new System.Drawing.Size(714, 104);
            this.panel_end.TabIndex = 1;
            this.panel_end.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.panel_end.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // StartPBox
            // 
            this.StartPBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartPBox.BackColor = System.Drawing.Color.Transparent;
            this.StartPBox.Image = global::PBLauncher.Properties.Resources.start;
            this.StartPBox.Location = new System.Drawing.Point(570, 33);
            this.StartPBox.Name = "StartPBox";
            this.StartPBox.Size = new System.Drawing.Size(136, 64);
            this.StartPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartPBox.TabIndex = 23;
            this.StartPBox.TabStop = false;
            this.StartPBox.Click += new System.EventHandler(this.StartPBox_Click);
            this.StartPBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartPBox_MouseDown);
            this.StartPBox.MouseLeave += new System.EventHandler(this.StartPBox_MouseLeave);
            this.StartPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartPBox_MouseMove);
            // 
            // CheckPBox
            // 
            this.CheckPBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckPBox.BackColor = System.Drawing.Color.Transparent;
            this.CheckPBox.Image = global::PBLauncher.Properties.Resources.check;
            this.CheckPBox.Location = new System.Drawing.Point(480, 33);
            this.CheckPBox.Name = "CheckPBox";
            this.CheckPBox.Size = new System.Drawing.Size(89, 64);
            this.CheckPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckPBox.TabIndex = 22;
            this.CheckPBox.TabStop = false;
            this.CheckPBox.Click += new System.EventHandler(this.CheckPBox_Click);
            this.CheckPBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CheckPBox_MouseDown);
            this.CheckPBox.MouseLeave += new System.EventHandler(this.CheckPBox_MouseLeave);
            this.CheckPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CheckPBox_MouseMove);
            // 
            // UpdatePBox
            // 
            this.UpdatePBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdatePBox.BackColor = System.Drawing.Color.Transparent;
            this.UpdatePBox.Image = global::PBLauncher.Properties.Resources.update;
            this.UpdatePBox.Location = new System.Drawing.Point(570, 33);
            this.UpdatePBox.Name = "UpdatePBox";
            this.UpdatePBox.Size = new System.Drawing.Size(136, 64);
            this.UpdatePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpdatePBox.TabIndex = 21;
            this.UpdatePBox.TabStop = false;
            this.UpdatePBox.Click += new System.EventHandler(this.UpdatePBox_Click);
            this.UpdatePBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdatePBox_MouseDown);
            this.UpdatePBox.MouseLeave += new System.EventHandler(this.UpdatePBox_MouseLeave);
            this.UpdatePBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdatePBox_MouseMove);
            // 
            // LDownload
            // 
            this.LDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LDownload.BackColor = System.Drawing.Color.Transparent;
            this.LDownload.ForeColor = System.Drawing.Color.White;
            this.LDownload.Location = new System.Drawing.Point(375, 31);
            this.LDownload.Name = "LDownload";
            this.LDownload.Size = new System.Drawing.Size(102, 15);
            this.LDownload.TabIndex = 28;
            this.LDownload.Text = "0/0 MB";
            this.LDownload.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LDownload.Visible = false;
            this.LDownload.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LDownload.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // Total_Bar
            // 
            this.Total_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Total_Bar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Total_Bar.Location = new System.Drawing.Point(12, 83);
            this.Total_Bar.Name = "Total_Bar";
            this.Total_Bar.Size = new System.Drawing.Size(463, 10);
            this.Total_Bar.TabIndex = 25;
            this.Total_Bar.TabStop = false;
            this.Total_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.Total_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // Arquivo_Bar
            // 
            this.Arquivo_Bar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Arquivo_Bar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Arquivo_Bar.Location = new System.Drawing.Point(12, 48);
            this.Arquivo_Bar.Name = "Arquivo_Bar";
            this.Arquivo_Bar.Size = new System.Drawing.Size(463, 10);
            this.Arquivo_Bar.TabIndex = 24;
            this.Arquivo_Bar.TabStop = false;
            this.Arquivo_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.Arquivo_Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // LTotalFixo
            // 
            this.LTotalFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LTotalFixo.AutoSize = true;
            this.LTotalFixo.BackColor = System.Drawing.Color.Transparent;
            this.LTotalFixo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalFixo.ForeColor = System.Drawing.Color.White;
            this.LTotalFixo.Location = new System.Drawing.Point(9, 67);
            this.LTotalFixo.Name = "LTotalFixo";
            this.LTotalFixo.Size = new System.Drawing.Size(33, 15);
            this.LTotalFixo.TabIndex = 19;
            this.LTotalFixo.Text = "Total";
            this.LTotalFixo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LTotalFixo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // LAquivoFixo
            // 
            this.LAquivoFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LAquivoFixo.AutoSize = true;
            this.LAquivoFixo.BackColor = System.Drawing.Color.Transparent;
            this.LAquivoFixo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAquivoFixo.ForeColor = System.Drawing.Color.White;
            this.LAquivoFixo.Location = new System.Drawing.Point(11, 31);
            this.LAquivoFixo.Name = "LAquivoFixo";
            this.LAquivoFixo.Size = new System.Drawing.Size(50, 15);
            this.LAquivoFixo.TabIndex = 18;
            this.LAquivoFixo.Text = "Arquivo";
            this.LAquivoFixo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LAquivoFixo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // LTitulo
            // 
            this.LTitulo.AutoSize = true;
            this.LTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LTitulo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitulo.ForeColor = System.Drawing.Color.White;
            this.LTitulo.Location = new System.Drawing.Point(9, 7);
            this.LTitulo.Name = "LTitulo";
            this.LTitulo.Size = new System.Drawing.Size(44, 18);
            this.LTitulo.TabIndex = 17;
            this.LTitulo.Text = "Titulo";
            this.LTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // Total_BarFixo
            // 
            this.Total_BarFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Total_BarFixo.BackColor = System.Drawing.Color.White;
            this.Total_BarFixo.Location = new System.Drawing.Point(12, 83);
            this.Total_BarFixo.Name = "Total_BarFixo";
            this.Total_BarFixo.Size = new System.Drawing.Size(463, 10);
            this.Total_BarFixo.TabIndex = 26;
            this.Total_BarFixo.TabStop = false;
            // 
            // Arquivo_BarFixo
            // 
            this.Arquivo_BarFixo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Arquivo_BarFixo.BackColor = System.Drawing.Color.White;
            this.Arquivo_BarFixo.Location = new System.Drawing.Point(12, 48);
            this.Arquivo_BarFixo.Name = "Arquivo_BarFixo";
            this.Arquivo_BarFixo.Size = new System.Drawing.Size(463, 10);
            this.Arquivo_BarFixo.TabIndex = 27;
            this.Arquivo_BarFixo.TabStop = false;
            // 
            // LArquivo
            // 
            this.LArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LArquivo.BackColor = System.Drawing.Color.Transparent;
            this.LArquivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LArquivo.ForeColor = System.Drawing.Color.White;
            this.LArquivo.Location = new System.Drawing.Point(58, 25);
            this.LArquivo.Name = "LArquivo";
            this.LArquivo.Size = new System.Drawing.Size(353, 21);
            this.LArquivo.TabIndex = 20;
            this.LArquivo.Text = "Arquivo...";
            this.LArquivo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.LArquivo.Visible = false;
            this.LArquivo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseDown);
            this.LArquivo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Launcher_MouseMove);
            // 
            // WEB_Announce
            // 
            this.WEB_Announce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WEB_Announce.IsWebBrowserContextMenuEnabled = false;
            this.WEB_Announce.Location = new System.Drawing.Point(0, 33);
            this.WEB_Announce.MinimumSize = new System.Drawing.Size(20, 20);
            this.WEB_Announce.Name = "WEB_Announce";
            this.WEB_Announce.ScrollBarsEnabled = false;
            this.WEB_Announce.Size = new System.Drawing.Size(714, 428);
            this.WEB_Announce.TabIndex = 2;
            this.WEB_Announce.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(714, 565);
            this.Controls.Add(this.WEB_Announce);
            this.Controls.Add(this.panel_end);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PBLauncher - PE Public";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConfigPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPBox)).EndInit();
            this.panel_end.ResumeLayout(false);
            this.panel_end.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StartPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatePBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_BarFixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_BarFixo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_end;
        private System.Windows.Forms.PictureBox ConfigPBox;
        private System.Windows.Forms.PictureBox MinPBox;
        private System.Windows.Forms.PictureBox ExitPBox;
        private System.Windows.Forms.Label LDownload;
        private System.Windows.Forms.PictureBox Total_Bar;
        private System.Windows.Forms.PictureBox Arquivo_Bar;
        public System.Windows.Forms.PictureBox StartPBox;
        private System.Windows.Forms.PictureBox CheckPBox;
        private System.Windows.Forms.PictureBox UpdatePBox;
        private System.Windows.Forms.Label LTotalFixo;
        private System.Windows.Forms.Label LAquivoFixo;
        private System.Windows.Forms.Label LTitulo;
        private System.Windows.Forms.PictureBox Total_BarFixo;
        private System.Windows.Forms.PictureBox Arquivo_BarFixo;
        private System.Windows.Forms.Label LArquivo;
        private System.Windows.Forms.WebBrowser WEB_Announce;
    }
}