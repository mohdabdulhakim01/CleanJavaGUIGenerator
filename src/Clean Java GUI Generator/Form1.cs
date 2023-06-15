using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;
namespace Clean_Java_GUI_Generator
{
    public partial class Form1 : Form
    {
        public string classname = "Default";
        public string title = "Untitled App";
        public Boolean addmainclass = true;
        public string layout_type = "BorderLayout";
        public Boolean visibilityform = true;
        public string form_size_width = "600";
        public string form_size_height = "400";
        public int labelinc = 1;
        public int formfield = 1;
        public int headtitle = 1;
        public int checkboxctr = 1;
        public int radiobtnctr = 1;
        public int autogridblank = 1;
        public int autogridbtn = 1;
        public int componentinc = 1;
        public int panelinc = 1;


        string current_selected_component = "JLabel";
        List<String> savedObjectList = new List<String>();
        public Form1()
        {
            
            InitializeComponent();
         
            generate_gui_class();
            
            savedObjectList.Add("innerContainer");

           
        }

      
        void generate_gui_all()
        {
            string template_generated_head = generate_class_template("head");
            string template_generated_end = generate_class_template( "end");
            string class_contructor = sc_class_contructor.Text;
            string element_declaration = GUI_component_combine(class_contructor, sc_element_declareTxt.Text, "\t//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_ELEMENT_DECLARATION");
            string form_element = GUI_component_combine(element_declaration, sc_form_element.Text, "\t//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_FORM_ELEMENT");
            string bind_setting = GUI_component_combine(form_element, sc_bind_setting.Text, "\t//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_BIND_SETTING");
            string function_template = GUI_component_combine(bind_setting, sc_funct_template.Text, "\t//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_FUNCTION_TEMPLATE");
            string combined_body = function_template;
   
            sc_class.Text = "";
            sc_class.Text = template_generated_head + "\n" + template_generated_end;
            //generate_form(txtTitle.Text, classname, layouttype_lb.SelectedItem.ToString(), txtSizeWidth.Text, txtSizeHeight.Text, chckVisibility.Checked, form_element);
           
            //library
            //head
	        //    element declaration
	        //    class contructor
		    //        //
		    //        form element 
		    //        //
		    //
		    //        bind setting
		    //
		    //
	        //    main
            //end
            sc_full.Text = template_generated_head + "\n" +
                          combined_body +
                           template_generated_end;
        }
        void generate_gui_class()
        {
            string template_generated_head = generate_class_template("head");
            string template_generated_end = generate_class_template("end");
            // string title,string classname,string width,string height,string visibility, string element
            generate_class_contructor(title, classname, layout_type, form_size_width, form_size_height, visibilityform);
            string template_body = sc_class_contructor.Text;
            sc_class.Text = "";
            sc_class.Text = template_generated_head + "\n" + template_generated_end ;

            // generate full body
            
        }
        string listenerGenerate()
        {
            string ActionListener = "\t@Override\n"+
                                    "\tpublic void actionPerformed(ActionEvent e) {}\n";
            string ItemListener = "\t@Override\n" +
                                   "\tpublic void itemStateChanged(ItemEvent e){}\n";
            string listener = ActionListener + ItemListener;
            return listener;
        }
        string generate_class_template(string type)
        {
          
            var mainclass = "";
            if (type == "head")
            {
                string template_head = "import java.awt.*;\n" +
                              "import java.awt.event.*;\n" +
                              "import javax.swing.*;\n" +
                              "import java.sql.*;\n"+
                               "import net.proteanit.sql.DbUtils;\n" +
                                "import javax.swing.table.DefaultTableModel;\n" +
                              "public class " + classname + " extends JFrame  implements  ActionListener,ItemListener{\n" +
                              "\tContainer container = getContentPane();\n";
                return template_head;
            }
            if (type == "end")
            {
                string template_end = "";
                if (addmainclass == false)
                {
                    template_end += "\t}\n}";
                    return template_end;
                }
                else
                {
                    template_end += "\tpublic static void main(String[] args) {\n" +
                                   "\t\t" + classname + " app = new " + classname + "();\n" +
                                    "\t\tapp.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);\n" +
                                    "\t}\n"+
                                    listenerGenerate()+
                                    "}\n";

                    return template_end;
                }
            }
            
            return "";


        }
        void generate_class_contructor(string title, string classname, string layouttype, string width, string height, Boolean visibility)
        {
            string widthmaxInnerContainer = (Int32.Parse(width)-10).ToString();
            string heightmaxInnerContainer = (Int32.Parse(height)-10).ToString();
            string bodylayout = "";
            if (layouttype == "BoxLayout") { bodylayout = "BoxLayout(this,BoxLayout.Y_AXIS)"; }
            if (layouttype == "BorderLayout"){bodylayout = "BorderLayout(5,5)";}
            if (layouttype == "FlowLayout") { bodylayout = "FlowLayout()"; }
            if (layouttype == "GridLayout") { bodylayout = "GridLayout(1,1)"; }
            string body = "\tJPanel innerContainer;\n"+
                           "\t//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_ELEMENT_DECLARATION" +
                          "\n\tpublic " + classname + "(){\n" +
                          "\t\tinnerContainer = new JPanel();\n" +
                          "\t\tinnerContainer.setLayout(new " + bodylayout + ");\n" +
                          "\t\tcontainer.setLayout(new FlowLayout());\n" +
                          "\n\t\t// Form Element Start \n" +
                           "\t//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_FORM_ELEMENT" +
                          "\n\t\t// Form Element End \n\n" +
                          "\n\t\t// Bind Element Start \n\n" +
                          "\t//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_BIND_SETTING" +
                          "\n\t\t// Bind Element End \n\n" +
                           "\t\tcontainer.add(innerContainer);\n" +
                          "\t\tsetSize(" + width + "," + height + ");\n" +
                          "\t\tinnerContainer.setPreferredSize(new Dimension(" + widthmaxInnerContainer + "," + heightmaxInnerContainer + "));\n" +
                          "\t\tsetVisible(" + visibility.ToString().ToLower() + ");\n" +
                          "\t\tsetTitle(\"" + title + "\");\n" +
                          "\t}"+
                          "\t//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_FUNCTION_TEMPLATE\n";
            
            sc_class_contructor.Text = body;
        }
        string GUI_component_combine(string past_component,string component,string replacement)
        {
            string bodylayout = "";
            string body_data = past_component;
            body_data = body_data.Replace(replacement, component);
          //  MessageBox.Show(sc_class_contructor.Text);
            
            return body_data;
        }
      
