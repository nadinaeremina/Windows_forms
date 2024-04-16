
namespace Tasks_menu
{
    partial class Task1
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
            this.exit_to_menu = new System.Windows.Forms.Button();
            this.task_3 = new System.Windows.Forms.Button();
            this.task_4 = new System.Windows.Forms.Button();
            this.task_2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.launch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_to_menu
            // 
            this.exit_to_menu.Location = new System.Drawing.Point(677, 180);
            this.exit_to_menu.Name = "exit_to_menu";
            this.exit_to_menu.Size = new System.Drawing.Size(100, 50);
            this.exit_to_menu.TabIndex = 0;
            this.exit_to_menu.Text = "Вернуться в меню";
            this.exit_to_menu.UseVisualStyleBackColor = true;
            this.exit_to_menu.Click += new System.EventHandler(this.exit_to_menu_Click);
            // 
            // task_3
            // 
            this.task_3.Location = new System.Drawing.Point(71, 180);
            this.task_3.Name = "task_3";
            this.task_3.Size = new System.Drawing.Size(100, 50);
            this.task_3.TabIndex = 1;
            this.task_3.Text = "Задание 3";
            this.toolTip1.SetToolTip(this.task_3, "Анкета");
            this.task_3.UseVisualStyleBackColor = true;
            this.task_3.Click += new System.EventHandler(this.task_3_Click);
            // 
            // task_4
            // 
            this.task_4.Location = new System.Drawing.Point(71, 298);
            this.task_4.Name = "task_4";
            this.task_4.Size = new System.Drawing.Size(100, 50);
            this.task_4.TabIndex = 2;
            this.task_4.Text = "Задание 4";
            this.toolTip1.SetToolTip(this.task_4, "Каталог товаров");
            this.task_4.UseVisualStyleBackColor = true;
            this.task_4.Click += new System.EventHandler(this.task_4_Click);
            // 
            // task_2
            // 
            this.task_2.Location = new System.Drawing.Point(71, 48);
            this.task_2.Name = "task_2";
            this.task_2.Size = new System.Drawing.Size(100, 50);
            this.task_2.TabIndex = 3;
            this.task_2.Text = "Задание 2";
            this.toolTip1.SetToolTip(this.task_2, "Таймер");
            this.task_2.UseVisualStyleBackColor = true;
            this.task_2.Click += new System.EventHandler(this.task_2_Click);
            // 
            // launch
            // 
            this.launch.Location = new System.Drawing.Point(319, 160);
            this.launch.Name = "launch";
            this.launch.Size = new System.Drawing.Size(181, 90);
            this.launch.TabIndex = 4;
            this.launch.Text = "Запустить задание 1";
            this.launch.UseVisualStyleBackColor = true;
            this.launch.Click += new System.EventHandler(this.launch_Click);
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.launch);
            this.Controls.Add(this.task_2);
            this.Controls.Add(this.task_4);
            this.Controls.Add(this.task_3);
            this.Controls.Add(this.exit_to_menu);
            this.Name = "Task1";
            this.Text = "Task1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_to_menu;
        private System.Windows.Forms.Button task_3;
        private System.Windows.Forms.Button task_4;
        private System.Windows.Forms.Button task_2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button launch;
    }
}