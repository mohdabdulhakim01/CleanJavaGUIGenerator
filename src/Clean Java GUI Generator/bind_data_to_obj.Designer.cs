namespace Clean_Java_GUI_Generator
{
    partial class bind_data_to_obj
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
            this.lblObjName = new System.Windows.Forms.Label();
            this.objName = new System.Windows.Forms.TextBox();
            this.bind_data = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BindToObj = new System.Windows.Forms.Label();
            this.valueBindData = new System.Windows.Forms.TextBox();
            this.lblBindValue = new System.Windows.Forms.Label();
            this.cb_bindto = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblObjName
            // 
            this.lblObjName.AutoSize = true;
            this.lblObjName.Location = new System.Drawing.Point(22, 15);
            this.lblObjName.Name = "lblObjName";
            this.lblObjName.Size = new System.Drawing.Size(78, 13);
            this.lblObjName.TabIndex = 0;
            this.lblObjName.Text = "Object Name : ";
            // 
            // objName
            // 
            this.objName.Location = new System.Drawing.Point(140, 12);
            this.objName.Name = "objName";
            this.objName.Size = new System.Drawing.Size(221, 20);
            this.objName.TabIndex = 1;
            // 
            // bind_data
            // 
            this.bind_data.Location = new System.Drawing.Point(279, 100);
            this.bind_data.Name = "bind_data";
            this.bind_data.Size = new System.Drawing.Size(82, 33);
            this.bind_data.TabIndex = 2;
            this.bind_data.Text = "Bind Data";
            this.bind_data.UseVisualStyleBackColor = true;
            this.bind_data.Click += new System.EventHandler(this.bind_data_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BindToObj
            // 
            this.BindToObj.AutoSize = true;
            this.BindToObj.Location = new System.Drawing.Point(22, 41);
            this.BindToObj.Name = "BindToObj";
            this.BindToObj.Size = new System.Drawing.Size(53, 13);
            this.BindToObj.TabIndex = 4;
            this.BindToObj.Text = "Bind To : ";
            // 
            // valueBindData
            // 
            this.valueBindData.Location = new System.Drawing.Point(140, 64);
            this.valueBindData.Name = "valueBindData";
            this.valueBindData.Size = new System.Drawing.Size(221, 20);
            this.valueBindData.TabIndex = 7;
            // 
            // lblBindValue
            // 
            this.lblBindValue.AutoSize = true;
            this.lblBindValue.Location = new System.Drawing.Point(22, 67);
            this.lblBindValue.Name = "lblBindValue";
            this.lblBindValue.Size = new System.Drawing.Size(58, 13);
            this.lblBindValue.TabIndex = 6;
            this.lblBindValue.Text = "Bind Value";
            // 
            // cb_bindto
            // 
            this.cb_bindto.FormattingEnabled = true;
            this.cb_bindto.Location = new System.Drawing.Point(140, 39);
            this.cb_bindto.Name = "cb_bindto";
            this.cb_bindto.Size = new System.Drawing.Size(221, 21);
            this.cb_bindto.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Color Picker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bind_data_to_obj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 134);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_bindto);
            this.Controls.Add(this.valueBindData);
            this.Controls.Add(this.lblBindValue);
            this.Controls.Add(this.BindToObj);
            this.Controls.Add(this.bind_data);
            this.Controls.Add(this.objName);
            this.Controls.Add(this.lblObjName);
            this.Name = "bind_data_to_obj";
            this.Text = "Bind Data To Object";
            this.Load += new System.EventHandler(this.bind_data_to_obj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblObjName;
        private System.Windows.Forms.TextBox objName;
        private System.Windows.Forms.Button bind_data;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label BindToObj;
        private System.Windows.Forms.TextBox valueBindData;
        private System.Windows.Forms.Label lblBindValue;
        private System.Windows.Forms.ComboBox cb_bindto;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button1;
    }
}