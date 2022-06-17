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
//using System.Runtime.InteropServices; //ウィンドウを最背面に配置するため

namespace YoshidayaGadgetsCS
{

    public partial class formGadgets : Form
    {

        public void CustomChanged()
        {
            if (Properties.Settings.Default.GadgetsTopMost)
            {
                this.TopMost = true;
            }
            else
            {
                //wp.hwndInsertAfter = HWND_NOTOPMOST;
                this.TopMost = false;
            }

            if (Properties.Settings.Default.GadgetsFixed)
            {
                Program.formGadgetsInstance.FormBorderStyle = FormBorderStyle.None;
                Program.formGadgetsInstance.ShowInTaskbar = false;
            }
            else
            {
                Program.formGadgetsInstance.FormBorderStyle = FormBorderStyle.Sizable;
                Program.formGadgetsInstance.ShowInTaskbar = true;
            }


        }

        NotifyIcon NotifyIconGadgets;

        private void setComponents()
        {
            NotifyIconGadgets = new NotifyIcon();
            // アイコンの設定
            NotifyIconGadgets.Icon = new Icon(@"C:\Users\user\Downloads\favicon01\favicon01\sky\rainbow\tmrainbow00101.ico");
            // アイコンを表示する
            NotifyIconGadgets.Visible = true;
            // アイコンにマウスポインタを合わせたときのテキスト
            NotifyIconGadgets.Text = "吉田屋ガジェット";
        }

        public formGadgets()
        {


            InitializeComponent();

            //this.ShowInTaskbar = false;
            //this.setComponents();

            Program.formGadgetsInstance = this;

        }



        private async Task InitializeAsync()
        {
            await viewGadgets.EnsureCoreWebView2Async(null); // CoreWebView2初期化待ち

            viewGadgets.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
        }


        private void formGadgets_Load(object sender, EventArgs e)
        {

            // ウィンドウの状態を復元
            if (Properties.Settings.Default.GadgetsSize.Width > 0 && Properties.Settings.Default.GadgetsSize.Height > 0)    // サイズが 0 じゃない
            {
                if (Properties.Settings.Default.GadgetsState != FormWindowState.Minimized)    // 最小化の場合は無視する
                {
                    this.WindowState = Properties.Settings.Default.GadgetsState;
                }
                this.Location = Properties.Settings.Default.GadgetsPos;
                this.Size = Properties.Settings.Default.GadgetsSize;
            }

            this.Opacity = Properties.Settings.Default.GadgetsOpacity; // 透明度
            this.Text = Properties.Settings.Default.GadgetsTitleName; // タイトルネーム

            this.viewGadgets.Source = new System.Uri(Properties.Settings.Default.GadgetsStartPageUrl.ToString(), System.UriKind.Absolute);

            viewGadgets.NavigationStarting += WebView2_NavigationStarting;

            //this.CustomChanged();

            _ = InitializeAsync();

        }

        private void WebView2_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {

                try

                {

                    string decstr = HttpUtility.UrlDecode(e.Uri);

                    //MessageBox.Show("start\n"+decstr);

                    if (!decstr.Contains(Properties.Settings.Default.GadgetsStartPageUrl.ToString()))

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
                    MessageBox.Show("Request\n" + decstr);

                    e.Handled = true; // NewWindowのキャンセル

                    if (!decstr.Contains(Properties.Settings.Default.GadgetsStartPageUrl.ToString()))

                    {

                        Process.Start(e.Uri);
                        return;
                    }
                }

                catch (Exception er)

                {
                    MessageBox.Show("ErrCode 1234 : " + er.ToString());
                    MessageBox.Show(Properties.Settings.Default.GadgetsStartPageUrl.ToString());

                }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (Program.formCustomInstance == null || Program.formCustomInstance.IsDisposed)

            {

                    FormCustom FormCustom = new FormCustom();
                    FormCustom.Show();

            }
        }

        private void formGadgets_Closed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.GadgetsState = this.WindowState;
            if (this.WindowState == FormWindowState.Normal)
            {
                // 通常の場合は現在の座標とサイズを記憶する
                Properties.Settings.Default.GadgetsPos = this.Location;
                Properties.Settings.Default.GadgetsSize = this.Size;
            }
            else
            {
                // そうじゃない場合（最大化もしくは最小化）は元のサイズを記憶する
                Properties.Settings.Default.GadgetsPos = this.RestoreBounds.Location;
                Properties.Settings.Default.GadgetsSize = this.RestoreBounds.Size;
            }

            // 設定を保存
            Properties.Settings.Default.Save();
        }

        private void メニュー1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void FormGadgets_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Hide();
            }
        }
    }


}
