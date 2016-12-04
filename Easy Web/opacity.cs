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
    public partial class opacity : DevExpress.XtraEditors.XtraForm
    {

        float op = 1.0f;

        public opacity()
        {
            InitializeComponent();
        }

        private void trackBarControl1_EditValueChanged(object sender, EventArgs e)
        {
            op = (float)trackBarControl1.Value / 10.0f;
            label2.Text = op.ToString() + " %";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Form1"];
            ((Form1)f).parser.SetCSS(((Form1)f).csstext.Text);
            ((Form1)f).parser.AddPropery(((Form1)f).htmltext.SelectedText, "opacity" ,op.ToString());
            ((Form1)f).csstext.Text = ((Form1)f).parser.ToString();
            this.Close();
        }

        private void opacity_Load(object sender, EventArgs e)
        {

        }
    }
}