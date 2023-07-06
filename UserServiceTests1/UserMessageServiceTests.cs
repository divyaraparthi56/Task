using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataService;

namespace UserService.Tests
{
    [TestClass()]
    public class UserMessageServiceTests
    {
        [TestMethod()]
        public void GetMessageFromDbTest()
        {
            string a = "I am from main data";
            DatabaseConnector db = new DatabaseConnector();
            var res=db.GetMsgFromMsgTbl();
            Assert.AreEqual(a,res);
            //Assert.Fail();
        }
    }
}