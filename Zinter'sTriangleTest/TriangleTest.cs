using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zinter_s_Triangle;

namespace Zinter_sTriangleTest
{
    [TestClass]
    public class UnitTestTriangle
    {
        // not Tiangle 3 Tests
        [TestMethod]
        public void NotTriangleT1()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(1);
            triangle.setBtest(2);
            triangle.setCtest(3);

            int expected = 0;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NotTriangleT2()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(2);
            triangle.setBtest(0);
            triangle.setCtest(2);

            int expected = 0;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NotTriangleT3()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(3);
            triangle.setBtest(500000000);
            triangle.setCtest(3);

            int expected = 0;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        // EquilateralTriangle 3 Tests
        [TestMethod]
        public void EquilateralTriangleT1()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(1);
            triangle.setBtest(1);
            triangle.setCtest(1);

            int expected = 1;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EquilateralTriangleT2()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(500000000);
            triangle.setBtest(500000000);
            triangle.setCtest(500000000);

            int expected = 1;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EquilateralTriangleT3()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(1000000000);
            triangle.setBtest(1000000000);
            triangle.setCtest(1000000000);

            int expected = 1;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        // IsoscelesTriangle 9 Tests
        [TestMethod]
        public void IsoscelesTriangleT1()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(2);
            triangle.setBtest(2);
            triangle.setCtest(1);

            int expected = 2;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsoscelesTriangleT2()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(500000000);
            triangle.setBtest(500000000);
            triangle.setCtest(150000005);

            int expected = 2;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsoscelesTriangleT3()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(1000000000);
            triangle.setBtest(1000000000);
            triangle.setCtest(999999999);

            int expected = 2;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsoscelesTriangleT4()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(1);
            triangle.setBtest(2);
            triangle.setCtest(2);

            int expected = 2;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsoscelesTriangleT5()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(500000005);
            triangle.setBtest(1000000000);
            triangle.setCtest(1000000000);

            int expected = 2;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsoscelesTriangleT6()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(999999999);
            triangle.setBtest(1000000000);
            triangle.setCtest(1000000000);

            int expected = 2;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsoscelesTriangleT7()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(2);
            triangle.setBtest(1);
            triangle.setCtest(2);

            int expected = 2;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsoscelesTriangleT8()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(500000000);
            triangle.setBtest(500000005);
            triangle.setCtest(500000000);

            int expected = 2;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsoscelesTriangleT9()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(1000000000);
            triangle.setBtest(999999999);
            triangle.setCtest(1000000000);

            int expected = 2;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        // VersatileTriangle
        [TestMethod]
        public void VersatileTriangleT1()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(2);
            triangle.setBtest(3);
            triangle.setCtest(4);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT2()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(500000000);
            triangle.setBtest(499999999);
            triangle.setCtest(499999998);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT3()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(1000000000);
            triangle.setBtest(999999999);
            triangle.setCtest(999999998);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT4()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(2);
            triangle.setBtest(4);
            triangle.setCtest(3);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT5()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(500000000);
            triangle.setBtest(499999998);
            triangle.setCtest(499999999);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT6()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(1000000000);
            triangle.setBtest(999999998);
            triangle.setCtest(999999999);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT7()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(4);
            triangle.setBtest(3);
            triangle.setCtest(2);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT8()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(499999998);
            triangle.setBtest(499999999);
            triangle.setCtest(500000000);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT9()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(999999998);
            triangle.setBtest(999999999);
            triangle.setCtest(1000000000);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT10()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(3);
            triangle.setBtest(2);
            triangle.setCtest(4);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT11()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(499999999);
            triangle.setBtest(500000000);
            triangle.setCtest(499999998);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT12()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(999999999);
            triangle.setBtest(1000000000);
            triangle.setCtest(999999998);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT13()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(4);
            triangle.setBtest(2);
            triangle.setCtest(3);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT14()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(499999998);
            triangle.setBtest(500000000);
            triangle.setCtest(499999999);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT15()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(999999998);
            triangle.setBtest(1000000000);
            triangle.setCtest(999999999);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT16()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(3);
            triangle.setBtest(4);
            triangle.setCtest(2);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void VersatileTriangleT17()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(499999999);
            triangle.setBtest(499999998);
            triangle.setCtest(500000000);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
        public void VersatileTriangleT18()
        {
            // arrange
            Triangle triangle = new Triangle();

            triangle.setAtest(999999999);
            triangle.setBtest(999999998);
            triangle.setCtest(1000000000);

            int expected = 3;

            // act
            int actual = triangle.whatIsTheTriangle(triangle.getA(), triangle.getB(), triangle.getC());

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
