using static BPMTool.Program;
using System.IO;
using Xunit;

namespace Tests
{
    public class FileValidationTests
    {
        [Theory]
        [InlineData(@"..\..\..\sample.xes", "")]
        [InlineData(@"wrongpath.xes", "ERROR: File not found")]
        public void Test1_ValidateFileExists(string filePath, string expected)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            var actual = IsFileExists(fileInfo)?.GetShortError() ?? string.Empty;

            Assert.Equal(expected, actual);
        }
    }
}
