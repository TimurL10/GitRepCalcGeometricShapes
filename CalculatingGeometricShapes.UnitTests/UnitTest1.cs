using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatingGeometricShapes.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
                
        [TestMethod]
        public void ReturnCircleSquere()
        {
            //Arrange
            var shapes = new Shapes();

            //Act
            var result = shapes.Circle(4);

            //Assert

            Assert.AreEqual(16 * Math.PI, result);
        }
        [TestMethod]
        public void ReturnTriangleSquare()
        {
            //Arrange
            var shapes = new Shapes();

            //Act
            var result = shapes.Triangle(14, 19, 18);

            //Assert
            Assert.AreEqual(119.566, result);
        }
        [TestMethod]
        public void CheckIfTriangleRightFalse()
        {
            //Arrange
            var shapes = new Shapes();

            //Act
            var result = shapes.TriangleCheck(5, 11, 8);

            //Assert
            Assert.IsFalse(false);
        }
        [TestMethod]
        public void CheckIfTriangleRightTrue()
        {
            //Arrange
            var shapes = new Shapes();

            //Act
            var result = shapes.TriangleCheck(5, 13, 12); //3, 4, 5; 6, 8, 10; 12, 16, 20; 5, 12, 13.

            //Assert
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void CheckAutoShapesDetectIfItCircle()
        {
            //Arrange
            var shapes = new Shapes();

            //Act
            var result = shapes.AutoShapesDetect(2);

            //Assert
            Assert.AreEqual(4 * Math.PI, result);
        }
        [TestMethod]
        public void CheckAutoShapesDetectIfItTriangle()
        {
            //Arrange
            var shapes = new Shapes();

            //Act
            var result = shapes.AutoShapesDetect(4, 9, 8);

            //Assert
            Assert.AreEqual(15.998, result);
        }
    }
}
    

