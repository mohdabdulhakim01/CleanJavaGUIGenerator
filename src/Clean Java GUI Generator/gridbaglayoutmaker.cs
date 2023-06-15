using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
namespace Clean_Java_GUI_Generator
{
    public partial class gridbaglayoutmaker : Form
    {
        public List<string> gridwidth = new List<string>();
        public List<string> gridheight = new List<string>();
        public List<string> weightx = new List<string>();
        public List<string> ipady = new List<string>();
        public List<string> ipadx = new List<string>();
        public List<string> gridx = new List<string>();
        public List<string> gridy = new List<string>();
        public List<int> itemlist = new List<int>();
        public List<string> panelreference = new List<string>();
        public int currentgridindex = 0;
        public int latest_index = 0;
        public string formelementcode = "";
        public string bindsettingcode = "";
        public gridbaglayoutmaker()
        {
            InitializeComponent();
            lb_panel_edit.Items.Clear();
            addnewitem();
           // MessageBox.Show((lb_panel_edit.Items.Count).ToString());
        }
        void addnewitem()
        {

           

            //if(currentlengthpanel<=0){}else{currentlengthpanel+=1;}
            int currentlengthpanel = lb_panel_edit.Items.Count;
            lb_panel_edit.Items.Add( "GridBagLayout_(" + currentgridindex + ")_P" + (currentlengthpanel)+"_100%");
            int current_max_space = 100;

            int maxspacelimit = current_max_space;
            
          
            itemlist.Add(currentlengthpanel);

            int nextcolumn = currentlengthpanel; ;
            element_weight.Minimum = 10;
            element_weight.Maximum = 100;

            element_weight.Value = 100;
            gridwidth.Add("1");
            weightx.Add(maxspacelimit.ToString());
            ipadx.Add(width.Text);
            ipady.Add(height.Text);
            gridx.Add(currentlengthpanel.ToString());

            gridy.Add(row.Text);
            gridheight.Add("1");
            lb_panel_edit.SelectedIndex = currentlengthpanel;
            latest_index = 0; 
           //
        }
        public void setcurrentgridindex(int gridindex)
        {
            currentgridindex = gridindex;
        }

        private void gridbaglayoutmaker_Load(object sender, EventArgs e)
        {
            //             c.gridwidth = 2;
            //        c.weightx = 1;
            //        c.ipady = 40;
            //        c.ipadx = 0;
            //        c.fill = GridBagConstraints.BOTH;  
            //        c.gridx = 0;  
            //        c.gridy = 2;  
            // element_weight
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackbarval.Text = element_weight.Value.ToString()+"%";
            button3.BackColor =Color.Red;
            //  try { updateitem(); }
            // catch (Exception es) { }
        }

       
        void updateitem()
        {

            int currenttarget = lb_panel_edit.SelectedIndex;
         //   int currenttarget = lb_panel_edit.Items.Count -1-  currentindex;
            gridwidth[currenttarget] = colspan.Text;
            weightx[currenttarget] = element_weight.Value.ToString();
            ipadx[currenttarget] = width.Text;
            ipady[currenttarget] = height.Text;
            gridx[currenttarget] = column.Text;
            gridy[currenttarget] = row.Text;
            gridheight[currenttarget] = rowspan.Text;
            lb_panel_edit.Items[currenttarget] = "GridBagLayout_(" + currentgridindex + ")_P" + (currenttarget) + "_" + weightx[currenttarget] + "%";
            trackbarval.Text = weightx[currenttarget] + "%";
           // MessageBox.Show("currenttarget : " + currenttarget.ToString() + " , gridy : " + gridy[currenttarget] + " , gridx : " + gridx[currenttarget] + ", rowspan : " + gridheight[currenttarget]);
           
        }
        public void setbindtogridbag(List<string> objlist)
        {
            string[] toArrObjList = objlist.ToArray();
            string target = "_Pnl", target2 = "_Panel",target3="innerContainer";
            string filter = "FormField_";
            List<string> PanelList = new List<string>();
            for (int x = 0; x < toArrObjList.Length; x++)
            {
                if ((toArrObjList[x].Contains(target)) || (toArrObjList[x].Contains(target2)) || (toArrObjList[x].Contains(target3)))
                {
                    if ((!toArrObjList[x].Contains(filter)))
                    {
                        PanelList.Add(toArrObjList[x]);

                    }

                }
            }

            bindtoobj.Items.AddRange(PanelList.ToArray());
            try
            {
                bindtoobj.SelectedIndex = 0;
            }
            catch (ArgumentOutOfRangeException e)
            {
                MessageBox.Show("Please add JPanel first before adding element");
            }

        }

