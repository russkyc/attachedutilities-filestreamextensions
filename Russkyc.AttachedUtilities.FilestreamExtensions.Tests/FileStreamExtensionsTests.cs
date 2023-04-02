
namespace Russkyc.AttachedUtilities.FilestreamExtensions.Tests;

public class FileStreamExtensionsTests
{
    // Test Create File
        [Theory]
        [InlineData(@"NewFile.txt")]
        [InlineData(@"TestFile2.rus")]
        [InlineData(@"TestFile2")]
        public void TestCreateFile(string filePath)
        {
            filePath.StreamCreate();
            Assert.True(File.Exists(filePath));
        }

        // Test Write and Read File
        [Theory]
        [InlineData(@"NewFile.txt","Content 1")]
        [InlineData(@"TestFile2.rus", "Content 2")]
        [InlineData(@"TestFile2", "Content 3")]
        public void TestWriteAndReadTextToFile(String filePath, string content)
        {
            filePath.StreamWrite(content);
            Assert.Equal(content,filePath.StreamRead());
        }

        // Test Write and Read Bytes
        [Theory]
        [InlineData(@"NewFile.txt")]
        [InlineData(@"TestFile2.rus")]
        [InlineData(@"TestFile2")]
        public void TestWriteAndReadBytesToFile(string filePath)
        {
            byte[] content = Encoding.ASCII.GetBytes("Content 1");
            filePath.StreamWriteBytes(content);
            Assert.Equal(content,filePath.StreamReadBytes());
            
        }
        
        // Test Append and Read File
        [Theory]
        [InlineData(@"NewFile.txt","Content 1","New Content")]
        [InlineData(@"TestFile2.rus", "Content 2","New Content")]
        [InlineData(@"TestFile2", "Content 3","New Content")]
        public void TestAppendAndReadTextToFile(String filePath, string content, string appendedContent)
        {
            filePath.StreamWrite(content);
            filePath.StreamAppend(appendedContent);
            Assert.Equal(content+appendedContent,filePath.StreamRead());
        }
        
        // Test Write Lines to File and Read Lines
        [Theory]
        [InlineData(@"NewFile.txt",new []{"a","b"},2)]
        [InlineData(@"TestFile2.rus", new []{"a","b","c"},3)]
        [InlineData(@"TestFile2", new []{"a","b","c","d"},4)]
        public void TestWriteToFileAndReadLinesAsStringArray(String filePath, string[] content, int count)
        {
            filePath.StreamWriteLines(content);
            Assert.Equal(count,filePath.StreamReadLines().Length);
        }
        
        // Test Append Lines to File and Read Lines
        [Theory]
        [InlineData(@"NewFile.txt", new []{"a"}, new []{"a"},2)]
        [InlineData(@"TestFile2.rus", new []{"a","b"}, new []{"a"},3)]
        [InlineData(@"TestFile2", new []{"a","b"},new []{"a","a"},4)]
        public void TestAppendLinesToFileAndReadLines(String filePath, string[] content, string[] appendedContent, int count)
        {
            filePath.StreamWriteLines(content);
            filePath.StreamAppendLines(appendedContent);
            Assert.Equal(count,filePath.StreamReadLines().Length);
        }
        
        // Test Write Lines to File and Read Lines
        [Theory]
        [InlineData(@"NewFile.txt", new []{"a","b"},2)]
        [InlineData(@"TestFile2.rus", new []{"a","b","c"},3)]
        [InlineData(@"TestFile2", new []{"a","b","c","d"},4)]
        public void TestWriteToFileAndReadLinesAsListOfString(String filePath, string[] content, int count)
        {
            filePath.StreamWriteLines(content);
            Assert.Equal(count,filePath.StreamListLines().Count);
        }
        
        // Test Write Lines to File, Read and Split Content to Array
        [Theory]
        [InlineData(@"NewFile.txt","a b c",3)]
        [InlineData(@"TestFile2.rus", "a,b,c,d",4,',')]
        [InlineData(@"TestFile2", "a?b,c:d!e",5,':',',','?','!')]
        public void TestWriteToFileAndReadSplitsAsStringArray(String filePath, string content, int count, params char[] separator)
        {
            filePath.StreamWrite(content);
            Assert.Equal(count,filePath.StreamReadSplit(separator).Length);
        }
        
        // Test Write Lines to File, Read and Split Content to List
        [Theory]
        [InlineData(@"NewFile.txt","a b c",3)]
        [InlineData(@"TestFile2.rus", "a,b,c,d",4,',')]
        [InlineData(@"TestFile2", "a?b,c:d!e",5,':',',','?','!')]
        public void TestWriteToFileAndReadSplitsAsListOfString(String filePath, string content, int count, params char[] separator)
        {
            filePath.StreamWrite(content);
            Assert.Equal(count,filePath.StreamListSplit(separator).Count);
        }
}