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
using Russkyc.AttachedUtilities.FileStreamExtensions.Interfaces;
using Russkyc.AttachedUtilities.FileStreamExtensions.Utilities;

namespace Russkyc.AttachedUtilities.FileStreamExtensions
{
    /// <summary>
    /// Handles FileStreamExtension Extension Methods.
    /// </summary>
    public static class FileStreamExtensions
    {
        private static IFileStreamUtility _fileStreamUtility { get => new UtilFileStreamExtension(new UtilFileStream()); }
        public static string StreamCreate(this string path) => _fileStreamUtility.StreamCreate(path);
        public static string StreamWrite(this string path, string content) => _fileStreamUtility.StreamWrite(path,content);
        public static string StreamWriteBytes(this string path, byte[] content) => _fileStreamUtility.StreamWriteBytes(path,content);
        public static string StreamAppend(this string path, string content) => _fileStreamUtility.StreamAppend(path, content);
        public static string StreamWriteLines(this string path, string[] content) => _fileStreamUtility.StreamWriteLines(path, content);
        public static string StreamWriteLines(this string path, List<string> content) => _fileStreamUtility.StreamWriteLines(path, content);
        public static string StreamAppendLines(this string path, string[] content) => _fileStreamUtility.StreamAppendLines(path, content);
        public static string StreamAppendLines(this string path, List<string> content) => _fileStreamUtility.StreamAppendLines(path, content);
        public static string StreamRead(this string path) => _fileStreamUtility.StreamRead(path);
        public static byte[] StreamReadBytes(this string path) => _fileStreamUtility.StreamReadBytes(path);
        public static string[] StreamReadLines(this string path) => _fileStreamUtility.StreamReadLines(path);
        public static List<string> StreamListLines(this string path) => _fileStreamUtility.StreamListLines(path);
        public static string[] StreamReadSplit(this string path, params char[] separator) => _fileStreamUtility.StreamReadSplit(path, separator);
        public static List<string> StreamListSplit(this string path, params char[] separator) => _fileStreamUtility.StreamListSplit(path, separator);
    }
}