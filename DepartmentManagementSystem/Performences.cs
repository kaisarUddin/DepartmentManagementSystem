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
    public partial class Performences : Form
    {
        private string constr = ConfigurationManager.ConnectionStrings["conDepartment"].ConnectionString;
        public Performences()
        {
            InitializeComponent();
        }

        private void Performences_Load(object sender, EventArgs e)
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
                        $"select * from Performances";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, con);

                    DataSet ds = new DataSet();

                    sda.Fill(ds);
                    grdPerformence.DataSource = "";
                    grdPerformence.DataSource = ds.Tables[0];
                    grdPerformence.Columns["DepartmentID"].HeaderText = "Department ID";
                    grdPerformence.Columns["StudentID"].HeaderText = "Student ID";
                    grdPerformence.Columns["ExamType"].HeaderText = "Exam";
                    grdPerformence.Columns["VivaVoce"].HeaderText = "Viva-Voce";
                    grdPerformence.AutoResizeColumns();
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
                        $"insert into Performances (StudentID,Attendence,Tutorial,Theory,VivaVoce,DepartmentID,ExamType) values ('{txtPSID.Text}', '{txtAttendence.Text}' ,'{txtTutorial.Text}', '{txtTheory.Text}', '{txtVivaVoce.Text}', '{txtnmrc.Value}', '{txtExamType.Text}')";
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

        private void btnCancelC_Click(object sender, EventArgs e)
        {
            dataReset();
        }

        private void dataReset()
        {
            txtPSID.Text = "";
            txtAttendence.Text = "";
            txtTutorial.Text = "";
            txtExamType.Text = "";
            txtnmrc.Text = "";
            txtTheory.Text = "";
            txtVivaVoce.Text = "";

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
                        $"delete from Performances where StudentID = '{txtPSID.Text}'";
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
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    string sql =
                        $"update [dbo].[Performances] set Attendence = '{txtAttendence.Text}', Tutorial = '{txtTutorial.Text}', Theory = '{txtTheory.Text}', VivaVoce = '{txtVivaVoce.Text}', DepartmentID = '{txtnmrc.Value}' ,ExamType = '{txtExamType.Text}' where StudentID = '{txtPSID.Text}'";
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = sql;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data updated successfully");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void grdPerformence_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            txtPSID.Text = grdPerformence.SelectedRows[0].Cells[0].Value.ToString();
            txtAttendence.Text = grdPerformence.SelectedRows[0].Cells[1].Value.ToString();
            txtTutorial.Text = grdPerformence.SelectedRows[0].Cells[2].Value.ToString();
            txtTheory.Text = grdPerformence.SelectedRows[0].Cells[3].Value.ToString();
            txtVivaVoce.Text = grdPerformence.SelectedRows[0].Cells[4].Value.ToString();
            txtnmrc.Text = grdPerformence.SelectedRows[0].Cells[5].Value.ToString();
            txtExamType.Text = grdPerformence.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
