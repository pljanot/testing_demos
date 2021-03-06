using System;
using System.Collections.Generic;
using Xunit;

namespace Fixtures.Examples.Tests.csproj;

public class StackTests : IDisposable
{
    readonly Stack<int> stack;

    public StackTests()
    {
        stack = new Stack<int>();
    }

    public void Dispose()
    {
        stack.Clear();
    }

    [Fact]
    public void WithNoItems_CountShouldReturnZero()
    {
        var count = stack.Count;

        Assert.Equal(0, count);
    }

    [Fact]
    public void AfterPushingItem_CountShouldReturnOne()
    {
        stack.Push(42);

        var count = stack.Count;

        Assert.Equal(1, count);
    }

//////////////// "test class as context" pattern,

    public class EmptyStack
    {
        readonly Stack<int> stack;

        public EmptyStack()
        {
            stack = new Stack<int>();
        }

        // ... tests for an empty stack ...
    }

    public class SingleItemStack
    {
        readonly Stack<int> stack;

        public SingleItemStack()
        {
            stack = new Stack<int>();
            stack.Push(42);
        }

        // ... tests for a single-item stack ...
    }
}
