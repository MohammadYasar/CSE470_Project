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
            // TODO: This line of code loads data into the '_400_data_baseDataSet1.log_info' table. You can move, or remove it, as needed.
           // this.log_infoTableAdapter.Fill(this._400_data_baseDataSet1.log_info);
        }

        private void lblForm2Password_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(global::WindowsFormsApplication1.Properties.Settings.Default.CSE_470_peraConnectionString);
            try {

                string sql = "SELECT * from [log_info]";
                SqlCommand exeSql = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = exeSql.ExecuteReader();
                string val = "";
                while(reader.Read()){
                    val = val + reader.GetString(0)+" "+reader.GetString(1);
                }

                MessageBox.Show(val,"working",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception en) {
                MessageBox.Show(en.Message, "working", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally {
                con.Close();
                String s = "Welcome!";
                Doctor_s_Form newForm = new Doctor_s_Form(s);
                newForm.Show();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
