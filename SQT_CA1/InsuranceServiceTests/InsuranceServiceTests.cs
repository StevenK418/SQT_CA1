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

        // ------------ Rural | Consolidated tests --------------
        /// <summary>
        /// Checks premium for rural users of multiple ages. 
        /// </summary>
        [TestCase(10, ExpectedResult = 0.0)]
        [TestCase(22, ExpectedResult = 5.0)]
        [TestCase(37, ExpectedResult = 2.50)]
        [TestCase(55, ExpectedResult = 0.375)]
        public double CheckMultipleAgesRural(int age)
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(age, "rural");

            //Assert
            return actualResult;
        }

        // ------------ Urban | Consolidated tests --------------
        /// <summary>
        /// Checks premium for urban users of multiple ages.
        /// </summary>
        [TestCase(10, ExpectedResult = 0.0)]
        [TestCase(22, ExpectedResult = 6.0)]
        [TestCase(37, ExpectedResult = 5.00)]
        [TestCase(55, ExpectedResult = 0.75)]
        public double CheckMultipleAgesUrban(int age)
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(age, "urban");

            //Assert
            return actualResult;
        }

        // ------------ Invalid location | Consolidated tests --------------
        /// <summary>
        /// Checks premium for ages within an invalid location.
        /// </summary>
        [TestCase(10, ExpectedResult = 0.0)]
        [TestCase(22, ExpectedResult = 0.0)]
        [TestCase(37, ExpectedResult = 0.0)]
        [TestCase(55, ExpectedResult = 0.0)]
        public double CheckMultipleAgesInvalidLocation(int age)
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(age, "London");

            //Assert
            return actualResult;
        }

        
    }
}
