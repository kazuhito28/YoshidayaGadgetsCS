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
            this.viewGadgets = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.viewGadgets)).BeginInit();
            this.SuspendLayout();
            // 
            // viewGadgets
            // 
            this.viewGadgets.AllowExternalDrop = true;
            this.viewGadgets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewGadgets.CreationProperties = null;
            this.viewGadgets.DefaultBackgroundColor = System.Drawing.Color.White;
            this.viewGadgets.Location = new System.Drawing.Point(2, 2);
            this.viewGadgets.Name = "viewGadgets";
            this.viewGadgets.Size = new System.Drawing.Size(797, 448);
            this.viewGadgets.TabIndex = 0;
            this.viewGadgets.ZoomFactor = 1D;
             // 
            // formGadgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewGadgets);
            this.Name = "formGadgets";
            this.Text = "吉田屋事務器";
            this.Load += new System.EventHandler(this.formGadgets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewGadgets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 viewGadgets;
    }
}