        void elementmaker()
        {

        }
        private void generate_all_Click(object sender, EventArgs e)
        {
            generate_gui_all();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            generate_gui_all();
            // write file and run
            string filename = classname+".java";
            string compiledClass = classname;
            if (File.Exists(filename))
            {
                File.Delete(filename);
                File.Delete(compiledClass+".class");
            }
                
            File.WriteAllText(filename,sc_full.Text);
            compileJava(filename);
            runJava(compiledClass);
        }
        private void compileJava(string filename)
        {
            DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory()); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles("*.jar"); //Getting Text files

            string cpbody = "";
            foreach (FileInfo file in Files)
            {
                cpbody += ";" + Path.GetFileName(file.Name);
            }
            string cp_command = "-cp ." + cpbody + "";
            cp_command = cp_command.Replace("\r\n", "");
            //MessageBox.Show(cp_command);       
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "javac.exe ";
            //startInfo.RedirectStandardOutput = false;
            //startInfo.RedirectStandardError = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = cp_command + " " + filename; ;
            p.StartInfo = startInfo;
            p.Start();
            string tempLog = consoleTxt.Text;
            string newData = p.StandardOutput.ReadToEnd()+p.StandardError.ReadToEnd();
            
           
            p.WaitForExit();

            consoleTxt.Text = newData+"\n";

        }

        private void runJava(string filename)
        {
            DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory()); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles("*.jar"); //Getting Text files

