// MIT License
// 
// Copyright (c) 2022 Russell Camo
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.IO;
using System.Linq;
using System.Collections.Generic;
using Russkyc.AttachedUtilities.FileStreamExtensions.Interfaces;

namespace Russkyc.AttachedUtilities.FileStreamExtensions.Utilities
{
    
    public class UtilFileStreamExtension : IFileStreamUtility
    {
        
        private IFileStream _fileStream;

        public UtilFileStreamExtension(IFileStream fileStream)
        {
            _fileStream = fileStream;
        }

        public string StreamCreate(string path)
        {
            using StreamWriter writer = _fileStream.CreateWriteStream(path, FileMode.Create);
            writer.Write("");
            return path;
        }
        
        public string StreamWrite(string path, string content)
        {
            using StreamWriter writer = _fileStream.CreateWriteStream(path, FileMode.Create);
            writer.Write(content);
            return path;
        }

        public string StreamWriteBytes(string path, byte[] bytes)
        {
            using StreamWriter writer = _fileStream.CreateWriteStream(path, FileMode.Create);
            writer.BaseStream.Write(bytes, 0, bytes.Length);
            return path;
        }

        public string StreamAppend(string path, string content)
        {
            using StreamWriter writer = _fileStream.CreateWriteStream(path, FileMode.Append);
            writer.Write(content);
            return path;
        }
        
        public string StreamWriteLines(string path, string[] content)
        {
            using StreamWriter writer = _fileStream.CreateWriteStream(path, FileMode.Create);
            foreach (string line in content) writer.WriteLine(line);
            return path;
        }
        
        public string StreamWriteLines(string path, List<string> content)
        {
            using StreamWriter writer = _fileStream.CreateWriteStream(path, FileMode.Create);
            content.ForEach(writer.WriteLine);
            return path;
        }
        
        public string StreamAppendLines(string path, string[] content)
        {
            using StreamWriter writer = _fileStream.CreateWriteStream(path, FileMode.Append);
            foreach (string line in content) writer.WriteLine(line);
            return path;
        }
        
        public string StreamAppendLines(string path, List<string> content)
        {
            using StreamWriter writer = _fileStream.CreateWriteStream(path, FileMode.Append);
            content.ForEach(writer.WriteLine);
            return path;
        }
        
        public string StreamRead(string path)
        {
            using StreamReader reader = _fileStream.CreateReadStream(path, FileAccess.Read);
            return reader.ReadToEnd();
        }

        public byte[] StreamReadBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        public string[] StreamReadLines(string path)
        {
            using StreamReader reader = _fileStream.CreateReadStream(path, FileAccess.Read);
            List<string> lines = new List<string>();
            while (reader.ReadLine() is { } line) lines.Add(line);
            return lines.ToArray();
        }
        
        public List<string> StreamListLines(string path)
        {
            using StreamReader reader = _fileStream.CreateReadStream(path, FileAccess.Read);
            List<string> lines = new List<string>();
            while (reader.ReadLine() is { } line) lines.Add(line);
            return lines;
        }
        
        public string[] StreamReadSplit(string path, params char[] separator)
        {
            using StreamReader reader = _fileStream.CreateReadStream(path, FileAccess.Read);
            return separator.Equals(null) ? reader.ReadToEnd().Split() : reader.ReadToEnd().Split(separator);
        }
        
        public List<string> StreamListSplit(string path, params char[] separator)
        {
            using StreamReader reader = _fileStream.CreateReadStream(path, FileAccess.Read);
            return separator.Equals(null) ? reader.ReadToEnd().Split().ToList() : reader.ReadToEnd().Split(separator).ToList();
        }
    }
}