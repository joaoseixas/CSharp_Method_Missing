using System;
using System.Collections.Generic;
using MetaProgrammingCSharp.Tests.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MetaProgrammingCSharp.Tests
{
    [TestClass]
    public class GetDynamicMemberNamesTests
    {
        [TestMethod]
        public void Should_Return_Empty_List_If_There_Is_No_Members()
        {
            dynamic propertyBag = new Dynamic();

            IEnumerable<string> memberList = propertyBag.GetDynamicMemberNames();
            //Wrap IEnumerable in a list to simplify Assert
            List<string> propertyList = new List<string>(memberList);
           
            Assert.IsNotNull(propertyList);
            Assert.AreEqual(0,propertyList.Count);
        }

        [TestMethod]
        public void Should_Return_List_With_Member_Name_If_There_Is_Dynamic_Member()
        {
            dynamic propertyBag = new Dynamic();
            propertyBag.Name = "Bosco";

            IEnumerable<string> memberList = propertyBag.GetDynamicMemberNames();
            //Wrap IEnumerable in a list to simplify Assert
            List<string> propertyList = new List<string>(memberList);

            Assert.IsNotNull(propertyList);
            //Check if property list contain "Name" at the first position
            Assert.AreEqual("Name", propertyList[0]);
            Assert.AreEqual(1, propertyList.Count);
        }

        
    }
}
