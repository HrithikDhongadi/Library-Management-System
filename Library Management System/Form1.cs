using System.Data.SqlClient;
namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\My Files\\College\\Projects\\DBMS\\Library Management System\\Library Management System\\Library Management System\\Database.mdf\";Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void getData()
        {
            // Fetch dat from database
            con.Open();
            String syntax = "SELECT value FROM systemTable WHERE Property = UserName";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            MessageBox.Show("" + dr.ToString());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getData();
            String Uname="1", Upass="1", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;

            if(name.Equals(Uname) && pass.Equals(Upass))
            {
                //Login
                label4.Hide();
                MessageBox.Show("Login Success");
            }
            else
            {
                //Dont login
                label4.Show();
            }

             
        }
    }
}