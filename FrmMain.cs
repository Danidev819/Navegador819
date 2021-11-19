using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using EasyTabs;

namespace Navegador819
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            InitializeBrowser();
        }

        public ChromiumWebBrowser chromeBrower;

        public void InitializeBrowser()
        {
            CefSettings settings = new CefSettings();

            if(!Cef.IsInitialized)
            {
                Cef.Initialize(settings);
            }

            chromeBrower = new ChromiumWebBrowser("https://google.com");

            pnlBody.Controls.Add(chromeBrower);
            chromeBrower.Dock = DockStyle.Fill;

            chromeBrower.LoadingStateChanged += ChromeBrowser_LoadingStateChanged;

            chromeBrower.TitleChanged += ChromeBrowser_TitleChanged;
        }

        private void ChromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                this.FindForm().Text = e.Title;
            });
        }

        private void ChromeBrowser_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {
            this.Invoke((Action)delegate
            {
                loader.Visible = e.IsLoading;
                txtURL.Text = chromeBrower.Address;

                iconSecurity.Image = chromeBrower.Address.StartsWith("https") ? imageList1.Images[0] : imageList1.Images[1];
            });
        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            chromeBrower.Reload();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if(chromeBrower.CanGoBack)
            {
                chromeBrower.Back();
            }
        }

        private void txtURL_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                LoadUrl(txtURL.Text.Trim());
            }
        }

        void LoadUrl(string url)
        {
            if (url.StartsWith("http"))
            {
                chromeBrower.Load(url);
            }
            else
            {
                chromeBrower.Load($"https://www.google.com/search?q={url}");
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if(chromeBrower.CanGoForward)
            {
                chromeBrower.Forward();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
