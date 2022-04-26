using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InsuranceService;


namespace InsuranceServiceTests
{
    [TestFixture]
    public class InsuranceServiceTests
    {
        // ------------ Rural | Individual tests --------------
        /// <summary>
        /// Checks premium for rural user with age 16 (Below range)
        /// </summary>
        [Test]
        public void CheckRuralAgeBelowRange()
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(10, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0.0));
        }

        /// <summary>
        /// Checks premium for rural user with age 19 (Within Range)
        /// </summary>
        [Test]
        public void CheckRuralAgeWithinFirstRange()
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(22, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(5.0));
        }

        /// <summary>
        /// Checks premium for rural user with age 31 (Above Range)
        /// </summary>
        [Test]
        public void CheckRuralAgeAboveFirstRange()
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(37, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(2.5));
        }

        /// <summary>
        /// Checks premium for rural user with age 55 (Max out of range)
        /// </summary>
        [Test]
        public void CheckRuralAgeAboveFifty()
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(55, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0.375));
        }

        // ------------ Urban | Individual tests --------------
        /// <summary>
        /// Checks premium for rural user with age 10 (Below range)
        /// </summary>
        [Test]
        public void CheckUrbanAgeBelowRange()
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(10, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0.0));
        }

        /// <summary>
        /// Checks premium for rural user with age 22 (Within Range)
        /// </summary>
        [Test]
        public void CheckUrbanAgeWithinRange()
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(22, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(6.0));
        }

        /// <summary>
        /// Checks premium for urban user with age 37 (Above Range)
        /// </summary>
        [Test]
        public void CheckUrbanAgeAboveFirstRange()
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(37, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(5.0));
        }

        /// <summary>
        /// Checks premium for urban user with age 55 (Max out of range)
        /// </summary>
        [Test]
        public void CheckUrbanAgeAboveFifty()
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(55, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0.75));
        }

        // ------------ Equivalence partitions | Consolidated tests --------------
        /// <summary>
        /// Checks premium for several given ages within each individual location.
        /// </summary>
        /// <summary>
        /// Checks premium for all users of multiple ages.
        /// </summary>
        [TestCase(-7, "rural", ExpectedResult = 0.0)]
        [TestCase(10, "rural", ExpectedResult = 0.0)]
        [TestCase(22, "rural", ExpectedResult = 5.0)]
        [TestCase(37, "rural", ExpectedResult = 2.50)]
        [TestCase(55, "rural", ExpectedResult = 0.375)]
        [TestCase(-7, "urban", ExpectedResult = 0.0)]
        [TestCase(10, "urban", ExpectedResult = 0.0)]
        [TestCase(22, "urban", ExpectedResult = 6.0)]
        [TestCase(37, "urban", ExpectedResult = 5.00)]
        [TestCase(55, "urban", ExpectedResult = 0.75)]
        [TestCase(-7, "london", ExpectedResult = 0.0)]
        [TestCase(10, "london", ExpectedResult = 0.0)]
        [TestCase(22, "london", ExpectedResult = 0.0)]
        [TestCase(37, "london", ExpectedResult = 0.0)]
        [TestCase(55, "london", ExpectedResult = 0.0)]
        public double CheckMultipleAgesAndLocations(int age, string location)
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(age, location);

            //Assert
            return actualResult;
        }


        // ------------  Boundary Values Consolidated tests --------------
        /// <summary>
        /// Checks premium for ages within Boundary values for each location.
        /// </summary>
        /// [TestCase(17, ExpectedResult = 0.0)]
        [TestCase(18,"rural", ExpectedResult = 5.0)]
        [TestCase(30,"rural", ExpectedResult = 5.0)]
        [TestCase(31,"rural", ExpectedResult = 2.5)]
        [TestCase(49,"rural", ExpectedResult = 2.5)]
        [TestCase(50,"rural", ExpectedResult = 0.375)]
        [TestCase( 17,"urban", ExpectedResult = 0.0)]
        [TestCase(18, "urban", ExpectedResult = 6.0)]
        [TestCase(30, "urban", ExpectedResult = 6.0)]
        [TestCase(36, "urban", ExpectedResult = 5.0)]
        [TestCase(49, "urban", ExpectedResult = 5.0)]
        [TestCase(50, "urban", ExpectedResult = 0.75)]
        public double CheckBoundaryValues(int age, string location)
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(age, location);

            //Assert
            return actualResult;
        }


    }
}
