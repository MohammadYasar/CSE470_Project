using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(global::WindowsFormsApplication1.Properties.Settings.Default.CSE_470_peraConnectionString);

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                string pass=textBox3.Text;
                string email=textBox2.Text;
                string sql = "SELECT * from [log_info] where (email_id='"+email+"' AND password='"+pass+"')";
                SqlCommand exeSql = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader reader = exeSql.ExecuteReader();
                bool contain=false;
                string val = "";
                while(reader.Read()){
                    if (reader.GetString(1) == email && reader.GetString(2)==pass) {
                        contain = true;
                    }
                   // val = val+reader.GetString(0)+" "+reader.GetString(1);
                }

                if (contain)
                {
                    MessageBox.Show("Success", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Not-Success", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                con.Close();
            }
            Doctor_s_Form newForm = new Doctor_s_Form();
            newForm.Show();
            MessageBox.Show("Welcome back!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
