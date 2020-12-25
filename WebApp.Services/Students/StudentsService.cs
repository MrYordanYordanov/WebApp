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
    }
}
