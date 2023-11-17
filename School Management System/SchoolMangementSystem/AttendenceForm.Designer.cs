namespace SchoolMangementSystem
{
    partial class AttendenceForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.attendence_class = new System.Windows.Forms.ComboBox();
            this.attendence_section = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.submitAttendence_btn = new System.Windows.Forms.Button();
            this.attendence_students = new System.Windows.Forms.DataGridView();
            this.addStudentDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.addStudentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendence_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 43);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // attendence_class
            // 
            this.attendence_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendence_class.FormattingEnabled = true;
            this.attendence_class.Items.AddRange(new object[] {
            "Grade 1",
            "Grade 2",
            "Grade 3",
            "Grade 4",
            "Grade 5",
            "Grade 6"});
            this.attendence_class.Location = new System.Drawing.Point(654, 41);
            this.attendence_class.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.attendence_class.Name = "attendence_class";
            this.attendence_class.Size = new System.Drawing.Size(180, 33);
            this.attendence_class.TabIndex = 3;
            this.attendence_class.SelectedIndexChanged += new System.EventHandler(this.attendence_class_SelectedIndexChanged);
            // 
            // attendence_section
            // 
            this.attendence_section.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendence_section.FormattingEnabled = true;
            this.attendence_section.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.attendence_section.Location = new System.Drawing.Point(1052, 39);
            this.attendence_section.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.attendence_section.Name = "attendence_section";
            this.attendence_section.Size = new System.Drawing.Size(180, 33);
            this.attendence_section.TabIndex = 4;
            this.attendence_section.SelectedIndexChanged += new System.EventHandler(this.attendence_section_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(566, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(938, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Section";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(34, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 85);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.attendence_students);
            this.panel2.Location = new System.Drawing.Point(34, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 527);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 37);
            this.label4.TabIndex = 10;
            this.label4.Text = "Students:";
            // 
            // submitAttendence_btn
            // 
            this.submitAttendence_btn.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.submitAttendence_btn.FlatAppearance.BorderSize = 0;
            this.submitAttendence_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.submitAttendence_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.submitAttendence_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitAttendence_btn.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAttendence_btn.ForeColor = System.Drawing.Color.White;
            this.submitAttendence_btn.Location = new System.Drawing.Point(34, 733);
            this.submitAttendence_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitAttendence_btn.Name = "submitAttendence_btn";
            this.submitAttendence_btn.Size = new System.Drawing.Size(212, 54);
            this.submitAttendence_btn.TabIndex = 15;
            this.submitAttendence_btn.Text = "Submit Attendence";
            this.submitAttendence_btn.UseVisualStyleBackColor = false;
            this.submitAttendence_btn.Click += new System.EventHandler(this.submitAttendence_btn_Click);
            // 
            // attendence_students
            // 
            this.attendence_students.AllowUserToAddRows = false;
            this.attendence_students.AllowUserToOrderColumns = true;
            this.attendence_students.AutoGenerateColumns = false;
            this.attendence_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendence_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Status});
            this.attendence_students.DataSource = this.addStudentDataBindingSource1;
            this.attendence_students.Location = new System.Drawing.Point(15, 51);
            this.attendence_students.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.attendence_students.Name = "attendence_students";
            this.attendence_students.RowHeadersVisible = false;
            this.attendence_students.RowHeadersWidth = 500;
            this.attendence_students.Size = new System.Drawing.Size(1196, 461);
            this.attendence_students.TabIndex = 7;
            this.attendence_students.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.attendence_students_CellContentClick);
            // 
            // addStudentDataBindingSource1
            // 
            this.addStudentDataBindingSource1.DataSource = typeof(SchoolMangementSystem.AddStudentData);
            // 
            // addStudentDataBindingSource
            // 
            this.addStudentDataBindingSource.DataSource = typeof(SchoolMangementSystem.AddStudentData);
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "StudentID";
            this.StudentID.MinimumWidth = 8;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 250;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.MinimumWidth = 8;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 250;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 250;
            // 
            // AttendenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.submitAttendence_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attendence_section);
            this.Controls.Add(this.attendence_class);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AttendenceForm";
            this.Size = new System.Drawing.Size(1312, 885);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendence_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox attendence_class;
        private System.Windows.Forms.ComboBox attendence_section;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource addStudentDataBindingSource;
        private System.Windows.Forms.Button submitAttendence_btn;
        private System.Windows.Forms.DataGridView attendence_students;
        private System.Windows.Forms.BindingSource addStudentDataBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}
