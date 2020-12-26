using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.ViewModels;

namespace WebApp.Services.Students
{
    public class StudentsService : BaseEFService
    {
        public async Task<List<Student>> GetAllStudents()
        {
            await this.Connection.OpenAsync();
            var command = new MySqlCommand("SELECT * FROM students;", this.Connection);
            var reader = await command.ExecuteReaderAsync();
            var students = new List<Student>();
            while (await reader.ReadAsync())
            {
                var id = reader.GetValue(0);
                var name = reader.GetValue(1);
                var surname = reader.GetValue(2);
                var dob = reader.GetValue(3);
                var student = new Student()
                {
                    Id = int.Parse(id.ToString()),
                    Name = name.ToString(),
                    Surname = surname.ToString(),
                    Dob = DateTime.Parse(dob.ToString()).ToString("yyyy-MM-dd")
                };
                students.Add(student);
            }

            await this.Connection.CloseAsync();

            return students;
        }

        public Student GetLastAddedStudent()
        {
            try
            {
                this.Connection.Open();

                var command = new MySqlCommand("SELECT * FROM students ORDER BY id DESC LIMIT 1;", this.Connection);
                var reader = command.ExecuteReader();
                var student = new Student();
                while (reader.Read())
                {
                    var id = reader.GetValue(0);
                    var name = reader.GetValue(1);
                    var surname = reader.GetValue(2);
                    var dob = reader.GetValue(3);
                    student = new Student()
                    {
                        Id = int.Parse(id.ToString()),
                        Name = name.ToString(),
                        Surname = surname.ToString(),
                        Dob = DateTime.Parse(dob.ToString()).ToString("yyyy-MM-dd")
                    };
                }
                return student;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.Connection.Close();
            }
        }


        public async Task Create(Student student)
        {
            try
            {
                await this.Connection.OpenAsync();
                var com = new MySqlCommand("sp_AddStudent", this.Connection);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", student.Name);
                com.Parameters.AddWithValue("@surname", student.Surname);
                com.Parameters.AddWithValue("@dob", DateTime.Parse(student.Dob));
                com.ExecuteNonQuery();
            }
            catch(Exception e) 
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.Connection.Close();
            }
        }

        public async void Edit(Student student)
        {
            await this.Connection.OpenAsync();
            var com = new MySqlCommand("sp_EditStudent", this.Connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@studentId", student.Id);
            com.Parameters.AddWithValue("@name", student.Name);
            com.Parameters.AddWithValue("@surname", student.Surname);
            com.Parameters.AddWithValue("@dob", DateTime.Parse(student.Dob));
            com.ExecuteNonQuery();
            this.Connection.Close();
        }
        
        public async Task<StudentSemesters> GetStudentSemesters(int id)
        {
            await this.Connection.OpenAsync();
            var command = new MySqlCommand($"select * from students_semesters" +
                $" INNER JOIN students ON students.id=students_semesters.student_id" +
                $" INNER JOIN semesters ON semesters.id=students_semesters.semester_id" +
                $" WHERE students_semesters.student_id={id};", this.Connection);
            var reader = await command.ExecuteReaderAsync();
            var model = new StudentSemesters();
            var semesters = new List<Semester>();
            var studentSemestersIds = new List<int>();
            
            while (await reader.ReadAsync())
            {
                var semesterId = int.Parse(reader.GetValue(6).ToString());
                studentSemestersIds.Add(semesterId);
                var semName = reader.GetValue(7);
                var semStartDate = reader.GetValue(8);
                var semEndDate = reader.GetValue(9);
                semesters.Add(new Semester()
                {
                    Id = semesterId,
                    Name = semName.ToString(),
                    StartDate = DateTime.Parse(semStartDate.ToString()).ToString("yyyy-MM-dd"),
                    EndDate = DateTime.Parse(semEndDate.ToString()).ToString("yyyy-MM-dd")
                });
            }

            await this.Connection.CloseAsync();

            model.Student = await this.GetStudentById(id);
            model.Semesters = semesters;
            model.AvailableSemesters = await this.GetAvailableSemesters(studentSemestersIds);

            return model;
        }

        public async void AddSemester(AddStudentSemester model)
        {
            await this.Connection.OpenAsync();
            var com = new MySqlCommand("sp_AddSemToStudent", this.Connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@studId", model.StudId);
            com.Parameters.AddWithValue("@semId", model.SemId);
            com.ExecuteNonQuery();
            await this.Connection.CloseAsync();
        }

        private async Task<Student> GetStudentById(int id)
        {
            await this.Connection.OpenAsync();
            var command = new MySqlCommand($"SELECT * FROM students WHERE id={id};", this.Connection);
            var reader = await command.ExecuteReaderAsync();
            var student = new Student();
            while (await reader.ReadAsync())
            {
                var name = reader.GetValue(1);
                var surname = reader.GetValue(2);
                var dob = reader.GetValue(3);
                student = new Student()
                {
                    Id = id,
                    Name = name.ToString(),
                    Surname = surname.ToString(),
                    Dob = DateTime.Parse(dob.ToString()).ToString("yyyy-MM-dd")
                };
            }

            await this.Connection.CloseAsync();

            return student;
        }

        private async Task<List<Semester>> GetAvailableSemesters(List<int> studentSemestersIds)
        {
            var availableSemesters = new List<Semester>();

            await this.Connection.OpenAsync();
            MySqlCommand commandAvaiDis;
            if (studentSemestersIds.Count > 0)
            { 
                commandAvaiDis = new MySqlCommand($"SELECT * FROM semesters WHERE id NOT IN ({String.Join(",", studentSemestersIds)});", this.Connection);               
            }
            else
            {
                commandAvaiDis = new MySqlCommand($"SELECT * FROM semesters;", this.Connection);
            }

            var reader1 = await commandAvaiDis.ExecuteReaderAsync();
            while (await reader1.ReadAsync())
            {
                var semesterId = int.Parse(reader1.GetValue(0).ToString());
                var semName = reader1.GetValue(1);
                var semStartDate = reader1.GetValue(2);
                var semEndDate = reader1.GetValue(3);

                availableSemesters.Add(new Semester()
                {
                    Id = semesterId,
                    Name = semName.ToString(),
                    StartDate = DateTime.Parse(semStartDate.ToString()).ToString("yyyy-MM-dd"),
                    EndDate = DateTime.Parse(semEndDate.ToString()).ToString("yyyy-MM-dd")
                });
            }
            await this.Connection.CloseAsync();

            return availableSemesters;
        }
    }
}
