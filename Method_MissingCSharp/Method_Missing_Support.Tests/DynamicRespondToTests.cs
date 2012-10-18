using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MetaProgrammingCSharp;
using MetaProgrammingCSharp.Tests.Entities;
using System.Linq.Expressions;
using System.Dynamic;

namespace MetaProgrammingCSharp.Tests
{
    [TestClass]
    public class DynamicRespondToTests
    {
        [TestMethod]
        public void Should_Respond_False_If_There_Is_No_Member_Defined()
        {
            dynamic testObject = new Dynamic();

            Assert.IsFalse(testObject.RespondTo("Name"));
        }

        [TestMethod]
        public void Should_Respond_True_If_Member_Exists_And_Is_Static_Member()
        {
            dynamic testObject = new DynamicPerson();

            Assert.IsTrue(testObject.RespondTo("Name"));
        }

        [TestMethod]
        public void Should_Respond_True_If_Member_Exists_And_Is_Dynamic()
        {
            dynamic testObject = new Dynamic();
            
            testObject.Name = "Joao";

            Assert.IsTrue(testObject.RespondTo("Name"));
        }

        
    }
}
