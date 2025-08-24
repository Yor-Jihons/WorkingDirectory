using Xunit;
using WorkingDirectory.CommandLines;
using WorkingDirectory.ExtensionMethods;
using System;
using System.Collections.Generic;
using WorkingDirectory.Processors;

namespace main.xTests;

public class SaveProcessorTest
{
    [Fact]
    public void Test1()
    {
        string? curDirPath = Environment.CurrentDirectory;
        string? curDirParentPath = System.IO.Path.GetDirectoryName(curDirPath);

        var processor1 = new SaveProcessor(".");
        List<string> list1 = ["C:\\sample", "C:\\test"];
        processor1.Run(list1);
        Assert.Equal(curDirPath, list1[^1]);

        var processor2 = new SaveProcessor("..");
        List<string> list2 = ["C:\\sample"];
        processor2.Run(list2);
        Assert.Equal(curDirParentPath, list2[^1]);

        var processor3 = new SaveProcessor("C:\\checker");
        List<string> list3 = ["C:\\sample"];
        processor3.Run(list3);
        Assert.Equal("C:\\checker", list3[^1]);
    }
}
