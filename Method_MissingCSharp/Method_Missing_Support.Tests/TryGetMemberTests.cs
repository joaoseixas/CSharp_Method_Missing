using System;
using MetaProgrammingCSharp.Tests.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetaProgrammingCSharp.Tests
{
    [TestClass]
    public class TryGetMemberTests
    {
        [TestMethod]
        public void Should_Find_Dynamic_Member()
        {
            dynamic obj = new Dynamic();
            obj.Functionality = "Test";

            Assert.IsNotNull(obj.Functionality);
        }

        [TestMethod]
        public void Should_Match_Dynamic_Member_Value()
        {
            dynamic obj = new Dynamic();
            obj.Functionality = "Test";

            Assert.AreEqual("Test",obj.Functionality);
        }
        
        [TestMethod]
        [ExpectedException(typeof(MissingMemberException))]
        public void Should_Get_Dynamic_Member_Value()
        {
            dynamic obj = new Dynamic();
            var func = obj.Functionality;
        }

        [TestMethod]
        public void Should_Find_Static_Member()
        {
            dynamic person = new DynamicPerson();

            Assert.IsNotNull(person.Name);
        }

        [TestMethod]
        public void Should_Match_Static_Member_Value()
        {
            dynamic person = new DynamicPerson();
            person.Name = "My New Name";

            Assert.AreEqual("My New Name", person.Name);
        }
    }
}
