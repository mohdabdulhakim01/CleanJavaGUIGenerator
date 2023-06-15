namespace Clean_Java_GUI_Generator
{
    partial class formcontainer
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
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.layouttype_lb = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.classname_inp = new System.Windows.Forms.TextBox();
            this.chckVisibility = new System.Windows.Forms.CheckBox();
            this.generate_gui = new System.Windows.Forms.Button();
            this.txtSizeWidth = new System.Windows.Forms.TextBox();
            this.chkbox_addmainclass = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSizeHeight = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTitle_inp = new System.Windows.Forms.TextBox();
            this.groupBox10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.layouttype_lb);
            this.groupBox10.Location = new System.Drawing.Point(20, 154);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(158, 104);
            this.groupBox10.TabIndex = 17;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Layout Type";
            // 
            // layouttype_lb
            // 
            this.layouttype_lb.FormattingEnabled = true;
            this.layouttype_lb.Items.AddRange(new object[] {
            "BoxLayout",
            "BorderLayout",
            "GridLayout",
            "FlowLayout"});
            this.layouttype_lb.Location = new System.Drawing.Point(6, 20);
            this.layouttype_lb.Name = "layouttype_lb";
            this.layouttype_lb.Size = new System.Drawing.Size(146, 82);
            this.layouttype_lb.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.classname_inp);
            this.groupBox2.Location = new System.Drawing.Point(21, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 46);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Class Name";
            // 
            // classname_inp
            // 
            this.classname_inp.Location = new System.Drawing.Point(6, 19);
            this.classname_inp.Name = "classname_inp";
            this.classname_inp.Size = new System.Drawing.Size(407, 20);
            this.classname_inp.TabIndex = 5;
            this.classname_inp.Text = "Default";
            // 
            // chckVisibility
            // 
            this.chckVisibility.AutoSize = true;
            this.chckVisibility.Checked = true;
            this.chckVisibility.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckVisibility.Location = new System.Drawing.Point(147, 107);
            this.chckVisibility.Name = "chckVisibility";
            this.chckVisibility.Size = new System.Drawing.Size(62, 17);
            this.chckVisibility.TabIndex = 16;
            this.chckVisibility.Text = "Visibility";
            this.chckVisibility.UseVisualStyleBackColor = true;
            // 
            // generate_gui
            // 
            this.generate_gui.Location = new System.Drawing.Point(319, 219);
            this.generate_gui.Name = "generate_gui";
            this.generate_gui.Size = new System.Drawing.Size(115, 39);
            this.generate_gui.TabIndex = 10;
            this.generate_gui.Text = "Generate Container";
            this.generate_gui.UseVisualStyleBackColor = true;
            this.generate_gui.Click += new System.EventHandler(this.generate_gui_Click);
            // 
            // txtSizeWidth
            // 
            this.txtSizeWidth.Location = new System.Drawing.Point(27, 121);
            this.txtSizeWidth.Name = "txtSizeWidth";
            this.txtSizeWidth.Size = new System.Drawing.Size(39, 20);
            this.txtSizeWidth.TabIndex = 13;
            this.txtSizeWidth.Text = "600";
            // 
            // chkbox_addmainclass
            // 
            this.chkbox_addmainclass.AutoSize = true;
            this.chkbox_addmainclass.Checked = true;
            this.chkbox_addmainclass.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbox_addmainclass.Location = new System.Drawing.Point(147, 130);
            this.chkbox_addmainclass.Name = "chkbox_addmainclass";
            this.chkbox_addmainclass.Size = new System.Drawing.Size(99, 17);
            this.chkbox_addmainclass.TabIndex = 12;
            this.chkbox_addmainclass.Text = "Add Main Class";
            this.chkbox_addmainclass.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label1);
            this.groupBox8.Controls.Add(this.txtSizeHeight);
            this.groupBox8.Location = new System.Drawing.Point(21, 102);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(120, 46);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "X";
            // 
            // txtSizeHeight
            // 
            this.txtSizeHeight.Location = new System.Drawing.Point(71, 19);
            this.txtSizeHeight.Name = "txtSizeHeight";
            this.txtSizeHeight.Size = new System.Drawing.Size(39, 20);
            this.txtSizeHeight.TabIndex = 8;
            this.txtSizeHeight.Text = "400";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTitle_inp);
            this.groupBox6.Location = new System.Drawing.Point(20, 57);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(420, 46);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "GUI Title";
            // 
            // txtTitle_inp
            // 
            this.txtTitle_inp.Location = new System.Drawing.Point(6, 19);
            this.txtTitle_inp.Name = "txtTitle_inp";
            this.txtTitle_inp.Size = new System.Drawing.Size(408, 20);
            this.txtTitle_inp.TabIndex = 5;
            this.txtTitle_inp.Text = "AppName";
            // 
            // formcontainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 273);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chckVisibility);
            this.Controls.Add(this.generate_gui);
            this.Controls.Add(this.txtSizeWidth);
            this.Controls.Add(this.chkbox_addmainclass);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Name = "formcontainer";
            this.Text = "Form Settings";
            this.Load += new System.EventHandler(this.formcontainer_Load);
            this.groupBox10.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ListBox layouttype_lb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox classname_inp;
        private System.Windows.Forms.CheckBox chckVisibility;
        private System.Windows.Forms.Button generate_gui;
        private System.Windows.Forms.TextBox txtSizeWidth;
        private System.Windows.Forms.CheckBox chkbox_addmainclass;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSizeHeight;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTitle_inp;
    }
}