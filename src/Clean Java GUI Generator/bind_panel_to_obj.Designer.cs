namespace Clean_Java_GUI_Generator
{
    partial class bind_panel_to_obj
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
            this.jp_obj_last_name = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.PanelbindToObject = new System.Windows.Forms.ComboBox();
            this.Paneladdcode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.Panellayout_lb = new System.Windows.Forms.ListBox();
            this.PanellayoutParam = new System.Windows.Forms.TextBox();
            this.PanelobjName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // jp_obj_last_name
            // 
            this.jp_obj_last_name.AutoSize = true;
            this.jp_obj_last_name.Location = new System.Drawing.Point(121, 9);
            this.jp_obj_last_name.Name = "jp_obj_last_name";
            this.jp_obj_last_name.Size = new System.Drawing.Size(60, 13);
            this.jp_obj_last_name.TabIndex = 38;
            this.jp_obj_last_name.Text = "JPanel_Pnl";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(12, 9);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(103, 13);
            this.label33.TabIndex = 37;
            this.label33.Text = "Final object name is ";
            // 
            // PanelbindToObject
            // 
            this.PanelbindToObject.FormattingEnabled = true;
            this.PanelbindToObject.Location = new System.Drawing.Point(369, 29);
            this.PanelbindToObject.Name = "PanelbindToObject";
            this.PanelbindToObject.Size = new System.Drawing.Size(172, 21);
            this.PanelbindToObject.TabIndex = 36;
            // 
            // Paneladdcode
            // 
            this.Paneladdcode.Location = new System.Drawing.Point(428, 159);
            this.Paneladdcode.Name = "Paneladdcode";
            this.Paneladdcode.Size = new System.Drawing.Size(113, 34);
            this.Paneladdcode.TabIndex = 35;
            this.Paneladdcode.Text = "Add to Code";
            this.Paneladdcode.UseVisualStyleBackColor = true;
            this.Paneladdcode.Click += new System.EventHandler(this.Paneladdcode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Object Name : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Bind To Object : ";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.Panellayout_lb);
            this.groupBox12.Location = new System.Drawing.Point(6, 56);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(259, 105);
            this.groupBox12.TabIndex = 31;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Layout Type";
            // 
            // Panellayout_lb
            // 
            this.Panellayout_lb.FormattingEnabled = true;
            this.Panellayout_lb.Items.AddRange(new object[] {
            "BoxLayout",
            "BorderLayout",
            "GridLayout",
            "FlowLayout"});
            this.Panellayout_lb.Location = new System.Drawing.Point(6, 20);
            this.Panellayout_lb.Name = "Panellayout_lb";
            this.Panellayout_lb.Size = new System.Drawing.Size(247, 82);
            this.Panellayout_lb.TabIndex = 9;
            this.Panellayout_lb.SelectedIndexChanged += new System.EventHandler(this.Panellayout_lb_SelectedIndexChanged);
            // 
            // PanellayoutParam
            // 
            this.PanellayoutParam.Location = new System.Drawing.Point(112, 167);
            this.PanellayoutParam.Name = "PanellayoutParam";
            this.PanellayoutParam.Size = new System.Drawing.Size(153, 20);
            this.PanellayoutParam.TabIndex = 33;
            this.PanellayoutParam.Text = "5,5";
            // 
            // PanelobjName
            // 
            this.PanelobjName.Location = new System.Drawing.Point(91, 30);
            this.PanelobjName.Name = "PanelobjName";
            this.PanelobjName.Size = new System.Drawing.Size(174, 20);
            this.PanelobjName.TabIndex = 30;
            this.PanelobjName.Text = "JPanel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Layout Parameter : ";
            // 
            // bind_panel_to_obj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 217);
            this.Controls.Add(this.jp_obj_last_name);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.PanelbindToObject);
            this.Controls.Add(this.Paneladdcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.PanellayoutParam);
            this.Controls.Add(this.PanelobjName);
            this.Controls.Add(this.label3);
            this.Name = "bind_panel_to_obj";
            this.Text = "bind_panel_to_obj";
            this.Load += new System.EventHandler(this.bind_panel_to_obj_Load);
            this.groupBox12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label jp_obj_last_name;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox PanelbindToObject;
        private System.Windows.Forms.Button Paneladdcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ListBox Panellayout_lb;
        private System.Windows.Forms.TextBox PanellayoutParam;
        private System.Windows.Forms.TextBox PanelobjName;
        private System.Windows.Forms.Label label3;

    }
}