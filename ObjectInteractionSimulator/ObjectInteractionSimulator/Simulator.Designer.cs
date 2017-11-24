namespace ObjectInteractionSimulator
{
    partial class Simulator
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.control = new System.Windows.Forms.Button();
            this.Interval_Label = new System.Windows.Forms.Label();
            this.Enter_Interval = new System.Windows.Forms.TextBox();
            this.Set_Interval = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // control
            // 
            this.control.Location = new System.Drawing.Point(10, 10);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(75, 23);
            this.control.TabIndex = 0;
            this.control.Text = "Start/Stop";
            this.control.UseVisualStyleBackColor = true;
            this.control.Click += new System.EventHandler(this.control_Click);
            // 
            // Interval_Label
            // 
            this.Interval_Label.AutoSize = true;
            this.Interval_Label.Location = new System.Drawing.Point(92, 13);
            this.Interval_Label.Name = "Interval_Label";
            this.Interval_Label.Size = new System.Drawing.Size(42, 13);
            this.Interval_Label.TabIndex = 1;
            this.Interval_Label.Text = "Interval";
            this.Interval_Label.Click += new System.EventHandler(this.Interval_Label_Click);
            // 
            // Enter_Interval
            // 
            this.Enter_Interval.Location = new System.Drawing.Point(141, 13);
            this.Enter_Interval.Name = "Enter_Interval";
            this.Enter_Interval.Size = new System.Drawing.Size(100, 20);
            this.Enter_Interval.TabIndex = 2;
            this.Enter_Interval.TextChanged += new System.EventHandler(this.Enter_Interval_TextChanged);
            // 
            // Set_Interval
            // 
            this.Set_Interval.Location = new System.Drawing.Point(248, 13);
            this.Set_Interval.Name = "Set_Interval";
            this.Set_Interval.Size = new System.Drawing.Size(75, 23);
            this.Set_Interval.TabIndex = 3;
            this.Set_Interval.Text = "Set Interval";
            this.Set_Interval.UseVisualStyleBackColor = true;
            this.Set_Interval.Click += new System.EventHandler(this.Set_Interval_Click);
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Set_Interval);
            this.Controls.Add(this.Enter_Interval);
            this.Controls.Add(this.Interval_Label);
            this.Controls.Add(this.control);
            this.Name = "Simulator";
            this.Text = "Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button control;
        private System.Windows.Forms.Label Interval_Label;
        private System.Windows.Forms.TextBox Enter_Interval;
        private System.Windows.Forms.Button Set_Interval;
    }
}

