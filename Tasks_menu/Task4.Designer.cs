
namespace Tasks_menu
{
    partial class Task4
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
            this.components = new System.ComponentModel.Container();
            this.task_1 = new System.Windows.Forms.Button();
            this.exit_to_menu = new System.Windows.Forms.Button();
            this.task_3 = new System.Windows.Forms.Button();
            this.task_2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.launch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task_1
            // 
            this.task_1.Location = new System.Drawing.Point(67, 51);
            this.task_1.Name = "task_1";
            this.task_1.Size = new System.Drawing.Size(100, 50);
            this.task_1.TabIndex = 11;
            this.task_1.Text = "Задание 1";
            this.toolTip1.SetToolTip(this.task_1, "Координаты мыши");
            this.task_1.UseVisualStyleBackColor = true;
            this.task_1.Click += new System.EventHandler(this.task_1_Click);
            // 
            // exit_to_menu
            // 
            this.exit_to_menu.Location = new System.Drawing.Point(661, 182);
            this.exit_to_menu.Name = "exit_to_menu";
            this.exit_to_menu.Size = new System.Drawing.Size(100, 50);
            this.exit_to_menu.TabIndex = 12;
            this.exit_to_menu.Text = "Вернуться в меню";
            this.toolTip1.SetToolTip(this.exit_to_menu, "Каталог товаров");
            this.exit_to_menu.UseVisualStyleBackColor = true;
            this.exit_to_menu.Click += new System.EventHandler(this.exit_to_menu_Click);
            // 
            // task_3
            // 
            this.task_3.Location = new System.Drawing.Point(67, 293);
            this.task_3.Name = "task_3";
            this.task_3.Size = new System.Drawing.Size(100, 50);
            this.task_3.TabIndex = 13;
            this.task_3.Text = "Задание 3";
            this.toolTip1.SetToolTip(this.task_3, "Анкета");
            this.task_3.UseVisualStyleBackColor = true;
            this.task_3.Click += new System.EventHandler(this.task_3_Click);
            // 
            // task_2
            // 
            this.task_2.Location = new System.Drawing.Point(67, 171);
            this.task_2.Name = "task_2";
            this.task_2.Size = new System.Drawing.Size(100, 50);
            this.task_2.TabIndex = 14;
            this.task_2.Text = "Задание 2";
            this.toolTip1.SetToolTip(this.task_2, "Таймер");
            this.task_2.UseVisualStyleBackColor = true;
            this.task_2.Click += new System.EventHandler(this.task_2_Click);
            // 
            // launch
            // 
            this.launch.Location = new System.Drawing.Point(310, 162);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(181, 90);
            this.launch.TabIndex = 15;
            this.launch.Text = "Запустить задание 4";
            this.launch.UseVisualStyleBackColor = true;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.launch);
            this.Controls.Add(this.task_2);
            this.Controls.Add(this.task_3);
            this.Controls.Add(this.exit_to_menu);
            this.Controls.Add(this.task_1);
            this.Name = "Task4";
            this.Text = "Task4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button task_1;
        private System.Windows.Forms.Button exit_to_menu;
        private System.Windows.Forms.Button task_3;
        private System.Windows.Forms.Button task_2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button launch;
    }
}