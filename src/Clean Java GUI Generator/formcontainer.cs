using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clean_Java_GUI_Generator
{
    public partial class formcontainer : Form
    {
        public string classname;
        public string title;
        public Boolean addmainclass;
        public string layout_type;
        public string sizewidth;
        public string sizeheight;
        public Boolean visibility;
        public formcontainer()
        {
            InitializeComponent();
            layouttype_lb.SelectedIndex = 1;

        }

        private void formcontainer_Load(object sender, EventArgs e)
        {
           
        }

        private void generate_gui_Click(object sender, EventArgs e)
        {
            classname = classname_inp.Text;
            title = txtTitle_inp.Text;
            addmainclass = chkbox_addmainclass.Checked;
            visibility = chckVisibility.Checked;
            layout_type = layouttype_lb.SelectedItem.ToString();
            sizewidth = txtSizeWidth.Text;
            sizeheight = txtSizeHeight.Text;
            this.Close();
        }
        public void setcurrentlayouttype(string layout_type)
        {
            layouttype_lb.Text = layout_type;
        }
        public void setformsetting(string classname,string title,Boolean addmainclass,Boolean visibility,string layout_type,string sizewidth,string sizeheight)
        {

            classname_inp.Text = classname;
            txtTitle_inp.Text = title;
            chkbox_addmainclass.Checked = addmainclass;
            chckVisibility.Checked = visibility;
            layouttype_lb.Text = layout_type;
            txtSizeWidth.Text = sizewidth;
            txtSizeHeight.Text = sizeheight;
        }
        public Boolean prematureclose = false;
        public bool ClosedByXButtonOrAltF4 { get; private set; }
        private const int SC_CLOSE = 0xF060;
        private const int WM_SYSCOMMAND = 0x0112;
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == WM_SYSCOMMAND && msg.WParam.ToInt32() == SC_CLOSE)
                ClosedByXButtonOrAltF4 = true;
            base.WndProc(ref msg);
        }
        protected override void OnShown(EventArgs e)
        {
            ClosedByXButtonOrAltF4 = false;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (ClosedByXButtonOrAltF4)
                prematureclose = true;
            else
                prematureclose = false;
        }
     
    }
}
