// MIT License
// 
// Copyright (c) 2022 Russell Camo
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Collections.Generic;

namespace Russkyc.AttachedUtilities.FileStreamExtensions.Interfaces
{
    public interface IFileStreamUtility
    {
        public string StreamCreate(string path);
        public string StreamWrite(string path, string content);
        public string StreamWriteBytes(string path, byte[] bytes);
        public string StreamAppend(string path, string content);
        public string StreamWriteLines(string path, string[] content);
        public string StreamWriteLines(string path, List<string> content);
        public string StreamAppendLines(string path, string[] content);
        public string StreamAppendLines(string path, List<string> content);
        public string StreamRead(string path);
        public byte[] StreamReadBytes(string path);
        public string[] StreamReadLines(string path);
        public List<string> StreamListLines(string path);
        public string[] StreamReadSplit(string path, params char[] separator);
        public List<string> StreamListSplit(string path, params char[] separator);
    }
}