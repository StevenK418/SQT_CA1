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
        /// <summary>
        /// Checks premium for rural user with age 16 (Below range)
        /// </summary>
        [Test]
        public void CheckRuralAgeBelowRange()
        {
            //Arrange
            InsuranceServiceProvider serviceProvider = new InsuranceServiceProvider();

            //Act
            double actualResult = serviceProvider.CalcPremium(17, "rural");

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
            double actualResult = serviceProvider.CalcPremium(19, "rural");

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
            double actualResult = serviceProvider.CalcPremium(31, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(2.5));
        }

    }
}
