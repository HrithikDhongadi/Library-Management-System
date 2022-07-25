using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Library_Management_System
{
    public partial class AppBody : Form

    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();




        public AppBody()
        {
            InitializeComponent();

            // Initializations
            isSlidingPanelExpanded = true;
            ExpandSlidingPanelGUI();

        }

        private void AppBody_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            Log_in_timer.Start();
        }

        private void Log_in_timer_Tick(object sender, EventArgs e)
        {
            if(this.Opacity <=1.0)
            {
                this.Opacity += 0.3;
            }
            else
            {
                this.Log_in_timer.Stop();  

            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void LogOffButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void title_Bar_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, (IntPtr)0);
            }
        }

        // Sliding Panel Code Starts from Here
        bool isSlidingPanelExpanded;
        const int MaxSliderWidth = 300;
        const int MinSliderWidth = 100;

        private void slidingPanelToggleButton_Click(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                //Retract panel
                //RetractSlidingPanelGUI();
            }
            SlideingPanelTimer.Start();

        }

        private void ExpandSlidingPanelGUI()
        {
            // GUI Adjustment for expanding.
            BooksTabButton.Text = "Books";
            BorrowersTabButton.Text = "Borrowers";
            TransactionsTabButton.Text = "Transaction";
            SettingsTabButton.Text = "Settings";
            AboutTabButton.Text = "About";

            slidingPanelToggleButton.Image = Properties.Resources.Left_Arrow;
            BooksTabButton.Image = null;
            BorrowersTabButton.Image = null;
            TransactionsTabButton.Image = null;
            SettingsTabButton.Image = null;
            AboutTabButton.Image = null;

        }
        private void RetractSlidingPanelGUI()
        {
            // GUI Adjustment for expanding.
            BooksTabButton.Text = "";
            BorrowersTabButton.Text = "";
            TransactionsTabButton.Text = "";
            SettingsTabButton.Text = "";
            AboutTabButton.Text = "";

            slidingPanelToggleButton.Image = Properties.Resources.Right_Arrow;
            BooksTabButton.Image = Properties.Resources.Books;
            BorrowersTabButton.Image = Properties.Resources.Borrower;
            TransactionsTabButton.Image = Properties.Resources.Transaction;
            SettingsTabButton.Image = Properties.Resources.Settings;
            AboutTabButton.Image = Properties.Resources.About;

        }

        private void SlideingPanelTimer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                // Retract Panel
                slidingPanel.Width -= 30;
                slidingPanelToggleButton.Width -= 30;
                if (slidingPanel.Width <= MinSliderWidth)
                {
                    //Stop Retract

                    isSlidingPanelExpanded = false;
                    SlideingPanelTimer.Stop();
                    RetractSlidingPanelGUI();

                    this.Refresh();
                }
            }
            else
            {
                // Expand the panel
                slidingPanel.Width += 30;
                slidingPanelToggleButton.Width += 30;   
                if (slidingPanel.Width >= MaxSliderWidth)
                {
                    //Stop Expanding
                    isSlidingPanelExpanded = true;
                    SlideingPanelTimer.Stop();
                    ExpandSlidingPanelGUI();

                    this.Refresh();
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BooksTabButton_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Books_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Books_UserControl.Instance);
                Books_UserControl.Instance.Dock=DockStyle.Fill;
                Books_UserControl.Instance.BringToFront();
            }
            else
            {
                Books_UserControl.Instance.BringToFront();
            }
        }

        private void BorrowersTabButton_Click(object sender, EventArgs e)
        {
            if(!ContentPanel.Controls.Contains(Borrower_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Borrower_UserControl.Instance);
                Borrower_UserControl.Instance.Dock=DockStyle.Fill;
                Borrower_UserControl.Instance.BringToFront();
            }
            else
            {
                Borrower_UserControl.Instance.BringToFront();
            }
        }

        private void TransactionsTabButton_Click(object sender, EventArgs e)
        {
            if(!ContentPanel.Controls.Contains(Transaction_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Transaction_UserControl.Instance);
                Transaction_UserControl.Instance.Dock=DockStyle.Fill;
                Transaction_UserControl.Instance.BringToFront();
            }
            else
            {
                Transaction_UserControl.Instance.BringToFront();
            }
        }

        private void SettingsTabButton_Click(object sender, EventArgs e)
        {
            if(!ContentPanel.Controls.Contains(Settings_UserControl.Instance))
            {
                ContentPanel.Controls.Add(Settings_UserControl.Instance);
                Settings_UserControl.Instance.Dock=DockStyle.Fill;
                Settings_UserControl.Instance.BringToFront();
            }
            else
            {
                Settings_UserControl.Instance.BringToFront();
            }
        }

        private void AboutTabButton_Click(object sender, EventArgs e)
        {
            if(!ContentPanel.Controls.Contains(About_UserControl.Instance))
            {
                ContentPanel.Controls.Add(About_UserControl.Instance);
                About_UserControl.Instance.Dock=DockStyle.Fill;
                About_UserControl.Instance.BringToFront();
            }
            else
            {
                About_UserControl.Instance.BringToFront();
            }
        }
    }
}
