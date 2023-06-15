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
    public partial class bind_data_to_obj : Form
    {
 
        public string optionvalue = "";
        public string objname = "";
        public string bindtoobj = "";

        public bind_data_to_obj()
        {
            InitializeComponent();
            
        }

        private void bind_data_to_obj_Load(object sender, EventArgs e)
        {

        }
      
        public void hideOptionBindValue(Boolean hideval)
        {
            if (hideval)
            {
                lblBindValue.Hide();
                valueBindData.Hide();
            }
            else
            {
                lblBindValue.Show();
                valueBindData.Show();
            }
        }
        public void hideOptionBindToObj(Boolean hideval)
        {
            if (hideval)
            {
                BindToObj.Hide();
                cb_bindto.Hide();
            }
            else
            {
                lblBindValue.Show();
                cb_bindto.Show();
            }
        }
        public void hideOptionBindObjName(Boolean hideval)
        {
            if (hideval)
            {
                objName.Hide();
                lblObjName.Hide();
            }
            else
            {
                objName.Show();
                lblObjName.Show();
            }
        }
        public void bindvalueTitle(string title)
        {
            lblBindValue.Text = title;
        }
        public void bindObjName(string title)
        {
            lblObjName.Text = title;
        }
        public void bindvalueData(string data)
        {
            valueBindData.Text = data;
        }

        private void bind_data_Click(object sender, EventArgs e)
        {
            bindData();
        }

        void bindData()
        {
            optionvalue = valueBindData.Text;
            objname = objName.Text;
            bindtoobj = cb_bindto.SelectedItem.ToString();

            this.Close();
        }
        public void settoBindObjList(List<string> objlist)
        {
            cb_bindto.Items.AddRange(objlist.ToArray());
            cb_bindto.SelectedIndex = 0;
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            string RColor = colorDialog1.Color.R.ToString();
            string GColor = colorDialog1.Color.G.ToString();
            string BColor = colorDialog1.Color.B.ToString();
            string rgb_value = RColor + "," + GColor + "," + BColor;
            valueBindData.Text = rgb_value;
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
