﻿using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UTestUtil;

namespace Coc.Data.Xmi.UTest
{
    [TestClass]
    public class XmiToOATSTest
    {
        private XmiToOATS parser;

        [TestInitialize()]
        public void Initializer()
        {
            parser = new XmiToOATS();
        }


        [TestMethod()]
        public void GenerateScriptTest()
        {
            DirectoryInfo testOutputFolder;
            String xmiPath, name;

            testOutputFolder = new DirectoryInfo("TestOutput");
            name = "test";

            if (!testOutputFolder.Exists)
            {
                testOutputFolder.Create();
            }

            xmiPath = "..\\..\\..\\TestFiles\\ogmaj - oats - astah.xml";

            FileUtil.CleanFolder(testOutputFolder);

            parser.ParserMethod(xmiPath, ref name, null);

            #region Check parsed files
            Assert.IsTrue((testOutputFolder.GetFiles().Length > 0), "Nothing was parsed");
            Assert.IsTrue(testOutputFolder.GetFiles()[0].Length > 0, "Nothing was parsed. File size is zero");

            Assert.Fail("NOT WORKING - Generated script is empy!");
            #endregion
        }
    }
}