using Xunit;
using WorkingDirectory.CommandLines;
using WorkingDirectory.ExtensionMethods;
using System.Collections.Generic;
using WorkingDirectory.Processors;

namespace main.xTests;

public class ProcessorCreatorTest
{
    [Fact]
    public void Test1()
    {
        var processor1 = ProcessorCreator.Create(ProcessTypes.SaveMode, ".");
        Assert.NotNull(processor1);
        Assert.IsType<SaveProcessor>(processor1);

        var processor2 = ProcessorCreator.Create(ProcessTypes.SaveMode, "..");
        Assert.NotNull(processor2);
        Assert.IsType<SaveProcessor>(processor2);

        var processor3 = ProcessorCreator.Create(ProcessTypes.SaveMode, "C:\\sample");
        Assert.NotNull(processor3);
        Assert.IsType<SaveProcessor>(processor3);

        var processor4 = ProcessorCreator.Create(ProcessTypes.LaodMode, "HEAD");
        Assert.NotNull(processor4);
        Assert.IsType<LoadProcessor>(processor4);

        var processor5 = ProcessorCreator.Create(ProcessTypes.LaodMode, "HEAD^");
        Assert.NotNull(processor5);
        Assert.IsType<LoadProcessor>(processor5);

        var processor6 = ProcessorCreator.Create(ProcessTypes.LaodMode, "HEAD^^");
        Assert.NotNull(processor6);
        Assert.IsType<LoadProcessor>(processor6);

        var processor7 = ProcessorCreator.Create(ProcessTypes.Unknown, ".");
        Assert.Null(processor7);

        var processor8 = ProcessorCreator.Create(ProcessTypes.Unknown, "HEAD");
        Assert.Null(processor8);

        var processor9 = ProcessorCreator.Create(ProcessTypes.ListMode, "");
        Assert.NotNull(processor9);
        Assert.IsType<ListProcessor>(processor9);

        var processor10 = ProcessorCreator.Create(ProcessTypes.ListMode, "abc");
        Assert.NotNull(processor10);
        Assert.IsType<ListProcessor>(processor10);

        var processor11 = ProcessorCreator.Create(ProcessTypes.CearMode, "");
        Assert.NotNull(processor11);
        Assert.IsType<ClearProcessor>(processor11);
    }
}
