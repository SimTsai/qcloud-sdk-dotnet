using NUnit.Framework;
using COSXML;
using System;
using System.Collections.Generic;
using System.Text;
using COSXMLTests;
using System.IO;

namespace COSXML.Tests
{
    [TestFixture()]
    public class CosXmlServerTests
    {
        [Test()]
        public void TestCreateFile()
        {
            string path = QCloudServer.CreateFile("test.txt", 1024 * 1024 * 2);

            FileInfo fileInfo = new FileInfo(path);

            DirectoryInfo directoryInfo = fileInfo.Directory;
            Console.WriteLine(path);
            Console.WriteLine(directoryInfo.FullName);
        }
    }
}
