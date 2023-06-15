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
    public partial class bind_panel_to_obj : Form
    {
        public string element_name = "";
        public string bind_to_obj = "";
        public string layouttype = "";
        public string layout_param = "";
        public bind_panel_to_obj()
        {
            InitializeComponent();
            Panellayout_lb.SelectedIndex = 0;
        }

        private void bind_panel_to_obj_Load(object sender, EventArgs e)
        {

        }
        public void panelinc(int num)
        {
            PanelobjName.Text = "JPanel_"+num.ToString();
        }
        private void Paneladdcode_Click(object sender, EventArgs e)
        {
             element_name = PanelobjName.Text;
            bind_to_obj = PanelbindToObject.SelectedItem.ToString();
            layouttype = Panellayout_lb.SelectedItem.ToString();
            layout_param = PanellayoutParam.Text;
            this.Close();
        }
        public void settoBindObjList(List<string> objlist)
        {
            PanelbindToObject.Items.AddRange(objlist.ToArray());
            PanelbindToObject.SelectedIndex = 0;
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

        private void Panellayout_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string choice = Panellayout_lb.SelectedItem.ToString();
            switch (choice)
            {

                case "BoxLayout":
                    PanellayoutParam.Text = "BoxLayout.X_AXIS";
                    break;
                case "BorderLayout":
                    PanellayoutParam.Text = "5,5";
                    break;

                case "GridLayout":
                    PanellayoutParam.Text = "0,1";
                    break;

                case "FlowLayout":
                    PanellayoutParam.Text = "FlowLayout.CENTER";
                    break;
            }

        }
     
    }
}
