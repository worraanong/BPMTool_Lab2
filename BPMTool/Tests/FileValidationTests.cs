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

        [Theory]
        [InlineData(@"..\..\..\sample.xes", "")]
        [InlineData(@"..\..\..\sample.csv", "")]
        [InlineData(@"..\..\..\sample.txt", "ERROR: The input file does not in XES or CSV format")]
        public void Test2_ValidateFileExtension(string filePath, string expected)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            var actual = IsValidFileExtension(fileInfo)?.GetShortError() ?? string.Empty;

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(@"..\..\..\sample.xes", "")]
        [InlineData(@"..\..\..\brokensample.xes", "ERROR: Malformed XES file")]
        [InlineData(@"..\..\..\emptysample.xes", "ERROR: The input file does not contain any event log")]
        public void Test3_ValidateXESFile(string filePath, string expected)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            var actual = IsValidXESFile(fileInfo)?.GetShortError() ?? string.Empty;

            Assert.Equal(expected, actual);
        }
    }
}
