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
using System.IO;

namespace Easy_Web
{
    public partial class BImage : DevExpress.XtraEditors.XtraForm
    {
        string[] ImagePath;


        public BImage(string[] imagepath)
        {
            InitializeComponent();
            ImagePath = imagepath;
        }

        private void BImage_Load(object sender, EventArgs e)
        {
            foreach (string imgn in ImagePath)
                listBoxControl1.Items.Add(imgn);
        }

        private void listBoxControl1_Click(object sender, EventArgs e)
        {
            if(listBoxControl1.SelectedItem != null)
                pictureEdit1.Image = new Bitmap(listBoxControl1.SelectedItem.ToString());
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Form1"];

            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                ((Form1)f).pf[((Form1)f).pfco].name = Path.GetFileName(of.FileName);
                File.Copy(of.FileName, ((Form1)f).path + "\\img\\" + ((Form1)f).pf[((Form1)f).pfco].name);
                ((Form1)f).pf[((Form1)f).pfco].path = ((Form1)f).path + "\\img\\" + ((Form1)f).pf[((Form1)f).pfco].name;
                ((Form1)f).iame_file_list.Items.Add(((Form1)f).pf[((Form1)f).pfco].name, 2);
                ((Form1)f).status.Caption = "Image Added";
                listBoxControl1.Items.Add(((Form1)f).path + "\\img\\" + ((Form1)f).pf[((Form1)f).pfco].name);
                ((Form1)f).pfco++;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Form f = Application.OpenForms["Form1"];
            ((Form1)f).applaycss("background-image: url(\"" + listBoxControl1.SelectedItem.ToString() + "\");");
            this.Close();
        }
    }
}