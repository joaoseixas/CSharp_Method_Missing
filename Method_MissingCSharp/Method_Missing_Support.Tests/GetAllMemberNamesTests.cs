using System;
using System.Collections.Generic;
using MetaProgrammingCSharp.Tests.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetaProgrammingCSharp.Tests
{
    [TestClass]
    public class GetAllMemberNamesTests
    {
        [TestMethod]
        public void Should_Return_Empty_List()
        {
            //DynamicPerson object has a static Name Property
            dynamic propertyBag = new Dynamic();
            
            IEnumerable<string> memberList = propertyBag.GetAllMemberNames();
            //Wrap IEnumerable in a list to simplify Assert
            List<string> propertyList = new List<string>(memberList);

            Assert.IsNotNull(propertyList);
            Assert.AreEqual(0, propertyList.Count);
        }

        [TestMethod]
        public void Should_Return_List_With_Member_If_There_Is_Static_Member()
        {
            //DynamicPerson object has a static Name Property
            dynamic propertyBag = new DynamicPerson();

            IEnumerable<string> memberList = propertyBag.GetAllMemberNames();
            //Wrap IEnumerable in a list to simplify Assert
            List<string> propertyList = new List<string>(memberList);

            Assert.IsNotNull(propertyList);
            //Check if property list contain "Name" at the first position
            Assert.AreEqual("Name", propertyList[0]);
            Assert.AreEqual(1, propertyList.Count);
        }

        [TestMethod]
        public void Should_Return_List_With_Member_If_There_Is_Dynamic_Member()
        {
            //DynamicPerson object has a static Name Property
            dynamic propertyBag = new Dynamic();
            propertyBag.Age = 27;

            IEnumerable<string> memberList = propertyBag.GetAllMemberNames();
            //Wrap IEnumerable in a list to simplify Assert
            List<string> propertyList = new List<string>(memberList);

            Assert.IsNotNull(propertyList);
            Assert.AreEqual("Age", propertyList[0]);
            Assert.AreEqual(1, propertyList.Count);
        }

        [TestMethod]
        public void Should_Return_List_With_Members_If_There_Is_Dynamic_And_Static_Members()
        {
            //DynamicPerson object has a static Name Property
            dynamic propertyBag = new DynamicPerson();
            propertyBag.Age = 27;

            IEnumerable<string> memberList = propertyBag.GetAllMemberNames();
            //Wrap IEnumerable in a list to simplify Assert
            List<string> propertyList = new List<string>(memberList);

            Assert.IsNotNull(propertyList);
            Assert.AreEqual(2, propertyList.Count);
        }
    }
}
