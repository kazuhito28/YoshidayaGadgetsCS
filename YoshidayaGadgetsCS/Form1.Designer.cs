namespace YoshidayaGadgetsCS
{
    partial class formGadgets
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGadgets));
            this.viewGadgets = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.ContextMenuStrip_Gadgets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItem_Freeze = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Custom = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIcon_Gadgets = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.viewGadgets)).BeginInit();
            this.ContextMenuStrip_Gadgets.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewGadgets
            // 
            this.viewGadgets.AllowExternalDrop = true;
            this.viewGadgets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewGadgets.CreationProperties = null;
            this.viewGadgets.DataBindings.Add(new System.Windows.Forms.Binding("Source", global::YoshidayaGadgetsCS.Properties.Settings.Default, "GadgetsStartPageUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.viewGadgets.DefaultBackgroundColor = System.Drawing.Color.White;
            this.viewGadgets.Location = new System.Drawing.Point(0, 0);
            this.viewGadgets.Margin = new System.Windows.Forms.Padding(0);
            this.viewGadgets.Name = "viewGadgets";
            this.viewGadgets.Size = new System.Drawing.Size(780, 540);
            this.viewGadgets.Source = global::YoshidayaGadgetsCS.Properties.Settings.Default.GadgetsStartPageUrl;
            this.viewGadgets.TabIndex = 0;
            this.viewGadgets.ZoomFactor = 1D;
            // 
            // ContextMenuStrip_Gadgets
            // 
            this.ContextMenuStrip_Gadgets.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuStrip_Gadgets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Freeze,
            this.MenuItem_Custom,
            this.MenuItem_Close});
            this.ContextMenuStrip_Gadgets.Name = "contextMenuStrip1";
            this.ContextMenuStrip_Gadgets.Size = new System.Drawing.Size(196, 76);
            // 
            // MenuItem_Freeze
            // 
            this.MenuItem_Freeze.Name = "MenuItem_Freeze";
            this.MenuItem_Freeze.Size = new System.Drawing.Size(195, 24);
            this.MenuItem_Freeze.Text = "ガジェットを固定する";
            this.MenuItem_Freeze.Click += new System.EventHandler(this.MenuItem_Freeze_Click);
            // 
            // MenuItem_Custom
            // 
            this.MenuItem_Custom.Name = "MenuItem_Custom";
            this.MenuItem_Custom.Size = new System.Drawing.Size(195, 24);
            this.MenuItem_Custom.Text = "設定";
            this.MenuItem_Custom.Click += new System.EventHandler(this.MenuItem_Custom_Click);
            // 
            // MenuItem_Close
            // 
            this.MenuItem_Close.Name = "MenuItem_Close";
            this.MenuItem_Close.Size = new System.Drawing.Size(195, 24);
            this.MenuItem_Close.Text = "終了";
            this.MenuItem_Close.Click += new System.EventHandler(this.MenuItem_Close_Click);
            // 
            // NotifyIcon_Gadgets
            // 
            this.NotifyIcon_Gadgets.ContextMenuStrip = this.ContextMenuStrip_Gadgets;
            this.NotifyIcon_Gadgets.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon_Gadgets.Icon")));
            this.NotifyIcon_Gadgets.Text = "ガジェット";
            this.NotifyIcon_Gadgets.Visible = true;
            // 
            // formGadgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.viewGadgets);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Opacity", global::YoshidayaGadgetsCS.Properties.Settings.Default, "GadgetsOpacity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::YoshidayaGadgetsCS.Properties.Settings.Default, "GadgetsTitleName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formGadgets";
            this.Opacity = global::YoshidayaGadgetsCS.Properties.Settings.Default.GadgetsOpacity;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.Text = global::YoshidayaGadgetsCS.Properties.Settings.Default.GadgetsTitleName;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formGadgets_Closed);
            this.Load += new System.EventHandler(this.formGadgets_Load);
            this.Resize += new System.EventHandler(this.FormGadgets_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.viewGadgets)).EndInit();
            this.ContextMenuStrip_Gadgets.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 viewGadgets;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip_Gadgets;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Freeze;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Custom;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Close;
        private System.Windows.Forms.NotifyIcon NotifyIcon_Gadgets;
    }
}

