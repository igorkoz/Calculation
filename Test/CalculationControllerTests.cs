using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Calculations.Controllers;
using Calculations.Models;
using Moq;
using Xunit;

namespace Test
{
    public class CalculationControllerTests
    {
        [Fact]
        public void CalculationGet()
        {
            // Arrange
            var results = new List<CalculationResult> { 
                { new CalculationResult { OperationName = "Add",      Result = "1",   num1 = 0, num2 = 1 }},
                { new CalculationResult { OperationName = "Multiply", Result = "2", num1 = 1, num2 = 2 }},
                { new CalculationResult { OperationName = "Compare", Result = "0", num1 = 1, num2 = 1 }}
            };
            var mock = new Mock<IRepository>();
            mock.SetupGet(m => m.Results).Returns(results);
            var controller = new CalculationController(mock.Object);

            // Act
            var model = controller.Get();

            // Assert
            Assert.Equal(results, model);
        }
    }
}
