using Xunit;
using WorkingDirectory.CommandLines;
using WorkingDirectory.ExtensionMethods;
using System.Collections.Generic;

namespace main.xTests;

public class ListExtensionMethodTest
{
    [Fact]
    public void Test1()
    {
        const int max = 3;
        List<string> list1 = [];
        list1.AddItem("C:\\test4csharp");
        Assert.Equal(1, list1.Count);
        Assert.Equal("C:\\test4csharp", list1[^1]);

        List<string> list2 = ["C:\\sample"];
        list2.AddItem("C:\\test4csharp2");
        Assert.Equal(2, list2.Count);
        Assert.Equal("C:\\test4csharp2", list2[^1]);

        List<string> list3 = ["C:\\sample", "C:\\sample\\maker", "C:\\sample\\samples4programmings\\testor1"];
        list3.AddItem("C:\\test4csharp");
        Assert.Equal(max, list3.Count);
        Assert.Equal("C:\\test4csharp", list3[^1]);
        Assert.Equal("C:\\sample\\samples4programmings\\testor1", list3[^2]);

        List<string> list4 = [
            "C:\\sample", "C:\\sample\\maker", "C:\\sample\\samples4programmings\\testor1",
            "C:\\creation"
        ];
        list4.AddItem("C:\\test4csharp");
        Assert.Equal(3, list4.Count);
        Assert.Equal("C:\\test4csharp", list4[^1]);
        Assert.Equal("C:\\creation", list4[^2]);

        List<string> list5 = [
            "C:\\sample", "C:\\sample\\maker", "C:\\sample\\samples4programmings\\testor1",
            "C:\\creation", "C:\\checker"
        ];
        list5.AddItem("C:\\test4csharp5");
        Assert.Equal(3, list5.Count);
        Assert.Equal("C:\\test4csharp5", list5[^1]);
        Assert.Equal("C:\\checker", list5[^2]);
    }
}
