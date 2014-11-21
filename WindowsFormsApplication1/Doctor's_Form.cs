using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Doctor_s_Form : Form
    {
        public Doctor_s_Form()
        {
            InitializeComponent();
            MessageBox.Show("welcome Back!");
        }
        public Doctor_s_Form(String s)
        {
            InitializeComponent();
            MessageBox.Show(s);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Doctor_s_Form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome!");
        }
    }
}
