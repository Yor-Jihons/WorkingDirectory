using Xunit;
using WorkingDirectory.CommandLines;

namespace main.xTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string[] args1 = ["save"];
        var cmdline1 = CmdLine.Create(args1);
        Assert.Equal(ProcessTypes.SaveMode, cmdline1.ProcessType);
        Assert.Equal(".", cmdline1.Arg);

        string[] args2 = ["save", "."];
        var cmdline2 = CmdLine.Create(args2);
        Assert.Equal(ProcessTypes.SaveMode, cmdline2.ProcessType);
        Assert.Equal(".", cmdline2.Arg);
        
        string[] args3 = ["save", ".." ];
        var cmdline3 = CmdLine.Create(args3);
        Assert.Equal( ProcessTypes.SaveMode, cmdline3.ProcessType);
        Assert.Equal( "..", cmdline3.Arg );
    }
}
