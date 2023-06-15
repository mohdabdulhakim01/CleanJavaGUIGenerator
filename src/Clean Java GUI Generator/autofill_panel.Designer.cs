namespace Clean_Java_GUI_Generator
{
    partial class autofill_panel
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
            this.af_bindto = new System.Windows.Forms.ComboBox();
            this.BindToObj = new System.Windows.Forms.Label();
            this.bind_data = new System.Windows.Forms.Button();
            this.lblBindValue = new System.Windows.Forms.Label();
            this.af_valueBindData = new System.Windows.Forms.TextBox();
            this.af_comp_Type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // af_bindto
            // 
            this.af_bindto.FormattingEnabled = true;
            this.af_bindto.Location = new System.Drawing.Point(130, 12);
            this.af_bindto.Name = "af_bindto";
            this.af_bindto.Size = new System.Drawing.Size(221, 21);
            this.af_bindto.TabIndex = 17;
            // 
            // BindToObj
            // 
            this.BindToObj.AutoSize = true;
            this.BindToObj.Location = new System.Drawing.Point(12, 14);
            this.BindToObj.Name = "BindToObj";
            this.BindToObj.Size = new System.Drawing.Size(53, 13);
            this.BindToObj.TabIndex = 14;
            this.BindToObj.Text = "Bind To : ";
            // 
            // bind_data
            // 
            this.bind_data.Location = new System.Drawing.Point(269, 112);
            this.bind_data.Name = "bind_data";
            this.bind_data.Size = new System.Drawing.Size(82, 33);
            this.bind_data.TabIndex = 12;
            this.bind_data.Text = "Bind Data";
            this.bind_data.UseVisualStyleBackColor = true;
            this.bind_data.Click += new System.EventHandler(this.bind_data_Click);
            // 
            // lblBindValue
            // 
            this.lblBindValue.AutoSize = true;
            this.lblBindValue.Location = new System.Drawing.Point(12, 69);
            this.lblBindValue.Name = "lblBindValue";
            this.lblBindValue.Size = new System.Drawing.Size(59, 13);
            this.lblBindValue.TabIndex = 15;
            this.lblBindValue.Text = "Fill Count : ";
            // 
            // af_valueBindData
            // 
            this.af_valueBindData.Location = new System.Drawing.Point(130, 66);
            this.af_valueBindData.Name = "af_valueBindData";
            this.af_valueBindData.Size = new System.Drawing.Size(221, 20);
            this.af_valueBindData.TabIndex = 16;
            // 
            // af_comp_Type
            // 
            this.af_comp_Type.FormattingEnabled = true;
            this.af_comp_Type.Items.AddRange(new object[] {
            "EmptyFill",
            "FormField + TextField",
            "FormField + RadioButton",
            "FormField + CheckBox",
            "JLabel",
            "JButton",
            "ImageIcon",
            "JCheckBox",
            "JRadioButton",
            "JTextField",
            "JTextArea",
            "JSeparator"});
            this.af_comp_Type.Location = new System.Drawing.Point(130, 39);
            this.af_comp_Type.Name = "af_comp_Type";
            this.af_comp_Type.Size = new System.Drawing.Size(221, 21);
            this.af_comp_Type.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Component Type: ";
            // 
            // autofill_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 165);
            this.Controls.Add(this.af_comp_Type);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.af_bindto);
            this.Controls.Add(this.af_valueBindData);
            this.Controls.Add(this.lblBindValue);
            this.Controls.Add(this.BindToObj);
            this.Controls.Add(this.bind_data);
            this.Name = "autofill_panel";
            this.Text = "AutoFill Panel With Object";
            this.Load += new System.EventHandler(this.autofill_panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox af_bindto;
        private System.Windows.Forms.Label BindToObj;
        private System.Windows.Forms.Button bind_data;
        private System.Windows.Forms.Label lblBindValue;
        private System.Windows.Forms.TextBox af_valueBindData;
        private System.Windows.Forms.ComboBox af_comp_Type;
        private System.Windows.Forms.Label label1;
    }
}