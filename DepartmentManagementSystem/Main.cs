using CrystalDecisions.CrystalReports.Engine;
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
    public partial class Main : Form
    {
        private string constr = ConfigurationManager.ConnectionStrings["conDepartment"].ConnectionString;
        public Main()
        {
            InitializeComponent();
        }

        private void mnuDeptInfo_Click(object sender, EventArgs e)
        {
            Department dept = new Department();
            dept.Show(this);
        }

        private void mnuCourses_Click(object sender, EventArgs e)
        {
            Courses crs = new Courses();
            crs.Show(this);
        }

        private void mnuStuInfo_Click(object sender, EventArgs e)
        {
            Students_Info stdInfo = new Students_Info();
            stdInfo.Show(this);
            
        }

        private void mnuTeachers_Click(object sender, EventArgs e)
        {
            TeachersInfo tchrInfo = new TeachersInfo();
            tchrInfo.Show(this);

        }

        private void mnuPerformance_Click(object sender, EventArgs e)
        {
            Performences prfrmnc = new Performences();
            prfrmnc.Show(this);
        }

      

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           var result =  MessageBox.Show("Are you sure want to logout?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
           if (result == DialogResult.OK)
           {
               Application.OpenForms["Form1"].Show();
               this.Close();
           }
           
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

     

        private void studentsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadStudentReport();
        }

        private void loadStudentReport()
        {

            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "select * from vwDetails";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "vwDetails");

                    ReportDocument rd = new ReportDocument();
                    string reportPath = Application.StartupPath + @"\Reports\StudentsReport.rpt";

                    rd.Load(reportPath);
                    rd.SetDataSource(ds);



                    ReportViewerForm rv = new ReportViewerForm();

                    rv.crystalReportViewer1.ReportSource = rd;

                    rv.Show(this);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
