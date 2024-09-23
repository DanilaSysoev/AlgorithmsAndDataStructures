using System;
using NUnit.Framework;

namespace AlgorithmsAndDataStructures.Tests;

public class LinkedListStackTests
{
    [Test]
    public void Size_NewStack_SizeIsEmpty()
    {
        IStack<int> stack = new LinkedListStack<int>();

        Assert.That(stack.Size, Is.EqualTo(0));
    }
    [Test]
    public void Size_AddOneElement_SizeIsOne()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);

        Assert.That(stack.Size, Is.EqualTo(1));
    }
    [Test]
    public void Size_AddTwoElement_SizeIsTwo()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);
        stack.Push(20);

        Assert.That(stack.Size, Is.EqualTo(2));
    }
    [Test]
    public void Size_AddTwoElementThenRemove_SizeIsOne()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Pop();

        Assert.That(stack.Size, Is.EqualTo(1));
    }
    [Test]
    public void Size_AddTwoElementThenTop_SizeIsTwo()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Top();

        Assert.That(stack.Size, Is.EqualTo(2));
    }

    [Test]
    public void Pop_FromEmpty_ThrowsError()
    {
        IStack<int> stack = new LinkedListStack<int>();

        Assert.Throws<InvalidOperationException>(
            () => stack.Pop()
        );
    }
    [Test]
    public void Pop_AfterAdd_NotThrowsError()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);

        Assert.DoesNotThrow(() => stack.Pop());
    }
    [Test]
    public void Pop_AfterAddTwo_NotThrowsErrorTwoTimes()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);
        stack.Push(20);

        Assert.DoesNotThrow(() => stack.Pop());
        Assert.DoesNotThrow(() => stack.Pop());
    }

    [Test]
    public void Top_FromEmpty_ThrowsError()
    {
        IStack<int> stack = new LinkedListStack<int>();

        Assert.Throws<InvalidOperationException>(
            () => stack.Top()
        );
    }
    [Test]
    public void Top_AfterAdd_ReturnCorrectValue()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);

        Assert.That(stack.Top(), Is.EqualTo(10));
    }
    [Test]
    public void Top_AfterAddTwo_ReturnCorrectValueTwoTimes()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);
        stack.Push(20);

        Assert.That(stack.Top(), Is.EqualTo(20));
        Assert.That(stack.Top(), Is.EqualTo(20));
    }
    [Test]
    public void Top_AfterAddTwoThenPop_ReturnCorrectValue()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Pop();

        Assert.That(stack.Top(), Is.EqualTo(10));
    }

    [Test]
    public void IsEmpty_CreatedNew_ReturnTrue()
    {
        IStack<int> stack = new LinkedListStack<int>();
        Assert.That(stack.IsEmpty, Is.True);
    }
    [Test]
    public void IsEmpty_AddOneElement_ReturnFalse()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);
        Assert.That(stack.IsEmpty, Is.False);
    }
    [Test]
    public void IsEmpty_AddOneElementThenRemove_ReturnTrue()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);
        stack.Pop();
        Assert.That(stack.IsEmpty, Is.True);
    }
    [Test]
    public void IsEmpty_AddOneElementThenTop_ReturnFalse()
    {
        IStack<int> stack = new LinkedListStack<int>();
        stack.Push(10);
        stack.Top();
        Assert.That(stack.IsEmpty, Is.False);
    }
}
