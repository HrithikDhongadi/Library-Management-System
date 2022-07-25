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
            this.slidingPanel = new System.Windows.Forms.Panel();
            this.AboutTabButton = new System.Windows.Forms.Button();
            this.SettingsTabButton = new System.Windows.Forms.Button();
            this.TransactionsTabButton = new System.Windows.Forms.Button();
            this.BorrowersTabButton = new System.Windows.Forms.Button();
            this.BooksTabButton = new System.Windows.Forms.Button();
            this.slidingPanelToggleButton = new System.Windows.Forms.Button();
            this.SlideingPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.title_Bar.SuspendLayout();
            this.slidingPanel.SuspendLayout();
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
            this.LogOffButton.Location = new System.Drawing.Point(1283, 3);
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
            this.MinimizeButton.Location = new System.Drawing.Point(1323, 3);
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
            this.closeButton.Location = new System.Drawing.Point(1363, 3);
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
            this.title_Bar.Controls.Add(this.LogOffButton);
            this.title_Bar.Controls.Add(this.closeButton);
            this.title_Bar.Controls.Add(this.MinimizeButton);
            this.title_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_Bar.Location = new System.Drawing.Point(0, 0);
            this.title_Bar.Name = "title_Bar";
            this.title_Bar.Size = new System.Drawing.Size(1400, 40);
            this.title_Bar.TabIndex = 2;
            this.title_Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_Bar_MouseDown);
            // 
            // slidingPanel
            // 
            this.slidingPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.slidingPanel.BackgroundImage = global::Library_Management_System.Properties.Resources.Slider_Panel;
            this.slidingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.slidingPanel.Controls.Add(this.AboutTabButton);
            this.slidingPanel.Controls.Add(this.SettingsTabButton);
            this.slidingPanel.Controls.Add(this.TransactionsTabButton);
            this.slidingPanel.Controls.Add(this.BorrowersTabButton);
            this.slidingPanel.Controls.Add(this.BooksTabButton);
            this.slidingPanel.Controls.Add(this.slidingPanelToggleButton);
            this.slidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.slidingPanel.Location = new System.Drawing.Point(0, 40);
            this.slidingPanel.Name = "slidingPanel";
            this.slidingPanel.Size = new System.Drawing.Size(300, 710);
            this.slidingPanel.TabIndex = 3;
            // 
            // AboutTabButton
            // 
            this.AboutTabButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTabButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AboutTabButton.Image = global::Library_Management_System.Properties.Resources.About;
            this.AboutTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutTabButton.Location = new System.Drawing.Point(0, 400);
            this.AboutTabButton.Name = "AboutTabButton";
            this.AboutTabButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.AboutTabButton.Size = new System.Drawing.Size(300, 80);
            this.AboutTabButton.TabIndex = 5;
            this.AboutTabButton.Text = "About";
            this.AboutTabButton.UseVisualStyleBackColor = false;
            this.AboutTabButton.Click += new System.EventHandler(this.AboutTabButton_Click);
            // 
            // SettingsTabButton
            // 
            this.SettingsTabButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsTabButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingsTabButton.Image = global::Library_Management_System.Properties.Resources.Settings;
            this.SettingsTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsTabButton.Location = new System.Drawing.Point(0, 320);
            this.SettingsTabButton.Name = "SettingsTabButton";
            this.SettingsTabButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SettingsTabButton.Size = new System.Drawing.Size(300, 80);
            this.SettingsTabButton.TabIndex = 4;
            this.SettingsTabButton.Text = "Settings";
            this.SettingsTabButton.UseVisualStyleBackColor = false;
            this.SettingsTabButton.Click += new System.EventHandler(this.SettingsTabButton_Click);
            // 
            // TransactionsTabButton
            // 
            this.TransactionsTabButton.BackColor = System.Drawing.Color.Transparent;
            this.TransactionsTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionsTabButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransactionsTabButton.Image = global::Library_Management_System.Properties.Resources.Transaction;
            this.TransactionsTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionsTabButton.Location = new System.Drawing.Point(0, 240);
            this.TransactionsTabButton.Name = "TransactionsTabButton";
            this.TransactionsTabButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.TransactionsTabButton.Size = new System.Drawing.Size(300, 80);
            this.TransactionsTabButton.TabIndex = 3;
            this.TransactionsTabButton.Text = "Transaction";
            this.TransactionsTabButton.UseVisualStyleBackColor = false;
            this.TransactionsTabButton.Click += new System.EventHandler(this.TransactionsTabButton_Click);
            // 
            // BorrowersTabButton
            // 
            this.BorrowersTabButton.BackColor = System.Drawing.Color.Transparent;
            this.BorrowersTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowersTabButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BorrowersTabButton.Image = global::Library_Management_System.Properties.Resources.Borrower;
            this.BorrowersTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowersTabButton.Location = new System.Drawing.Point(0, 160);
            this.BorrowersTabButton.Name = "BorrowersTabButton";
            this.BorrowersTabButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BorrowersTabButton.Size = new System.Drawing.Size(300, 80);
            this.BorrowersTabButton.TabIndex = 2;
            this.BorrowersTabButton.Text = "Borrowers";
            this.BorrowersTabButton.UseVisualStyleBackColor = false;
            this.BorrowersTabButton.Click += new System.EventHandler(this.BorrowersTabButton_Click);
            // 
            // BooksTabButton
            // 
            this.BooksTabButton.BackColor = System.Drawing.Color.Transparent;
            this.BooksTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BooksTabButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BooksTabButton.Image = global::Library_Management_System.Properties.Resources.Books;
            this.BooksTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BooksTabButton.Location = new System.Drawing.Point(0, 80);
            this.BooksTabButton.Name = "BooksTabButton";
            this.BooksTabButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BooksTabButton.Size = new System.Drawing.Size(300, 80);
            this.BooksTabButton.TabIndex = 1;
            this.BooksTabButton.Text = "Books";
            this.BooksTabButton.UseVisualStyleBackColor = false;
            this.BooksTabButton.Click += new System.EventHandler(this.BooksTabButton_Click);
            // 
            // slidingPanelToggleButton
            // 
            this.slidingPanelToggleButton.AutoSize = true;
            this.slidingPanelToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.slidingPanelToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slidingPanelToggleButton.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slidingPanelToggleButton.Image = global::Library_Management_System.Properties.Resources.Left_Arrow;
            this.slidingPanelToggleButton.Location = new System.Drawing.Point(0, 0);
            this.slidingPanelToggleButton.Name = "slidingPanelToggleButton";
            this.slidingPanelToggleButton.Size = new System.Drawing.Size(300, 80);
            this.slidingPanelToggleButton.TabIndex = 0;
            this.slidingPanelToggleButton.UseVisualStyleBackColor = false;
            this.slidingPanelToggleButton.Click += new System.EventHandler(this.slidingPanelToggleButton_Click);
            // 
            // SlideingPanelTimer
            // 
            this.SlideingPanelTimer.Tick += new System.EventHandler(this.SlideingPanelTimer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(300, 40);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(1100, 710);
            this.ContentPanel.TabIndex = 4;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 750);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.slidingPanel);
            this.Controls.Add(this.title_Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppBody";
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.title_Bar.ResumeLayout(false);
            this.slidingPanel.ResumeLayout(false);
            this.slidingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_in_timer;
        private Button closeButton;
        private Button LogOffButton;
        private Button MinimizeButton;
        private Panel title_Bar;
        private Panel slidingPanel;
        private Button slidingPanelToggleButton;
        private System.Windows.Forms.Timer SlideingPanelTimer;
        private Button AboutTabButton;
        private Button SettingsTabButton;
        private Button TransactionsTabButton;
        private Button BorrowersTabButton;
        private Button BooksTabButton;
        private Panel ContentPanel;
    }
}