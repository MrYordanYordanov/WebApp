using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.ViewModels;

namespace WebApp.Services.Disciplines
{
    public class DisciplinesService : BaseEFService
    {
        public async Task<List<Discipline>> GetAllDisciplines()
        {
            await this.Connection.OpenAsync();
            var command = new MySqlCommand("SELECT * FROM disciplines;", this.Connection);
            var reader = await command.ExecuteReaderAsync();
            var disciplines = new List<Discipline>();
            while (await reader.ReadAsync())
            {
                var id = reader.GetValue(0);
                var name = reader.GetValue(1);
                var professorName = reader.GetValue(2);
                var score = reader.GetValue(3);

                decimal parsedScore = 0.0m;
                decimal.TryParse(score.ToString(), out parsedScore);

                var discipline = new Discipline()
                {
                    Id = int.Parse(id.ToString()),
                    Name = name.ToString(),
                    ProfessorName = professorName.ToString(),
                    Score = parsedScore,
                };
                disciplines.Add(discipline);
            }

            await this.Connection.CloseAsync();

            return disciplines;
        }

        public Discipline GetLastAddedDiscipline()
        {
            try
            {
                this.Connection.Open();

                var command = new MySqlCommand("SELECT * FROM disciplines ORDER BY id DESC LIMIT 1;", this.Connection);
                var reader = command.ExecuteReader();
                var discipline = new Discipline();
                while (reader.Read())
                {
                    var id = reader.GetValue(0);
                    var name = reader.GetValue(1);
                    var professorName = reader.GetValue(2);
                    var score = reader.GetValue(3);

                    decimal parsedScore = 0.0m;
                    decimal.TryParse(score.ToString(), out parsedScore);

                    discipline = new Discipline()
                    {
                        Id = int.Parse(id.ToString()),
                        Name = name.ToString(),
                        ProfessorName = professorName.ToString(),
                        Score = parsedScore,
                    };
                }
                return discipline;
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


        public async Task Create(Discipline discipline)
        {
            try
            {
                await this.Connection.OpenAsync();
                var com = new MySqlCommand("sp_AddDiscipline", this.Connection);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@name", discipline.Name);
                com.Parameters.AddWithValue("@professorName", discipline.ProfessorName);
                com.Parameters.AddWithValue("@score", discipline.Score);
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

        public async void Edit(Discipline discipline)
        {
            await this.Connection.OpenAsync();
            var com = new MySqlCommand("sp_EditDiscipline", this.Connection);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@disciplineId", discipline.Id);
            com.Parameters.AddWithValue("@name", discipline.Name);
            com.Parameters.AddWithValue("@professorName", discipline.ProfessorName);
            com.Parameters.AddWithValue("@score", discipline.Score);
            com.ExecuteNonQuery();
            this.Connection.Close();
        }
    }
}
