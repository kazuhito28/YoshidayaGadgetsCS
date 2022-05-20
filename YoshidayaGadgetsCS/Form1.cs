using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Diagnostics;
using System.Web;

namespace YoshidayaGadgetsCS
{

    public partial class formGadgets : Form
    {

        //string StartURL = "file://server02/data/%EF%BE%8E%EF%BD%BD%EF%BE%84%EF%BE%83%EF%BE%9E%EF%BD%B0%EF%BE%80/desktop/index.html";
        //string StartURL = "file:///C:/Users/user/source/repos/YoshidayaGadgetsCS/YoshidayaGadgetsCS/test.html";

        public formGadgets()
        {
            InitializeComponent();

            //this.viewGadgets.Source = new System.Uri(StartURL, System.UriKind.Absolute);

            //MessageBox.Show(Properties.Settings.Default.StartPageUrl.ToString());

        }

        private async Task InitializeAsync()
        {
            await viewGadgets.EnsureCoreWebView2Async(null); // CoreWebView2初期化待ち

            viewGadgets.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }

        private void formGadgets_Load(object sender, EventArgs e)
        {

            // ウィンドウの状態を復元
            if (Properties.Settings.Default.GadgetSize.Width > 0 && Properties.Settings.Default.GadgetSize.Height > 0)    // サイズが 0 じゃない
            {
                if (Properties.Settings.Default.GadgetState != FormWindowState.Minimized)    // 最小化の場合は無視する
                {
                    this.WindowState = Properties.Settings.Default.GadgetState;
                }
                this.Location = Properties.Settings.Default.GadgetPos;
                this.Size = Properties.Settings.Default.GadgetSize;
            }

            this.viewGadgets.Source = new System.Uri(Properties.Settings.Default.StartPageUrl.ToString(), System.UriKind.Absolute);

            viewGadgets.NavigationStarting += WebView2_NavigationStarting;

            _ = InitializeAsync();

        }

        private void WebView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            try
            
            {

                string decstr = HttpUtility.UrlDecode(e.Uri);

                //MessageBox.Show("start\n"+decstr);

                if (!decstr.Contains(Properties.Settings.Default.StartPageUrl.ToString()))

                {

                    e.Cancel = true; // webview2内でのアクセスをキャンセル

                    Process.Start(e.Uri); // デフォルトブラウザで開く

                    return;
                }
                



            }
            
            catch (Exception er)
            
            {
                MessageBox.Show(e.Uri.ToString());
                MessageBox.Show(er.ToString());
            }
        }

        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            try 

            {
                string decstr = HttpUtility.UrlDecode(e.Uri);
                MessageBox.Show("Request\n"+decstr);

                e.Handled = true; // NewWindowのキャンセル

                if (!decstr.Contains( Properties.Settings.Default.StartPageUrl.ToString()))

                {

                    Process.Start(e.Uri);
                    return;
                }
            }

            catch (Exception er)
            
            {
                MessageBox.Show("ErrCode 1234 : " + er.ToString());
                MessageBox.Show(Properties.Settings.Default.StartPageUrl.ToString());

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormCustom FormCustom = new FormCustom();
            FormCustom.Show();
        }

        private void formGadgets_Closed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.GadgetState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // 通常の場合は現在の座標とサイズを記憶する
                Properties.Settings.Default.GadgetPos = this.Location;
                Properties.Settings.Default.GadgetSize = this.Size;
            }
            else
            {
                // そうじゃない場合（最大化もしくは最小化）は元のサイズを記憶する
                Properties.Settings.Default.GadgetPos = this.RestoreBounds.Location;
                Properties.Settings.Default.GadgetSize = this.RestoreBounds.Size;
            }

            // 設定を保存
            Properties.Settings.Default.Save();
        }

  
    }
}
