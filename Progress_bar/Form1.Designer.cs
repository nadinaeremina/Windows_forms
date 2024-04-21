
namespace Progress_bar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button_start = new System.Windows.Forms.Button();
            this.label_pr_bar = new System.Windows.Forms.Label();
            this.trackBar_red = new System.Windows.Forms.TrackBar();
            this.trackBar_green = new System.Windows.Forms.TrackBar();
            this.trackBar_blue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Magenta;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(127, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(538, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(442, 88);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "START";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_pr_bar
            // 
            this.label_pr_bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label_pr_bar.Location = new System.Drawing.Point(168, 88);
            this.label_pr_bar.Name = "label_pr_bar";
            this.label_pr_bar.Size = new System.Drawing.Size(100, 23);
            this.label_pr_bar.TabIndex = 2;
            // 
            // trackBar_red
            // 
            this.trackBar_red.Location = new System.Drawing.Point(126, 161);
            this.trackBar_red.Maximum = 255;
            this.trackBar_red.Name = "trackBar_red";
            this.trackBar_red.Size = new System.Drawing.Size(549, 45);
            this.trackBar_red.TabIndex = 3;
            this.trackBar_red.TickFrequency = 5;
            this.trackBar_red.Scroll += new System.EventHandler(this.trackBar_red_Scroll);
            // 
            // trackBar_green
            // 
            this.trackBar_green.Location = new System.Drawing.Point(126, 203);
            this.trackBar_green.Maximum = 255;
            this.trackBar_green.Name = "trackBar_green";
            this.trackBar_green.Size = new System.Drawing.Size(549, 45);
            this.trackBar_green.TabIndex = 4;
            this.trackBar_green.TickFrequency = 5;
            this.trackBar_green.Scroll += new System.EventHandler(this.trackBar_green_Scroll);
            // 
            // trackBar_blue
            // 
            this.trackBar_blue.Location = new System.Drawing.Point(126, 242);
            this.trackBar_blue.Maximum = 255;
            this.trackBar_blue.Name = "trackBar_blue";
            this.trackBar_blue.Size = new System.Drawing.Size(549, 45);
            this.trackBar_blue.TabIndex = 5;
            this.trackBar_blue.TickFrequency = 5;
            this.trackBar_blue.Scroll += new System.EventHandler(this.trackBar_blue_Scroll);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(61, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(61, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_blue);
            this.Controls.Add(this.trackBar_green);
            this.Controls.Add(this.trackBar_red);
            this.Controls.Add(this.label_pr_bar);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Label label_pr_bar;
        private System.Windows.Forms.TrackBar trackBar_red;
        private System.Windows.Forms.TrackBar trackBar_green;
        private System.Windows.Forms.TrackBar trackBar_blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

