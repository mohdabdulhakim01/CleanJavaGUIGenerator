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
    public partial class autofill_panel : Form
    {
        public string bindto = "";
        public string component_type = "";
        public string count = "";
        public autofill_panel()
        {
            InitializeComponent();
        }

        private void autofill_panel_Load(object sender, EventArgs e)
        {
            af_comp_Type.Text = "EmptyFill";
        }

        private void bind_data_Click(object sender, EventArgs e)
        {
            bindto = af_bindto.SelectedItem.ToString();
            component_type = af_comp_Type.SelectedItem.ToString() ;
            count = af_valueBindData.Text;
            this.Close();
        }
        public void setToBindAutoFillList(List<string> objlist)
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

            af_bindto.Items.AddRange(PanelList.ToArray());
            try
            {
                af_bindto.SelectedIndex = 0;
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
