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
    public partial class Students_Info : Form
    {
        private string constr = ConfigurationManager.ConnectionStrings["conDepartment"].ConnectionString;
        public Students_Info()
        {
            InitializeComponent();
        }

        private void Students_Info_Load(object sender, EventArgs e)
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
                        $"select * from StudentsInfo";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);

                    DataSet ds = new DataSet();

                    sda.Fill(ds);
                    grdStudent.DataSource = "";
                    grdStudent.DataSource = ds.Tables[0];
                    grdStudent.Columns["StudentName"].HeaderText = "Student Name";
                    grdStudent.AutoResizeColumns();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
        }

        private void grdStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSID.Text = grdStudent.SelectedRows[0].Cells[0].Value.ToString();
            txtSName.Text = grdStudent.SelectedRows[0].Cells[1].Value.ToString();
            txtSAddress.Text = grdStudent.SelectedRows[0].Cells[2].Value.ToString();
            txtnmrc.Text = grdStudent.SelectedRows[0].Cells[3].Value.ToString();
            txtSMobile.Text = grdStudent.SelectedRows[0].Cells[4].Value.ToString();
            
        }

        private void btnSaveC_Click(object sender, EventArgs e)
        {
            dataSave();
            dataLoad();
        }

        private void dataSave()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string sql =
                        $"insert into StudentsInfo (StudentName,Address,DepartmentID,Mobile) values ('{txtSName.Text}','{txtSAddress.Text}','{txtnmrc.Value}','{txtSMobile.Text}')";
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
                        $"update StudentsInfo set StudentName = '{txtSName.Text}', Address = '{txtSAddress.Text}', DepartmentID = '{txtnmrc.Value}', Mobile = '{txtSMobile.Text}' where StudentID = '{txtSID.Text}'";
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
        }

        private void dataDelete()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string sql =
                        $"delete from StudentsInfo where StudentID = {txtSID.Text}";
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

        private void btnCancelC_Click(object sender, EventArgs e)
        {
            dataReset();
        }

        private void dataReset()
        {
            txtSAddress.Text = "";
            txtSID.Text = "";
            txtSMobile.Text = "";
            txtSName.Text = "";
            txtnmrc.Value = 0;
        }
    }
}
