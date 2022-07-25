using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class Borrower_UserControl : UserControl
    {
        private static Borrower_UserControl _instance;

        public static Borrower_UserControl Instance
        {
            get
            {
                if( _instance == null )
                {
                    _instance = new Borrower_UserControl();
                }
                return _instance;
            }
        }
        public Borrower_UserControl()
        {
            InitializeComponent();
        }
    }
}
