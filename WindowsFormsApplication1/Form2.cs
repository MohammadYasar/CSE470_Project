using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;



namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        String password, confirm_password, userName, email_id;
        Form4 mainForm=new Form4();
        public Form2()
        {
            
            InitializeComponent();
        }
        public Form2(Form4 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lblForm2Password_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //if (this.textBox1.Text != string.Empty)
            //{

            //    mainForm.listBox1.Items.Clear();

            //    string[] stringsEntered = textBox1.Lines;

            //    for (int count = 0; count < stringsEntered.Length; count++)
            //    {

            //        mainForm.listBox1.Items.Add(stringsEntered[count]);

            //    }

            //}
            //this.Close();
            //mainForm.listBox1.Show();

            MySql.Data.mySqlClient.MySqlConnection conn;
            string connString = "server=127.0.0.1; uid=root;" + "pwd=root; database=cse470_project;";
            try
            {
                conn = new MySql.Data.MySqlClinet.MySqlConnection();
                conn.ConnectionString = connString;
                conn.open();
            }

            catch (Exception exp)
            {
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.userName = this.textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            this.email_id = this.textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.password = this.textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.confirm_password = this.Text;
            if (!this.password.Equals(this.confirm_password))            {
                MessageBox.Show("Password MisMatch");

            }
        }
    }
}
