using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment2;


namespace Assignment2.Tests
{
    [TestFixture]
    public class ConversionTest
    {
        [Test]
        public void Conversion_CelciusToFaharenheitTest()
        {
            //Arrange
            Conversion temp = new Conversion(45);
            //Act
            temp.CelsiusToFahrenheit();
            //Assert
            Assert.AreEqual(113, temp.CelsiusToFahrenheit());

        }

        [Test]
        public void Conversion_CelciusToFaharenheitTest1()
        {
            //Arrange
            Conversion temp1 = new Conversion(20);
            //Act
            temp1.CelsiusToFahrenheit();
            //Assert
            Assert.AreNotEqual(56, temp1.CelsiusToFahrenheit());
        }

        [Test]
        public void Conversion_CelciusToFaharenheitTest2()
        {

            //Arrange
            Conversion temp2 = new Conversion(20);
            //Act
            temp2.CelsiusToFahrenheit();
            //Assert
            Assert.AreNotSame(113.0d, temp2.CelsiusToFahrenheit());
        }



        [Test]
        public void Conversion_FahrenheitToCelsiusTest()
        {
            //Arrange
            Conversion temp = new Conversion(100);
            //Act
            temp.FahrenheitToCelsius();
            //Assert
            Assert.AreEqual(37.777777777777779d, temp.FahrenheitToCelsius());
        }

        [Test]
        public void Conversion_FahrenheitToCelsiusTest1()
        {

            //Arrange
            Conversion temp1 = new Conversion(10);
            //Act
            temp1.FahrenheitToCelsius();
            //Assert
            Assert.AreNotEqual(68, temp1.FahrenheitToCelsius());
        }

        [Test]
        public void Conversion_FahrenheitToCelsiusTest2()
        {

            //Arrange
            Conversion temp2 = new Conversion(23);
            //Act
            temp2.FahrenheitToCelsius();
            //Assert
            Assert.AreNotSame(113.0d, temp2.FahrenheitToCelsius());
        }

        [Test]
        public void Conversion_CelsiusToKelvinTest()
        {
            //Arrange
            Conversion temp = new Conversion(56);
            //Act
            temp.CelsiusToKelvin();
            //Assert
            Assert.AreEqual(329.14999999999998d, temp.CelsiusToKelvin());
        }
        [Test]
        public void Conversion_CelsiusToKelvinTest1()
        {

            //Arrange
            Conversion temp1 = new Conversion(70);
            //Act
            temp1.CelsiusToKelvin();
            //Assert
            Assert.AreNotEqual(24, temp1.CelsiusToKelvin());
        }

        [Test]
        public void Conversion_CelsiusToKelvinTest2()
        {

            //Arrange
            Conversion temp2 = new Conversion(63);
            //Act
            temp2.CelsiusToKelvin();
            //Assert
            Assert.AreNotSame(113, temp2.CelsiusToKelvin());
        }

        [Test]
        public void Conversion_KelvinToCelsiusTest()
        {
            //Arrange
            Conversion temp = new Conversion(10);
            //Act
            temp.KelvinToCelsius();
            //Assert
            Assert.AreEqual(10.0, temp.KelvinToCelsius());
        }
        [Test]
        public void Conversion_KelvinToCelsiusTest1()
        {

            //Arrange
            Conversion temp1 = new Conversion(90);
            //Act
            temp1.KelvinToCelsius();
            //Assert
            Assert.AreNotEqual(56, temp1.KelvinToCelsius());
        }
        [Test]
        public void Conversion_KelvinToCelsiusTest2()
        {

            //Arrange
            Conversion temp2 = new Conversion(56);
            //Act
            temp2.KelvinToCelsius();
            //Assert
            Assert.AreNotSame(178, temp2.KelvinToCelsius());
        }
        [Test]
        public void Conversion_FahrenheitToKelvinTest()
        {
            //Arrange
            Conversion temp = new Conversion(34);
            //Act
            temp.FahrenheitToKelvin();
            //Assert
            Assert.AreEqual(273.5, temp.FahrenheitToKelvin());
        }
        [Test]
        public void Conversion_FahrenheitToKelvinTest1()
        {
            //Arrange
            Conversion temp1 = new Conversion(67);
            //Act
            temp1.FahrenheitToKelvin();
            //Assert
            Assert.AreNotEqual(678, temp1.FahrenheitToKelvin());
        }
        [Test]
        public void Conversion_FahrenheitToKelvinTest2()
        {

            //Arrange
            Conversion temp2 = new Conversion(58);
            //Act
            temp2.FahrenheitToKelvin();
            //Assert
            Assert.AreNotSame(18, temp2.FahrenheitToKelvin());
        }
        [Test]
        public void Conversion_KelvinToFahrenheitTest()
        {
            //Arrange
            Conversion temp = new Conversion(67);
            //Act
            temp.KelvinToFahrenheit();
            //Assert
            Assert.AreEqual(67.0, temp.KelvinToFahrenheit());
        }
        [Test]
        public void Conversion_KelvinToFahrenheitTest1()
        {

            //Arrange
            Conversion temp1 = new Conversion(87);
            //Act
            temp1.KelvinToFahrenheit();
            //Assert
            Assert.AreNotEqual(78, temp1.KelvinToFahrenheit());
        }
        [Test]
        public void Conversion_KelvinToFahrenheitTest2()
        {
            //Arrange
            Conversion temp2 = new Conversion(76);
            //Act
            temp2.KelvinToFahrenheit();
            //Assert
            Assert.AreNotSame(46, temp2.KelvinToFahrenheit());
        }
    }
}

