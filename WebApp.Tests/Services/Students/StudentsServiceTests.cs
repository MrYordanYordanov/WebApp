using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WebApp.Models.ViewModels;
using WebApp.Tests.Mocks.Interfaces;

namespace WebApp.Tests.Services.Students
{
    [TestClass]
    public class StudentsServiceTests
    {
        [TestMethod]
        public async Task InsertShouldReturnOneItem()
        {
            //Arrange
            
            var ser = new StudentsServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Student()
            {
                Name = "Test",
                Surname = "Testov",
                Dob = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            });
            
            var items= await ser.GetAllStudents();
            var count = items.Count;
            //Assert

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public async Task InsertThreeItemsShouldReturnThreeItems()
        {
            //Arrange

            var ser = new StudentsServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Student()
            {
                Name = "Best",
                Surname = "Bestov",
                Dob = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            });

            await ser.Create(new Student()
            {
                Name = "Vest",
                Surname = "Vestov",
                Dob = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            });

            await ser.Create(new Student()
            {
                Name = "Test",
                Surname = "Testov",
                Dob = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            });

            var items = await ser.GetAllStudents();
            var count = items.Count;
            //Assert

            Assert.AreEqual(3, count);
        }

        [TestMethod]
        public async Task GetLastAddedShouldReturnLastItem()
        {
            //Arrange

            var ser = new StudentsServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Student()
            {
                Name = "Test",
                Surname = "Testov",
                Dob = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            });

            await ser.Create(new Student()
            {
                Name = "Vest",
                Surname = "Vestov",
                Dob = DateTime.UtcNow.AddDays(12).ToString("yyyy-MM-dd"),
            });

            var item = ser.GetLastAddedStudent();
            //Assert

            Assert.AreEqual("Vest", item.Name);
            Assert.AreEqual("Vestov", item.Surname);
            Assert.AreEqual(DateTime.UtcNow.AddDays(12).ToString("yyyy-MM-dd"), item.Dob);
        }

        [TestMethod]
        public async Task EditShouldReturnExpectedItem()
        {
            //Arrange

            var ser = new StudentsServiceTest();

            //Act
            ser.Clear();
            await ser.Create(new Student()
            {
                Name = "Vest",
                Surname = "Vestov",
                Dob = DateTime.UtcNow.ToString("yyyy-MM-dd"),
            });

            var item = ser.GetLastAddedStudent();

             var edititem=await ser.Edit(new Student()
            {
                Id=item.Id,
                Name = "Test",
                Surname = "Testov",
                Dob = DateTime.UtcNow.AddDays(30).ToString("yyyy-MM-dd"),
            });
            
            
            //Assert

            Assert.AreEqual("Test", edititem.Name);
            Assert.AreEqual("Testov", edititem.Surname);
            Assert.AreEqual(DateTime.UtcNow.AddDays(30).ToString("yyyy-MM-dd"), edititem.Dob);
        }
    }
}
