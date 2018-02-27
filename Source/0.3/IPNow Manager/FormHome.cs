// IPNow Manager 0.3
// © Ismael Heredia , Argentina , 2017

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Media;

namespace IPNow_Manager
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            SoundPlayer sound1 = new SoundPlayer(IPNow_Manager.Properties.Resources.formcreate);
            sound1.Play();

            toolStripStatusLabel1.Text = "[+] Getting Information ...";
            this.Refresh();

            WebClient web = new WebClient();
            web.Headers["User-Agent"] = "Opera/9.80 (Windows NT 6.0) Presto/2.12.388 Version/12.14";
            string codigofuente = web.DownloadString("http://www.ipnow.org/index.php");

            Match search = Regex.Match(codigofuente, "IP Address:\\s*</td>\\s*<td class=\"info\">\\s*(.*?)\\s*</td>", RegexOptions.IgnoreCase);
            if (search.Success)
            {
                txtIP.Text = search.Groups[1].Value;
            }
            else
            {
                txtIP.Text = "Fail";
            }
            search = Regex.Match(codigofuente, "Remote Port:\\s*</td>\\s*<td class=\"info\">\\s*(.*?)\\s*</td>", RegexOptions.IgnoreCase);
            if (search.Success)
            {
                txtRemotePort.Text = search.Groups[1].Value;
            }
            else
            {
                txtRemotePort.Text = "Fail";
            }

            search = Regex.Match(codigofuente, "Internet Port:\\s*</td>\\s*<td class=\"info\">\\s*(.*?)\\s*</td>", RegexOptions.IgnoreCase);
            if (search.Success)
            {
                txtInternetPort.Text = search.Groups[1].Value;
            }
            else
            {
                txtInternetPort.Text = "Fail";
            }

            search = Regex.Match(codigofuente, "Host:\\s*</td>\\s*<td class=\"info\">\\s*(.*?)\\s*</td>", RegexOptions.IgnoreCase);
            if (search.Success)
            {
                txtHost.Text = search.Groups[1].Value;
            }
            else
            {
                txtHost.Text = "Fail";
            }

            search = Regex.Match(codigofuente, "Service Provider:\\s*</td>\\s*<td class=\"info\">\\s*(.*?)\\s*</td>", RegexOptions.IgnoreCase);
            if (search.Success)
            {
                txtServiceProvider.Text = search.Groups[1].Value;
            }
            else
            {
                txtServiceProvider.Text = "Fail";
            }

            search = Regex.Match(codigofuente, "Decimal IP: <a href=(.*?) target=(.*?) title=(.*?)>(.*?)</a>\\s*</td>\\s*<td class=\"info\">\\s*(.*?)\\s*</td>", RegexOptions.IgnoreCase);
            if (search.Success)
            {
                txtDecimalIP.Text = search.Groups[5].Value;
            }
            else
            {
                txtDecimalIP.Text = "Fail";
            }

            search = Regex.Match(codigofuente, "IPv6: <a href=(.*?) target=(.*?) title=(.*?)>(.*?)</a>\\s*</td>\\s*<td class=\"info\">\\s*(.*?)\\s*</td>", RegexOptions.IgnoreCase);
            if (search.Success)
            {
                txtIPv6.Text = search.Groups[5].Value;
            }
            else
            {
                txtIPv6.Text = "Fail";
            }

            search = Regex.Match(codigofuente, "Proxy:\\s*</td>\\s*<td class=\"info\">\\s*(.*?)\\s*</td>", RegexOptions.IgnoreCase);
            if (search.Success)
            {
                txtProxy.Text = search.Groups[1].Value;
            }
            else
            {
                txtProxy.Text = "Fail";
            }

            var peticion = WebRequest.Create("http://www.ipnow.org/images/iprand.jpg");
            var respuesta = peticion.GetResponse();
            var mostrar = respuesta.GetResponseStream();
            pbImage.Image = Bitmap.FromStream(mostrar);

            txtLink.Text = "http://www.ipnow.org/images/iprand.jpg";
            txtHTMLImage.Text = "<img src=\"http://www.ipnow.org/images/iprand.jpg\">";
            txtForumImage.Text = "[img]http://www.ipnow.org/images/iprand.jpg[/img]";

            toolStripStatusLabel1.Text = "[+] Ready";
            this.Refresh();

            SoundPlayer sound2 = new SoundPlayer(IPNow_Manager.Properties.Resources.scanfin);
            sound2.Play();
        }

        private void btnCopyLink_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(txtLink.Text);
        }

        private void btnCopyHTML_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(IPNow_Manager.Properties.Resources.click);
            sound.Play();
            Clipboard.Clear();
            Clipboard.SetText(txtHTMLImage.Text);
        }

        private void btnCopyForum_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(IPNow_Manager.Properties.Resources.click);
            sound.Play();
            Clipboard.Clear();
            Clipboard.SetText(txtForumImage.Text);
        }

        private void lblPowered_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ipnow.org/");
        }

        private void CopyIP_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(IPNow_Manager.Properties.Resources.click);
            sound.Play();
            Clipboard.Clear();
            Clipboard.SetText(txtIP.Text);
        }

        private void CopyRemotePort_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(IPNow_Manager.Properties.Resources.click);
            sound.Play();
            Clipboard.Clear();
            Clipboard.SetText(txtRemotePort.Text);
        }

        private void CopyInternetPort_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(IPNow_Manager.Properties.Resources.click);
            sound.Play();
            Clipboard.Clear();
            Clipboard.SetText(txtInternetPort.Text);
        }

        private void CopyHost_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(IPNow_Manager.Properties.Resources.click);
            sound.Play();
            Clipboard.Clear();
            Clipboard.SetText(txtHost.Text);
        }

        private void CopyServiceProvider_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(IPNow_Manager.Properties.Resources.click);
            sound.Play();
            Clipboard.Clear();
            Clipboard.SetText(txtServiceProvider.Text);
        }

        private void CopyDecimalIP_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(IPNow_Manager.Properties.Resources.click);
            sound.Play();
            Clipboard.Clear();
            Clipboard.SetText(txtDecimalIP.Text);
        }

        private void CopyIPv6_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(IPNow_Manager.Properties.Resources.click);
            sound.Play();
            Clipboard.Clear();
            Clipboard.SetText(txtIPv6.Text);
        }

        private void CopyProxy_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(IPNow_Manager.Properties.Resources.click);
            sound.Play();
            Clipboard.Clear();
            Clipboard.SetText(txtProxy.Text);
        }

    }
}
