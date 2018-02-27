namespace IPNow_Manager
{
    partial class FormHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtProxy = new System.Windows.Forms.TextBox();
            this.txtIPv6 = new System.Windows.Forms.TextBox();
            this.txtDecimalIP = new System.Windows.Forms.TextBox();
            this.txtServiceProvider = new System.Windows.Forms.TextBox();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtInternetPort = new System.Windows.Forms.TextBox();
            this.txtRemotePort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblProxy = new System.Windows.Forms.Label();
            this.lblIPv6 = new System.Windows.Forms.Label();
            this.lblDecimalIP = new System.Windows.Forms.Label();
            this.lblServiceProvider = new System.Windows.Forms.Label();
            this.lblHost = new System.Windows.Forms.Label();
            this.lblInternetPort = new System.Windows.Forms.Label();
            this.lblRemotePort = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCopyForum = new System.Windows.Forms.Button();
            this.txtForumImage = new System.Windows.Forms.TextBox();
            this.lblForumImage = new System.Windows.Forms.Label();
            this.btnCopyHTML = new System.Windows.Forms.Button();
            this.btnCopyLink = new System.Windows.Forms.Button();
            this.txtHTMLImage = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.lblHTMLImage = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbAbout = new System.Windows.Forms.GroupBox();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToClipboard = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyIP = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyRemotePort = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyInternetPort = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyHost = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyServiceProvider = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyDecimalIP = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyIPv6 = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyProxy = new System.Windows.Forms.ToolStripMenuItem();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblPowered = new System.Windows.Forms.Label();
            this.tcPrincipal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.gbAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.status.SuspendLayout();
            this.cmsOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tabPage1);
            this.tcPrincipal.Controls.Add(this.tabPage4);
            this.tcPrincipal.Controls.Add(this.tabPage3);
            this.tcPrincipal.Location = new System.Drawing.Point(10, 103);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(289, 267);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtProxy);
            this.tabPage1.Controls.Add(this.txtIPv6);
            this.tabPage1.Controls.Add(this.txtDecimalIP);
            this.tabPage1.Controls.Add(this.txtServiceProvider);
            this.tabPage1.Controls.Add(this.txtHost);
            this.tabPage1.Controls.Add(this.txtInternetPort);
            this.tabPage1.Controls.Add(this.txtRemotePort);
            this.tabPage1.Controls.Add(this.txtIP);
            this.tabPage1.Controls.Add(this.lblProxy);
            this.tabPage1.Controls.Add(this.lblIPv6);
            this.tabPage1.Controls.Add(this.lblDecimalIP);
            this.tabPage1.Controls.Add(this.lblServiceProvider);
            this.tabPage1.Controls.Add(this.lblHost);
            this.tabPage1.Controls.Add(this.lblInternetPort);
            this.tabPage1.Controls.Add(this.lblRemotePort);
            this.tabPage1.Controls.Add(this.lblIP);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(281, 241);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtProxy
            // 
            this.txtProxy.Location = new System.Drawing.Point(65, 201);
            this.txtProxy.Name = "txtProxy";
            this.txtProxy.ReadOnly = true;
            this.txtProxy.Size = new System.Drawing.Size(157, 20);
            this.txtProxy.TabIndex = 17;
            // 
            // txtIPv6
            // 
            this.txtIPv6.Location = new System.Drawing.Point(65, 175);
            this.txtIPv6.Name = "txtIPv6";
            this.txtIPv6.ReadOnly = true;
            this.txtIPv6.Size = new System.Drawing.Size(157, 20);
            this.txtIPv6.TabIndex = 16;
            // 
            // txtDecimalIP
            // 
            this.txtDecimalIP.Location = new System.Drawing.Point(93, 147);
            this.txtDecimalIP.Name = "txtDecimalIP";
            this.txtDecimalIP.ReadOnly = true;
            this.txtDecimalIP.Size = new System.Drawing.Size(129, 20);
            this.txtDecimalIP.TabIndex = 15;
            // 
            // txtServiceProvider
            // 
            this.txtServiceProvider.Location = new System.Drawing.Point(122, 118);
            this.txtServiceProvider.Name = "txtServiceProvider";
            this.txtServiceProvider.ReadOnly = true;
            this.txtServiceProvider.Size = new System.Drawing.Size(100, 20);
            this.txtServiceProvider.TabIndex = 13;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(70, 92);
            this.txtHost.Name = "txtHost";
            this.txtHost.ReadOnly = true;
            this.txtHost.Size = new System.Drawing.Size(152, 20);
            this.txtHost.TabIndex = 12;
            // 
            // txtInternetPort
            // 
            this.txtInternetPort.Location = new System.Drawing.Point(104, 70);
            this.txtInternetPort.Name = "txtInternetPort";
            this.txtInternetPort.ReadOnly = true;
            this.txtInternetPort.Size = new System.Drawing.Size(118, 20);
            this.txtInternetPort.TabIndex = 11;
            // 
            // txtRemotePort
            // 
            this.txtRemotePort.Location = new System.Drawing.Point(104, 44);
            this.txtRemotePort.Name = "txtRemotePort";
            this.txtRemotePort.ReadOnly = true;
            this.txtRemotePort.Size = new System.Drawing.Size(118, 20);
            this.txtRemotePort.TabIndex = 10;
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(54, 14);
            this.txtIP.Name = "txtIP";
            this.txtIP.ReadOnly = true;
            this.txtIP.Size = new System.Drawing.Size(168, 20);
            this.txtIP.TabIndex = 9;
            // 
            // lblProxy
            // 
            this.lblProxy.AutoSize = true;
            this.lblProxy.Location = new System.Drawing.Point(26, 201);
            this.lblProxy.Name = "lblProxy";
            this.lblProxy.Size = new System.Drawing.Size(42, 13);
            this.lblProxy.TabIndex = 8;
            this.lblProxy.Text = " Proxy: ";
            // 
            // lblIPv6
            // 
            this.lblIPv6.AutoSize = true;
            this.lblIPv6.Location = new System.Drawing.Point(26, 176);
            this.lblIPv6.Name = "lblIPv6";
            this.lblIPv6.Size = new System.Drawing.Size(32, 13);
            this.lblIPv6.TabIndex = 7;
            this.lblIPv6.Text = "IPv6:";
            // 
            // lblDecimalIP
            // 
            this.lblDecimalIP.AutoSize = true;
            this.lblDecimalIP.Location = new System.Drawing.Point(26, 147);
            this.lblDecimalIP.Name = "lblDecimalIP";
            this.lblDecimalIP.Size = new System.Drawing.Size(61, 13);
            this.lblDecimalIP.TabIndex = 6;
            this.lblDecimalIP.Text = "Decimal IP:";
            // 
            // lblServiceProvider
            // 
            this.lblServiceProvider.AutoSize = true;
            this.lblServiceProvider.Location = new System.Drawing.Point(22, 118);
            this.lblServiceProvider.Name = "lblServiceProvider";
            this.lblServiceProvider.Size = new System.Drawing.Size(94, 13);
            this.lblServiceProvider.TabIndex = 4;
            this.lblServiceProvider.Text = " Service Provider: ";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(26, 96);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(38, 13);
            this.lblHost.TabIndex = 3;
            this.lblHost.Text = "Host : ";
            // 
            // lblInternetPort
            // 
            this.lblInternetPort.AutoSize = true;
            this.lblInternetPort.Location = new System.Drawing.Point(23, 70);
            this.lblInternetPort.Name = "lblInternetPort";
            this.lblInternetPort.Size = new System.Drawing.Size(74, 13);
            this.lblInternetPort.TabIndex = 2;
            this.lblInternetPort.Text = "Internet Port : ";
            // 
            // lblRemotePort
            // 
            this.lblRemotePort.AutoSize = true;
            this.lblRemotePort.Location = new System.Drawing.Point(22, 44);
            this.lblRemotePort.Name = "lblRemotePort";
            this.lblRemotePort.Size = new System.Drawing.Size(75, 13);
            this.lblRemotePort.TabIndex = 1;
            this.lblRemotePort.Text = "Remote Port : ";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(22, 17);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(26, 13);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP : ";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCopyForum);
            this.tabPage4.Controls.Add(this.txtForumImage);
            this.tabPage4.Controls.Add(this.lblForumImage);
            this.tabPage4.Controls.Add(this.btnCopyHTML);
            this.tabPage4.Controls.Add(this.btnCopyLink);
            this.tabPage4.Controls.Add(this.txtHTMLImage);
            this.tabPage4.Controls.Add(this.txtLink);
            this.tabPage4.Controls.Add(this.lblHTMLImage);
            this.tabPage4.Controls.Add(this.lblLink);
            this.tabPage4.Controls.Add(this.gbImage);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(281, 241);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tools";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCopyForum
            // 
            this.btnCopyForum.Location = new System.Drawing.Point(220, 207);
            this.btnCopyForum.Name = "btnCopyForum";
            this.btnCopyForum.Size = new System.Drawing.Size(49, 23);
            this.btnCopyForum.TabIndex = 9;
            this.btnCopyForum.Text = "Copy";
            this.btnCopyForum.UseVisualStyleBackColor = true;
            this.btnCopyForum.Click += new System.EventHandler(this.btnCopyForum_Click);
            // 
            // txtForumImage
            // 
            this.txtForumImage.Location = new System.Drawing.Point(93, 209);
            this.txtForumImage.Name = "txtForumImage";
            this.txtForumImage.ReadOnly = true;
            this.txtForumImage.Size = new System.Drawing.Size(120, 20);
            this.txtForumImage.TabIndex = 8;
            // 
            // lblForumImage
            // 
            this.lblForumImage.AutoSize = true;
            this.lblForumImage.Location = new System.Drawing.Point(18, 209);
            this.lblForumImage.Name = "lblForumImage";
            this.lblForumImage.Size = new System.Drawing.Size(77, 13);
            this.lblForumImage.TabIndex = 7;
            this.lblForumImage.Text = "Forum Image : ";
            // 
            // btnCopyHTML
            // 
            this.btnCopyHTML.Location = new System.Drawing.Point(220, 183);
            this.btnCopyHTML.Name = "btnCopyHTML";
            this.btnCopyHTML.Size = new System.Drawing.Size(49, 23);
            this.btnCopyHTML.TabIndex = 6;
            this.btnCopyHTML.Text = "Copy";
            this.btnCopyHTML.UseVisualStyleBackColor = true;
            this.btnCopyHTML.Click += new System.EventHandler(this.btnCopyHTML_Click);
            // 
            // btnCopyLink
            // 
            this.btnCopyLink.Location = new System.Drawing.Point(220, 159);
            this.btnCopyLink.Name = "btnCopyLink";
            this.btnCopyLink.Size = new System.Drawing.Size(49, 23);
            this.btnCopyLink.TabIndex = 5;
            this.btnCopyLink.Text = "Copy";
            this.btnCopyLink.UseVisualStyleBackColor = true;
            this.btnCopyLink.Click += new System.EventHandler(this.btnCopyLink_Click);
            // 
            // txtHTMLImage
            // 
            this.txtHTMLImage.Location = new System.Drawing.Point(93, 183);
            this.txtHTMLImage.Name = "txtHTMLImage";
            this.txtHTMLImage.ReadOnly = true;
            this.txtHTMLImage.Size = new System.Drawing.Size(120, 20);
            this.txtHTMLImage.TabIndex = 4;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(61, 159);
            this.txtLink.Name = "txtLink";
            this.txtLink.ReadOnly = true;
            this.txtLink.Size = new System.Drawing.Size(152, 20);
            this.txtLink.TabIndex = 3;
            // 
            // lblHTMLImage
            // 
            this.lblHTMLImage.AutoSize = true;
            this.lblHTMLImage.Location = new System.Drawing.Point(18, 183);
            this.lblHTMLImage.Name = "lblHTMLImage";
            this.lblHTMLImage.Size = new System.Drawing.Size(78, 13);
            this.lblHTMLImage.TabIndex = 2;
            this.lblHTMLImage.Text = "HTML Image : ";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Location = new System.Drawing.Point(18, 159);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(36, 13);
            this.lblLink.TabIndex = 1;
            this.lblLink.Text = "Link : ";
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.pbImage);
            this.gbImage.Location = new System.Drawing.Point(18, 21);
            this.gbImage.Name = "gbImage";
            this.gbImage.Size = new System.Drawing.Size(241, 131);
            this.gbImage.TabIndex = 0;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "Image";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(20, 20);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(198, 92);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbAbout);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(281, 241);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbAbout
            // 
            this.gbAbout.Controls.Add(this.lblCopyRight);
            this.gbAbout.Controls.Add(this.pbAvatar);
            this.gbAbout.Location = new System.Drawing.Point(17, 12);
            this.gbAbout.Name = "gbAbout";
            this.gbAbout.Size = new System.Drawing.Size(244, 211);
            this.gbAbout.TabIndex = 0;
            this.gbAbout.TabStop = false;
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(36, 187);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(176, 13);
            this.lblCopyRight.TabIndex = 1;
            this.lblCopyRight.Text = "© Ismael Heredia , Argentina , 2017";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvatar.Image")));
            this.pbAvatar.Location = new System.Drawing.Point(39, 24);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(177, 150);
            this.pbAvatar.TabIndex = 0;
            this.pbAvatar.TabStop = false;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.status.Location = new System.Drawing.Point(0, 422);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(311, 22);
            this.status.TabIndex = 1;
            this.status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToClipboard});
            this.cmsOpciones.Name = "contextMenuStrip1";
            this.cmsOpciones.Size = new System.Drawing.Size(172, 26);
            // 
            // CopyToClipboard
            // 
            this.CopyToClipboard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyIP,
            this.CopyRemotePort,
            this.CopyInternetPort,
            this.CopyHost,
            this.CopyServiceProvider,
            this.CopyDecimalIP,
            this.CopyIPv6,
            this.CopyProxy});
            this.CopyToClipboard.Name = "CopyToClipboard";
            this.CopyToClipboard.Size = new System.Drawing.Size(171, 22);
            this.CopyToClipboard.Text = "Copy to Clipboard";
            // 
            // CopyIP
            // 
            this.CopyIP.Name = "CopyIP";
            this.CopyIP.Size = new System.Drawing.Size(158, 22);
            this.CopyIP.Text = "IP";
            this.CopyIP.Click += new System.EventHandler(this.CopyIP_Click);
            // 
            // CopyRemotePort
            // 
            this.CopyRemotePort.Name = "CopyRemotePort";
            this.CopyRemotePort.Size = new System.Drawing.Size(158, 22);
            this.CopyRemotePort.Text = "Remote Port";
            this.CopyRemotePort.Click += new System.EventHandler(this.CopyRemotePort_Click);
            // 
            // CopyInternetPort
            // 
            this.CopyInternetPort.Name = "CopyInternetPort";
            this.CopyInternetPort.Size = new System.Drawing.Size(158, 22);
            this.CopyInternetPort.Text = "Internet Port";
            this.CopyInternetPort.Click += new System.EventHandler(this.CopyInternetPort_Click);
            // 
            // CopyHost
            // 
            this.CopyHost.Name = "CopyHost";
            this.CopyHost.Size = new System.Drawing.Size(158, 22);
            this.CopyHost.Text = "Host";
            this.CopyHost.Click += new System.EventHandler(this.CopyHost_Click);
            // 
            // CopyServiceProvider
            // 
            this.CopyServiceProvider.Name = "CopyServiceProvider";
            this.CopyServiceProvider.Size = new System.Drawing.Size(158, 22);
            this.CopyServiceProvider.Text = "Service Provider";
            this.CopyServiceProvider.Click += new System.EventHandler(this.CopyServiceProvider_Click);
            // 
            // CopyDecimalIP
            // 
            this.CopyDecimalIP.Name = "CopyDecimalIP";
            this.CopyDecimalIP.Size = new System.Drawing.Size(158, 22);
            this.CopyDecimalIP.Text = "Decimal IP";
            this.CopyDecimalIP.Click += new System.EventHandler(this.CopyDecimalIP_Click);
            // 
            // CopyIPv6
            // 
            this.CopyIPv6.Name = "CopyIPv6";
            this.CopyIPv6.Size = new System.Drawing.Size(158, 22);
            this.CopyIPv6.Text = "IPv6";
            this.CopyIPv6.Click += new System.EventHandler(this.CopyIPv6_Click);
            // 
            // CopyProxy
            // 
            this.CopyProxy.Name = "CopyProxy";
            this.CopyProxy.Size = new System.Drawing.Size(158, 22);
            this.CopyProxy.Text = "Proxy";
            this.CopyProxy.Click += new System.EventHandler(this.CopyProxy_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(10, 13);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(289, 74);
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // lblPowered
            // 
            this.lblPowered.AutoSize = true;
            this.lblPowered.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowered.Location = new System.Drawing.Point(75, 387);
            this.lblPowered.Name = "lblPowered";
            this.lblPowered.Size = new System.Drawing.Size(159, 20);
            this.lblPowered.TabIndex = 5;
            this.lblPowered.Text = "Powered By IPNow";
            this.lblPowered.Click += new System.EventHandler(this.lblPowered_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 444);
            this.ContextMenuStrip = this.cmsOpciones;
            this.Controls.Add(this.lblPowered);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tcPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.Text = "- IPNow Manager 0.3 - © Ismael Heredia , Argentina , 2017 -";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.tcPrincipal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.gbAbout.ResumeLayout(false);
            this.gbAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.cmsOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrincipal;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox gbAbout;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtProxy;
        private System.Windows.Forms.TextBox txtIPv6;
        private System.Windows.Forms.TextBox txtDecimalIP;
        private System.Windows.Forms.TextBox txtServiceProvider;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtInternetPort;
        private System.Windows.Forms.TextBox txtRemotePort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblProxy;
        private System.Windows.Forms.Label lblIPv6;
        private System.Windows.Forms.Label lblDecimalIP;
        private System.Windows.Forms.Label lblServiceProvider;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Label lblInternetPort;
        private System.Windows.Forms.Label lblRemotePort;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox txtHTMLImage;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label lblHTMLImage;
        private System.Windows.Forms.Label lblLink;
        private System.Windows.Forms.Button btnCopyHTML;
        private System.Windows.Forms.Button btnCopyLink;
        private System.Windows.Forms.TextBox txtForumImage;
        private System.Windows.Forms.Label lblForumImage;
        private System.Windows.Forms.Button btnCopyForum;
        private System.Windows.Forms.ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem CopyToClipboard;
        private System.Windows.Forms.ToolStripMenuItem CopyIP;
        private System.Windows.Forms.ToolStripMenuItem CopyRemotePort;
        private System.Windows.Forms.ToolStripMenuItem CopyInternetPort;
        private System.Windows.Forms.ToolStripMenuItem CopyHost;
        private System.Windows.Forms.ToolStripMenuItem CopyServiceProvider;
        private System.Windows.Forms.ToolStripMenuItem CopyDecimalIP;
        private System.Windows.Forms.ToolStripMenuItem CopyIPv6;
        private System.Windows.Forms.ToolStripMenuItem CopyProxy;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblPowered;
    }
}

