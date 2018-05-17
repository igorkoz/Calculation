using System;
using System.Collections;
using System.Collections.Generic;
using Calculations.Controllers;
using Calculations.Models;
using Microsoft.CodeAnalysis;
using Moq;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace Test
{
    public class MemoryRepositoryTests
    {
        [Fact]
        public void AddToRepository()
        {
            // Arrange
            var CalculationResult = new CalculationResult { num1 = 1, num2 = 5, OperationName = "Multiply", Result = "5" };
            var Repository = new MemoryRepository();
            var index = Repository.AddResult(CalculationResult);

            // Assert
            Assert.Equal(CalculationResult, Repository[index]);
        }
    }
}
