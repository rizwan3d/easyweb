namespace Easy_Web
{
    partial class Color
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Color));
            this.textcolor = new DevExpress.XtraEditors.CheckEdit();
            this.tcolor = new DevExpress.XtraEditors.ColorPickEdit();
            this.bcolor = new DevExpress.XtraEditors.ColorPickEdit();
            this.backgroundcolor = new DevExpress.XtraEditors.CheckEdit();
            this.borcolor = new DevExpress.XtraEditors.ColorPickEdit();
            this.border = new DevExpress.XtraEditors.CheckEdit();
            this.ocolor = new DevExpress.XtraEditors.ColorPickEdit();
            this.outlinecolor = new DevExpress.XtraEditors.CheckEdit();
            this.tdcolor = new DevExpress.XtraEditors.ColorPickEdit();
            this.textdecorationcolor = new DevExpress.XtraEditors.CheckEdit();
            this.apply = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textcolor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcolor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcolor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundcolor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcolor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocolor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlinecolor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdcolor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textdecorationcolor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textcolor
            // 
            this.textcolor.Location = new System.Drawing.Point(15, 11);
            this.textcolor.Name = "textcolor";
            this.textcolor.Properties.Caption = "Color";
            this.textcolor.Size = new System.Drawing.Size(204, 19);
            this.textcolor.TabIndex = 0;
            // 
            // tcolor
            // 
            this.tcolor.EditValue = System.Drawing.Color.Empty;
            this.tcolor.Location = new System.Drawing.Point(225, 11);
            this.tcolor.Name = "tcolor";
            this.tcolor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tcolor.Size = new System.Drawing.Size(100, 20);
            this.tcolor.TabIndex = 3;
            this.tcolor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tcolor_KeyDown);
            // 
            // bcolor
            // 
            this.bcolor.EditValue = System.Drawing.Color.Empty;
            this.bcolor.Location = new System.Drawing.Point(225, 37);
            this.bcolor.Name = "bcolor";
            this.bcolor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.bcolor.Size = new System.Drawing.Size(100, 20);
            this.bcolor.TabIndex = 5;
            this.bcolor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tcolor_KeyDown);
            // 
            // backgroundcolor
            // 
            this.backgroundcolor.Location = new System.Drawing.Point(15, 37);
            this.backgroundcolor.Name = "backgroundcolor";
            this.backgroundcolor.Properties.Caption = "Background-Color";
            this.backgroundcolor.Size = new System.Drawing.Size(204, 19);
            this.backgroundcolor.TabIndex = 4;
            // 
            // borcolor
            // 
            this.borcolor.EditValue = System.Drawing.Color.Empty;
            this.borcolor.Location = new System.Drawing.Point(225, 63);
            this.borcolor.Name = "borcolor";
            this.borcolor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.borcolor.Size = new System.Drawing.Size(100, 20);
            this.borcolor.TabIndex = 7;
            this.borcolor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tcolor_KeyDown);
            // 
            // border
            // 
            this.border.Location = new System.Drawing.Point(15, 63);
            this.border.Name = "border";
            this.border.Properties.Caption = "Border Color ";
            this.border.Size = new System.Drawing.Size(204, 19);
            this.border.TabIndex = 6;
            // 
            // ocolor
            // 
            this.ocolor.EditValue = System.Drawing.Color.Empty;
            this.ocolor.Location = new System.Drawing.Point(225, 89);
            this.ocolor.Name = "ocolor";
            this.ocolor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ocolor.Size = new System.Drawing.Size(100, 20);
            this.ocolor.TabIndex = 9;
            this.ocolor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tcolor_KeyDown);
            // 
            // outlinecolor
            // 
            this.outlinecolor.Location = new System.Drawing.Point(15, 89);
            this.outlinecolor.Name = "outlinecolor";
            this.outlinecolor.Properties.Caption = "Outline-Color";
            this.outlinecolor.Size = new System.Drawing.Size(204, 19);
            this.outlinecolor.TabIndex = 8;
            // 
            // tdcolor
            // 
            this.tdcolor.EditValue = System.Drawing.Color.Empty;
            this.tdcolor.Location = new System.Drawing.Point(225, 115);
            this.tdcolor.Name = "tdcolor";
            this.tdcolor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tdcolor.Size = new System.Drawing.Size(100, 20);
            this.tdcolor.TabIndex = 11;
            this.tdcolor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tcolor_KeyDown);
            // 
            // textdecorationcolor
            // 
            this.textdecorationcolor.Location = new System.Drawing.Point(15, 115);
            this.textdecorationcolor.Name = "textdecorationcolor";
            this.textdecorationcolor.Properties.Caption = "Text Decoration Color";
            this.textdecorationcolor.Size = new System.Drawing.Size(204, 19);
            this.textdecorationcolor.TabIndex = 10;
            // 
            // apply
            // 
            this.apply.Location = new System.Drawing.Point(250, 141);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(75, 23);
            this.apply.TabIndex = 14;
            this.apply.Text = "Apply";
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 176);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.tdcolor);
            this.Controls.Add(this.textdecorationcolor);
            this.Controls.Add(this.ocolor);
            this.Controls.Add(this.outlinecolor);
            this.Controls.Add(this.borcolor);
            this.Controls.Add(this.border);
            this.Controls.Add(this.bcolor);
            this.Controls.Add(this.backgroundcolor);
            this.Controls.Add(this.tcolor);
            this.Controls.Add(this.textcolor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinMaskColor = System.Drawing.Color.Transparent;
            this.LookAndFeel.SkinName = "Visual Studio 2013 Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Color";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color";
            this.Load += new System.EventHandler(this.Color_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textcolor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcolor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bcolor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundcolor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borcolor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ocolor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outlinecolor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdcolor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textdecorationcolor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit textcolor;
        private DevExpress.XtraEditors.ColorPickEdit tcolor;
        private DevExpress.XtraEditors.ColorPickEdit bcolor;
        private DevExpress.XtraEditors.CheckEdit backgroundcolor;
        private DevExpress.XtraEditors.ColorPickEdit borcolor;
        private DevExpress.XtraEditors.CheckEdit border;
        private DevExpress.XtraEditors.ColorPickEdit ocolor;
        private DevExpress.XtraEditors.CheckEdit outlinecolor;
        private DevExpress.XtraEditors.ColorPickEdit tdcolor;
        private DevExpress.XtraEditors.CheckEdit textdecorationcolor;
        private DevExpress.XtraEditors.SimpleButton apply;
    }
}