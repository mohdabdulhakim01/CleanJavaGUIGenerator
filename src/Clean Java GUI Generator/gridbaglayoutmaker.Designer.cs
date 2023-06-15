namespace Clean_Java_GUI_Generator
{
    partial class gridbaglayoutmaker
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
            this.bindtoobj = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.element_weight = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rowspan = new System.Windows.Forms.NumericUpDown();
            this.colspan = new System.Windows.Forms.NumericUpDown();
            this.column = new System.Windows.Forms.NumericUpDown();
            this.row = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.trackbarval = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.previewdesign = new System.Windows.Forms.Button();
            this.lb_panel_edit = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.load_image = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.element_weight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowspan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colspan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.column)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.row)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load_image)).BeginInit();
            this.SuspendLayout();
            // 
            // bindtoobj
            // 
            this.bindtoobj.FormattingEnabled = true;
            this.bindtoobj.Location = new System.Drawing.Point(347, 69);
            this.bindtoobj.Name = "bindtoobj";
            this.bindtoobj.Size = new System.Drawing.Size(217, 21);
            this.bindtoobj.TabIndex = 61;
            this.bindtoobj.SelectedIndexChanged += new System.EventHandler(this.bindtoobj_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Bind To Object : ";
            // 
            // element_weight
            // 
            this.element_weight.LargeChange = 10;
            this.element_weight.Location = new System.Drawing.Point(8, 32);
            this.element_weight.Maximum = 100;
            this.element_weight.Name = "element_weight";
            this.element_weight.Size = new System.Drawing.Size(210, 45);
            this.element_weight.SmallChange = 10;
            this.element_weight.TabIndex = 65;
            this.element_weight.TickFrequency = 10;
            this.element_weight.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Column :  ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Row :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Col Span : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Max Component Size in Row";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.rowspan);
            this.groupBox1.Controls.Add(this.colspan);
            this.groupBox1.Controls.Add(this.column);
            this.groupBox1.Controls.Add(this.row);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.trackbarval);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.width);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.height);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.element_weight);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(254, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 223);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Component Position Settings";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LawnGreen;
            this.button3.Location = new System.Drawing.Point(189, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 31);
            this.button3.TabIndex = 86;
            this.button3.Text = "Save Change";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rowspan
            // 
            this.rowspan.Location = new System.Drawing.Point(224, 113);
            this.rowspan.Name = "rowspan";
            this.rowspan.Size = new System.Drawing.Size(74, 20);
            this.rowspan.TabIndex = 85;
            this.rowspan.ValueChanged += new System.EventHandler(this.rowspan_ValueChanged);
            // 
            // colspan
            // 
            this.colspan.Location = new System.Drawing.Point(63, 113);
            this.colspan.Name = "colspan";
            this.colspan.Size = new System.Drawing.Size(74, 20);
            this.colspan.TabIndex = 84;
            this.colspan.ValueChanged += new System.EventHandler(this.colspan_ValueChanged);
            // 
            // column
            // 
            this.column.Location = new System.Drawing.Point(221, 87);
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(77, 20);
            this.column.TabIndex = 83;
            this.column.ValueChanged += new System.EventHandler(this.column_ValueChanged);
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(59, 87);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(77, 20);
            this.row.TabIndex = 82;
            this.row.ValueChanged += new System.EventHandler(this.row_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(164, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 79;
            this.label8.Text = "Row Span :";
            // 
            // trackbarval
            // 
            this.trackbarval.AutoSize = true;
            this.trackbarval.Location = new System.Drawing.Point(214, 32);
            this.trackbarval.Name = "trackbarval";
            this.trackbarval.Size = new System.Drawing.Size(37, 13);
            this.trackbarval.TabIndex = 77;
            this.trackbarval.Text = "100%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(164, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 75;
            this.label7.Text = "Width : ";
            // 
            // width
            // 
            this.width.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.width.Location = new System.Drawing.Point(224, 144);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(74, 20);
            this.width.TabIndex = 76;
            this.width.Text = "AUTO";
            this.width.TextChanged += new System.EventHandler(this.width_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 73;
            this.label6.Text = "Height :";
            // 
            // height
            // 
            this.height.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(59, 141);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(78, 20);
            this.height.TabIndex = 74;
            this.height.Text = "AUTO";
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // previewdesign
            // 
            this.previewdesign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.previewdesign.BackColor = System.Drawing.Color.SpringGreen;
            this.previewdesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewdesign.Location = new System.Drawing.Point(598, 210);
            this.previewdesign.Name = "previewdesign";
            this.previewdesign.Size = new System.Drawing.Size(115, 36);
            this.previewdesign.TabIndex = 77;
            this.previewdesign.Text = "Preview Live Design";
            this.previewdesign.UseVisualStyleBackColor = false;
            this.previewdesign.Click += new System.EventHandler(this.previewdesign_Click);
            // 
            // lb_panel_edit
            // 
            this.lb_panel_edit.FormattingEnabled = true;
            this.lb_panel_edit.Items.AddRange(new object[] {
            ""});
            this.lb_panel_edit.Location = new System.Drawing.Point(6, 19);
            this.lb_panel_edit.Name = "lb_panel_edit";
            this.lb_panel_edit.Size = new System.Drawing.Size(224, 290);
            this.lb_panel_edit.TabIndex = 74;
            this.lb_panel_edit.SelectedIndexChanged += new System.EventHandler(this.lb_panel_edit_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_panel_edit);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 323);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Component Edit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(578, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 52);
            this.button1.TabIndex = 76;
            this.button1.Text = "Bind Current Layout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(578, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 28);
            this.button4.TabIndex = 77;
            this.button4.Text = "Import Reference";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // load_image
            // 
            this.load_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.load_image.Location = new System.Drawing.Point(570, 45);
            this.load_image.Name = "load_image";
            this.load_image.Size = new System.Drawing.Size(179, 160);
            this.load_image.TabIndex = 78;
            this.load_image.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(254, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 41);
            this.button2.TabIndex = 81;
            this.button2.Text = "Add New Panel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gridbaglayoutmaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.load_image);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.previewdesign);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bindtoobj);
            this.Name = "gridbaglayoutmaker";
            this.Text = "gridbaglayoutmaker";
            this.Load += new System.EventHandler(this.gridbaglayoutmaker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.element_weight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rowspan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colspan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.column)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.row)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.load_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bindtoobj;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar element_weight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.ListBox lb_panel_edit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button previewdesign;
        private System.Windows.Forms.Label trackbarval;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox load_image;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown rowspan;
        private System.Windows.Forms.NumericUpDown colspan;
        private System.Windows.Forms.NumericUpDown column;
        private System.Windows.Forms.NumericUpDown row;
        private System.Windows.Forms.Button button3;

    }
}