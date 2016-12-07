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
    public partial class Color : DevExpress.XtraEditors.XtraForm
    {
        public Color()
        {
            InitializeComponent();           
        }  
        private void Color_Load(object sender, EventArgs e)
        {
            tcolor.CustomDisplayText += Tcolor_CustomDisplayText;
            bcolor.CustomDisplayText += Tcolor_CustomDisplayText;
            borcolor.CustomDisplayText += Tcolor_CustomDisplayText;
            tdcolor.CustomDisplayText += Tcolor_CustomDisplayText;
            outlinecolor.CustomDisplayText += Tcolor_CustomDisplayText;
        }
        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
        private void Tcolor_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            e.DisplayText = HexConverter((sender as ColorPickEdit).Color);                
        }    
        private void apply_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Form1"];
            if (textcolor.Checked)
            {
                ((Form1)f).parser.SetCSS(((Form1)f).csstext.Text);
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "color", HexConverter(tcolor.Color));
                ((Form1)f).csstext.Text = ((Form1)f).parser.ToString();
            }
            if (backgroundcolor.Checked)
            {
                ((Form1)f).parser.SetCSS(((Form1)f).csstext.Text);
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "background-color", HexConverter(bcolor.Color));
                ((Form1)f).csstext.Text = ((Form1)f).parser.ToString();
            }
            if (border.Checked)
            {
                ((Form1)f).parser.SetCSS(((Form1)f).csstext.Text);
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "border-color", HexConverter(borcolor.Color));
                ((Form1)f).csstext.Text = ((Form1)f).parser.ToString();
            }
            if (outlinecolor.Checked)
            {
                ((Form1)f).parser.SetCSS(((Form1)f).csstext.Text);
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "outline-color", HexConverter(ocolor.Color));
                ((Form1)f).csstext.Text = ((Form1)f).parser.ToString();
            }
            if (textdecorationcolor.Checked)
            {
                ((Form1)f).parser.SetCSS(((Form1)f).csstext.Text);
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "text-decoration-color", HexConverter(tdcolor.Color));
                ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "-moz-text-decoration-color", HexConverter(tdcolor.Color));
                ((Form1)f).csstext.Text = ((Form1)f).parser.ToString();
            }
            this.Close();
        }

        private void tcolor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            
                apply.PerformClick();
            
        }
    }
}