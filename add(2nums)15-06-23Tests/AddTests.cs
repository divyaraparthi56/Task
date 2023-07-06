using Microsoft.VisualStudio.TestTools.UnitTesting;
using add_2nums_15_06_23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_2nums_15_06_23.Tests
{
    [TestClass()]
    public class AddTests
    {
        Add ad = new Add();
        [TestMethod()]
        public void sumTest()
        {
            int a = 1234567890;
            int b = 9;
            int c = ad.sum(a, b);
            int e = 10;
            //Assert.AreEqual(c, a);
            Assert.ThrowsException<Exception>(() =>ad.sum(a, b));


            //Assert.Fail();
        }

        [TestMethod()]
        public void subTest()
        {
            int d = 10;
            int e = 9;
            int f = ad.sub(d, e);
            int h = 1;
            Assert.AreEqual(f, h);

            //Assert.Fail();
        }

        [TestMethod()]
        public void mulTest()
        {
            int d=3;
            int r=3;
            int s = ad.mul(d, r);
            int t = 9;
            Assert.AreEqual(s, t);

            //Assert.Fail();
        }
        [TestMethod()]
        public void divTest()
        {
            int d = 3;
            int r = 3;
            int s = ad.div(d, r);
            int t = 1;
            Assert.AreEqual(s, t);

            //Assert.Fail();
        }
    }
}

namespace add_2nums_15_06_23Tests
{
    internal class AddTests
    {
    }
}