        private void lb_panel_edit_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                button3.BackColor =Color.Red;
              //  MessageBox.Show(itemlist[lb_panel_edit.SelectedIndex].ToString());
                editchangeitem();
              
            }
            catch (Exception es)
            {

           //     MessageBox.Show("hehe : "+es.ToString());
            } 
         
        

        }
       
     
        void editchangeitem()
        {


            int currenttarget = lb_panel_edit.SelectedIndex;
         //   int currenttarget = lb_panel_edit.Items.Count - 1- currentindex;
           // MessageBox.Show(lb_panel_edit.SelectedIndex.ToString());
         
            colspan.Text = gridwidth[currenttarget];
            element_weight.Value = Int32.Parse(weightx[currenttarget]);
            width.Text = ipadx[currenttarget];
            height.Text = ipady[currenttarget];
            column.Text = gridx[currenttarget];
            //MessageBox.Show(gridy[currenttarget]);
            row.Text = gridy[currenttarget];
            rowspan.Text = gridheight[currenttarget];
            trackbarval.Text = weightx[currenttarget] + "%";
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            addnewitem();
        }

        private void component_type_SelectedIndexChanged(object sender, EventArgs e)
        { try{updateitem();}catch (Exception es){ }}

        private void bindtoobj_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try { updateitem(); }
            //catch (Exception es) { }
        }

       

        private void height_TextChanged(object sender, EventArgs e)
        {
            button3.BackColor =Color.Red;
        }

        private void width_TextChanged(object sender, EventArgs e)
        {
            button3.BackColor =Color.Red;
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
              string objname = "GridBagLayout_" + currentgridindex+"_Pnl";
              string tobindlayout = bindtoobj.SelectedItem.ToString();
              string source_code = "\tJPanel " + objname + " = new JPanel();\n" +
                                    "\t\t " + objname + ".setLayout(new GridBagLayout());\n" +
                                      "\t\tGridBagConstraints c = new GridBagConstraints();  ;\n" +
                                    embedsettingcode("publishmode") +
                                   "\tc.fill = GridBagConstraints.HORIZONTAL;\n" +
                                    "\tc.gridx = 0;\n" +
                                    "\tc.gridy = 100;\n" +
                                    "\tc.weighty = 1;\n" +
                                    "\tc.weightx = 0;\n" +
                                    "\tc.anchor = GridBagConstraints.PAGE_END;\n" +
                                    "\t" + objname + ".add(new JLabel(\" \"), c);\n";
                                  
              formelementcode = source_code;
              bindsettingcode = "\t\t" + tobindlayout + ".add(" + objname + ");\n";
              this.Close();
        }
        string embedsettingcode(string type)
        {
            //JPanel panex = new JPanel(new GridLayout(0, 1));
            //            JLabel lblx = new JLabel(" ");
            //            LineBorder border = new LineBorder(Color.RED, 3);
            //            panex.setBorder(border);
            //            panex.add(lblx);
            //            c.weightx = 0.2;
            //            c.fill = GridBagConFupdatstraints.BOTH;
            //
            //            c.gridx = 0;
            //            c.gridy = 0;
            //            c.ipady = 40;
            //            c.gridheight = 2;
            //            pane.add(panex, c);  

            //         colspan.Text = gridwidth[currenttarget];
            //            element_weight.Value = Int32.Parse(weightx[currenttarget]);
            //            width.Text = ipadx[currenttarget];
            //            height.Text = ipady[currenttarget];
            //            column.Text = gridx[currenttarget];
            //            row.Text = gridy[currenttarget];
            //            rowspan.Text = gridheight[currenttarget];
            string source_code = "";
            for (int x = 0; x < itemlist.Count; x++)
            {
                string gridlength = "";
                string ipadding = "";
                if (gridheight[x] != "0")
                    gridlength +="\t\t  c.gridheight = " + gridheight[x] + ";\n" ;
                if (gridwidth[x] != "0")
                    gridlength += "\t\t  c.gridwidth = " + gridwidth[x] + ";\n";

                if (ipadx[x] == "AUTO")
                    ipadding += "\t\t c.ipadx = 0;\n";
                else
                    ipadding += "\t\t c.ipadx = " + ipadx[x] + ";\n";
                if (ipady[x] == "AUTO")
                    ipadding += "\t\t c.ipady = 0;\n";
                else
                    ipadding += "\t\t c.ipady = " + ipady[x] + ";\n";
               double weightx_ = Double.Parse(weightx[x]);
                double weightcount = weightx_ / 100;

               // MessageBox.Show(weightcount.ToString());
                string tobindlayout = "";
                 weightx_ = weightcount;
                 string objname = "GridBagLayout_" + currentgridindex + "_" + x + "_Pnl";
                string objreference_name = "GridBagLayout_(" + currentgridindex + ")_P" + (x) + "_" + weightx[x] + "%";
                if (type == "editmode")
                {
                    tobindlayout = "innerContainer";
                    source_code += "\t\t JPanel " + objname + " = new JPanel(new GridLayout(0,1));\n" +
                             "\t\t JLabel lbl" + objname + " = new JLabel(\"" + objreference_name + "\",SwingConstants.CENTER);\n" +
                            "\t\t" + objname + ".setBorder(border);\n" +
                            "\t\t" + objname + ".add(lbl" + objname + ");\n" +
                            "\t\t  c.weightx = " + weightx_ + ";\n" +
                            "\t\t  c.fill = GridBagConstraints.BOTH;\n  " +
                            "\t\t  c.gridx = " + gridx[x] + "; \n " +
                            "\t\t  c.gridy = " + gridy[x] + ";\n " +

                            gridlength +
                            ipadding +
                            "\t\t" + tobindlayout + ".add(" + objname + ", c); \n ";
                }
                 if (type == "publishmode")
                 {
                     panelreference.Add(objname);
                     tobindlayout = "GridBagLayout_" + currentgridindex + "_Pnl";
                     source_code += "\t\t JPanel " + objname + " = new JPanel(new GridLayout(0,1));\n" +
                            "\t\t  c.weightx = " + weightx_ + ";\n" +
                            "\t\t  c.fill = GridBagConstraints.BOTH;\n  " +
                            "\t\t  c.gridx = " + gridx[x] + "; \n " +
                            "\t\t  c.gridy = " + gridy[x] + ";\n " +

                            gridlength +
                            ipadding +
                            "\t\t" + tobindlayout + ".add(" + objname + ", c); \n ";
                 }
                
               

            }
            return source_code;
        }
        private void previewdesign_Click(object sender, EventArgs e)
        {
            // compile preview design
            string classname = "gridbagdesigner";
            string filename = classname + ".java";
            string javasourcecode = "import java.awt.*;\n" +
                              "import java.awt.event.*;\n" +
                                "import javax.swing.border.LineBorder;\n" +
                              "import javax.swing.*;\n" +
                              "public class " + classname + " extends JFrame {\n" +
                              "\tContainer container = getContentPane();\n"+
                              "\tJPanel innerContainer;\n" +
                               "\t//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_ELEMENT_DECLARATION" +
                              "\n\tpublic " + classname + "(){\n" +
                              "\t\tinnerContainer = new JPanel();\n" +
                              "\t\tinnerContainer.setLayout(new GridBagLayout());\n" +
                              "\t\tcontainer.setLayout(new GridLayout(1,1));\n" +
                               "\t\tGridBagConstraints c = new GridBagConstraints();  ;\n" +
                               "\t\t innerContainer.setLayout(new GridBagLayout());  \n" +
                                " \t\tLineBorder border = new LineBorder(Color.RED, 3);" +
                                 embedsettingcode("editmode") +
                              "\t//PLEASE_DO_NOT_DELETE_OR_MODIFY_THIS_LINE_BIND_SETTING\n" +
                                "\tc.fill = GridBagConstraints.HORIZONTAL;\n" +
                                "\tc.gridx = 0;\n" +
                                "\tc.gridy = 100;\n" +
                                "\tc.weighty = 1;\n" +
                                "\tc.weightx = 0;\n" +
                                "\tc.anchor = GridBagConstraints.PAGE_END;\n"+
                                "\tinnerContainer.add(new JLabel(\" \"), c);\n" +
                               "\t\tcontainer.add(innerContainer);\n" +
                              "\t\tsetSize(600,400);\n" +
                              "\t\tinnerContainer.setPreferredSize(new Dimension(600,400));\n" +
                              "\t\tsetVisible(true);\n" +
                              "\t\tsetTitle(\"GridBagLayout Design Sample\");\n" +
                              "\t}"+
                               "\tpublic static void main(String[] args) {\n" +
                               "\t\t" + classname + " app = new " + classname + "();\n" +
                              "\t\tapp.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);\n" +
                              "\t}\n" +
                              "}\n";
            


           
            string compiledClass = classname;
            if (File.Exists(filename))
            {
                File.Delete(filename);
                File.Delete(compiledClass + ".class");
            }

            File.WriteAllText(filename, javasourcecode);
            compileJava(filename);
            runJava(compiledClass);
        }
        private void compileJava(string filename)
        {
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "javac.exe";
            //startInfo.RedirectStandardOutput = false;
            //startInfo.RedirectStandardError = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.CreateNoWindow = true;
            startInfo.Arguments = filename;
            p.StartInfo = startInfo;
            p.Start();
         
         

            p.WaitForExit();


        }

        private void runJava(string filename)
        {
          
            Process p = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "java.exe";
            //startInfo.RedirectStandardOutput = false;
            //startInfo.RedirectStandardError = false;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = filename;
            p.StartInfo = startInfo;
            p.Start();
            p.WaitForExit();

        }

        private void column_ValueChanged(object sender, EventArgs e)
        {

            button3.BackColor =Color.Red;
        }

        private void colspan_ValueChanged(object sender, EventArgs e)
        {
            button3.BackColor =Color.Red;
        }

        private void row_ValueChanged(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
        }

        private void rowspan_ValueChanged(object sender, EventArgs e)
        {
            button3.BackColor =Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            try { updateitem();
            button3.BackColor = Color.LimeGreen;
            }
            catch (Exception es) { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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

    }
}
