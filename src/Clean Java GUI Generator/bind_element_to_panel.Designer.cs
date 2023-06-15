namespace Clean_Java_GUI_Generator
{
    partial class bind_element_to_panel
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
            this.comp_obj_last_name = new System.Windows.Forms.Label();
            this.objnametitle = new System.Windows.Forms.Label();
            this.bindtoObject = new System.Windows.Forms.ComboBox();
            this.elementvalue = new System.Windows.Forms.RichTextBox();
            this.bindelement = new System.Windows.Forms.Button();
            this.elem_val_title = new System.Windows.Forms.Label();
            this.objname_title = new System.Windows.Forms.Label();
            this.bindtopanel_title = new System.Windows.Forms.Label();
            this.element_name_inp = new System.Windows.Forms.TextBox();
            this.component_type = new System.Windows.Forms.ComboBox();
            this.type_title = new System.Windows.Forms.Label();
            this.of_bindfilepath = new System.Windows.Forms.Button();
            this.elementvalue2 = new System.Windows.Forms.RichTextBox();
            this.value2_title = new System.Windows.Forms.Label();
            this.image_name_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comp_obj_last_name
            // 
            this.comp_obj_last_name.AutoSize = true;
            this.comp_obj_last_name.Location = new System.Drawing.Point(96, 9);
            this.comp_obj_last_name.Name = "comp_obj_last_name";
            this.comp_obj_last_name.Size = new System.Drawing.Size(112, 13);
            this.comp_obj_last_name.TabIndex = 57;
            this.comp_obj_last_name.Text = "Component_ComType";
            // 
            // objnametitle
            // 
            this.objnametitle.AutoSize = true;
            this.objnametitle.Location = new System.Drawing.Point(8, 9);
            this.objnametitle.Name = "objnametitle";
            this.objnametitle.Size = new System.Drawing.Size(103, 13);
            this.objnametitle.TabIndex = 56;
            this.objnametitle.Text = "Final object name is ";
            // 
            // bindtoObject
            // 
            this.bindtoObject.FormattingEnabled = true;
            this.bindtoObject.Location = new System.Drawing.Point(373, 30);
            this.bindtoObject.Name = "bindtoObject";
            this.bindtoObject.Size = new System.Drawing.Size(170, 21);
            this.bindtoObject.TabIndex = 55;
            // 
            // elementvalue
            // 
            this.elementvalue.Location = new System.Drawing.Point(97, 76);
            this.elementvalue.Name = "elementvalue";
            this.elementvalue.Size = new System.Drawing.Size(176, 44);
            this.elementvalue.TabIndex = 54;
            this.elementvalue.Text = "Some Text";
            this.elementvalue.TextChanged += new System.EventHandler(this.elementvalue_TextChanged);
            // 
            // bindelement
            // 
            this.bindelement.Location = new System.Drawing.Point(433, 175);
            this.bindelement.Name = "bindelement";
            this.bindelement.Size = new System.Drawing.Size(110, 50);
            this.bindelement.TabIndex = 53;
            this.bindelement.Text = "Bind Component";
            this.bindelement.UseVisualStyleBackColor = true;
            this.bindelement.Click += new System.EventHandler(this.bindelement_Click);
            // 
            // elem_val_title
            // 
            this.elem_val_title.AutoSize = true;
            this.elem_val_title.Location = new System.Drawing.Point(8, 79);
            this.elem_val_title.Name = "elem_val_title";
            this.elem_val_title.Size = new System.Drawing.Size(52, 13);
            this.elem_val_title.TabIndex = 52;
            this.elem_val_title.Text = "Value 1 : ";
            // 
            // objname_title
            // 
            this.objname_title.AutoSize = true;
            this.objname_title.Location = new System.Drawing.Point(8, 32);
            this.objname_title.Name = "objname_title";
            this.objname_title.Size = new System.Drawing.Size(78, 13);
            this.objname_title.TabIndex = 49;
            this.objname_title.Text = "Object Name : ";
            // 
            // bindtopanel_title
            // 
            this.bindtopanel_title.AutoSize = true;
            this.bindtopanel_title.Location = new System.Drawing.Point(280, 33);
            this.bindtopanel_title.Name = "bindtopanel_title";
            this.bindtopanel_title.Size = new System.Drawing.Size(83, 13);
            this.bindtopanel_title.TabIndex = 51;
            this.bindtopanel_title.Text = "Bind To Panel : ";
            // 
            // element_name_inp
            // 
            this.element_name_inp.Location = new System.Drawing.Point(97, 30);
            this.element_name_inp.Name = "element_name_inp";
            this.element_name_inp.Size = new System.Drawing.Size(177, 20);
            this.element_name_inp.TabIndex = 50;
            this.element_name_inp.Text = "Component";
            this.element_name_inp.TextChanged += new System.EventHandler(this.element_name_inp_TextChanged);
            // 
            // component_type
            // 
            this.component_type.FormattingEnabled = true;
            this.component_type.Items.AddRange(new object[] {
            "JButton",
            "JCheckBox",
            "JLabel",
            "JRadioButton",
            "JTextArea",
            "JTextField",
            "ImageIcon",
            "JSeparator",
            "JTable",
            "EmptyHeight"});
            this.component_type.Location = new System.Drawing.Point(97, 52);
            this.component_type.Name = "component_type";
            this.component_type.Size = new System.Drawing.Size(176, 21);
            this.component_type.TabIndex = 59;
            this.component_type.SelectedIndexChanged += new System.EventHandler(this.component_type_SelectedIndexChanged);
            // 
            // type_title
            // 
            this.type_title.AutoSize = true;
            this.type_title.Location = new System.Drawing.Point(8, 55);
            this.type_title.Name = "type_title";
            this.type_title.Size = new System.Drawing.Size(37, 13);
            this.type_title.TabIndex = 58;
            this.type_title.Text = "Type :";
            // 
            // of_bindfilepath
            // 
            this.of_bindfilepath.Location = new System.Drawing.Point(18, 202);
            this.of_bindfilepath.Name = "of_bindfilepath";
            this.of_bindfilepath.Size = new System.Drawing.Size(75, 23);
            this.of_bindfilepath.TabIndex = 60;
            this.of_bindfilepath.Text = "Open File...";
            this.of_bindfilepath.UseVisualStyleBackColor = true;
            this.of_bindfilepath.Click += new System.EventHandler(this.of_bindfilepath_Click);
            // 
            // elementvalue2
            // 
            this.elementvalue2.Location = new System.Drawing.Point(97, 126);
            this.elementvalue2.Name = "elementvalue2";
            this.elementvalue2.Size = new System.Drawing.Size(176, 44);
            this.elementvalue2.TabIndex = 63;
            this.elementvalue2.Text = "Option 1,Option 2,Option 3";
            // 
            // value2_title
            // 
            this.value2_title.AutoSize = true;
            this.value2_title.Location = new System.Drawing.Point(8, 129);
            this.value2_title.Name = "value2_title";
            this.value2_title.Size = new System.Drawing.Size(52, 13);
            this.value2_title.TabIndex = 62;
            this.value2_title.Text = "Value 2 : ";
            // 
            // image_name_lbl
            // 
            this.image_name_lbl.AutoSize = true;
            this.image_name_lbl.Location = new System.Drawing.Point(99, 212);
            this.image_name_lbl.Name = "image_name_lbl";
            this.image_name_lbl.Size = new System.Drawing.Size(33, 13);
            this.image_name_lbl.TabIndex = 64;
            this.image_name_lbl.Text = "imglbl";
            // 
            // bind_element_to_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 237);
            this.Controls.Add(this.image_name_lbl);
            this.Controls.Add(this.elementvalue2);
            this.Controls.Add(this.value2_title);
            this.Controls.Add(this.of_bindfilepath);
            this.Controls.Add(this.component_type);
            this.Controls.Add(this.type_title);
            this.Controls.Add(this.comp_obj_last_name);
            this.Controls.Add(this.objnametitle);
            this.Controls.Add(this.bindtoObject);
            this.Controls.Add(this.elementvalue);
            this.Controls.Add(this.bindelement);
            this.Controls.Add(this.elem_val_title);
            this.Controls.Add(this.objname_title);
            this.Controls.Add(this.bindtopanel_title);
            this.Controls.Add(this.element_name_inp);
            this.Name = "bind_element_to_panel";
            this.Text = "Bind Element to Panel";
            this.Load += new System.EventHandler(this.bind_element_to_panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label comp_obj_last_name;
        private System.Windows.Forms.Label objnametitle;
        private System.Windows.Forms.ComboBox bindtoObject;
        private System.Windows.Forms.RichTextBox elementvalue;
        private System.Windows.Forms.Button bindelement;
        private System.Windows.Forms.Label elem_val_title;
        private System.Windows.Forms.Label objname_title;
        private System.Windows.Forms.Label bindtopanel_title;
        private System.Windows.Forms.TextBox element_name_inp;
        private System.Windows.Forms.ComboBox component_type;
        private System.Windows.Forms.Label type_title;
        private System.Windows.Forms.Button of_bindfilepath;
        private System.Windows.Forms.RichTextBox elementvalue2;
        private System.Windows.Forms.Label value2_title;
        private System.Windows.Forms.Label image_name_lbl;

    }
}