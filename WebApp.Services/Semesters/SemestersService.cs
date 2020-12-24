using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.ViewModels;

namespace WebApp.Services.Semesters
{
    public class SemestersService : BaseEFService
    {
        public async Task<List<Semester>> GetAllSemesters()
        {
            await this.Connection.OpenAsync();
            var command = new MySqlCommand("SELECT * FROM semesters;", this.Connection);
            var reader = await command.ExecuteReaderAsync();
            var semesters = new List<Semester>();
            while (await reader.ReadAsync())
            {
                var id = reader.GetValue(0);
                var name = reader.GetValue(1);
                var startDate = reader.GetValue(2);
                var endDate = reader.GetValue(3);
                var semester = new Semester()
                {
                    Id = int.Parse(id.ToString()),
                    Name = name.ToString(),
                    StartDate = DateTime.Parse(startDate.ToString()).ToString("yyyy-MM-dd"),
                    EndDate = DateTime.Parse(endDate.ToString()).ToString("yyyy-MM-dd")
                };
                semesters.Add(semester);
            }

            return semesters;
        }

        public Semester GetLastAddedSemester()
        {
            try
            {
                this.Connection.Close();
                this.Connection.Open();

                var command = new MySqlCommand("SELECT * FROM semesters ORDER BY id DESC LIMIT 1;", this.Connection);
                var reader = command.ExecuteReader();
                var semester = new Semester();
                while (reader.Read())
                {
                    var id = reader.GetValue(0);
                    var name = reader.GetValue(1);
                    var startDate = reader.GetValue(2);
                    var endDate = reader.GetValue(3);
                    semester = new Semester()
                    {
                        Id = int.Parse(id.ToString()),
                        Name = name.ToString(),
                        StartDate = DateTime.Parse(startDate.ToString()).ToString("yyyy-MM-dd"),
                        EndDate = DateTime.Parse(endDate.ToString()).ToString("yyyy-MM-dd")
                    };
                }
                return semester;
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


        public async Task Create(Semester semester)
        {
            try
            {
                this.Connection.Close();
                await this.Connection.OpenAsync();
                var com = new MySqlCommand("sp_AddSemester", this.Connection);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", semester.Name);
                com.Parameters.AddWithValue("@startDate", DateTime.Parse(semester.StartDate));
                com.Parameters.AddWithValue("@endDate", DateTime.Parse(semester.EndDate));
                com.ExecuteNonQuery();
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

        public async void Edit(Semester semester)
        {
            await this.Connection.OpenAsync();
            var com = new MySqlCommand("sp_EditSemester", this.Connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@semesterId", semester.Id);
            com.Parameters.AddWithValue("@name", semester.Name);
            com.Parameters.AddWithValue("@startDate", DateTime.Parse(semester.StartDate));
            com.Parameters.AddWithValue("@endDate", DateTime.Parse(semester.EndDate));
            com.ExecuteNonQuery();
            this.Connection.Close();
        }
    }
}
