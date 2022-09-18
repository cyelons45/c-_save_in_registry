namespace Registry_Colors
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.color_textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.font_textBox1 = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.size_textBox1 = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.location_save_button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.x_trackBar3 = new System.Windows.Forms.TrackBar();
            this.location_textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.y_trackBar4 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_trackBar4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // color_textBox1
            // 
            this.color_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_textBox1.Location = new System.Drawing.Point(300, 24);
            this.color_textBox1.Multiline = true;
            this.color_textBox1.Name = "color_textBox1";
            this.color_textBox1.Size = new System.Drawing.Size(182, 44);
            this.color_textBox1.TabIndex = 1;
            this.color_textBox1.Text = "Sample Text";
            this.color_textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Fore Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "Font";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // font_textBox1
            // 
            this.font_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.font_textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.font_textBox1.Location = new System.Drawing.Point(300, 92);
            this.font_textBox1.Multiline = true;
            this.font_textBox1.Name = "font_textBox1";
            this.font_textBox1.Size = new System.Drawing.Size(182, 44);
            this.font_textBox1.TabIndex = 4;
            this.font_textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // size_textBox1
            // 
            this.size_textBox1.Location = new System.Drawing.Point(29, 106);
            this.size_textBox1.Multiline = true;
            this.size_textBox1.Name = "size_textBox1";
            this.size_textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.size_textBox1.Size = new System.Drawing.Size(159, 29);
            this.size_textBox1.TabIndex = 6;
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.Location = new System.Drawing.Point(67, 28);
            this.trackBar1.Maximum = 600;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(176, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Value = 200;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // trackBar2
            // 
            this.trackBar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar2.Location = new System.Drawing.Point(346, 19);
            this.trackBar2.Maximum = 300;
            this.trackBar2.Minimum = 20;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(196, 45);
            this.trackBar2.TabIndex = 8;
            this.trackBar2.Value = 20;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.size_textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Location = new System.Drawing.Point(12, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 152);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Height";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(29, 65);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 24);
            this.button4.TabIndex = 11;
            this.button4.Text = "Save Changes";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.location_save_button5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.x_trackBar3);
            this.groupBox2.Controls.Add(this.location_textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.y_trackBar4);
            this.groupBox2.Location = new System.Drawing.Point(12, 319);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 227);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Location";
            // 
            // location_save_button5
            // 
            this.location_save_button5.Location = new System.Drawing.Point(29, 65);
            this.location_save_button5.Name = "location_save_button5";
            this.location_save_button5.Size = new System.Drawing.Size(93, 24);
            this.location_save_button5.TabIndex = 11;
            this.location_save_button5.Text = "Save Changes";
            this.location_save_button5.UseVisualStyleBackColor = true;
            this.location_save_button5.Click += new System.EventHandler(this.location_save_button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y";
            // 
            // x_trackBar3
            // 
            this.x_trackBar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.x_trackBar3.Location = new System.Drawing.Point(67, 28);
            this.x_trackBar3.Maximum = 600;
            this.x_trackBar3.Name = "x_trackBar3";
            this.x_trackBar3.Size = new System.Drawing.Size(176, 45);
            this.x_trackBar3.TabIndex = 7;
            this.x_trackBar3.Value = 29;
            this.x_trackBar3.ValueChanged += new System.EventHandler(this.x_trackBar3_ValueChanged);
            // 
            // location_textBox1
            // 
            this.location_textBox1.Location = new System.Drawing.Point(29, 107);
            this.location_textBox1.Multiline = true;
            this.location_textBox1.Name = "location_textBox1";
            this.location_textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.location_textBox1.Size = new System.Drawing.Size(159, 29);
            this.location_textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "X";
            // 
            // y_trackBar4
            // 
            this.y_trackBar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.y_trackBar4.Location = new System.Drawing.Point(346, 19);
            this.y_trackBar4.Maximum = 300;
            this.y_trackBar4.Minimum = 107;
            this.y_trackBar4.Name = "y_trackBar4";
            this.y_trackBar4.Size = new System.Drawing.Size(196, 45);
            this.y_trackBar4.TabIndex = 8;
            this.y_trackBar4.Value = 107;
            this.y_trackBar4.Scroll += new System.EventHandler(this.y_trackBar4_Scroll);
            this.y_trackBar4.ValueChanged += new System.EventHandler(this.y_trackBar4_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 543);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.font_textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.color_textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_trackBar4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox color_textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox font_textBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox size_textBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button location_save_button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar x_trackBar3;
        private System.Windows.Forms.TextBox location_textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar y_trackBar4;
    }
}

