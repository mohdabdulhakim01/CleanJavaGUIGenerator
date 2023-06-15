namespace Clean_Java_GUI_Generator
{
    partial class sqlgenerator
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
            this.objname_title = new System.Windows.Forms.Label();
            this.db_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portnum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hostname_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.portnum)).BeginInit();
            this.SuspendLayout();
            // 
            // objname_title
            // 
            this.objname_title.AutoSize = true;
            this.objname_title.Location = new System.Drawing.Point(20, 42);
            this.objname_title.Name = "objname_title";
            this.objname_title.Size = new System.Drawing.Size(93, 13);
            this.objname_title.TabIndex = 61;
            this.objname_title.Text = "Database Name : ";
            // 
            // db_name
            // 
            this.db_name.Location = new System.Drawing.Point(119, 40);
            this.db_name.Name = "db_name";
            this.db_name.Size = new System.Drawing.Size(177, 20);
            this.db_name.TabIndex = 62;
            this.db_name.Text = "DatabaseName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Username : ";
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(119, 66);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(177, 20);
            this.usernametext.TabIndex = 64;
            this.usernametext.Text = "root";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Port : ";
            // 
            // portnum
            // 
            this.portnum.Location = new System.Drawing.Point(337, 14);
            this.portnum.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.portnum.Name = "portnum";
            this.portnum.Size = new System.Drawing.Size(65, 20);
            this.portnum.TabIndex = 66;
            this.portnum.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Password : ";
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(119, 92);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(177, 20);
            this.passwordtext.TabIndex = 68;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 45);
            this.button1.TabIndex = 69;
            this.button1.Text = "Generate SQL Function";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Hostname : ";
            // 
            // hostname_Text
            // 
            this.hostname_Text.Location = new System.Drawing.Point(119, 14);
            this.hostname_Text.Name = "hostname_Text";
            this.hostname_Text.Size = new System.Drawing.Size(177, 20);
            this.hostname_Text.TabIndex = 71;
            this.hostname_Text.Text = "localhost";
            // 
            // sqlgenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 183);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hostname_Text);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.portnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.objname_title);
            this.Controls.Add(this.db_name);
            this.Name = "sqlgenerator";
            this.Text = "SQL Generator";
            ((System.ComponentModel.ISupportInitialize)(this.portnum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label objname_title;
        private System.Windows.Forms.TextBox db_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown portnum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hostname_Text;
    }
}