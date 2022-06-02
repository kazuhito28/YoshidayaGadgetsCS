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
            this.textBoxStartPageUrl = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.textBoxTitleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonFormZNone = new System.Windows.Forms.RadioButton();
            this.RadioButtonFormZBottom = new System.Windows.Forms.RadioButton();
            this.RadioButtonFormZTop = new System.Windows.Forms.RadioButton();
            this.chkboxFixed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "スタートページ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "透明度（%）";
            // 
            // textBoxStartPageUrl
            // 
            this.textBoxStartPageUrl.Location = new System.Drawing.Point(32, 138);
            this.textBoxStartPageUrl.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxStartPageUrl.Name = "textBoxStartPageUrl";
            this.textBoxStartPageUrl.Size = new System.Drawing.Size(472, 25);
            this.textBoxStartPageUrl.TabIndex = 4;
            this.textBoxStartPageUrl.Validated += new System.EventHandler(this.TextBoxStartPageUrl_Validated);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(32, 340);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(212, 22);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "ガジェットを自動起動する";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.LargeChange = 1;
            this.trackBarOpacity.Location = new System.Drawing.Point(32, 244);
            this.trackBarOpacity.Margin = new System.Windows.Forms.Padding(2);
            this.trackBarOpacity.Minimum = 1;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(470, 69);
            this.trackBarOpacity.TabIndex = 7;
            this.trackBarOpacity.Value = 10;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.trackBarOpacity_Scroll);
            // 
            // textBoxTitleName
            // 
            this.textBoxTitleName.Location = new System.Drawing.Point(32, 46);
            this.textBoxTitleName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTitleName.Name = "textBoxTitleName";
            this.textBoxTitleName.Size = new System.Drawing.Size(472, 25);
            this.textBoxTitleName.TabIndex = 9;
            this.textBoxTitleName.TextChanged += new System.EventHandler(this.textBoxTitleName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "ガジェット名（タイトルバー）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "100";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(526, 132);
            this.btnFileOpen.Margin = new System.Windows.Forms.Padding(2);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(125, 37);
            this.btnFileOpen.TabIndex = 13;
            this.btnFileOpen.Text = "参照";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonFormZNone);
            this.groupBox1.Controls.Add(this.RadioButtonFormZBottom);
            this.groupBox1.Controls.Add(this.RadioButtonFormZTop);
            this.groupBox1.Location = new System.Drawing.Point(550, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(190, 134);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ガジェットの表示";
            // 
            // RadioButtonFormZNone
            // 
            this.RadioButtonFormZNone.AutoSize = true;
            this.RadioButtonFormZNone.Checked = true;
            this.RadioButtonFormZNone.Location = new System.Drawing.Point(24, 104);
            this.RadioButtonFormZNone.Name = "RadioButtonFormZNone";
            this.RadioButtonFormZNone.Size = new System.Drawing.Size(112, 22);
            this.RadioButtonFormZNone.TabIndex = 2;
            this.RadioButtonFormZNone.TabStop = true;
            this.RadioButtonFormZNone.Text = "指定しない";
            this.RadioButtonFormZNone.UseVisualStyleBackColor = true;
            this.RadioButtonFormZNone.CheckedChanged += new System.EventHandler(this.RadioButtonFormZCheck);
            // 
            // RadioButtonFormZBottom
            // 
            this.RadioButtonFormZBottom.AutoSize = true;
            this.RadioButtonFormZBottom.Location = new System.Drawing.Point(24, 72);
            this.RadioButtonFormZBottom.Name = "RadioButtonFormZBottom";
            this.RadioButtonFormZBottom.Size = new System.Drawing.Size(87, 22);
            this.RadioButtonFormZBottom.TabIndex = 1;
            this.RadioButtonFormZBottom.TabStop = true;
            this.RadioButtonFormZBottom.Text = "最背面";
            this.RadioButtonFormZBottom.UseVisualStyleBackColor = true;
            this.RadioButtonFormZBottom.CheckedChanged += new System.EventHandler(this.RadioButtonFormZCheck);
            // 
            // RadioButtonFormZTop
            // 
            this.RadioButtonFormZTop.AutoSize = true;
            this.RadioButtonFormZTop.Location = new System.Drawing.Point(24, 40);
            this.RadioButtonFormZTop.Name = "RadioButtonFormZTop";
            this.RadioButtonFormZTop.Size = new System.Drawing.Size(87, 22);
            this.RadioButtonFormZTop.TabIndex = 0;
            this.RadioButtonFormZTop.TabStop = true;
            this.RadioButtonFormZTop.Text = "最前面";
            this.RadioButtonFormZTop.UseVisualStyleBackColor = true;
            this.RadioButtonFormZTop.CheckedChanged += new System.EventHandler(this.RadioButtonFormZCheck);
            // 
            // chkboxFixed
            // 
            this.chkboxFixed.AutoSize = true;
            this.chkboxFixed.Location = new System.Drawing.Point(30, 384);
            this.chkboxFixed.Margin = new System.Windows.Forms.Padding(2);
            this.chkboxFixed.Name = "chkboxFixed";
            this.chkboxFixed.Size = new System.Drawing.Size(176, 22);
            this.chkboxFixed.TabIndex = 17;
            this.chkboxFixed.Text = "ガジェットを固定する";
            this.chkboxFixed.UseVisualStyleBackColor = true;
            this.chkboxFixed.CheckedChanged += new System.EventHandler(this.chkBoxFixed_CheckedChanged);
            // 
            // FormCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkboxFixed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTitleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarOpacity);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxStartPageUrl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormCustom";
            this.Text = "FormCustom";
            this.Load += new System.EventHandler(this.formCustom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStartPageUrl;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.TextBox textBoxTitleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkboxFixed;
        private System.Windows.Forms.RadioButton RadioButtonFormZBottom;
        private System.Windows.Forms.RadioButton RadioButtonFormZTop;
        private System.Windows.Forms.RadioButton RadioButtonFormZNone;
    }
}