using System;
using System.Diagnostics.SymbolStore;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using NSubstitute;
using NSubstitute.Routing.Handlers;
using Xunit;
using Xunit.Sdk;

namespace Nsubisute.Mock.Tests;

public interface ICalculator
{
    int add(int x,int y);
    int substract(int x, int y);
    int multiply(int x, int y);
}

public class MyCalculator : ICalculator 
{
    public int add (int x, int y) {
        Thread.Sleep(1000);
        return substract(x,y);
    }

    public int substract (int x, int y) {
        return 0;
    }

    public int multiply (int x, int y) {
        return 0;
    }
}

// Recieved Callcs
// https://nsubstitute.github.io/help/received-calls/ 
public class SubsistuteMocks
{
    [Fact]
    public void SubsistuteBasics()
    {
        var calculator = Substitute.For<ICalculator>();
        calculator.add(1,2).Returns(3);
        Assert.Equal(3, calculator.add(1,2));
        calculator.Received().add(1,2);

        calculator.DidNotReceiveWithAnyArgs().multiply(Arg.Any<int>(), Arg.Any<int>());
    }

    [Fact]
    public void SubsisuteDoNotCallBase()
    {
        var myCalc = Substitute.ForPartsOf<MyCalculator>();
        myCalc.WhenForAnyArgs(x => x.add(default, default)).DoNotCallBase();

        var res = myCalc.add(2,2);
        myCalc.Received().add(2,2);
        //Assert.Equal(4, res);
    }
}