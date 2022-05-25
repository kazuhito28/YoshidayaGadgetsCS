namespace YoshidayaGadgetsCS
{
    partial class FormCustom
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStartPageUrl = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tbTitleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkboxBottom = new System.Windows.Forms.CheckBox();
            this.chkboxTop = new System.Windows.Forms.CheckBox();
            this.chkboxFixed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "スタートページ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "透明度（%）";
            // 
            // tbStartPageUrl
            // 
            this.tbStartPageUrl.Location = new System.Drawing.Point(26, 115);
            this.tbStartPageUrl.Margin = new System.Windows.Forms.Padding(2);
            this.tbStartPageUrl.Name = "tbStartPageUrl";
            this.tbStartPageUrl.Size = new System.Drawing.Size(378, 22);
            this.tbStartPageUrl.TabIndex = 4;
            this.tbStartPageUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 283);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(177, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "ガジェットを自動起動する";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(26, 203);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(376, 56);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 10;
            // 
            // tbTitleName
            // 
            this.tbTitleName.Location = new System.Drawing.Point(26, 38);
            this.tbTitleName.Margin = new System.Windows.Forms.Padding(2);
            this.tbTitleName.Name = "tbTitleName";
            this.tbTitleName.Size = new System.Drawing.Size(378, 22);
            this.tbTitleName.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "ガジェット名（タイトルバー）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 247);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "100";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(421, 110);
            this.btnFileOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(100, 31);
            this.btnFileOpen.TabIndex = 13;
            this.btnFileOpen.Text = "参照";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(512, 320);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 31);
            this.btnOK.TabIndex = 14;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(392, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkboxBottom);
            this.groupBox1.Controls.Add(this.chkboxTop);
            this.groupBox1.Location = new System.Drawing.Point(440, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 112);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ガジェットの表示";
            // 
            // chkboxBottom
            // 
            this.chkboxBottom.AutoSize = true;
            this.chkboxBottom.Location = new System.Drawing.Point(16, 56);
            this.chkboxBottom.Name = "chkboxBottom";
            this.chkboxBottom.Size = new System.Drawing.Size(74, 19);
            this.chkboxBottom.TabIndex = 1;
            this.chkboxBottom.Text = "最背面";
            this.chkboxBottom.UseVisualStyleBackColor = true;
            // 
            // chkboxTop
            // 
            this.chkboxTop.AutoSize = true;
            this.chkboxTop.Location = new System.Drawing.Point(16, 32);
            this.chkboxTop.Name = "chkboxTop";
            this.chkboxTop.Size = new System.Drawing.Size(74, 19);
            this.chkboxTop.TabIndex = 0;
            this.chkboxTop.Text = "最前面";
            this.chkboxTop.UseVisualStyleBackColor = true;
            // 
            // chkboxFixed
            // 
            this.chkboxFixed.AutoSize = true;
            this.chkboxFixed.Location = new System.Drawing.Point(24, 320);
            this.chkboxFixed.Margin = new System.Windows.Forms.Padding(2);
            this.chkboxFixed.Name = "chkboxFixed";
            this.chkboxFixed.Size = new System.Drawing.Size(147, 19);
            this.chkboxFixed.TabIndex = 17;
            this.chkboxFixed.Text = "ガジェットを固定する";
            this.chkboxFixed.UseVisualStyleBackColor = true;
            this.chkboxFixed.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // FormCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 375);
            this.Controls.Add(this.chkboxFixed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTitleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbStartPageUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCustom";
            this.Text = "FormCustom";
            this.Load += new System.EventHandler(this.formCustom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbStartPageUrl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox tbTitleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkboxBottom;
        private System.Windows.Forms.CheckBox chkboxTop;
        private System.Windows.Forms.CheckBox chkboxFixed;
    }
}