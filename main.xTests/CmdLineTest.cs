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

        string[] args3 = ["save", ".."];
        var cmdline3 = CmdLine.Create(args3);
        Assert.Equal(ProcessTypes.SaveMode, cmdline3.ProcessType);
        Assert.Equal("..", cmdline3.Arg);

        string[] args4 = ["save", "C:\\sample\\dir1"];
        var cmdline4 = CmdLine.Create(args4);
        Assert.Equal(ProcessTypes.SaveMode, cmdline4.ProcessType);
        Assert.Equal("C:\\sample\\dir1", cmdline4.Arg);

        string[] args5 = ["load"];
        var cmdline5 = CmdLine.Create(args5);
        Assert.Equal(ProcessTypes.LaodMode, cmdline5.ProcessType);
        Assert.Equal("HEAD", cmdline5.Arg);

        string[] args6 = ["load", "HEAD"];
        var cmdline6 = CmdLine.Create(args6);
        Assert.Equal(ProcessTypes.LaodMode, cmdline6.ProcessType);
        Assert.Equal("HEAD", cmdline6.Arg);

        string[] args7 = ["load", "HEAD^"];
        var cmdline7 = CmdLine.Create(args7);
        Assert.Equal(ProcessTypes.LaodMode, cmdline7.ProcessType);
        Assert.Equal("HEAD^", cmdline7.Arg);

        string[] args8 = ["load", "HEAD^^"];
        var cmdline8 = CmdLine.Create(args8);
        Assert.Equal(ProcessTypes.LaodMode, cmdline8.ProcessType);
        Assert.Equal("HEAD^^", cmdline8.Arg);
    }

    [Fact]
    public void Test2()
    {
        string[] args1 = ["--help"];
        var cmdline1 = CmdLine.Create(args1);
        Assert.Null(cmdline1);

        string[] args2 = ["-h"];
        var cmdline2 = CmdLine.Create(args2);
        Assert.Null(cmdline2);

        string[] args3 = ["--version"];
        var cmdline3 = CmdLine.Create(args3);
        Assert.Null(cmdline3);

        string[] args4 = ["-v"];
        var cmdline4 = CmdLine.Create(args4);
        Assert.Null(cmdline4);

        string[] args5 = ["load"];
        var cmdline5 = CmdLine.Create(args5);
        Assert.Equal(ProcessTypes.LaodMode, cmdline5.ProcessType);
        Assert.Equal("HEAD", cmdline5.Arg);

        string[] args6 = ["load", "HEAD"];
        var cmdline6 = CmdLine.Create(args6);
        Assert.Equal(ProcessTypes.LaodMode, cmdline6.ProcessType);
        Assert.Equal("HEAD", cmdline6.Arg);

        string[] args7 = ["load", "HEAD^"];
        var cmdline7 = CmdLine.Create(args7);
        Assert.Equal(ProcessTypes.LaodMode, cmdline7.ProcessType);
        Assert.Equal("HEAD^", cmdline7.Arg);

        string[] args8 = ["load", "HEAD^^"];
        var cmdline8 = CmdLine.Create(args8);
        Assert.Equal(ProcessTypes.LaodMode, cmdline8.ProcessType);
        Assert.Equal("HEAD^^", cmdline8.Arg);
    }

    [Fact]
    public void Test3()
    {
        string[] args1 = ["eat"];
        var cmdline1 = CmdLine.Create(args1);
        Assert.Null(cmdline1);

        string[] args2 = ["eat", "test"];
        var cmdline2 = CmdLine.Create(args2);
        Assert.Null(cmdline2);
        
        // TODO: Modify the tests.

        //string[] args3 = [ "save", "HEAD" ];
        //var cmdline3 = CmdLine.Create(args3);
        //Assert.Null(cmdline3);

        //string[] args4 = [ "save", "HEAD^" ];
        //var cmdline4 = CmdLine.Create(args4);
        //Assert.Null(cmdline4);

        //string[] args5 = [ "save", "HEAD^^" ];
        //var cmdline5 = CmdLine.Create(args5);
        //Assert.Null(cmdline5);

        //string[] args6 = [ "load", "." ];
        //var cmdline6 = CmdLine.Create(args6);
        //Assert.Null(cmdline6);

        //string[] args7 = [ "load", ".." ];
        //var cmdline7 = CmdLine.Create(args7);
        //Assert.Null(cmdline7);

        //string[] args8 = [ "load", "C:\\sample\\dir2" ];
        //var cmdline8 = CmdLine.Create(args8);
        //Assert.Null(cmdline8);
    }
}
