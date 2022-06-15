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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.viewGadgets = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.メニュー1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGadgets)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(752, 8);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.viewGadgets.Location = new System.Drawing.Point(0, 80);
            this.viewGadgets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewGadgets.Name = "viewGadgets";
            this.viewGadgets.Size = new System.Drawing.Size(824, 472);
            this.viewGadgets.Source = global::YoshidayaGadgetsCS.Properties.Settings.Default.GadgetsStartPageUrl;
            this.viewGadgets.TabIndex = 0;
            this.viewGadgets.ZoomFactor = 1D;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.メニュー1ToolStripMenuItem,
            this.設定ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 76);
            // 
            // メニュー1ToolStripMenuItem
            // 
            this.メニュー1ToolStripMenuItem.Name = "メニュー1ToolStripMenuItem";
            this.メニュー1ToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.メニュー1ToolStripMenuItem.Text = "メニュー1";
            this.メニュー1ToolStripMenuItem.Click += new System.EventHandler(this.メニュー1ToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.設定ToolStripMenuItem.Text = "設定";
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.終了ToolStripMenuItem.Text = "終了";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // formGadgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(827, 553);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewGadgets)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 viewGadgets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem メニュー1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

