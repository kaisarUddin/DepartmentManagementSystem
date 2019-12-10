namespace DepartmentManagementSystem
{
    partial class Students_Info
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtSAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSMobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grdStudent = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancelC = new System.Windows.Forms.Button();
            this.btnSaveC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnmrc = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnmrc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address :";
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(177, 44);
            this.txtSID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSID.Multiline = true;
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(311, 31);
            this.txtSID.TabIndex = 1;
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(177, 90);
            this.txtSName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSName.Multiline = true;
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(311, 30);
            this.txtSName.TabIndex = 1;
            // 
            // txtSAddress
            // 
            this.txtSAddress.Location = new System.Drawing.Point(177, 138);
            this.txtSAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSAddress.Multiline = true;
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.Size = new System.Drawing.Size(311, 48);
            this.txtSAddress.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(509, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department ID :";
            // 
            // txtSMobile
            // 
            this.txtSMobile.Location = new System.Drawing.Point(657, 100);
            this.txtSMobile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSMobile.Multiline = true;
            this.txtSMobile.Name = "txtSMobile";
            this.txtSMobile.Size = new System.Drawing.Size(205, 38);
            this.txtSMobile.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(509, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mobile :";
            // 
            // grdStudent
            // 
            this.grdStudent.AllowUserToAddRows = false;
            this.grdStudent.AllowUserToDeleteRows = false;
            this.grdStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.grdStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grdStudent.Location = new System.Drawing.Point(0, 303);
            this.grdStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdStudent.MultiSelect = false;
            this.grdStudent.Name = "grdStudent";
            this.grdStudent.ReadOnly = true;
            this.grdStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStudent.Size = new System.Drawing.Size(1031, 387);
            this.grdStudent.TabIndex = 3;
            this.grdStudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudent_CellDoubleClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(288, 230);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 45);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(404, 230);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 45);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancelC
            // 
            this.btnCancelC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelC.ForeColor = System.Drawing.Color.White;
            this.btnCancelC.Location = new System.Drawing.Point(514, 230);
            this.btnCancelC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelC.Name = "btnCancelC";
            this.btnCancelC.Size = new System.Drawing.Size(90, 45);
            this.btnCancelC.TabIndex = 6;
            this.btnCancelC.Text = "Cancel";
            this.btnCancelC.UseVisualStyleBackColor = false;
            this.btnCancelC.Click += new System.EventHandler(this.btnCancelC_Click);
            // 
            // btnSaveC
            // 
            this.btnSaveC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSaveC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveC.ForeColor = System.Drawing.Color.White;
            this.btnSaveC.Location = new System.Drawing.Point(174, 232);
            this.btnSaveC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveC.Name = "btnSaveC";
            this.btnSaveC.Size = new System.Drawing.Size(90, 45);
            this.btnSaveC.TabIndex = 7;
            this.btnSaveC.Text = "Save";
            this.btnSaveC.UseVisualStyleBackColor = false;
            this.btnSaveC.Click += new System.EventHandler(this.btnSaveC_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(634, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnmrc
            // 
            this.txtnmrc.Location = new System.Drawing.Point(657, 50);
            this.txtnmrc.Name = "txtnmrc";
            this.txtnmrc.Size = new System.Drawing.Size(205, 23);
            this.txtnmrc.TabIndex = 11;
            // 
            // Students_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1031, 690);
            this.Controls.Add(this.txtnmrc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancelC);
            this.Controls.Add(this.btnSaveC);
            this.Controls.Add(this.grdStudent);
            this.Controls.Add(this.txtSMobile);
            this.Controls.Add(this.txtSAddress);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Students_Info";
            this.Text = "Students_Info";
            this.Load += new System.EventHandler(this.Students_Info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnmrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtSAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSMobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdStudent;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancelC;
        private System.Windows.Forms.Button btnSaveC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown txtnmrc;
    }
}