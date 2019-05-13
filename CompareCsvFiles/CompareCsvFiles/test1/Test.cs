using NUnit.Framework;
using CompareCsvFiles;
namespace CompareCsvFileUnitTests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void ValidateInvalidPath_TestCase()
        {
            Assert.IsFalse(CompareCsv.isFileExist(@"c:\sample.csv"), "File path is not present and should throw the exception");
        }
        [Test()]
        public void ValidateValidPath_TestCase()
        {
            //note, please make sure to have this file present locally or give valid path of a file when running the test.
            Assert.IsTrue(CompareCsv.isFileExist(@"c:\test.csv"), "File path should present and should not throw any exception");
        }
    }
}
