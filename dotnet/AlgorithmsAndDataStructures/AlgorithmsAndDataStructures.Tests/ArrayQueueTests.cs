using System;
using NUnit.Framework;

namespace AlgorithmsAndDataStructures.Tests;

public class ArrayQueueTests
{
    [Test]
    public void Size_NewQueue_SizeIsEmpty()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);

        Assert.That(queue.Size, Is.EqualTo(0));
    }
    [Test]
    public void Size_AddOneElement_SizeIsOne()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);

        Assert.That(queue.Size, Is.EqualTo(1));
    }
    [Test]
    public void Size_AddTwoElement_SizeIsTwo()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);
        queue.Enqueue(20);

        Assert.That(queue.Size, Is.EqualTo(2));
    }
    [Test]
    public void Size_AddTwoElementThenRemove_SizeIsOne()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Dequeue();

        Assert.That(queue.Size, Is.EqualTo(1));
    }
    [Test]
    public void Size_AddTwoElementThenHead_SizeIsTwo()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Head();

        Assert.That(queue.Size, Is.EqualTo(2));
    }

    [Test]
    public void Dequeue_FromEmpty_ThrowsError()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);

        Assert.Throws<InvalidOperationException>(
            () => queue.Dequeue()
        );
    }
    [Test]
    public void Dequeue_AfterAdd_NotThrowsError()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);

        Assert.DoesNotThrow(() => queue.Dequeue());
    }
    [Test]
    public void Dequeue_AfterAddTwo_NotThrowsErrorTwoTimes()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);
        queue.Enqueue(20);

        Assert.DoesNotThrow(() => queue.Dequeue());
        Assert.DoesNotThrow(() => queue.Dequeue());
    }

    [Test]
    public void Head_FromEmpty_ThrowsError()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);

        Assert.Throws<InvalidOperationException>(
            () => queue.Head()
        );
    }
    [Test]
    public void Head_AfterAdd_ReturnCorrectValue()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);

        Assert.That(queue.Head(), Is.EqualTo(10));
    }
    [Test]
    public void Head_AfterAddTwo_ReturnCorrectValueTwoTimes()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);
        queue.Enqueue(20);

        Assert.That(queue.Head(), Is.EqualTo(10));
        Assert.That(queue.Head(), Is.EqualTo(10));
    }
    [Test]
    public void Head_AfterAddTwoThenDequeue_ReturnCorrectValue()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Dequeue();

        Assert.That(queue.Head(), Is.EqualTo(20));
    }

    [Test]
    public void IsEmpty_CreatedNew_ReturnTrue()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        Assert.That(queue.IsEmpty, Is.True);
    }
    [Test]
    public void IsEmpty_AddOneElement_ReturnFalse()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);
        Assert.That(queue.IsEmpty, Is.False);
    }
    [Test]
    public void IsEmpty_AddOneElementThenRemove_ReturnTrue()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);
        queue.Dequeue();
        Assert.That(queue.IsEmpty, Is.True);
    }
    [Test]
    public void IsEmpty_AddOneElementThenHead_ReturnFalse()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);
        queue.Head();
        Assert.That(queue.IsEmpty, Is.False);
    }


    [Test]
    public void Enqueue_AddThreTimesInThreeCapacity_DoesNotThrowsErrors()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        Assert.DoesNotThrow(() => queue.Enqueue(10));
        Assert.DoesNotThrow(() => queue.Enqueue(20));
        Assert.DoesNotThrow(() => queue.Enqueue(30));
    }
    [Test]
    public void Enqueue_AddFourTimesInThreeCapacity_ThrowsErrorOnLastTime()
    {
        IQueue<int> queue = new ArrayQueue<int>(3);
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Assert.Throws<InvalidOperationException>(
            () => queue.Enqueue(40)
        );
    }
}
