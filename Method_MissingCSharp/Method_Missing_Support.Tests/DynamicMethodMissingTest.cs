using System;
using MetaProgrammingCSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Dynamic;
using Microsoft.CSharp;
using MetaProgrammingCSharp.Tests.Entities;

namespace MetaProgrammingCSharp.Tests
{
    [TestClass]
    public class DynamicMethodMissingTest
    {
        [TestMethod]
        [ExpectedException(typeof(MissingMethodException))]
        public void Should_Throw_MissingMethodException_When_Method_Doesnt_Exists()
        {
            //Arrange
            dynamic dynamicObject = new MetaProgrammingCSharp.Dynamic();
            //Act
            dynamicObject.HelloWorld();

        }

        [TestMethod]
        [ExpectedException(typeof(MissingMethodException))]
        public void Should_Throw_MissingMethodException_When_MethodMissing_Not_Overrided()
        {
            //Arrange
            dynamic dynamicObject = new DynamicWithoutOverrideMethodMissing();
            //Act
            dynamicObject.NewTestMethod();

        }

        [TestMethod]
        public void Should_NOT_Throw_MissingMethodException_When_MethodMissing_Overrided()
        {
            //Arrange
            dynamic dynamicObject = new DynamicMethodMissingOverrided();
            //Act
            var result = dynamicObject.HelloMethod();

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("No HelloMethod declared in this class", result);
        }
    }
}
