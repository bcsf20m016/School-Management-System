using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMangementSystem
{
    public partial class AttendenceForm : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SchoolManagementSystem");
        public string grade { get; set; } = "";
        public string section { get; set; } = "A";
        public AttendenceForm()
        {
            InitializeComponent();
            grade = "";
            section = "A";
        }

        private void attendence_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            var gradeIndex = attendence_class.SelectedIndex;
            grade = attendence_class.Items[gradeIndex].ToString();
            displayAttendenceStudents();
        }
        private void attendence_section_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sectionIndex = attendence_section.SelectedIndex;
            section = attendence_section.Items[sectionIndex].ToString();
            displayAttendenceStudents();
        }
        private void displayAttendenceStudents()
        {
            List<AddStudentData> listData = new List<AddStudentData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string sql = $"SELECT * FROM students WHERE date_delete IS NULL and student_section = '{section}' and student_grade = '{grade}'";

                    using (SqlCommand cmd = new SqlCommand(sql, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddStudentData addSD = new AddStudentData();
                            addSD.ID = (int)reader["id"];
                            addSD.StudentID = reader["student_id"].ToString();
                            addSD.StudentName = reader["student_name"].ToString();
                            addSD.StudentGender = reader["student_gender"].ToString();
                            addSD.StudentAddress = reader["student_address"].ToString();
                            addSD.StudentGrade = reader["student_grade"].ToString();
                            addSD.StudentSection = reader["student_section"].ToString();
                            addSD.StudentImage = reader["student_image"].ToString();
                            addSD.Status = reader["student_status"].ToString();
                            addSD.DateInsert = reader["date_insert"].ToString();

                            listData.Add(addSD);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database: " + ex);
                }
                finally
                {
                    connect.Close();
                    attendence_students.DataSource = listData;
                }
            }
        }

        private void submitAttendence_btn_Click(object sender, EventArgs e)
        {
            connect.Open();
            foreach (DataGridViewRow row in attendence_students.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells["Status"] as DataGridViewCheckBoxCell;
                string studentID = row.Cells["StudentID"].Value.ToString();

                if (checkBoxCell != null && Convert.ToBoolean(checkBoxCell.Value))
                {
                    string query = $"update students set student_presents = student_presents + 1 where student_id = '{studentID}'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string query = $"update students set student_absents = student_absents + 1 where student_id = '{studentID}'";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                }
            }
            connect.Close();
            MessageBox.Show("Attendence updated successfully");
            //Resetting user control
            attendence_students.DataSource = null;
            grade = "";
            attendence_class.Text = "";
            section = "A";
            attendence_section.Text = "A";
        }

        private void attendence_students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
