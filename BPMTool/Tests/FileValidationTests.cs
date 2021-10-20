using static BPMTool.Program;
using System.IO;
using Xunit;

namespace Tests
{
    public class FileValidationTests
    {
        [Fact]
        public void Test1_ValidateFileExists()
        {
            FileInfo fileInfo1 = new FileInfo(@"..\..\..\sample.xes");

            var actual1 = IsFileExists(fileInfo1);

            Assert.Equal("", actual1);

            FileInfo fileInfo2 = new FileInfo(@"wrongpath.xes");

            var actual2 = IsFileExists(fileInfo2);

            Assert.Equal("ERROR: File not found", actual2);
        }
    }
}
