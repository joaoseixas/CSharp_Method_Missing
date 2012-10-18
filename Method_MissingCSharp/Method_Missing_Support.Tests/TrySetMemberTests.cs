using System;
using MetaProgrammingCSharp.Tests.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetaProgrammingCSharp.Tests
{
    [TestClass]
    public class TrySetMemberTests
    {
        [TestMethod]
        public void Should_Set_Value_Dynamic_Member()
        {
            dynamic obj = new Dynamic();
            obj.TestDescription = "New Test";

            Assert.AreEqual("New Test", obj.TestDescription);
        }

        [TestMethod]
        public void Should_Set_Value_Static_Member()
        {
            dynamic obj = new DynamicPerson();
            obj.Name = "Joao Bosco";

            Assert.AreEqual("Joao Bosco", obj.Name);
        }

        [TestMethod]
        public void Should_Set_Value_Of_Existing_Dynamic_Member()
        {
            dynamic obj = new Dynamic();
            obj.TestDescription = "New Test";

            obj.TestDescription = "Same Test again";

            Assert.AreEqual("Same Test again", obj.TestDescription);
        }
    }
}
