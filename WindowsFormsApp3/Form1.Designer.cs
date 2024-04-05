
namespace WindowsFormsApp3
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
            this.lb_color = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cb_sh = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.rb_mum = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_grandmum = new System.Windows.Forms.RadioButton();
            this.rb_dad = new System.Windows.Forms.RadioButton();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_color
            // 
            this.lb_color.FormattingEnabled = true;
            this.lb_color.Items.AddRange(new object[] {
            "blue",
            "brown",
            "green",
            "red",
            "white",
            "yellow"});
            this.lb_color.Location = new System.Drawing.Point(42, 21);
            this.lb_color.Name = "lb_color";
            this.lb_color.Size = new System.Drawing.Size(149, 108);
            this.lb_color.Sorted = true;
            this.lb_color.TabIndex = 0;
            this.lb_color.SelectedIndexChanged += new System.EventHandler(this.lb_color_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(246, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 47);
            this.label1.TabIndex = 1;
            // 
            // cb_1
            // 
            this.cb_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cb_1.FormattingEnabled = true;
            this.cb_1.Items.AddRange(new object[] {
            "липа",
            "ольха",
            "дуб ",
            "клен"});
            this.cb_1.Location = new System.Drawing.Point(42, 149);
            this.cb_1.Name = "cb_1";
            this.cb_1.Size = new System.Drawing.Size(149, 95);
            this.cb_1.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(6, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(45, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "С++";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cb_sh
            // 
            this.cb_sh.AutoSize = true;
            this.cb_sh.Location = new System.Drawing.Point(6, 88);
            this.cb_sh.Name = "cb_sh";
            this.cb_sh.Size = new System.Drawing.Size(40, 17);
            this.cb_sh.TabIndex = 1;
            this.cb_sh.Text = "C#";
            this.cb_sh.UseVisualStyleBackColor = true;
            this.cb_sh.CheckedChanged += new System.EventHandler(this.cb_sh_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.cb_sh);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(243, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 167);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Языки программирования";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 135);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(47, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "SQL";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // rb_mum
            // 
            this.rb_mum.AutoSize = true;
            this.rb_mum.Location = new System.Drawing.Point(6, 25);
            this.rb_mum.Name = "rb_mum";
            this.rb_mum.Size = new System.Drawing.Size(54, 17);
            this.rb_mum.TabIndex = 4;
            this.rb_mum.TabStop = true;
            this.rb_mum.Text = "Мама";
            this.rb_mum.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_grandmum);
            this.groupBox2.Controls.Add(this.rb_dad);
            this.groupBox2.Controls.Add(this.rb_mum);
            this.groupBox2.Location = new System.Drawing.Point(534, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 167);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Родственники";
            // 
            // rb_grandmum
            // 
            this.rb_grandmum.AutoSize = true;
            this.rb_grandmum.Location = new System.Drawing.Point(6, 138);
            this.rb_grandmum.Name = "rb_grandmum";
            this.rb_grandmum.Size = new System.Drawing.Size(69, 17);
            this.rb_grandmum.TabIndex = 6;
            this.rb_grandmum.TabStop = true;
            this.rb_grandmum.Text = "Бабушка";
            this.rb_grandmum.UseVisualStyleBackColor = true;
            // 
            // rb_dad
            // 
            this.rb_dad.AutoSize = true;
            this.rb_dad.Location = new System.Drawing.Point(6, 83);
            this.rb_dad.Name = "rb_dad";
            this.rb_dad.Size = new System.Drawing.Size(51, 17);
            this.rb_dad.TabIndex = 5;
            this.rb_dad.TabStop = true;
            this.rb_dad.Text = "Папа";
            this.rb_dad.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(277, 287);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(42, 358);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_color);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cb_sh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton rb_mum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_grandmum;
        private System.Windows.Forms.RadioButton rb_dad;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

