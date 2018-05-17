using Calculations.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Test
{
    public class OperationTests
    {
        [Fact]
        public void CanAdd() =>
            //Assert
            Assert.Equal("5", Operation.ExecuteOperation("Add", 2, 3));

        [Fact]
        public void CanMultiply() =>
            //Assert
            Assert.Equal("6", Operation.ExecuteOperation("Multiply", 2, 3));

        [Fact]
        public void CanCompare() =>
            //Assert
            Assert.Equal("0", Operation.ExecuteOperation("Compare", 3, 3));

        [Fact]
        public void CanExp() =>
            //Assert
            Assert.Equal("27", Operation.ExecuteOperation("Exp", 3, 3));

    }
}
