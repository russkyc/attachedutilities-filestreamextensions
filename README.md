<h2 align="center">AttachedUtilities.FileStreamExtensions</h2>

<p align="center">
    <a href="https://www.nuget.org/packages/Russkyc.AttachedUtilities.FilestreamExtensions">
        <img src="https://img.shields.io/nuget/v/Russkyc.AttachedUtilities.FilestreamExtensions?color=1f72de" alt="Nuget">
    </a>
    <a href="#">
        <img src="https://img.shields.io/badge/-.NET%20Standard%202.0-blueviolet?color=1f72de&label=NET" alt="">
    </a>
</p>

<p align="center">
<a href="https://www.nuget.org/packages/Russkyc.AttachedUtilities.FilestreamExtensions">Russkyc.AttachedUtilities.FileStreamExtensions</a> is a collection of filestream attached method utilities for .NET Standard, .NET Core, and .NET Framework.
</p>

### Setup
```csharp
//Dependency Import
using Russkyc.AttachedUtilities.FileStreamExtensions;
```

### Filestream Utilities

**StreamRead** - FileStream Reader.
- _`.StreamRead()`_ - Returns `string` of file content.
- _`.StreamReadBytes()`_ - Returns file as `byte[]` array.
- _`.StreamReadLines()`_ - Returns `string[]` of file content lines.
- _`.StreamListLines()`_ - Returns `List<string>` of file content lines.
- _`.StreamReadSplit()`_ - Returns `string[]` of file contents split by separator.
- _`.StreamListSplit()`_ - Returns `List<string>` array of file contents split by separator.

**StreamWrite** - FileStream Writer.
- _`.StreamCreate()`_ - Creates empty file.
- _`.StreamWrite()`_ - Writes text to file. Returns file path.
- _`.StreamWriteBytes()`_ - Writes bytes to file. Returns file path.
- _`.StreamWriteLines()`_ - Writes text lines to file. Returns file path.
- _`.StreamAppend()`_ - Appends text to file. Returns file path.
- _`.StreamAppendLines()`_ - Appends text lines to file. Returns file path.

**StreamRead Usage:**

```csharp
//File path
string path = @"C:\Testfile.txt";

//Reads file to byte array
byte[] file = path.StreamReadBytes();

//Reads file content
string content = path.StreamRead();

//Reads file content lines to array
string[] lines = path.StreamReadLines();

//Reads delimited file content to array
string[] words = path.StreamReadSplit();

//Reads delimited file content to array
string[] delimited = path.StreamReadSplit(',');
```

**StreamWrite Usage:**

```csharp
//File path
string path = @"C:\Testfile.txt";

//Writes bytes to file
byte[] bytes = {};
path.StreamReadBytes(bytes);

//Creates file
path.StreamCreate();

//Writes text to file
string text = "Hello C#!"
path.StreamWrite(text);

//Appends text to file
string text = "New Text C#!";
path.StreamAppend(text);

//Writes lines to file
string lines = {"Hello Line 1","Hello Line 2","Hello Line 3"};
path.StreamWriteLines(lines);

//Appends lines to file
string lines = {"Hello Line 1","Hello Line 2","Hello Line 3"};
path.StreamAppendLines(lines);
```
