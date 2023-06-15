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
    public partial class sqlfilltable : Form
    {
        public sqlfilltable()
        {
            InitializeComponent();
        }

        private void sqlfilltable_Load(object sender, EventArgs e)
        {

        }
        public void settoSQLFillTable(List<string> objlist)
        {
            string[] toArrObjList = objlist.ToArray();
            string target = "_JTbl";
            List<string> PanelList = new List<string>();
            for (int x = 0; x < toArrObjList.Length; x++)
            {
                if ((toArrObjList[x].Contains(target)))
                {
                    PanelList.Add(toArrObjList[x]);

                }
            }
            bindtoObject.Items.AddRange(PanelList.ToArray());
            try
            {
                bindtoObject.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show("Please add JTable first before generating this function");
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

        private void passwordtext_TextChanged(object sender, EventArgs e)

        {
            generateresult();
            }

        void generateresult()
        {
            generatedresult.Text = "FillTable(" + bindtoObject.SelectedItem.ToString() + ",\"SELECT * FROM " + tablename.Text + " " + sqlcondition.Text + ";\");";

        }

        private void bindtoObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateresult();
        }

        private void sqlcondition_TextChanged(object sender, EventArgs e)
        {
            generateresult();
        }

        private void generatedresult_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void generatedresult_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            generatedresult.SelectAll();
            Clipboard.SetText(generatedresult.Text);
            MessageBox.Show("Generated Code Copied !");
        }
        
    }
}
