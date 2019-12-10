namespace DepartmentManagementSystem
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeptInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCourses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTeachers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPerformance = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 27);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataEntryToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(884, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dataEntryToolStripMenuItem
            // 
            this.dataEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeptInfo,
            this.mnuCourses,
            this.mnuStuInfo,
            this.mnuTeachers,
            this.mnuPerformance});
            this.dataEntryToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEntryToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.dataEntryToolStripMenuItem.Name = "dataEntryToolStripMenuItem";
            this.dataEntryToolStripMenuItem.Size = new System.Drawing.Size(108, 23);
            this.dataEntryToolStripMenuItem.Text = "Data Entry";
            // 
            // mnuDeptInfo
            // 
            this.mnuDeptInfo.ForeColor = System.Drawing.Color.Green;
            this.mnuDeptInfo.Name = "mnuDeptInfo";
            this.mnuDeptInfo.Size = new System.Drawing.Size(214, 24);
            this.mnuDeptInfo.Text = "Department Info";
            this.mnuDeptInfo.Click += new System.EventHandler(this.mnuDeptInfo_Click);
            // 
            // mnuCourses
            // 
            this.mnuCourses.ForeColor = System.Drawing.Color.Green;
            this.mnuCourses.Name = "mnuCourses";
            this.mnuCourses.Size = new System.Drawing.Size(214, 24);
            this.mnuCourses.Text = "Courses";
            this.mnuCourses.Click += new System.EventHandler(this.mnuCourses_Click);
            // 
            // mnuStuInfo
            // 
            this.mnuStuInfo.ForeColor = System.Drawing.Color.Green;
            this.mnuStuInfo.Name = "mnuStuInfo";
            this.mnuStuInfo.Size = new System.Drawing.Size(214, 24);
            this.mnuStuInfo.Text = "Students Info";
            this.mnuStuInfo.Click += new System.EventHandler(this.mnuStuInfo_Click);
            // 
            // mnuTeachers
            // 
            this.mnuTeachers.ForeColor = System.Drawing.Color.Green;
            this.mnuTeachers.Name = "mnuTeachers";
            this.mnuTeachers.Size = new System.Drawing.Size(214, 24);
            this.mnuTeachers.Text = "Teachers Info";
            this.mnuTeachers.Click += new System.EventHandler(this.mnuTeachers_Click);
            // 
            // mnuPerformance
            // 
            this.mnuPerformance.ForeColor = System.Drawing.Color.Green;
            this.mnuPerformance.Name = "mnuPerformance";
            this.mnuPerformance.Size = new System.Drawing.Size(214, 24);
            this.mnuPerformance.Text = "Performences";
            this.mnuPerformance.Click += new System.EventHandler(this.mnuPerformance_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(85, 23);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(77, 23);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // studentsReportToolStripMenuItem
            // 
            this.studentsReportToolStripMenuItem.Name = "studentsReportToolStripMenuItem";
            this.studentsReportToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.studentsReportToolStripMenuItem.Text = "Students Report";
            this.studentsReportToolStripMenuItem.Click += new System.EventHandler(this.studentsReportToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDeptInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuCourses;
        private System.Windows.Forms.ToolStripMenuItem mnuStuInfo;
        private System.Windows.Forms.ToolStripMenuItem mnuTeachers;
        private System.Windows.Forms.ToolStripMenuItem mnuPerformance;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsReportToolStripMenuItem;
    }
}