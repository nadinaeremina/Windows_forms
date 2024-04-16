
namespace Tasks_menu
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
            this.components = new System.ComponentModel.Container();
            this.task_1 = new System.Windows.Forms.Button();
            this.task_2 = new System.Windows.Forms.Button();
            this.task_3 = new System.Windows.Forms.Button();
            this.task_4 = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // task_1
            // 
            this.task_1.Location = new System.Drawing.Point(68, 46);
            this.task_1.Name = "task_1";
            this.task_1.Size = new System.Drawing.Size(129, 97);
            this.task_1.TabIndex = 0;
            this.task_1.Text = "Задание 1";
            this.toolTip1.SetToolTip(this.task_1, "Координаты мыши");
            this.task_1.UseVisualStyleBackColor = true;
            this.task_1.Click += new System.EventHandler(this.task_1_Click);
            // 
            // task_2
            // 
            this.task_2.Location = new System.Drawing.Point(307, 46);
            this.task_2.Name = "task_2";
            this.task_2.Size = new System.Drawing.Size(129, 97);
            this.task_2.TabIndex = 1;
            this.task_2.Text = "Задание 2";
            this.toolTip1.SetToolTip(this.task_2, "Таймер");
            this.task_2.UseVisualStyleBackColor = true;
            this.task_2.Click += new System.EventHandler(this.task_2_Click);
            // 
            // task_3
            // 
            this.task_3.Location = new System.Drawing.Point(558, 46);
            this.task_3.Name = "task_3";
            this.task_3.Size = new System.Drawing.Size(129, 97);
            this.task_3.TabIndex = 2;
            this.task_3.Text = "Задание 3";
            this.toolTip1.SetToolTip(this.task_3, "Анкета");
            this.task_3.UseVisualStyleBackColor = true;
            this.task_3.Click += new System.EventHandler(this.task_3_Click);
            // 
            // task_4
            // 
            this.task_4.Location = new System.Drawing.Point(307, 215);
            this.task_4.Name = "task_4";
            this.task_4.Size = new System.Drawing.Size(129, 97);
            this.task_4.TabIndex = 3;
            this.task_4.Text = "Задание 4";
            this.toolTip1.SetToolTip(this.task_4, "Каталог товаров");
            this.task_4.UseVisualStyleBackColor = true;
            this.task_4.Click += new System.EventHandler(this.task_4_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(703, 388);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(90, 50);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.task_4);
            this.Controls.Add(this.task_3);
            this.Controls.Add(this.task_2);
            this.Controls.Add(this.task_1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button task_1;
        private System.Windows.Forms.Button task_2;
        private System.Windows.Forms.Button task_3;
        private System.Windows.Forms.Button task_4;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

