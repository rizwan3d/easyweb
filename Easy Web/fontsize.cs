using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Easy_Web
{
    public partial class FontSize : DevExpress.XtraEditors.XtraForm
    {
        public FontSize()
        {
            InitializeComponent();
        }

        private void FontSize_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.Items.Add("px");
            comboBoxEdit1.Properties.Items.Add("%");
            comboBoxEdit1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Form1"];
            ((Form1)f).parser.SetCSS(((Form1)f).csstext.Text);
            ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText,"font-size", textEdit1.Text + comboBoxEdit1.Text);
            ((Form1)f).csstext.Text = ((Form1)f).parser.ToString();
            this.Close();       
        }

        private void FontSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                simpleButton1.PerformClick();
            }
        }
    }
}