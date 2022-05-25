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
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //Uri contoso = new Uri(this.textBoxStartPageUrl.Text, UriKind.Absolute);

            //Properties.Settings.Default.StartPageUrl = new System.Uri(contoso.ToString(), System.UriKind.RelativeOrAbsolute);

            Properties.Settings.Default.GadgetsStartPageUrl = new Uri(this.tbStartPageUrl.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                tbStartPageUrl.Text = openFileDialog1.FileName;
 
            }
        }





        private void formCustom_Load(object sender, EventArgs e)
        {



            this.tbStartPageUrl.Text = Properties.Settings.Default.GadgetsStartPageUrl.ToString();
            this.trackBar1.Value = (int)(Properties.Settings.Default.GadgetsOpacity * 10);
            this.tbTitleName.Text = Properties.Settings.Default.GadgetsTitleName;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GadgetsOpacity = (double)trackBar1.Value / 10;
            Properties.Settings.Default.GadgetsTitleName = this.tbTitleName.Text; 

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.GadgetsFixed = this.chkboxFixed.Checked;



            if (Properties.Settings.Default.GadgetsFixed)
            
            {
                MessageBox.Show("true");
                Program.formGadgetsInstance.FormBorderStyle = FormBorderStyle.None;
                Program.formGadgetsInstance.ShowInTaskbar = false;
            }

            else
            
            {
                MessageBox.Show("false");
                Program.formGadgetsInstance.FormBorderStyle = FormBorderStyle.Sizable;
                Program.formGadgetsInstance.ShowInTaskbar = true;
            }
        }
    }





}
