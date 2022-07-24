namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
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