using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pronin.AppData;
using Pronin.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pronin.Pages.Tests
{
    [TestClass()]
    public class addSPRWindowTests
    {
        [TestMethod()]
        public void ChekSprTest()
        {
            spravochnaia c = new spravochnaia { tabel_nomer = 5, FIO = "Козлов" };
            bool exp = true;
            bool ac = addSPRWindow.ChekSpr(c);
            Assert.AreEqual(exp, ac);

        }

        [TestMethod()]
        public void ChekNullSprTest()
        {
            spravochnaia c = new spravochnaia { tabel_nomer = 5, FIO = " " };
            bool exp = false;
            bool ac = addSPRWindow.ChekSpr(c);
            Assert.AreEqual(exp, ac);
        }

        [TestMethod()]
        public void ChekDigSprTest()
        {
            spravochnaia c = new spravochnaia { tabel_nomer = 5, FIO = "Козлов1234" };
            bool exp = false;
            bool ac = addSPRWindow.ChekSpr(c);
            Assert.AreEqual(exp, ac);
        }
    }
}