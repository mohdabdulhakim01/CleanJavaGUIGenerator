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
    public partial class formfield_binder : Form
    { // FFieldTitle FFieldObjectName FFieldBindtoObj component_type FFieldField_lb 
        public string object_name = "";
        public string title = "";
        public string bindtoobj = "";
        public string componenttype = "";
        public string formfield_pos_type = "";

        public void setFFobjname(string formfieldname)
        {
            FFieldObjectName.Text = formfieldname;
            
        }
        public formfield_binder()
        {
            InitializeComponent();
            component_type.SelectedIndex = 5;
            FFieldField_lb.SelectedIndex = 0;
           
        }

        private void FFieldaddcode_Click(object sender, EventArgs e)
        {
            if (FFieldField_lb.SelectedIndex == 0)
            {
                formfield_pos_type = "GridLayout(1,2)";
            }
            if (FFieldField_lb.SelectedIndex == 1)
            {
                formfield_pos_type = "GridLayout(2,1)";
            }
            object_name = FFieldObjectName.Text;
            title = FFieldTitle.Text;
            bindtoobj = FFieldBindtoObj.SelectedItem.ToString();
            componenttype = component_type.SelectedItem.ToString();
           
            this.Close();
           
        }

        private void formfield_binder_Load(object sender, EventArgs e)
        {
           
        }
        public void setToBindFormFieldList(List<string> objlist)
        {
            string[] toArrObjList = objlist.ToArray();
            string target = "_Pnl", target2 = "_Panel";
            string filter = "FormField_";
            List<string> PanelList = new List<string>();
            for (int x = 0; x < toArrObjList.Length; x++)
            {
                if ((toArrObjList[x].Contains(target)) || (toArrObjList[x].Contains(target2)))
                {
                    if ((!toArrObjList[x].Contains(filter)))
                    {
                        PanelList.Add(toArrObjList[x]);

                    }

                }
            }
           
            FFieldBindtoObj.Items.AddRange(PanelList.ToArray());
            try
            {
                FFieldBindtoObj.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show("Please add JPanel first before adding element");
            }

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
