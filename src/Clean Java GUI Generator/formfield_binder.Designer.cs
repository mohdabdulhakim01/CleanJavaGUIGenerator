namespace Clean_Java_GUI_Generator
{
    partial class formfield_binder
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
            this.ff_obj_last_name = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.FFieldBindtoObj = new System.Windows.Forms.ComboBox();
            this.FFieldaddcode = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.FFieldTitle = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.FFieldField_lb = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.FFieldObjectName = new System.Windows.Forms.TextBox();
            this.component_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ff_obj_last_name
            // 
            this.ff_obj_last_name.AutoSize = true;
            this.ff_obj_last_name.Location = new System.Drawing.Point(121, 9);
            this.ff_obj_last_name.Name = "ff_obj_last_name";
            this.ff_obj_last_name.Size = new System.Drawing.Size(86, 13);
            this.ff_obj_last_name.TabIndex = 55;
            this.ff_obj_last_name.Text = "FormField_FField";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(12, 9);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(103, 13);
            this.label34.TabIndex = 54;
            this.label34.Text = "Final object name is ";
            // 
            // FFieldBindtoObj
            // 
            this.FFieldBindtoObj.FormattingEnabled = true;
            this.FFieldBindtoObj.Location = new System.Drawing.Point(399, 36);
            this.FFieldBindtoObj.Name = "FFieldBindtoObj";
            this.FFieldBindtoObj.Size = new System.Drawing.Size(132, 21);
            this.FFieldBindtoObj.TabIndex = 53;
            // 
            // FFieldaddcode
            // 
            this.FFieldaddcode.Location = new System.Drawing.Point(403, 156);
            this.FFieldaddcode.Name = "FFieldaddcode";
            this.FFieldaddcode.Size = new System.Drawing.Size(123, 43);
            this.FFieldaddcode.TabIndex = 52;
            this.FFieldaddcode.Text = "Bind FormField";
            this.FFieldaddcode.UseVisualStyleBackColor = true;
            this.FFieldaddcode.Click += new System.EventHandler(this.FFieldaddcode_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Title : ";
            // 
            // FFieldTitle
            // 
            this.FFieldTitle.Location = new System.Drawing.Point(121, 76);
            this.FFieldTitle.Name = "FFieldTitle";
            this.FFieldTitle.Size = new System.Drawing.Size(113, 20);
            this.FFieldTitle.TabIndex = 51;
            this.FFieldTitle.Text = "FormField_Title";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.FFieldField_lb);
            this.groupBox5.Location = new System.Drawing.Point(309, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 64);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Field Type";
            // 
            // FFieldField_lb
            // 
            this.FFieldField_lb.FormattingEnabled = true;
            this.FFieldField_lb.Items.AddRange(new object[] {
            "1 Row , 2 Columns",
            "2 Rows , 1 Column"});
            this.FFieldField_lb.Location = new System.Drawing.Point(6, 20);
            this.FFieldField_lb.Name = "FFieldField_lb";
            this.FFieldField_lb.Size = new System.Drawing.Size(210, 30);
            this.FFieldField_lb.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Object Name : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Bind To Object : ";
            // 
            // FFieldObjectName
            // 
            this.FFieldObjectName.Location = new System.Drawing.Point(121, 36);
            this.FFieldObjectName.Name = "FFieldObjectName";
            this.FFieldObjectName.Size = new System.Drawing.Size(113, 20);
            this.FFieldObjectName.TabIndex = 47;
            this.FFieldObjectName.Text = "FormField";
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
            "JSeparator"});
            this.component_type.Location = new System.Drawing.Point(121, 117);
            this.component_type.Name = "component_type";
            this.component_type.Size = new System.Drawing.Size(113, 21);
            this.component_type.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Component Type :";
            // 
            // formfield_binder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 208);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.component_type);
            this.Controls.Add(this.ff_obj_last_name);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.FFieldBindtoObj);
            this.Controls.Add(this.FFieldaddcode);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FFieldTitle);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FFieldObjectName);
            this.Name = "formfield_binder";
            this.Text = "Form Field Binder";
            this.Load += new System.EventHandler(this.formfield_binder_Load);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ff_obj_last_name;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox FFieldBindtoObj;
        private System.Windows.Forms.Button FFieldaddcode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FFieldTitle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox FFieldField_lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FFieldObjectName;
        private System.Windows.Forms.ComboBox component_type;
        private System.Windows.Forms.Label label1;
    }
}