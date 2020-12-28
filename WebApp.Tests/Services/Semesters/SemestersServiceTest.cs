using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.ViewModels;
using WebApp.Tests.Mocks;

namespace WebApp.Tests.Services.Semesters
{
    public class SemestersServiceTest : MySqlConnectionFactory
    {
        public void Clear()
        {
            try
            {
                this.Connection.Open();
                var com = new MySqlCommand("sp_DeleteAllSemesters", this.Connection);
                com.CommandType = CommandType.StoredProcedure;
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

            await this.Connection.CloseAsync();

            return semesters;

           
        }

        public Semester GetLastAddedSemester()
        {
            try
            {
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

        public async Task<Semester> Edit(Semester semester)
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

            this.Connection.Open();

            var command = new MySqlCommand($"SELECT * FROM semesters where id={semester.Id};",
                this.Connection);
            var reader = command.ExecuteReader();
            var editSemester = new Semester();
            while (reader.Read())
            {
                var id = reader.GetValue(0);
                var name = reader.GetValue(1);
                var startDate = reader.GetValue(2);
                var endDate = reader.GetValue(3);
                editSemester = new Semester()
                {
                    Id = int.Parse(id.ToString()),
                    Name = name.ToString(),
                    StartDate = DateTime.Parse(startDate.ToString()).ToString("yyyy-MM-dd"),
                    EndDate = DateTime.Parse(endDate.ToString()).ToString("yyyy-MM-dd")
                };
            }
            this.Connection.Close();
            return editSemester;
        }

        public async Task<SemesterDisciplies> GetSemesterDisciplines(int id)
        {
            await this.Connection.OpenAsync();
            var command = new MySqlCommand($"SELECT * FROM disciplines INNER JOIN semesters ON semesters.id=disciplines.semester_id WHERE disciplines.semester_id={id};", this.Connection);
            var reader = await command.ExecuteReaderAsync();
            var model = new SemesterDisciplies();
            var disciplines = new List<Discipline>();
            
            while (await reader.ReadAsync())
            {
                var disId = reader.GetValue(0);
                var disName = reader.GetValue(1);
                var disProfessorName = reader.GetValue(2);
                var disScore = reader.GetValue(3);

                decimal parsedScore = 0.0m;
                decimal.TryParse(disScore.ToString(), out parsedScore);

                disciplines.Add(new Discipline()
                {
                    Id= int.Parse(disId.ToString()),
                    Name= disName.ToString(),
                    ProfessorName=disProfessorName.ToString(),
                    Score= parsedScore
                });
            }
            await this.Connection.CloseAsync();

            model.Semester = await this.GetSemesterById(id);
            model.Disciplines = disciplines;
            model.AvailableDisciplies = await this.GetAvailableDisciplines();

            return model;
        }

        public async void AddDiscipline(AddSemesterDiscipline model)
        {
            await this.Connection.OpenAsync();
            var com = new MySqlCommand("sp_AddDisToSemester", this.Connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@semesterId", model.SemId);
            com.Parameters.AddWithValue("@disId", model.DisId);
            com.ExecuteNonQuery();
            await this.Connection.CloseAsync();
        }

        public async void DeleteDiscipline(int disId)
        {
            await this.Connection.OpenAsync();
            var com = new MySqlCommand("sp_DeleteDisFromSemester", this.Connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@disId", disId);
            com.ExecuteNonQuery();
            await this.Connection.CloseAsync();
        }

        private async Task<Semester> GetSemesterById(int id)
        {
            await this.Connection.OpenAsync();
            var command = new MySqlCommand($"SELECT * FROM semesters WHERE id={id};", this.Connection);
            var reader = await command.ExecuteReaderAsync();
            var semester = new Semester();
            while (await reader.ReadAsync())
            {
                var name = reader.GetValue(1);
                var startDate = reader.GetValue(2);
                var endDate = reader.GetValue(3);
                semester = new Semester()
                {
                    Id = id,
                    Name = name.ToString(),
                    StartDate = DateTime.Parse(startDate.ToString()).ToString("yyyy-MM-dd"),
                    EndDate = DateTime.Parse(endDate.ToString()).ToString("yyyy-MM-dd")
                };
            }

            await this.Connection.CloseAsync();

            return semester;
        }

        private async Task<List<Discipline>> GetAvailableDisciplines()
        {
            var availableDisciplies = new List<Discipline>();

            await this.Connection.OpenAsync();
            var commandAvaiDis = new MySqlCommand("SELECT * FROM disciplines WHERE semester_id is null;", this.Connection);
            var reader1 = await commandAvaiDis.ExecuteReaderAsync();
            while (await reader1.ReadAsync())
            {
                var disId = reader1.GetValue(0);
                var disName = reader1.GetValue(1);
                var disProfessorName = reader1.GetValue(2);
                var disScore = reader1.GetValue(3);

                decimal parsedScore = 0.0m;
                decimal.TryParse(disScore.ToString(), out parsedScore);
                
                availableDisciplies.Add(new Discipline()
                {
                    Id = int.Parse(disId.ToString()),
                    Name = disName.ToString(),
                    ProfessorName = disProfessorName.ToString(),
                    Score = parsedScore
                });
            }

            await this.Connection.CloseAsync();

            return availableDisciplies;
        }
    }
}
