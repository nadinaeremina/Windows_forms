
namespace Paint
{
    partial class Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paint));
            this.panel_color = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button_save = new System.Windows.Forms.Button();
            this.button_filling = new System.Windows.Forms.Button();
            this.button_rectangle = new System.Windows.Forms.Button();
            this.button_line = new System.Windows.Forms.Button();
            this.button_eraser = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_pencil = new System.Windows.Forms.Button();
            this.button_circle = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_draw = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_color
            // 
            this.panel_color.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_color.Location = new System.Drawing.Point(6, 19);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(83, 59);
            this.panel_color.TabIndex = 1;
            this.panel_color.DoubleClick += new System.EventHandler(this.panel_color_DoubleClick);
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 2;
            this.trackBar1.Location = new System.Drawing.Point(6, 93);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 2;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(684, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 2;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.Blue;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save.Location = new System.Drawing.Point(635, 19);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(135, 59);
            this.button_save.TabIndex = 11;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_filling
            // 
            this.button_filling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_filling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filling.Image = ((System.Drawing.Image)(resources.GetObject("button_filling.Image")));
            this.button_filling.Location = new System.Drawing.Point(451, 19);
            this.button_filling.Name = "button_filling";
            this.button_filling.Size = new System.Drawing.Size(83, 59);
            this.button_filling.TabIndex = 3;
            this.button_filling.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_filling.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_filling.UseVisualStyleBackColor = true;
            this.button_filling.Click += new System.EventHandler(this.button_filling_Click);
            // 
            // button_rectangle
            // 
            this.button_rectangle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rectangle.Image = ((System.Drawing.Image)(resources.GetObject("button_rectangle.Image")));
            this.button_rectangle.Location = new System.Drawing.Point(362, 19);
            this.button_rectangle.Name = "button_rectangle";
            this.button_rectangle.Size = new System.Drawing.Size(83, 59);
            this.button_rectangle.TabIndex = 5;
            this.button_rectangle.UseVisualStyleBackColor = false;
            this.button_rectangle.Click += new System.EventHandler(this.button_rectangle_Click);
            // 
            // button_line
            // 
            this.button_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_line.Image = ((System.Drawing.Image)(resources.GetObject("button_line.Image")));
            this.button_line.Location = new System.Drawing.Point(184, 19);
            this.button_line.Name = "button_line";
            this.button_line.Size = new System.Drawing.Size(83, 59);
            this.button_line.TabIndex = 6;
            this.button_line.UseVisualStyleBackColor = false;
            this.button_line.Click += new System.EventHandler(this.button_line_Click);
            // 
            // button_eraser
            // 
            this.button_eraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_eraser.Image = ((System.Drawing.Image)(resources.GetObject("button_eraser.Image")));
            this.button_eraser.Location = new System.Drawing.Point(540, 19);
            this.button_eraser.Name = "button_eraser";
            this.button_eraser.Size = new System.Drawing.Size(83, 59);
            this.button_eraser.TabIndex = 4;
            this.button_eraser.UseVisualStyleBackColor = false;
            this.button_eraser.Click += new System.EventHandler(this.button_eraser_Click);
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Red;
            this.button_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_clear.Location = new System.Drawing.Point(696, 93);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(74, 45);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_pencil
            // 
            this.button_pencil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pencil.Image = ((System.Drawing.Image)(resources.GetObject("button_pencil.Image")));
            this.button_pencil.Location = new System.Drawing.Point(95, 19);
            this.button_pencil.Name = "button_pencil";
            this.button_pencil.Size = new System.Drawing.Size(83, 59);
            this.button_pencil.TabIndex = 8;
            this.button_pencil.UseVisualStyleBackColor = false;
            this.button_pencil.Click += new System.EventHandler(this.button_pencil_Click);
            // 
            // button_circle
            // 
            this.button_circle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_circle.Image = ((System.Drawing.Image)(resources.GetObject("button_circle.Image")));
            this.button_circle.Location = new System.Drawing.Point(273, 19);
            this.button_circle.Name = "button_circle";
            this.button_circle.Size = new System.Drawing.Size(83, 59);
            this.button_circle.TabIndex = 7;
            this.button_circle.UseVisualStyleBackColor = false;
            this.button_circle.Click += new System.EventHandler(this.button_circle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_color);
            this.groupBox1.Controls.Add(this.button_pencil);
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.button_save);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.button_eraser);
            this.groupBox1.Controls.Add(this.button_filling);
            this.groupBox1.Controls.Add(this.button_line);
            this.groupBox1.Controls.Add(this.button_rectangle);
            this.groupBox1.Controls.Add(this.button_circle);
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 153);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Инструменты";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel_draw
            // 
            this.panel_draw.Location = new System.Drawing.Point(12, 12);
            this.panel_draw.Name = "panel_draw";
            this.panel_draw.Size = new System.Drawing.Size(770, 276);
            this.panel_draw.TabIndex = 13;
            this.panel_draw.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_draw_Paint_1);
            this.panel_draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_draw_MouseDown_1);
            this.panel_draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_draw_MouseMove_1);
            this.panel_draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_draw_MouseUp_1);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.panel_draw);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Paint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_color;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button_rectangle;
        private System.Windows.Forms.Button button_line;
        private System.Windows.Forms.Button button_eraser;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_pencil;
        private System.Windows.Forms.Button button_circle;
        private System.Windows.Forms.Button button_filling;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel_draw;
    }
}