            string cpbody = "";
            foreach (FileInfo file in Files)
            {
                cpbody += ";" + Path.GetFileName(file.Name);
            }
            string cp_command = "-cp ." + cpbody + "";
            cp_command = cp_command.Replace("\r\n", "");
            //MessageBox.Show(cp_command);            
            
           
           
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "java.exe";
            //startInfo.RedirectStandardOutput = false;
            //startInfo.RedirectStandardError = false;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
        //    MessageBox.Show(cp_command);
            startInfo.Arguments = cp_command+" "+filename;
            consoleTxt.Text += "Running java.exe " + cp_command + " " + filename +".java . . .";
            p.StartInfo = startInfo;
            p.Start();
           // p.WaitForExit();

        }

        private void generate_all_Click_1(object sender, EventArgs e)
        {
            generate_gui_all();
        }

        private void clsconsole_Click(object sender, EventArgs e)
        {
            consoleTxt.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:hakimencem01@gmail.com");
        }

        void addNewObjectname(string ObjectName)
        {
            savedObjectList.Insert(0,ObjectName);
        }
     
      

   
      


        private void cls_all_Click(object sender, EventArgs e)
        {
        
        }

      

      

        private void autoCompleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
       
      

      
        //FFieldObjectName FFieldBindtoObj FFieldTitle FFieldField_lb smoothwrapinc
        // TFObjName TFBindtoObj TFPretext TFWidth
        // TAObjName TABindtoObj TAPreText TAsize
        // BObjName BBindtoObj BTitle 
        // jcObjName jcValueElement jcBindToObj
        // jrObjName jrBindToObj jrElementValue

       
      

        private void resetEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void clearAllGeneratedGUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sc_class.Text = "";
            sc_class_contructor.Text = "";
            sc_element_declareTxt.Text = "";
            sc_form_element.Text = "";
            sc_full.Text = "";
            sc_bind_setting.Text = "";
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.ShowDialog();
        }

       
        // template generator
        public void fgcolor(string objname,string rgbvalue)
        {
            sc_form_element.Text += "\t\t" + objname + ".setForeground(new Color(" + rgbvalue + "));\n";
          
            
        }
        public void bgcolor(string objname, string rgbvalue)
        {
            sc_form_element.Text += "\t\t" + objname + ".setBackground(new Color(" + rgbvalue + "));\n";


        }
        public void autofillborderlayout()
        {
            sc_element_declareTxt.Text += "\tJPanel BorderLayoutNorth_Panel;\n";
            sc_element_declareTxt.Text += "\tJPanel BorderLayoutSouth_Panel;\n";
            sc_element_declareTxt.Text += "\tJPanel BorderLayoutEast_Panel;\n";
            sc_element_declareTxt.Text += "\tJPanel BorderLayoutWest_Panel;\n";
            sc_element_declareTxt.Text += "\tJPanel BorderLayoutCenter_Panel;\n";

            sc_form_element.Text += "\t\tBorderLayoutNorth_Panel = new JPanel();\n" +
                                    "\t\tBorderLayoutNorth_Panel.setLayout(new GridLayout(0,1));\n";

            sc_form_element.Text += "\t\tBorderLayoutSouth_Panel = new JPanel();\n"+
                                    "\t\tBorderLayoutSouth_Panel.setLayout(new GridLayout(0,1));\n";

            sc_form_element.Text += "\t\tBorderLayoutEast_Panel = new JPanel();\n" +
                                    "\t\tBorderLayoutEast_Panel.setLayout(new GridLayout(0,1));\n";

            sc_form_element.Text += "\t\tBorderLayoutWest_Panel = new JPanel();\n" +
                                    "\t\tBorderLayoutWest_Panel.setLayout(new GridLayout(0,1));\n";

            sc_form_element.Text += "\t\tBorderLayoutCenter_Panel = new JPanel();\n" +
                                    "\t\tBorderLayoutCenter_Panel.setLayout(new GridLayout(0,1));\n";


            sc_bind_setting.Text += "\t\tinnerContainer.add(BorderLayoutNorth_Panel,BorderLayout.NORTH);\n";
            sc_bind_setting.Text += "\t\tinnerContainer.add(BorderLayoutSouth_Panel,BorderLayout.SOUTH);\n";
            sc_bind_setting.Text += "\t\tinnerContainer.add(BorderLayoutEast_Panel,BorderLayout.EAST);\n";
            sc_bind_setting.Text += "\t\tinnerContainer.add(BorderLayoutWest_Panel,BorderLayout.WEST);\n";
            sc_bind_setting.Text += "\t\tinnerContainer.add(BorderLayoutCenter_Panel,BorderLayout.CENTER);\n";

            addNewObjectname("BorderLayoutNorth_Panel");
            addNewObjectname("BorderLayoutSouth_Panel");
            addNewObjectname("BorderLayoutEast_Panel");
            addNewObjectname("BorderLayoutWest_Panel");
            addNewObjectname("BorderLayoutCenter_Panel");
           
        }

        

       
       

        private void borderLayoutAutoFillWithJPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void headingTitleForPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bind_data_to_obj bdto = new bind_data_to_obj();
            
            bdto.bindObjName("Form Title :");
            bdto.bindvalueTitle("Width : ");
            bdto.bindvalueData("10");
            bdto.settoBindObjList(savedObjectList);
            bdto.ShowDialog();
            string title = bdto.objname; // in this case. we will use objname for formfield title manipulation.
            string optionvalue = bdto.optionvalue;
            string bindtoobj = bdto.bindtoobj;
            // FormField with label
            sc_element_declareTxt.Text += "\tJPanel FormField_" + formfield + "_Pnl;\n" +
                                         "\tJLabel lbl" + labelinc + ";\n";
            sc_form_element.Text += "\t\tFormField_" + formfield + "_Pnl = new JPanel(new GridLayout(1,2));\n" +
                                   "\t\t lbl" + labelinc + " = new JLabel(\"" + title + "\");\n" +
                                   "\t\t FormField_" + formfield + "_Pnl.add(lbl" + labelinc + ");\n";
            sc_bind_setting.Text += "\t\t" + bindtoobj + ".add(FormField_" + formfield + "_Pnl);\n";
            // JTextField
            sc_element_declareTxt.Text += "\tJTextField FormField_" + formfield + "_TField;\n";
            sc_form_element.Text += "\t\tFormField_" + formfield + "_TField = new JTextField(" + optionvalue + ");\n";
            sc_bind_setting.Text += "\t\tFormField_" + formfield + "_Pnl.add(FormField_" + formfield + "_TField);\n";

            addNewObjectname("FormField_" + formfield + "_TField");
            addNewObjectname("FormField_" + formfield + "_Pnl");
           
            formfield++;
            labelinc++;
        }

       


      

        private void addImageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mathFormulaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bindElementToObjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindelementtoObject(current_selected_component);
        
        }

        void bindelementtoObject(string currentcomponentselect)
        {
            /// bind element to object
            bind_element_to_panel beto = new bind_element_to_panel();
            beto.setElementobjname("Component_" + componentinc);
            beto.setcurrentpick(currentcomponentselect);
            beto.settoBindObjList(savedObjectList);
            beto.getMaxContainerHeight(form_size_width, form_size_height);
            beto.ShowDialog();
            string element_name = beto.element_name;
            string element_type = beto.element_type;
            string bind_to_panel = beto.bind_to_panel;
            string element_value = beto.element_value;
            string element_value2 = beto.element_value2;
            string image_file_path = beto.image_file_path;
            current_selected_component = element_type;
            Boolean prematureclose = beto.prematureclose;
            if (prematureclose == false)
            {
                switch (element_type.ToLower())
                {
                    case "jlabel":
                        bindjlabel(element_name, bind_to_panel, element_value);

                        break;
                    case "jbutton":
                        bindjbutton(element_name, bind_to_panel, element_value);
                        break;
                    case "jtextfield":
                        bindjtextfield(element_name, bind_to_panel, element_value, element_value2);
                        break;
                    case "jtextarea":
                        bindjtextarea(element_name, bind_to_panel, element_value, element_value2);
                        break;
                    case "jradiobutton":
                        bindjradiobutton(element_name, bind_to_panel, element_value);
                        break;
                    case "jcheckbox":
                        bindjcheckbox(element_name, bind_to_panel, element_value);
                        break;
                    case "jseparator":
                        bindjseparator(bind_to_panel, element_value);
                        break;
                    case "imageicon":
                        bindimageicon(element_name, bind_to_panel, element_value, element_value2, image_file_path);
                        break;
                    case "emptyheight":
                        bindemptyheight(bind_to_panel, element_name, element_value);
                        break;
                    case "jtable":
                        bindjtable(bind_to_panel, element_name, element_value,element_value2);
                        break;
                }
                componentinc++;
            }
           
        }

        void bindjtable(string bind_to_panel, string element_name, string element_value, string element_value2)
        {
            string datarow = element_value;
            string[] elem_val = datarow.Split(',');
            int colcount = elem_val.Length;
            sc_element_declareTxt.Text += "\tJTable " + element_name + "_JTbl;\n";
            sc_form_element.Text += "\t\tString[] Table_Column_" + element_name + "_JTbl = {" + element_value + "};\n" +
                                    "\t\tString[][] Table_Data_" + element_name + "_JTbl = new String[" + element_value2 + "]["+colcount.ToString()+"];\n" +
                                    "\t\t" + element_name + "_JTbl = new JTable(Table_Data_" + element_name + "_JTbl, Table_Column_" + element_name + "_JTbl);\n"+
                                     "\t\tJScrollPane ScrollPane_" + element_name + "_JTbl = new JScrollPane(" + element_name + "_JTbl);";
            sc_bind_setting.Text += "\t\t" + bind_to_panel + ".add(ScrollPane_" + element_name + "_JTbl);\n";
            addNewObjectname(element_name + "_JTbl");

        }
        void bindjlabel(string element_name, string bind_to_panel, string element_value)
        {
            sc_element_declareTxt.Text += "\tJLabel " + element_name + "_JLbl;\n";
            sc_form_element.Text += "\t\t" + element_name + "_JLbl = new JLabel(\"" + element_value + "\", SwingConstants.LEFT);\n";
            sc_bind_setting.Text += "\t\t" + bind_to_panel + ".add(" + element_name + "_JLbl);\n";
            addNewObjectname(element_name + "_JLbl");
            
        }
        void bindjbutton(string element_name, string bind_to_panel, string element_value)
        {
            sc_element_declareTxt.Text += "\tJButton " + element_name + "_JBtn;\n";
            sc_form_element.Text += "\t\t" + element_name + "_JBtn = new JButton(\"" + element_value + "\");\n";
            sc_bind_setting.Text += "\t\t" + bind_to_panel + ".add(" + element_name + "_JBtn);\n";
            addNewObjectname(element_name + "_JBtn");
            
        }
        void bindjtextfield(string element_name, string bind_to_panel, string element_value,string elementvalue2)
        {
            sc_element_declareTxt.Text += "\tJTextField " + element_name + "_TField;\n";
            sc_form_element.Text += "\t\t" + element_name + "_TField = new JTextField(" + element_value + ");\n"+
                                    "\t\t" + element_name + "_TField.setText(\"" +  elementvalue2 + "\");\n";
            sc_bind_setting.Text += "\t\t" + bind_to_panel + ".add(" + element_name + "_TField);\n";
            addNewObjectname(element_name + "_TField");
            
        }
        void bindjtextarea(string element_name, string bind_to_panel, string element_value, string elementvalue2)
        {
            sc_element_declareTxt.Text += "\tJTextArea " + element_name + "_TArea;\n";
            sc_form_element.Text += "\t\t" + element_name + "_TArea = new JTextArea(\"" + elementvalue2 + "\"," + element_value + ");\n"+
                                     "\t\t" + element_name + "_TArea.setPreferredSize(new Dimension(50, 50));;\n";
            sc_bind_setting.Text += "\t\t" + bind_to_panel + ".add(" + element_name + "_TArea);\n";
            addNewObjectname(element_name + "_TArea");
            
        }
        void bindjradiobutton(string element_name, string bind_to_panel, string element_value)
        {
            string[] jrElementList = element_value.Split(',');
            sc_element_declareTxt.Text += "\tJPanel " + element_name + "_Panel;\n";
            sc_element_declareTxt.Text += "\tButtonGroup " + element_name + "_BtnGrp;\n";
            sc_form_element.Text += "\t\t" + element_name + "_Panel = new JPanel(new GridLayout(1," + jrElementList.Length + "));\n";
            sc_form_element.Text += "\t\t" + element_name + "_BtnGrp = new ButtonGroup();\n";

            for (int x = 0; x < jrElementList.Length; x++)
            {
                sc_element_declareTxt.Text += "\tJRadioButton " + element_name + "_" + x + "_JRBtn;\n";
                sc_form_element.Text += "\t\t" + element_name + "_" + x + "_JRBtn = new JRadioButton(\"" + jrElementList[x] + "\");\n";
                sc_form_element.Text += "\t\t" + element_name + "_" + x + "_JRBtn.addActionListener(this);\n";
                sc_form_element.Text += "\t\t" + element_name + "_BtnGrp.add(" + element_name + "_" + x + "_JRBtn);\n";
                sc_bind_setting.Text += "\t\t" + element_name + "_Panel.add(" + element_name + "_" + x + "_JRBtn);\n";
            }
            sc_bind_setting.Text += "\t\t" + bind_to_panel + ".add(" + element_name + "_Panel);\n";
            addNewObjectname(element_name + "_JRBtn");
            
        }
        void bindjcheckbox(string element_name, string bind_to_panel, string element_value)
        {
            string[] jcElementList = element_value.Split(',');
            sc_element_declareTxt.Text += "\tJPanel " + element_name + "_Panel;\n";
            sc_form_element.Text += "\t\t" + element_name + "_Panel = new JPanel(new GridLayout(1," + jcElementList.Length + "));\n";

            for (int x = 0; x < jcElementList.Length; x++)
            {
                sc_element_declareTxt.Text += "\tJCheckBox " + element_name + "_" + x + "_JCBox;\n";
                sc_form_element.Text += "\t\t" + element_name + "_" + x + "_JCBox = new JCheckBox(\"" + jcElementList[x] + "\");\n";
                sc_form_element.Text += "\t\t" + element_name + "_" + x + "_JCBox.addItemListener(this);\n";
                sc_bind_setting.Text += "\t\t" + element_name + "_Panel.add(" + element_name + "_" + x + "_JCBox);\n";
            }
            sc_bind_setting.Text += "\t\t" + bind_to_panel + ".add(" + element_name + "_Panel);\n";
            addNewObjectname(element_name + "_JCBox");
            
        }
        void bindjseparator(string bind_to_panel, string element_value)
        {
          
            sc_bind_setting.Text += "\t\t"+bind_to_panel+".add(new JSeparator("+element_value+"));\n";
            
        }
        void bindemptyfill(string bindtopanel,string element_name)
        {

            sc_element_declareTxt.Text += "\tJLabel emptyfill_" + element_name + "_JLbl;\n";
            sc_form_element.Text += "\t\temptyfill_" + element_name + "_JLbl = new JLabel(\" \");\n";
            sc_bind_setting.Text += "\t\t" + bindtopanel + ".add(emptyfill_" + element_name + "_JLbl);\n";
           

        }
        void bindemptyheight(string bindtopanel, string element_name,string height)
        {

            sc_element_declareTxt.Text += "\tJLabel emptyheight_" + element_name + "_JLbl;\n";
            sc_form_element.Text += "\t\temptyheight_" + element_name + "_JLbl = new JLabel(\" \");\n"+ 
                                    "\t\temptyheight_" + element_name + "_JLbl.setPreferredSize(new Dimension(50, "+height+"));;\n";
            sc_bind_setting.Text += "\t\t" + bindtopanel + ".add(emptyheight_" + element_name + "_JLbl);\n";


        }
        void bindimageicon(string element_name, string bind_to_panel, string element_value, string element_value2, string image_path)
        {
            //.setIcon(new ImageIcon(new javax.swing.ImageIcon(getClass().getResource("wall.jpg")).getImage().getScaledInstance(590, 80, Image.SCALE_SMOOTH)));
            //  sc_form_element.Text += "\t\t" + element_name + "_" + x + "_JCBox.addItemListener(this);\n";
            string file_dest = Directory.GetCurrentDirectory()+"\\"+Path.GetFileName(image_path);
           
            string name = Path.GetFileNameWithoutExtension(image_path);
            string path = Path.GetDirectoryName(image_path);
            string newname = name + ".png";
            try
            {
                if (!File.Exists(file_dest))
                {
                    Image png = Image.FromFile(image_path);

                    png.Save(Directory.GetCurrentDirectory() + @"/" + newname, ImageFormat.Png);
                    png.Dispose();
                }
               
                sc_element_declareTxt.Text += "\tJPanel " + element_name + "_ImgIconWrap;\n";
                sc_element_declareTxt.Text += "\tJLabel " + element_name + "_ImgIcon;\n";
                sc_form_element.Text += "\t\t" + element_name + "_ImgIconWrap = new JPanel(new FlowLayout());\n";
                sc_form_element.Text += "\t\t" + element_name + "_ImgIcon = new JLabel(\"\",SwingConstants.CENTER);\n";
                sc_form_element.Text += "\t\t" + element_name + "_ImgIcon.setIcon(new ImageIcon(new javax.swing.ImageIcon(getClass().getResource(\"" + newname + "\")).getImage().getScaledInstance(" + element_value + ", " + element_value2 + ", Image.SCALE_SMOOTH)));\n";
                sc_bind_setting.Text += "\t\t" + element_name + "_ImgIconWrap.add(" + element_name + "_ImgIcon);\n";
                sc_bind_setting.Text += "\t\t" + bind_to_panel + ".add(" + element_name + "_ImgIconWrap);\n";
                addNewObjectname(element_name + "_ImgIconWrap");
                
            }
            catch (OutOfMemoryException ec)
            {
                MessageBox.Show("Invalid image or if the image display correctly on other program. Try to save it to .PNG in MS Paint program !");
            }
        }
        private void foreGroundColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            string RColor = colorDialog1.Color.R.ToString();
            string GColor = colorDialog1.Color.G.ToString();
            string BColor = colorDialog1.Color.B.ToString();
            string rgb_value = RColor + "," + GColor + "," + BColor;
            bind_data_to_obj bdto = new bind_data_to_obj();
            bdto.bindvalueTitle("ForeGround Color : ");
            bdto.bindvalueData(rgb_value);
            bdto.settoBindObjList(savedObjectList);
            bdto.hideOptionBindObjName(true);
            bdto.ShowDialog();
            string optionvalue = bdto.optionvalue;
            string bindtoobj = bdto.bindtoobj;

            if (bindtoobj != "")
            {
                fgcolor(bindtoobj, optionvalue);
            }
            
        }

        private void backGroundColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            string RColor = colorDialog1.Color.R.ToString();
            string GColor = colorDialog1.Color.G.ToString();
            string BColor = colorDialog1.Color.B.ToString();
            string rgb_value = RColor + "," + GColor + "," + BColor;
            bind_data_to_obj bdto = new bind_data_to_obj();
            bdto.hideOptionBindObjName(true);
            bdto.bindvalueTitle("BackGround Color : ");
            bdto.bindvalueData(rgb_value);
            bdto.settoBindObjList(savedObjectList);
            bdto.ShowDialog();
            string optionvalue = bdto.optionvalue;
            string bindtoobj = bdto.bindtoobj;
            if (bindtoobj != "")
            {
                bgcolor(bindtoobj, optionvalue);
            }
            
        }

        private void formSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formcontainer fc = new formcontainer();
            fc.setformsetting(classname, title, addmainclass, visibilityform, layout_type, form_size_width, form_size_height);
            
           
            fc.ShowDialog();

            Boolean prematureclose = fc.prematureclose;
            // FormField with label
            if (prematureclose == false)
            {
                classname = fc.classname;
                title = fc.title;
                addmainclass = fc.addmainclass;
                layout_type = fc.layout_type;
                form_size_width = fc.sizewidth;
                form_size_height = fc.sizeheight;
                visibilityform = fc.visibility;
                generate_gui_class();
            }
      
            
        }

        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bind_panel_to_obj bpto = new bind_panel_to_obj();
            bpto.panelinc(panelinc);
            bpto.settoBindObjList(savedObjectList);
            bpto.ShowDialog();
            string element_name = bpto.element_name;
            string bind_to_obj = bpto.bind_to_obj;
            string layouttype = bpto.layouttype;
            string layout_param = bpto.layout_param;
            Boolean prematureclose = bpto.prematureclose;
            if (prematureclose == false)
            {
                panelbindtoobj(element_name, bind_to_obj, layouttype, layout_param);
                panelinc++;
            }
        }
        void panelbindtoobj(string element_name, string bind_to_obj, string layouttype, string layout_param)
        {
            string boxlayoutreference = "";
            if (layouttype == "BoxLayout")
                boxlayoutreference = element_name + "_Pnl,";
            sc_element_declareTxt.Text += "\tJPanel " + element_name + "_Pnl;\n";
            sc_form_element.Text += "\t\t" + element_name + "_Pnl = new JPanel();\n"+
                                     "\t\t" + element_name + "_Pnl.setLayout(new " + layouttype + "("+boxlayoutreference + layout_param + "))";
            sc_bind_setting.Text += "\t\t" + bind_to_obj + ".add(" + element_name + "_Pnl);\n";
            addNewObjectname(element_name + "_Pnl");
            
        }

    
       
        private void fillBorderLayoutWithPanelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to fill Borderlayout with panel ?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                autofillborderlayout();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
        }

        void formfieldautofill(string object_name, string bind_to_panel,string type,string increment)
        {
            sc_element_declareTxt.Text += "\tJPanel FormField_" + object_name + "_Pnl;\n" +
                                      "\tJLabel lblF_" + labelinc + ";\n";
            sc_form_element.Text += "\t\tFormField_" + object_name + "_Pnl = new JPanel(new GridLayout(1,2));\n" +
                                   "\t\tlblF_" + labelinc + " = new JLabel(\"FormField" + increment + "\");\n" +
                                   "\t\tFormField_" + object_name + "_Pnl.add(lblF_" + labelinc + ");\n";
            sc_bind_setting.Text += "\t\t" + bind_to_panel + ".add(FormField_" + object_name + "_Pnl);\n";
            addNewObjectname("FormField_" + object_name + "_Pnl");

            labelinc++;
            formfield++;
            if (type == "textfield")
            {
                bindjtextfield(object_name, "FormField_" + object_name + "_Pnl", "10", "");
            }
            if (type == "radiobutton")
            {
                bindjradiobutton(object_name, "FormField_" + object_name + "_Pnl", "Option 1,Option 2,Option 3");
            }
            if (type == "jcheckbox")
            {
                bindjcheckbox(object_name, "FormField_" + object_name + "_Pnl", "Option 1,Option 2,Option 3");
            }
            
        }
        private void autoFillPanelWithComponentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autofill_panel afp = new autofill_panel();
            afp.setToBindAutoFillList(savedObjectList);
            afp.ShowDialog();
            string bindto = afp.bindto;
            string component_type = afp.component_type;
            string count = afp.count;

           
            string element_type = component_type;
            string bind_to_panel = bindto;
            string element_value = "";
            string element_value2 = "";
            string image_file_path = "image_placeholder.png";
            current_selected_component = element_type;
            Boolean prematureclose = afp.prematureclose;
            if (prematureclose == false)
            {
                for (int y = 1; y <= Int32.Parse(count); y++)
                {
                   
                    string element_name = "Component_" + componentinc;
                    switch (element_type.ToLower())
                    {
                        case "jlabel":
                            bindjlabel(element_name, bind_to_panel, "Untitled Label " + y);
                            break;
                        case "jbutton":
                            bindjbutton(element_name, bind_to_panel, "Untitled Button " + y);
                            break;
                        case "jtextfield":
                            bindjtextfield(element_name, bind_to_panel, "15", "");
                            break;
                        case "jtextarea":
                            bindjtextarea(element_name, bind_to_panel, "4","10");
                            break;
                        case "jradiobutton":
                            bindjradiobutton(element_name, bind_to_panel, "Option 1,Option 2,Option 3");
                            break;
                        case "jcheckbox":
                            bindjcheckbox(element_name, bind_to_panel, "Option 1,Option 2,Option 3");
                            break;
                        case "jseparator":
                            bindjseparator(bind_to_panel, "SwingContants.VERTICAL");
                            break;
                        case "emptyfill":
                            bindemptyfill(bind_to_panel,element_name);
                            break;
                        case "imageicon":
                            bindimageicon(element_name, bind_to_panel, "100", "100", image_file_path);
                            break;
                        case "formfield + textfield":
                            formfieldautofill(element_name, bind_to_panel,"textfield",y.ToString() );
                            break;
                        case "formfield + radiobutton":
                            formfieldautofill(element_name, bind_to_panel, "radiobutton", y.ToString());
                            break;
                        case "formfield + checkbox":
                            formfieldautofill(element_name, bind_to_panel, "checkbox", y.ToString());
                            break;
                        


                    }
                    componentinc++;
                }
               
            }
        }

        private void formFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formfield_binder ffb = new formfield_binder();
            ffb.setToBindFormFieldList(savedObjectList);
            ffb.setFFobjname("FormField_" + formfield);
            ffb.ShowDialog();
            string object_name = ffb.object_name;
            string title = ffb.title;
            string bindtoobj = ffb.bindtoobj;
            string componenttype = ffb.componenttype;
            string formfield_pos_type = ffb.formfield_pos_type;
            Boolean prematureclose = ffb.prematureclose;
            // FormField with label
            if (prematureclose == false)
            {
                sc_element_declareTxt.Text += "\tJPanel FormField_" + object_name + "_Pnl;\n" +
                                      "\tJLabel lblF_" + labelinc + ";\n";
                sc_form_element.Text += "\t\tFormField_" + object_name + "_Pnl = new JPanel(new " + formfield_pos_type + ");\n" +
                                       "\t\tlblF_" + labelinc + " = new JLabel(\"" + title + "\");\n" +
                                       "\t\tFormField_" + object_name + "_Pnl.add(lblF_" + labelinc + ");\n";
                sc_bind_setting.Text += "\t\t" + bindtoobj + ".add(FormField_" + object_name + "_Pnl);\n";
                addNewObjectname("FormField_" + object_name + "_Pnl");
                
                labelinc++;
                formfield++;
                bindelementtoObject(componenttype);
            }
          
            

        }



        private void headingTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bind_data_to_obj bdto = new bind_data_to_obj();
            bdto.bindObjName("Heading Title : ");
            bdto.bindvalueTitle("Background Color : ");
            bdto.bindvalueData("179,197,233");
            bdto.settoBindObjList(savedObjectList);
            bdto.ShowDialog();
            string title = bdto.objname;
            string optionvalue = bdto.optionvalue;
            string bindtoobj = bdto.bindtoobj;
            Boolean prematureclose = bdto.prematureclose;
            if (prematureclose == false)
            {
                sc_element_declareTxt.Text += "\tJPanel HeadingTitle_" + headtitle + "_Pnl;\n" +
                                               "\tJLabel lblHeadingTitle" + headtitle + ";\n";
                sc_form_element.Text += "\t\tHeadingTitle_" + headtitle + "_Pnl = new JPanel(new FlowLayout());\n" +
                                         "\t\tHeadingTitle_" + headtitle + "_Pnl.setBackground(new Color(" + optionvalue + "));;\n" +
                                       "\t\tlblHeadingTitle" + headtitle + " = new JLabel(\"" + title + "\");\n" +
                                       "\t\tHeadingTitle_" + headtitle + "_Pnl.add(lblHeadingTitle" + headtitle + ");\n";
                sc_bind_setting.Text += "\t\t" + bindtoobj + ".add(HeadingTitle_" + headtitle + "_Pnl);\n";
                addNewObjectname("HeadingTitle_" + headtitle + "_Pnl");
                
                headtitle++;
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void jrElementValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox21_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

      
      

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png"; 
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;
            Random r = new Random();
            int rInt = r.Next(0, 10000);
            
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                string temppath = Path.GetTempPath() + "\\javaguigen_" + rInt.ToString() + ".png";
                File.Copy(choofdlog.FileName, temppath);
                load_image.Image = new Bitmap(temppath);
                load_image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void arrangeDeclarationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to rearrange the element declaration. The rerrangement are limited to basic component only !", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string element_declaration = sc_element_declareTxt.Text;
                if (element_declaration != "")
                {
                    string[] element_declaration_list = element_declaration.Split(new string[] { "\n" }, StringSplitOptions.None);
                    string JPanelList = "\tJPanel ";
                    string JTextAreaList = "\tJTextArea ";
                    string JButtonList = "\tJButton ";
                    string JSeparatorList = "\tJSeparator ";
                    string JTextFieldList = "\tJTextField ";
                    string JCheckBoxList = "\tJCheckBox ";
                    string JRadioButtonList = "\tJRadioButton ";
                    string JLabelList = "\tJLabel ";
                    string ButtonGroupList = "\tButtonGroup ";
                    Boolean jpanelexist = false;
                    Boolean jtextareaexist = false;
                    Boolean jbuttonexist = false;
                    Boolean jseparatorexist = false;
                    Boolean jtextfieldexist = false;
                    Boolean jcheckboxexist = false;
                    Boolean jradiobuttonexist = false;
                    Boolean jlabelexist = false;
                    Boolean buttongroupexist = false;
                    for (int x = 0; x < element_declaration_list.Length; x++)
                    {
                        if (element_declaration_list[x] == "")
                            continue;
                        string[] keyval = elementNamePull(element_declaration_list[x]);
                        string objtype = keyval[0];
                        string val = keyval[1];
                        if (objtype == "JPanel")
                        {
                            JPanelList += val + ",";
                            jpanelexist = true;
                        }
                        if (objtype == "JTextArea")
                        {
                            JTextAreaList += val + ",";
                            jtextareaexist = true;
                        }
                        if (objtype == "JButton")
                        {
                            JButtonList += val + ",";
                            jbuttonexist = true;
                        }
                        if (objtype == "JSeparator")
                        {
                            JSeparatorList += val + ",";
                            jseparatorexist = true;
                        }
                        if (objtype == "JTextField")
                        {
                            JTextFieldList += val + ",";
                            jtextfieldexist = true;
                        }
                        if (objtype == "JCheckBox")
                        {
                            JCheckBoxList += val + ",";
                            jcheckboxexist = true;
                        }
                        if (objtype == "JRadioButton")
                        {
                            JRadioButtonList += val + ",";
                            jradiobuttonexist = true;
                        }
                        if (objtype == "JLabel")
                        {
                            JLabelList += val + ",";
                            jlabelexist = true;
                        }
                        if (objtype == "ButtonGroup")
                        {
                            ButtonGroupList += val + ",";
                            buttongroupexist = true;
                        }
                    }
                    JPanelList = JPanelList.Substring(0, JPanelList.Length - 1) + ";";
                    JTextAreaList = JTextAreaList.Substring(0, JTextAreaList.Length - 1) + ";";
                    JButtonList = JButtonList.Substring(0, JButtonList.Length - 1) + ";";
                    JSeparatorList = JSeparatorList.Substring(0, JSeparatorList.Length - 1) + ";";
                    JTextFieldList = JTextFieldList.Substring(0, JTextFieldList.Length - 1) + ";";
                    JCheckBoxList = JCheckBoxList.Substring(0, JCheckBoxList.Length - 1) + ";";
                    JRadioButtonList = JRadioButtonList.Substring(0, JRadioButtonList.Length - 1) + ";";
                    JLabelList = JLabelList.Substring(0, JLabelList.Length - 1) + ";";
                    ButtonGroupList = ButtonGroupList.Substring(0, ButtonGroupList.Length - 1) + ";";
                    string full_element_declaration = "";
                    if (jpanelexist)
                        full_element_declaration += JPanelList + "\n";
                    if (jtextareaexist)
                        full_element_declaration += JTextAreaList + "\n";
                    if (jbuttonexist)
                        full_element_declaration += JButtonList + "\n";
                    if (jseparatorexist)
                        full_element_declaration += JSeparatorList + "\n";
                    if (jtextfieldexist)
                        full_element_declaration += JTextFieldList + "\n";
                    if (jcheckboxexist)
                        full_element_declaration += JCheckBoxList + "\n";
                    if (jradiobuttonexist)
                        full_element_declaration += JRadioButtonList + "\n";
                    if (jlabelexist)
                        full_element_declaration += JLabelList + "\n";
                    if (buttongroupexist)
                        full_element_declaration += ButtonGroupList + "\n";
                    sc_element_declareTxt.Text = full_element_declaration;
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
           

        }
        string[] elementNamePull(string argument)
        {
            argument = argument.Replace(";", "");
            argument = argument.Replace("\t", "");
            string[] arglist = argument.Split(' ');
            
            return arglist;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            string RColor = colorDialog1.Color.R.ToString();
            string GColor = colorDialog1.Color.G.ToString();
            string BColor = colorDialog1.Color.B.ToString();
            string rgb_value = RColor + "," + GColor + "," + BColor;
            colorpicked cp = new colorpicked();
            cp.setcolor(rgb_value);
            cp.StartPosition = FormStartPosition.CenterParent;
            cp.ShowDialog();
        }

        private void gridBagLayoutMagicDesignerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridbaglayoutmaker gblm = new gridbaglayoutmaker();
            List<string> panelreference = new  List<string>();
            gblm.setbindtogridbag(savedObjectList);
            gblm.ShowDialog();
            panelreference = gblm.panelreference;
            string formelementcode = gblm.formelementcode;
             string bindsettingcode = gblm.bindsettingcode;
            for (int x = 0; x < panelreference.Count; x++)
            {
                addNewObjectname(panelreference[x]);
            }
            sc_form_element.Text += formelementcode;
            sc_bind_setting.Text += bindsettingcode;
        }

        private void autoGenerateSQLFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        void generatesqltemplate(string connectionparam)
        {
            string sqltemplate = "\n\t\tpublic Boolean getConnection(){\n" +
                                "\t\ttry{\n" +
                                "\t\t    Class.forName(\"com.mysql.jdbc.Driver\");\n" +
                                "\t\t}catch(java.lang.ClassNotFoundException e){\n" +
                                "\t\t    System.err.print(\"ClassNotFoundException : \");\n" +
                                "\t\t    System.err.println(e.getMessage());\n" +
                                "\t\t}\n" +
                                "\t\ttry{\n" +
                                "\t\t    conn = DriverManager.getConnection("+connectionparam+");\n" +
                                "\t\t    return true;"+
                                "\t\t}catch(SQLException ex){\n" +
                                "\t\t    System.err.println(\"SQL Exception \"+ex.getMessage());\n" +
                                "\t\t    return false;\n"+
                                "\t\t}\n" +
                                "}\n";
            sqltemplate += "public Boolean sqlExecute(String query){\n"+
                            "         try{\n"+
                            "             getConnection();\n"+
                            "             stmt = conn.createStatement();\n"+
                            "             stmt.executeUpdate(query);\n"+
                            "             return true;\n "+
                            "             }catch(SQLException ex){\n "+
                            "                 System.err.println(\"SQL Exception \"+ex.getMessage());\n "+
                            "				 return false;\n"+
                            "         }\n "+
                            "         \n "+
                            "     }\n";
            sqltemplate += "public void FillTable(JTable table, String Query)\n" +
                            "{\n" +
                            " try\n"+
                            "    {\n"+
                            "        getConnection();\n"+
                            "        Statement stat = conn.createStatement();\n"+
                            "        ResultSet rs = stat.executeQuery(Query);\n"+
                            "          stmt=conn.createStatement();\n"+
                            "         table.setModel(DbUtils.resultSetToTableModel(rs));\n"+
                            "\n"+
                            "        rs.close();\n"+
                            "        stat.close();\n"+
                            "        conn.close();\n"+
                            "    }\n"+
                            "    catch(SQLException e)\n"+
                            "    {\n"+
                            "    }"+

                            "}\n";
            sc_element_declareTxt.Text+= "\tConnection conn;\n" +
                                    "\tStatement stmt;\n";
            sc_funct_template.Text += sqltemplate;
            
        }

        private void generateSQLFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }

        private void fillTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void autoGenerateSQLFunctionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            sqlgenerator sqlgen = new sqlgenerator();
            sqlgen.ShowDialog();
            string hostname = sqlgen.hostname;
            string dbname = sqlgen.dbname;
            string port = sqlgen.port;
            string username = sqlgen.username;
            string password = sqlgen.password;
            string connectionparam = "\"jdbc:mysql://" + hostname + ":" + port + "/" + dbname + "\",\"" + username + "\",\"" + password + "\"";
            Boolean prematureclose = sqlgen.prematureclose;
            if (prematureclose == false)
            {
                generatesqltemplate(connectionparam);
            }
        }

        private void generateSQLFunctionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            sqlgenerator sqlgen = new sqlgenerator();
            sqlgen.ShowDialog();
            string hostname = sqlgen.hostname;
            string dbname = sqlgen.dbname;
            string port = sqlgen.port;
            string username = sqlgen.username;
            string password = sqlgen.password;
            string connectionparam = "\"jdbc:mysql://" + hostname + ":" + port + "/" + dbname + "\",\"" + username + "\",\"" + password + "\"";
            Boolean prematureclose = sqlgen.prematureclose;
            if (prematureclose == false)
            {
                generatesqltemplate(connectionparam);
            }
        }

        private void fillTableToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            sqlfilltable sqlft = new sqlfilltable();
            sqlft.settoSQLFillTable(savedObjectList);
            sqlft.ShowDialog();
        }
    }
}
