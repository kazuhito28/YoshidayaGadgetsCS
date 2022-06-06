using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoshidayaGadgetsCS
{
    public partial class FormCustom : Form
    {
        public FormCustom()
        {
            InitializeComponent();
            Program.formCustomInstance = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBoxStartPageUrl.Text = openFileDialog1.FileName;
                Properties.Settings.Default.GadgetsStartPageUrl = new Uri(this.textBoxStartPageUrl.Text);
            }
        }

        private void formCustom_Load(object sender, EventArgs e)
        {
            this.textBoxStartPageUrl.Text = Properties.Settings.Default.GadgetsStartPageUrl.ToString();
            this.trackBarOpacity.Value = (int)(Properties.Settings.Default.GadgetsOpacity * 10);
            this.textBoxTitleName.Text = Properties.Settings.Default.GadgetsTitleName;
        }

        private void chkBoxFixed_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GadgetsFixed = this.chkboxFixed.Checked;

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

        private void trackBarOpacity_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.GadgetsOpacity = (double)trackBarOpacity.Value / 10;
        }

        private void textBoxTitleName_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GadgetsTitleName = this.textBoxTitleName.Text;
        }

        private void TextBoxStartPageUrl_Validated(object sender, EventArgs e)
        {
            Properties.Settings.Default.GadgetsStartPageUrl = new Uri(this.textBoxStartPageUrl.Text);
        }

        private void RadioButtonFormZCheck(object sender, EventArgs e)
        {
            if (RadioButtonFormZNone.Checked)
            {
                Properties.Settings.Default.GadgetsFormZ = 0; //指定しない
            }

            if (RadioButtonFormZTop.Checked)
            {
                Properties.Settings.Default.GadgetsFormZ = 1; //最前面
            }

            if (RadioButtonFormZBottom.Checked)
            {
                Properties.Settings.Default.GadgetsFormZ = -1; //最背面
            }

            Program.formGadgetsInstance.f_send_wm_windowposchanging();

        }
    }
}
