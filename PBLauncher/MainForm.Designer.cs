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
            this.panel_top = new System.Windows.Forms.Panel();
            this.ConfigPBox = new System.Windows.Forms.PictureBox();
            this.MinPBox = new System.Windows.Forms.PictureBox();
            this.ExitPBox = new System.Windows.Forms.PictureBox();
            this.panel_end = new System.Windows.Forms.Panel();
            this.LDownload = new System.Windows.Forms.Label();
            this.Total_Bar = new System.Windows.Forms.PictureBox();
            this.Arquivo_Bar = new System.Windows.Forms.PictureBox();
            this.StartPBox = new System.Windows.Forms.PictureBox();
            this.CheckPBox = new System.Windows.Forms.PictureBox();
            this.UpdatePBox = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.Total_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatePBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_BarFixo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_BarFixo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.ConfigPBox);
            this.panel_top.Controls.Add(this.MinPBox);
            this.panel_top.Controls.Add(this.ExitPBox);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(714, 30);
            this.panel_top.TabIndex = 0;
            // 
            // ConfigPBox
            // 
            this.ConfigPBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ConfigPBox.Image = global::PBLauncher.Properties.Resources.config;
            this.ConfigPBox.Location = new System.Drawing.Point(619, 3);
            this.ConfigPBox.Name = "ConfigPBox";
            this.ConfigPBox.Size = new System.Drawing.Size(25, 25);
            this.ConfigPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ConfigPBox.TabIndex = 10;
            this.ConfigPBox.TabStop = false;
            // 
            // MinPBox
            // 
            this.MinPBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MinPBox.Image = global::PBLauncher.Properties.Resources.minim;
            this.MinPBox.Location = new System.Drawing.Point(655, 3);
            this.MinPBox.Name = "MinPBox";
            this.MinPBox.Size = new System.Drawing.Size(25, 25);
            this.MinPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinPBox.TabIndex = 9;
            this.MinPBox.TabStop = false;
            // 
            // ExitPBox
            // 
            this.ExitPBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExitPBox.Image = global::PBLauncher.Properties.Resources.exit;
            this.ExitPBox.Location = new System.Drawing.Point(685, 3);
            this.ExitPBox.Name = "ExitPBox";
            this.ExitPBox.Size = new System.Drawing.Size(25, 25);
            this.ExitPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExitPBox.TabIndex = 8;
            this.ExitPBox.TabStop = false;
            // 
            // panel_end
            // 
            this.panel_end.Controls.Add(this.LDownload);
            this.panel_end.Controls.Add(this.Total_Bar);
            this.panel_end.Controls.Add(this.Arquivo_Bar);
            this.panel_end.Controls.Add(this.StartPBox);
            this.panel_end.Controls.Add(this.CheckPBox);
            this.panel_end.Controls.Add(this.UpdatePBox);
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
            // 
            // LDownload
            // 
            this.LDownload.BackColor = System.Drawing.Color.Transparent;
            this.LDownload.ForeColor = System.Drawing.Color.White;
            this.LDownload.Location = new System.Drawing.Point(375, 31);
            this.LDownload.Name = "LDownload";
            this.LDownload.Size = new System.Drawing.Size(102, 15);
            this.LDownload.TabIndex = 28;
            this.LDownload.Text = "0/0 MB";
            this.LDownload.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.LDownload.Visible = false;
            // 
            // Total_Bar
            // 
            this.Total_Bar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Total_Bar.Location = new System.Drawing.Point(12, 83);
            this.Total_Bar.Name = "Total_Bar";
            this.Total_Bar.Size = new System.Drawing.Size(463, 10);
            this.Total_Bar.TabIndex = 25;
            this.Total_Bar.TabStop = false;
            // 
            // Arquivo_Bar
            // 
            this.Arquivo_Bar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Arquivo_Bar.Location = new System.Drawing.Point(12, 48);
            this.Arquivo_Bar.Name = "Arquivo_Bar";
            this.Arquivo_Bar.Size = new System.Drawing.Size(463, 10);
            this.Arquivo_Bar.TabIndex = 24;
            this.Arquivo_Bar.TabStop = false;
            // 
            // StartPBox
            // 
            this.StartPBox.BackColor = System.Drawing.Color.Transparent;
            this.StartPBox.Image = global::PBLauncher.Properties.Resources.start;
            this.StartPBox.Location = new System.Drawing.Point(570, 33);
            this.StartPBox.Name = "StartPBox";
            this.StartPBox.Size = new System.Drawing.Size(136, 64);
            this.StartPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartPBox.TabIndex = 23;
            this.StartPBox.TabStop = false;
            // 
            // CheckPBox
            // 
            this.CheckPBox.BackColor = System.Drawing.Color.Transparent;
            this.CheckPBox.Image = global::PBLauncher.Properties.Resources.check;
            this.CheckPBox.Location = new System.Drawing.Point(480, 33);
            this.CheckPBox.Name = "CheckPBox";
            this.CheckPBox.Size = new System.Drawing.Size(89, 64);
            this.CheckPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckPBox.TabIndex = 22;
            this.CheckPBox.TabStop = false;
            // 
            // UpdatePBox
            // 
            this.UpdatePBox.BackColor = System.Drawing.Color.Transparent;
            this.UpdatePBox.Image = global::PBLauncher.Properties.Resources.update;
            this.UpdatePBox.Location = new System.Drawing.Point(570, 33);
            this.UpdatePBox.Name = "UpdatePBox";
            this.UpdatePBox.Size = new System.Drawing.Size(136, 64);
            this.UpdatePBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UpdatePBox.TabIndex = 21;
            this.UpdatePBox.TabStop = false;
            // 
            // LTotalFixo
            // 
            this.LTotalFixo.AutoSize = true;
            this.LTotalFixo.BackColor = System.Drawing.Color.Transparent;
            this.LTotalFixo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTotalFixo.ForeColor = System.Drawing.Color.White;
            this.LTotalFixo.Location = new System.Drawing.Point(9, 67);
            this.LTotalFixo.Name = "LTotalFixo";
            this.LTotalFixo.Size = new System.Drawing.Size(33, 15);
            this.LTotalFixo.TabIndex = 19;
            this.LTotalFixo.Text = "Total";
            // 
            // LAquivoFixo
            // 
            this.LAquivoFixo.AutoSize = true;
            this.LAquivoFixo.BackColor = System.Drawing.Color.Transparent;
            this.LAquivoFixo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAquivoFixo.ForeColor = System.Drawing.Color.White;
            this.LAquivoFixo.Location = new System.Drawing.Point(11, 31);
            this.LAquivoFixo.Name = "LAquivoFixo";
            this.LAquivoFixo.Size = new System.Drawing.Size(50, 15);
            this.LAquivoFixo.TabIndex = 18;
            this.LAquivoFixo.Text = "Arquivo";
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
            // 
            // Total_BarFixo
            // 
            this.Total_BarFixo.BackColor = System.Drawing.Color.White;
            this.Total_BarFixo.Location = new System.Drawing.Point(12, 83);
            this.Total_BarFixo.Name = "Total_BarFixo";
            this.Total_BarFixo.Size = new System.Drawing.Size(463, 10);
            this.Total_BarFixo.TabIndex = 26;
            this.Total_BarFixo.TabStop = false;
            // 
            // Arquivo_BarFixo
            // 
            this.Arquivo_BarFixo.BackColor = System.Drawing.Color.White;
            this.Arquivo_BarFixo.Location = new System.Drawing.Point(12, 48);
            this.Arquivo_BarFixo.Name = "Arquivo_BarFixo";
            this.Arquivo_BarFixo.Size = new System.Drawing.Size(463, 10);
            this.Arquivo_BarFixo.TabIndex = 27;
            this.Arquivo_BarFixo.TabStop = false;
            // 
            // LArquivo
            // 
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
            // 
            // WEB_Announce
            // 
            this.WEB_Announce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WEB_Announce.IsWebBrowserContextMenuEnabled = false;
            this.WEB_Announce.Location = new System.Drawing.Point(0, 30);
            this.WEB_Announce.MinimumSize = new System.Drawing.Size(20, 20);
            this.WEB_Announce.Name = "WEB_Announce";
            this.WEB_Announce.ScrollBarsEnabled = false;
            this.WEB_Announce.Size = new System.Drawing.Size(714, 431);
            this.WEB_Announce.TabIndex = 2;
            this.WEB_Announce.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(714, 565);
            this.Controls.Add(this.WEB_Announce);
            this.Controls.Add(this.panel_end);
            this.Controls.Add(this.panel_top);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
            ((System.ComponentModel.ISupportInitialize)(this.Total_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpdatePBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total_BarFixo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arquivo_BarFixo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_end;
        private System.Windows.Forms.WebBrowser WEB_Announce;
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
    }
}