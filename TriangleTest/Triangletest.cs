using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;



namespace TriangleTest
{
    public class TriangleTest
    {
        [TestFixture]
        
        public class TriangleTest1
        {
            [Test]

            public void EquilateralTriangle_Input70and70and70_OutputTriangle()
            {
                //Arrange
                int firstAngle = 70;
                int secondAngle = 70;
                int thirdAngle = 70;

                string expected = "An EQUILATERAL triangle is formed";
                
                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void IsoscelesTriangle_Input70and60and60_OutputTriangle()
            {
                //Arrange
                int firstAngle = 70;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "An ISOSCELES triangle is formed";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void IsoscelesTriangle_Input60and50and60_OutputTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 50;
                int thirdAngle = 60;

                string expected = "An ISOSCELES triangle is formed";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void IsoscelesTriangle_Input60and60and40_OutputTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 60;
                int thirdAngle = 40;

                string expected = "An ISOSCELES triangle is formed";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void ScaleneTriangle_Input80and70and30_OutputTriangle()
            {
                //Arrange
                int firstAngle = 80;
                int secondAngle = 70;
                int thirdAngle = 30;

                string expected = "A SCALENE triangle is formed";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }

            [Test]
            
            public void ScaleneTriangle_Input20and50and60_OutputTriangle()
            {
                //Arrange
                int firstAngle = 20;
                int secondAngle = 50;
                int thirdAngle = 60;

                string expected = "A SCALENE triangle is formed";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void ScaleneTriangle_Input40and70and50_OutputTriangle()
            {
                //Arrange
                int firstAngle = 40;
                int secondAngle = 70;
                int thirdAngle = 50;

                string expected = "A SCALENE triangle is formed";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }

            [Test]
            
            public void ScaleneTriangle_Input60and50and70_OutputTriangle()
            {
                //Arrange
                int firstAngle = 60;
                int secondAngle = 50;
                int thirdAngle = 70;

                string expected = "A SCALENE triangle is formed";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }

            [Test]
          
            public void ScaleneTriangle_Input70and30and80_OutputTriangle()
            {
                //Arrange
                int firstAngle = 70;
                int secondAngle = 30;
                int thirdAngle = 80;

                string expected = "A SCALENE triangle is formed";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }

            [Test]

           
            public void InValidTriangle_Input0and60and60_OutputTriangle()
            {
                //Arrange
                int firstAngle = 0;
                int secondAngle = 60;
                int thirdAngle = 60;

                string expected = "Invalid Triangle - at least one side is zero";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void InValidTriangle_Input0and0and0_OutputTriangle()
            {
                //Arrange
                int firstAngle = 0;
                int secondAngle = 0;
                int thirdAngle = 0;

                string expected = "Invalid Triangle - at least one side is zero";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void InValidTriangle_Input0and0and60_OutputTriangle()
            {
                //Arrange
                int firstAngle = 0;
                int secondAngle = 0;
                int thirdAngle = 60;

                string expected = "Invalid Triangle - at least one side is zero";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void INVALIDTriangle_Input10and20and60_OutputTriangle()
            {
                //Arrange
                int firstAngle = 10;
                int secondAngle = 20;
                int thirdAngle = 60;

                string expected = "INVALID Triangle detected!!";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void INVALIDTriangle_Input100and20and60_OutputTriangle()
            {
                //Arrange
                int firstAngle = 100;
                int secondAngle = 20;
                int thirdAngle = 60;

                string expected = "INVALID Triangle detected!!";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
            [Test]
            public void INVALIDTriangle_Input10and20and30_OutputTriangle()
            {
                //Arrange
                int firstAngle = 10;
                int secondAngle = 20;
                int thirdAngle = 30;

                string expected = "INVALID Triangle detected!!";

                //Act
                string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

                //Assert
                Assert.AreEqual(expected, actual);


            }
        }
    }

    
}
