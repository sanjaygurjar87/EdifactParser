using Microsoft.VisualStudio.TestTools.UnitTesting;
using EdifactMessageParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edifact.Tests
{
    [TestClass()]
    public class EdifactTests
    {
        [TestMethod()]
        public void EdifactTest()
        {
            string[] args = new string[] { };
            Program.Main(args);
            Assert.IsFalse(false);
        }
    }
}