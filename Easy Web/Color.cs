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
            if(textcolor.Checked)
                ((Form1)f).applaycss("color:" + HexConverter(tcolor.Color) + ";");
            if(backgroundcolor.Checked)
                ((Form1)f).applaycss("background-color:" + HexConverter(bcolor.Color) + ";");
            if (border.Checked)
                ((Form1)f).applaycss("background-color:" + HexConverter(borcolor.Color) + ";");
            if (outlinecolor.Checked)
                ((Form1)f).applaycss("background-color:" + HexConverter(ocolor.Color) + ";");
            if (textdecorationcolor.Checked)
                ((Form1)f).applaycss("background-color:" + HexConverter(tdcolor.Color) + ";");
            this.Close();
        }
        
    }
}