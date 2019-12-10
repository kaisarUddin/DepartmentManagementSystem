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
    public partial class Courses : Form
    {
        private string constr = ConfigurationManager.ConnectionStrings["conDepartment"].ConnectionString;
        public Courses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.Show();
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
                        $"insert into Courses (CourseName) values ('{txtCName.Text}')";
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
                        $"update Courses set CourseName = '{txtCName.Text}' where CourseCode = '{txtCode.Text}'";
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

        private void Courses_Load(object sender, EventArgs e)
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
                        $"select * from Courses";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);

                    DataSet ds = new DataSet();

                    sda.Fill(ds);
                    grdCourse.DataSource = "";
                    grdCourse.DataSource = ds.Tables[0];
                    grdCourse.Columns["CourseName"].HeaderText = "Course Name";
                    grdCourse.AutoResizeColumns();
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
                        $"delete from Courses where CourseCode = {txtCode.Text}";
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
            txtCode.Text = "";
            txtCName.Text = "";
        }

        private void grdCourse_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = grdCourse.SelectedRows[0].Cells[0].Value.ToString();
            txtCName.Text = grdCourse.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
