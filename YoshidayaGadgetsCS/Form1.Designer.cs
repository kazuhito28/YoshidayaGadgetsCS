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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGadgets));
            this.viewGadgets = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.viewGadgets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewGadgets
            // 
            this.viewGadgets.AllowExternalDrop = true;
            this.viewGadgets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewGadgets.CreationProperties = null;
            this.viewGadgets.DataBindings.Add(new System.Windows.Forms.Binding("Source", global::YoshidayaGadgetsCS.Properties.Settings.Default, "StartPageUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.viewGadgets.DefaultBackgroundColor = System.Drawing.Color.White;
            this.viewGadgets.Location = new System.Drawing.Point(-1, 1);
            this.viewGadgets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewGadgets.Name = "viewGadgets";
            this.viewGadgets.Size = new System.Drawing.Size(829, 552);
            this.viewGadgets.Source = global::YoshidayaGadgetsCS.Properties.Settings.Default.StartPageUrl;
            this.viewGadgets.TabIndex = 0;
            this.viewGadgets.ZoomFactor = 1D;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(751, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // formGadgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(827, 553);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.viewGadgets);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formGadgets";
            this.Text = "吉田屋事務器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formGadgets_Closed);
            this.Load += new System.EventHandler(this.formGadgets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewGadgets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 viewGadgets;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

