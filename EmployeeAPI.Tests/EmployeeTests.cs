using EmployeeAPI.Controllers;
using EmployeeAPI.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace EmployeeAPI.Tests
{
    [TestClass]
    public class EmployeeTests
    {
        /// <summary>
        /// The Employee controller.
        /// </summary>
        private EmployeesController employeeController;
        
        /// <summary>
        /// The mock context.
        /// </summary>
        private Mock<EmployeeContext> mockEmployeeContext;
      
        
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            this.employeeController = new EmployeesController(this.mockEmployeeContext.Object);          
        }
        

        [TestMethod]
        public void GetEmployeeBy_ShouldGetEmployeeData()
        {
            //Arrange
            var employee = new Employee { Id = 1, Name = "Rajesh", Role = "Admin", Department = "IT", IsActive = true };            
          
            //Act
            var result = employeeController.GetEmployee(1);

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
