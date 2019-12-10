using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentManagementSystem
{
    public partial class Form1 : Form
    {
        private const string UserId = "admin";
        private const string Password = "admin";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text!=UserId)
            {
                MessageBox.Show("Invalid User Id");
                return;
            }
            else if(txtPassword.Text!=Password)
            {
                MessageBox.Show("Invalid Password");
                return;
            }
            Main mainfrm = new Main();
            mainfrm.Show();
            formReset();
            this.Hide();
        }

        private void formReset()
        {
            txtUserName.Text = null;
            txtPassword.Text = null;
        }
    }
}
