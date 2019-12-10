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
    public partial class TeachersInfo : Form
    {
        private string constr = ConfigurationManager.ConnectionStrings["conDepartment"].ConnectionString;
        public TeachersInfo()
        {
            InitializeComponent();
        }

        private void TeachersInfo_Load(object sender, EventArgs e)
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
                        $"select * from TeachersInfo";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);

                    DataSet ds = new DataSet();

                    sda.Fill(ds);
                    grdteacher.DataSource = "";
                    grdteacher.DataSource = ds.Tables[0];
                    grdteacher.Columns["TeacherName"].HeaderText = "Teacher's Name";
                    grdteacher.AutoResizeColumns();
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

        private void grdteacher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTID.Text = grdteacher.SelectedRows[0].Cells[0].Value.ToString();
            txtTName.Text = grdteacher.SelectedRows[0].Cells[1].Value.ToString();
            txtTAddress.Text = grdteacher.SelectedRows[0].Cells[2].Value.ToString();
            txtTMobile.Text = grdteacher.SelectedRows[0].Cells[3].Value.ToString();
            txtTCourseCode.Text = grdteacher.SelectedRows[0].Cells[4].Value.ToString();
            txtnmrc.Text = grdteacher.SelectedRows[0].Cells[5].Value.ToString();
            txtTDesignation.Text = grdteacher.SelectedRows[0].Cells[6].Value.ToString();
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
                        $"insert into TeachersInfo (TeacherName,Address,Mobile,CourseCode,DepartmentID,Designation) values ('{txtTName.Text}','{txtTAddress.Text}','{txtTMobile.Text}','{txtTCourseCode.Text}','{txtnmrc.Value}', '{txtTDesignation.Text}')";
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
                        $"delete from TeachersInfo where TeacherID = {txtTID.Text}";
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
                        $"update TeachersInfo set TeacherName = '{txtTName.Text}', Address = '{txtTAddress.Text}', Mobile = '{txtTMobile.Text}', CourseCode = '{txtTCourseCode.Text}', DepartmentID = '{txtnmrc.Value}', Designation = '{txtTDesignation.Text}' where TeacherID = '{txtTID.Text}'";
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

        private void btnCancelC_Click(object sender, EventArgs e)
        {
            datareset();
        }

        private void datareset()
        {
            txtTID.Text = "";
            txtTName.Text = "";
            txtTAddress.Text = "";
            txtTMobile.Text = "";
            txtTCourseCode.Text = "";
            txtnmrc.Value = 0;
            txtTDesignation.Text = "";
        }
    }
}
