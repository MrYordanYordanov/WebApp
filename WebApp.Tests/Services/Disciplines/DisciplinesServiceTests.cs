using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.ViewModels;
using WebApp.Tests.Mocks.Interfaces;

namespace WebApp.Tests.Services.Disciplines
{
    [TestClass]
    public class StudentsServiceTests
    {
        [TestMethod]
        public async Task InsertShouldReturnOneItem()
        {
            //Arrange
            
            var ser = new DisciplinesServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Discipline()
            {
                Name = "Php",
                ProfessorName = "Angelov",
                Score = 5.5m
            });
            
            var items= await ser.GetAllDisciplines();
            var count = items.Count;
            //Assert

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public async Task InsertThreeItemsShouldReturnThreeItems()
        {
            //Arrange

            var ser = new DisciplinesServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Discipline()
            {
                Name = "Php",
                ProfessorName = "Angelov",
                Score = 5.5m
            });

            await ser.Create(new Discipline()
            {
                Name = "Bast",
                ProfessorName = "Todorov",
                Score = 1.5m
            });

            await ser.Create(new Discipline()
            {
                Name = "Shp",
                ProfessorName = "Serov",
                Score = 3.5m
            });

            var items = await ser.GetAllDisciplines();
            var count = items.Count;
            //Assert

            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public async Task GetLastAddedShouldReturnLastItem()
        {
            //Arrange

            var ser = new DisciplinesServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Discipline()
            {
                Name = "Php",
                ProfessorName = "Angelov",
                Score = 5.5m
            });

            await ser.Create(new Discipline()
            {
                Name = "Shp",
                ProfessorName = "Serov",
                Score = 3.5m
            });
            
            var item = ser.GetLastAddedDiscipline();
            //Assert

            Assert.AreEqual("Shp", item.Name);
            Assert.AreEqual("Serov", item.ProfessorName);
            Assert.AreEqual(3.5m, item.Score);
        }

        [TestMethod]
        public async Task EditShouldReturnExpectedItem()
        {
            //Arrange

            var ser = new DisciplinesServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Discipline()
            {
                Name = "Php",
                ProfessorName = "Angelov",
                Score = 5.5m
            });

            var item = ser.GetLastAddedDiscipline();

            var edititem=await ser.Edit(new Discipline()
            {
                Id=item.Id,
                Name = "Shp",
                ProfessorName = "Serov",
                Score = 3.5m
            });
            
            //Assert

            Assert.AreEqual("Shp", edititem.Name);
            Assert.AreEqual("Serov", edititem.ProfessorName);
            Assert.AreEqual(3.5m, edititem.Score);
        }
    }
}
