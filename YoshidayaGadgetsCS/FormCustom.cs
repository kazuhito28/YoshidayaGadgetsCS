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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            // TrackBarの値が変更されたらラベルに表示
            label2.Text = trackBar1.Value.ToString()+"%";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)((trackBar1.Value / 10) * 10);
        }
    }
}
