
namespace Tasks_menu
{
    partial class Ancetacs
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.city = new System.Windows.Forms.ComboBox();
            this.country = new System.Windows.Forms.ComboBox();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.Woman = new System.Windows.Forms.RadioButton();
            this.Man = new System.Windows.Forms.RadioButton();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.SurName = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(319, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Посмотреть результат";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.country);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.Woman);
            this.groupBox1.Controls.Add(this.Man);
            this.groupBox1.Controls.Add(this.Birthday);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Controls.Add(this.SurName);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(237, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 280);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Анкета";
            // 
            // city
            // 
            this.city.BackColor = System.Drawing.Color.White;
            this.city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.city.FormattingEnabled = true;
            this.city.Location = new System.Drawing.Point(171, 152);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(142, 21);
            this.city.TabIndex = 18;
            // 
            // country
            // 
            this.country.BackColor = System.Drawing.Color.White;
            this.country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.country.FormattingEnabled = true;
            this.country.Items.AddRange(new object[] {
            "Россия",
            "США",
            "Испания"});
            this.country.Location = new System.Drawing.Point(171, 117);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(142, 21);
            this.country.TabIndex = 17;
            this.country.SelectedIndexChanged += new System.EventHandler(this.country_SelectedIndexChanged_1);
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.White;
            this.phone.Location = new System.Drawing.Point(171, 186);
            this.phone.Mask = "(999) 000-0000";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(142, 20);
            this.phone.TabIndex = 2;
            // 
            // Woman
            // 
            this.Woman.AutoSize = true;
            this.Woman.BackColor = System.Drawing.Color.LightGray;
            this.Woman.Location = new System.Drawing.Point(224, 249);
            this.Woman.Name = "Woman";
            this.Woman.Size = new System.Drawing.Size(45, 17);
            this.Woman.TabIndex = 16;
            this.Woman.TabStop = true;
            this.Woman.Text = "жен";
            this.Woman.UseVisualStyleBackColor = false;
            // 
            // Man
            // 
            this.Man.AutoSize = true;
            this.Man.BackColor = System.Drawing.Color.LightGray;
            this.Man.Location = new System.Drawing.Point(133, 249);
            this.Man.Name = "Man";
            this.Man.Size = new System.Drawing.Size(46, 17);
            this.Man.TabIndex = 15;
            this.Man.TabStop = true;
            this.Man.Text = "муж";
            this.Man.UseVisualStyleBackColor = false;
            // 
            // Birthday
            // 
            this.Birthday.Location = new System.Drawing.Point(119, 212);
            this.Birthday.MaxDate = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            this.Birthday.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(200, 20);
            this.Birthday.TabIndex = 14;
            this.Birthday.Value = new System.DateTime(2024, 4, 5, 0, 0, 0, 0);
            // 
            // FirstName
            // 
            this.FirstName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.FirstName.Location = new System.Drawing.Point(171, 53);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(142, 20);
            this.FirstName.TabIndex = 10;
            this.FirstName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FirstName_MouseDown_1);
            this.FirstName.MouseLeave += new System.EventHandler(this.FirstName_MouseLeave_1);
            // 
            // SurName
            // 
            this.SurName.BackColor = System.Drawing.Color.White;
            this.SurName.Location = new System.Drawing.Point(171, 79);
            this.SurName.Name = "SurName";
            this.SurName.Size = new System.Drawing.Size(142, 20);
            this.SurName.TabIndex = 9;
            // 
            // LastName
            // 
            this.LastName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LastName.Location = new System.Drawing.Point(171, 25);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(142, 20);
            this.LastName.TabIndex = 8;
            this.LastName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LastName_MouseDown_1);
            this.LastName.MouseLeave += new System.EventHandler(this.LastName_MouseLeave_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Пол";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Дата рождения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Город";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Страна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // Ancetacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ancetacs";
            this.Text = "Ancetacs";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox city;
        private System.Windows.Forms.ComboBox country;
        private System.Windows.Forms.MaskedTextBox phone;
        private System.Windows.Forms.RadioButton Woman;
        private System.Windows.Forms.RadioButton Man;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox SurName;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}