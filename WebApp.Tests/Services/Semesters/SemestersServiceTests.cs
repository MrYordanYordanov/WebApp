using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.ViewModels;

namespace WebApp.Tests.Services.Semesters
{
    [TestClass]
    public class SemestersServiceTests
    {
        [TestMethod]
        public async Task InsertShouldReturnOneItem()
        {
            //Arrange

            var ser = new SemestersServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Semester()
            {
                Name = "Semester 1",
                StartDate=DateTime.UtcNow.ToString("yyyy-MM-dd"),
                EndDate = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            });

            var items = await ser.GetAllSemesters();
            var count = items.Count;
            //Assert

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public async Task InsertThreeItemsShouldReturnThreeItems()
        {
            //Arrange

            var ser = new SemestersServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Semester()
            {
                Name = "Semester 1",
                StartDate = DateTime.UtcNow.ToString("yyyy-MM-dd"),
                EndDate = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            });

            await ser.Create(new Semester()
            {
                Name = "Semester 2",
                StartDate = DateTime.UtcNow.AddDays(15).ToString("yyyy-MM-dd"),
                EndDate = DateTime.UtcNow.AddDays(30).ToString("yyyy-MM-dd"),
            });

            await ser.Create(new Semester()
            {
                Name = "Semester 3",
                StartDate = DateTime.UtcNow.AddDays(20).ToString("yyyy-MM-dd"),
                EndDate = DateTime.UtcNow.AddDays(25).ToString("yyyy-MM-dd"),
            });
            var items = await ser.GetAllSemesters();
            var count = items.Count;
            //Assert

            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public async Task GetLastAddedShouldReturnLastItem()
        {
            //Arrange

            var ser = new SemestersServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Semester()
            {
                Name = "Semester 1",
                StartDate = DateTime.UtcNow.ToString("yyyy-MM-dd"),
                EndDate = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            });

            await ser.Create(new Semester()
            {
                Name = "Semester 2",
                StartDate = DateTime.UtcNow.AddDays(15).ToString("yyyy-MM-dd"),
                EndDate = DateTime.UtcNow.AddDays(30).ToString("yyyy-MM-dd"),
            });

            var item = ser.GetLastAddedSemester();
            //Assert

            Assert.AreEqual("Semester 2", item.Name);
            Assert.AreEqual(DateTime.UtcNow.AddDays(15).ToString("yyyy-MM-dd"), item.StartDate);
            Assert.AreEqual(DateTime.UtcNow.AddDays(30).ToString("yyyy-MM-dd"), item.EndDate);
        }

        [TestMethod]
        public async Task EditShouldReturnExpectedItem()
        {
            //Arrange

            var ser = new SemestersServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Semester()
            {
                Name = "Semester 1",
                StartDate = DateTime.UtcNow.ToString("yyyy-MM-dd"),
                EndDate = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            });


            var item = ser.GetLastAddedSemester();

            var edititem = await ser.Edit(new Semester()
            {
                Id = item.Id,
                Name = "Semester 2",
                StartDate = DateTime.UtcNow.AddDays(15).ToString("yyyy-MM-dd"),
                EndDate = DateTime.UtcNow.AddDays(30).ToString("yyyy-MM-dd"),
            });

            //Assert

            Assert.AreEqual("Semester 2", edititem.Name);
            Assert.AreEqual(DateTime.UtcNow.AddDays(15).ToString("yyyy-MM-dd"), edititem.StartDate);
            Assert.AreEqual(DateTime.UtcNow.AddDays(30).ToString("yyyy-MM-dd"), edititem.EndDate);
        }
    }
}
