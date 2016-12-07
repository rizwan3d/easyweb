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
using DevExpress.XtraEditors.Controls;

namespace Easy_Web
{
    public partial class borderwidth : DevExpress.XtraEditors.XtraForm
    {
        public borderwidth()
        {
            InitializeComponent();
        }

        private void borderwidth_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.Items.Add("px");
            comboBoxEdit1.Properties.Items.Add("%");
            comboBoxEdit1.SelectedIndex = 0;

            RadioGroupItem item1 = new RadioGroupItem();
            item1.Description = "Fixed";
            RadioGroupItem item2 = new RadioGroupItem();
            item2.Description = "Custom";

            radioGroup1.Properties.Items.Add(item1);
            radioGroup1.Properties.Items.Add(item2);
            radioGroup1.Name = "radioEdit1";

            radioGroup1.SelectedIndexChanged += RadioEdit1_SelectedIndexChanged;
            radioGroup1.SelectedIndex = 0;
        }

        private void RadioEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radioGroup1.SelectedIndex == 1)
            {
                textEdit1.Enabled = false;
                textEdit2.Enabled = true;
                textEdit3.Enabled = true;
                textEdit4.Enabled = true;
                textEdit5.Enabled = true;
            }
            else
            {
                textEdit1.Enabled = true;
                textEdit2.Enabled = false;
                textEdit3.Enabled = false;
                textEdit4.Enabled = false;
                textEdit5.Enabled = false;
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Form1"];
            if (radioGroup1.SelectedIndex == 0)
            {
                ((Form1)f).parser.SetCSS(((Form1)f).csstext.Text);
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "border-width", textEdit1.Text + comboBoxEdit1.Text);
                ((Form1)f).csstext.Text = ((Form1)f).parser.ToString();
            }

            else
            {
                ((Form1)f).parser.SetCSS(((Form1)f).csstext.Text);
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "border-bottom-width" , textEdit5.Text + comboBoxEdit1.Text);
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "border-right-width" , textEdit4.Text + comboBoxEdit1.Text);
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "border-left-width" , textEdit3.Text + comboBoxEdit1.Text );
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "border-top-width" , textEdit2.Text + comboBoxEdit1.Text );
                ((Form1)f).csstext.Text = ((Form1)f).parser.ToString();
            }
            this.Close();
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                simpleButton1.PerformClick();
            }
        }
    }
}