using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatingGeometricShapes;
using ShiftShapes;

namespace CalculatingGeometricShapes.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnCircleSquereClass()
        {
            //Arrange
            var circle = new Circle();
            circle.Parameters = new double[] { 4 };

            //Act            
            var result = circle.SquereCalc(circle.Parameters);

            //Assert
            Assert.AreEqual(16 * Math.PI, result);

        }
        [TestMethod]
        public void ReturnTriangleSquereClass()
        {
            //Arrange
            var triangle = new Triangle();
            triangle.Parameters = new double[] { 14, 19, 18 };

            //Act
            var result = triangle.SquereCalc(triangle.Parameters);

            //Assert
            Assert.AreEqual(119.566, result);

        }
        [TestMethod]
        public void CheckIfTriangleRightTrueClass()
        {
            //Arrange
            var triangle = new Triangle();
            triangle.Parameters = new double[] { 5, 13, 12 };

            //Act
            var result = triangle.TriangleCheck(triangle.Parameters);

            //Assert
            Assert.IsTrue(result);
        }     
        
    }
}
    

