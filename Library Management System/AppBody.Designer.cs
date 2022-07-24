namespace Library_Management_System
{
    partial class AppBody
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
            this.Log_in_timer = new System.Windows.Forms.Timer(this.components);
            this.LogOffButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.title_Bar = new System.Windows.Forms.Panel();
            this.title_Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_in_timer
            // 
            this.Log_in_timer.Tick += new System.EventHandler(this.Log_in_timer_Tick);
            // 
            // LogOffButton
            // 
            this.LogOffButton.BackgroundImage = global::Library_Management_System.Properties.Resources.LogOffButton1;
            this.LogOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOffButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.LogOffButton.Location = new System.Drawing.Point(929, 3);
            this.LogOffButton.Name = "LogOffButton";
            this.LogOffButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogOffButton.Size = new System.Drawing.Size(34, 32);
            this.LogOffButton.TabIndex = 1;
            this.LogOffButton.UseVisualStyleBackColor = true;
            this.LogOffButton.Click += new System.EventHandler(this.LogOffButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::Library_Management_System.Properties.Resources.MinimizeButton;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.MinimizeButton.Location = new System.Drawing.Point(969, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MinimizeButton.Size = new System.Drawing.Size(34, 32);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::Library_Management_System.Properties.Resources.CloseButton;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.closeButton.Location = new System.Drawing.Point(1009, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.closeButton.Size = new System.Drawing.Size(34, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // title_Bar
            // 
            this.title_Bar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.title_Bar.Controls.Add(this.closeButton);
            this.title_Bar.Controls.Add(this.LogOffButton);
            this.title_Bar.Controls.Add(this.MinimizeButton);
            this.title_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Bar.Location = new System.Drawing.Point(0, 0);
            this.title_Bar.Name = "title_Bar";
            this.title_Bar.Size = new System.Drawing.Size(1046, 41);
            this.title_Bar.TabIndex = 2;
            this.title_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_Bar_MouseDown);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 715);
            this.Controls.Add(this.title_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.title_Bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_in_timer;
        private Button closeButton;
        private Button LogOffButton;
        private Button MinimizeButton;
        private Panel title_Bar;
    }
}