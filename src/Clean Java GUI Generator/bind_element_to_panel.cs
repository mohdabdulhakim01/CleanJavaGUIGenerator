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
    public partial class bind_element_to_panel : Form
    {
        public string element_name = "";
        public string element_type = "";
        public string bind_to_panel = "";
        public string element_value = "";
        public string element_value2 = "";
        public string short_obj_type = "";
        public string image_file_path = "";
        public string container_max_height = "";
        public string container_max_width = "";
        public void setElementobjname(string elementobjname)
        {
            element_name_inp.Text = elementobjname;
        }
        public bind_element_to_panel()
        {
            InitializeComponent();
            component_type.SelectedIndex = 2;
           
        }

        private void bind_element_to_panel_Load(object sender, EventArgs e)
        {

        }

        private void bindelement_Click(object sender, EventArgs e)
        {
            element_name = element_name_inp.Text;
            bind_to_panel = bindtoObject.SelectedItem.ToString();
            element_type = component_type.SelectedItem.ToString();
            element_value = elementvalue.Text;
            element_value2 = elementvalue2.Text;
            
            this.Close();
        }
        void form_elem_display(Boolean element_name, Boolean bind_to_panel, Boolean element_type, Boolean element_value, Boolean element_value2, Boolean choose_file)
        {
            image_name_lbl.Hide();
            if (element_name == false) { element_name_inp.Hide(); objname_title.Hide(); } else { element_name_inp.Show(); objname_title.Show(); }
            if (bind_to_panel == false) { bindtoObject.Hide(); bindtopanel_title.Hide(); } else { bindtoObject.Show(); bindtopanel_title.Show(); }
            if (element_type == false) { component_type.Hide(); type_title.Hide(); } else { component_type.Show(); type_title.Show(); }
            if (element_value == false) { elementvalue.Hide(); elem_val_title.Hide(); } else { elementvalue.Show(); elem_val_title.Show(); }
            if (element_value2 == false) { elementvalue2.Hide(); value2_title.Hide(); } else { elementvalue2.Show(); value2_title.Show(); }
            if (choose_file == false) { of_bindfilepath.Hide(); } else { of_bindfilepath.Show(); }
        }
        public void settoBindObjList(List<string> objlist)
        {
            string[] toArrObjList = objlist.ToArray();
            string target = "_Pnl",target2 = "_Panel";
            List<string>  PanelList = new List<string>(); 
            for(int x = 0;x<toArrObjList.Length;x++)
            {
                if ((toArrObjList[x].Contains(target)) || (toArrObjList[x].Contains(target2)))
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
                MessageBox.Show("Please add JPanel first before adding element");
            }
            
        }

        private void elementvalue_TextChanged(object sender, EventArgs e)
        {

        }

        private void component_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (component_type.SelectedItem.ToString())
            {
                // form_elem_display(Boolean element_name, Boolean bind_to_panel, Boolean element_type, Boolean element_value, Boolean element_value2, Boolean choose_file)
        
                case "JLabel":
                    elem_val_title.Text = "JLabel Title : ";
                    elementvalue.Text = "Untitled Label";
                    short_obj_type = "_JLbl";
                    comp_obj_last_name.Text = element_name_inp.Text + short_obj_type;
                    form_elem_display(true, true, true, true, false,false);
                    break;
                case "JButton":
                    elem_val_title.Text = "JButton Title";
                    elementvalue.Text = "Untitled Button";
                    short_obj_type = "_JBtn";
                    comp_obj_last_name.Text = element_name_inp.Text + short_obj_type;
                    form_elem_display(true, true, true,true, false, false);
                    break;
                case "JTextField":
                    elem_val_title.Text = "Width : ";
                    elementvalue.Text = "15";
                    value2_title.Text = "Initial Text : ";
                    elementvalue2.Text = "";
                    short_obj_type = "_TField";
                    comp_obj_last_name.Text = element_name_inp.Text + short_obj_type;
                    form_elem_display(true, true, true, true, true, false);
                    break;
                case "JTextArea":
                    elem_val_title.Text = "Rows,Cols : ";
                    elementvalue.Text = "4,10";
                    value2_title.Text = "Initial Text : ";
                    elementvalue2.Text = "";
                    short_obj_type = "_TArea";
                    comp_obj_last_name.Text = element_name_inp.Text + short_obj_type;
                    form_elem_display(true, true, true,true, true, false);
                    break;
                case "JTable":
                    elem_val_title.Text = "Column Title : ";
                    elementvalue.Text = "\"Column 1\",\"Column 2\",\"Column 3\"";
                    value2_title.Text = "Row Count";
                    elementvalue2.Text = "8";
                    short_obj_type = "_TArea";
                    comp_obj_last_name.Text = element_name_inp.Text + short_obj_type;
                    form_elem_display(true, true, true, true, true, false);
                    break;
                case "JRadioButton":
                    elem_val_title.Text = "RadioButton List : ";
                    elementvalue.Text = "Option 1,Option 2,Option 3";
                    short_obj_type = "_JRBtn";
                    comp_obj_last_name.Text = element_name_inp.Text + short_obj_type;
                    form_elem_display(true, true, true, true, false, false);
                    break;
                case "JCheckBox":
                    elem_val_title.Text = "CheckBox List : ";
                    elementvalue.Text = "Option 1,Option 2,Option 3";
                    short_obj_type = "_JCBox";
                    comp_obj_last_name.Text = element_name_inp.Text + short_obj_type;
                    form_elem_display(true, true, true, true, false, false);
                    break;
                case "JSeparator":
                    elem_val_title.Text = "Title";
                    elementvalue.Text = "SwingConstants.HORIZONTAL";
                    short_obj_type = "_JSep";
                    comp_obj_last_name.Text = element_name_inp.Text + short_obj_type;
                    form_elem_display(false,true,true,true,false,false);
                    break;
                case "EmptyHeight":
                    elem_val_title.Text = "Height";
                    elementvalue.Text = "Height";
                    short_obj_type = "_HeightEmpty";
                    comp_obj_last_name.Text = element_name_inp.Text + short_obj_type;
                    form_elem_display(false, true, true, true, false, false);
                    break;
                case "ImageIcon":
                    of_bindfilepath.Text = "Choose Image. . .";
                    elem_val_title.Text = "Width : ";
                    elementvalue.Text = container_max_width;
                    value2_title.Text = "Height : ";
                    elementvalue2.Text = container_max_height;
                    short_obj_type = "_ImgIcon"; 
                    comp_obj_last_name.Text = element_name_inp.Text + short_obj_type;
                    form_elem_display(true,true,true,true,true,true);
                    break;
                
            }
        }
        public void getMaxContainerHeight(string form_size_width, string form_size_height)
        {
            container_max_height = form_size_height;
            container_max_width = form_size_width;
        }
        private void element_name_inp_TextChanged(object sender, EventArgs e)
        {
            comp_obj_last_name.Text = element_name_inp.Text + short_obj_type;
        }

        private void of_bindfilepath_Click(object sender, EventArgs e)
        {

            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                 image_file_path = choofdlog.FileName;
                 image_name_lbl.Text = image_file_path;
                 image_name_lbl.Show();
            }
        }

        public void setcurrentpick(string currentcomponent)
        {
            component_type.SelectedItem = currentcomponent;
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
