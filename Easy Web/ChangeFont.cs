﻿using System;
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
    public partial class ChangeFont : DevExpress.XtraEditors.XtraForm
    {
        public ChangeFont()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            RadioGroupItem item1 = new RadioGroupItem();
            item1.Description = "Windows Font";
            RadioGroupItem item2 = new RadioGroupItem();
            item2.Description = "Custom font";

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
                textEdit1.Enabled = true;
                fontEdit1.Enabled = false;
            }
            else
            {
                textEdit1.Enabled = false;
                fontEdit1.Enabled = true;
            }


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Form1"];
            if (radioGroup1.SelectedIndex == 1)
            {
                ((Form1)f).parser.SetCSS(((Form1)f).csstext.Text);
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "font-family", "\"" + textEdit1.Text + "\"");
                ((Form1)f).csstext.Text = ((Form1)f).parser.ToString();
            }
            else
            {
                ((Form1)f).parser.SetCSS(((Form1)f).csstext.Text);
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "font-family", "\"" + fontEdit1.Text + "\"");
                ((Form1)f).csstext.Text = ((Form1)f).parser.ToString();
            }
            this.Close();
        }

        private void ChangeFont_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                simpleButton1.PerformClick();
            }
        }
    }
}