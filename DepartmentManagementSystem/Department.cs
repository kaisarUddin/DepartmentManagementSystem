using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentManagementSystem
{
    public partial class Department : Form
    {
        private string constr = ConfigurationManager.ConnectionStrings["conDepartment"].ConnectionString;
        public Department()
        {
            InitializeComponent();
        }

        private void Department_Load(object sender, EventArgs e)
        {
            dataLoad();

        }

        private void dataLoad()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string sql =
                        $"select * from Department";
                   SqlDataAdapter sda = new SqlDataAdapter(sql,con);
                   
                    DataSet ds = new DataSet();
                    
                    sda.Fill(ds);
                    grdDepartment.DataSource = "";
                    grdDepartment.DataSource = ds.Tables[0];
                    grdDepartment.Columns["DepartmentName"].HeaderText = "Department Name";
                    grdDepartment.AutoResizeColumns(); 
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnSaveD_Click(object sender, EventArgs e)
        {
            saveData();
            dataLoad();
           
        }

        private void saveData()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string sql =
                        $"insert into Department (DepartmentName) values ('{txtName.Text}')";
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = sql;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data saved successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnCancelD_Click(object sender, EventArgs e)
        {
            dataReset();
        }

        private void dataReset()
        {
            txtID.Text = "";
            txtName.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dataUpdate();
            dataLoad();
        }

        private void dataUpdate()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string sql =
                        $"update Department set DepartmentName = '{txtName.Text}' where DepartmentID = {txtID.Text}";
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = sql;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data updated successfully");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataDelete();
            dataLoad();
        }

        private void dataDelete()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string sql =
                        $"delete from Department where DepartmentID = {txtID.Text}";
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = sql;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data deleted successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
        }

        private void grdDepartment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = grdDepartment.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = grdDepartment.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
