namespace Clean_Java_GUI_Generator
{
    partial class sqlfilltable
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
            this.bindtoObject = new System.Windows.Forms.ComboBox();
            this.bindtopanel_title = new System.Windows.Forms.Label();
            this.generatedresult = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tablename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlcondition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bindtoObject
            // 
            this.bindtoObject.FormattingEnabled = true;
            this.bindtoObject.Location = new System.Drawing.Point(114, 12);
            this.bindtoObject.Name = "bindtoObject";
            this.bindtoObject.Size = new System.Drawing.Size(261, 21);
            this.bindtoObject.TabIndex = 57;
            this.bindtoObject.SelectedIndexChanged += new System.EventHandler(this.bindtoObject_SelectedIndexChanged);
            // 
            // bindtopanel_title
            // 
            this.bindtopanel_title.AutoSize = true;
            this.bindtopanel_title.Location = new System.Drawing.Point(20, 15);
            this.bindtopanel_title.Name = "bindtopanel_title";
            this.bindtopanel_title.Size = new System.Drawing.Size(88, 13);
            this.bindtopanel_title.TabIndex = 56;
            this.bindtopanel_title.Text = "Bind To JTable : ";
            // 
            // generatedresult
            // 
            this.generatedresult.Location = new System.Drawing.Point(23, 110);
            this.generatedresult.Name = "generatedresult";
            this.generatedresult.Size = new System.Drawing.Size(352, 79);
            this.generatedresult.TabIndex = 58;
            this.generatedresult.Text = "";
            this.generatedresult.TextChanged += new System.EventHandler(this.generatedresult_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 69;
            this.label3.Text = "Table Name : ";
            // 
            // tablename
            // 
            this.tablename.Location = new System.Drawing.Point(114, 39);
            this.tablename.Name = "tablename";
            this.tablename.Size = new System.Drawing.Size(261, 20);
            this.tablename.TabIndex = 70;
            this.tablename.TextChanged += new System.EventHandler(this.passwordtext_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Condition : ";
            // 
            // sqlcondition
            // 
            this.sqlcondition.Location = new System.Drawing.Point(114, 63);
            this.sqlcondition.Name = "sqlcondition";
            this.sqlcondition.Size = new System.Drawing.Size(261, 20);
            this.sqlcondition.TabIndex = 72;
            this.sqlcondition.TextChanged += new System.EventHandler(this.sqlcondition_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Copy code above and paste to your function manually";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Generated Function : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 75;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sqlfilltable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 228);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sqlcondition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tablename);
            this.Controls.Add(this.generatedresult);
            this.Controls.Add(this.bindtoObject);
            this.Controls.Add(this.bindtopanel_title);
            this.Name = "sqlfilltable";
            this.Text = "Fill Table";
            this.Load += new System.EventHandler(this.sqlfilltable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bindtoObject;
        private System.Windows.Forms.Label bindtopanel_title;
        private System.Windows.Forms.RichTextBox generatedresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tablename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sqlcondition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}