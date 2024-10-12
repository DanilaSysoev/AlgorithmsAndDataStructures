using NUnit.Framework;

namespace AlgorithmsAndDataStructures.Tests;

public class LinkedListDequeueTests
{
    [Test]
    public void Size_CreateNewDeque_SizeEqualsZero()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        Assert.That(dequeue.Size, Is.EqualTo(0));
    }
    [Test]
    public void Front_CreateNewDeque_ThrowsError()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        int tmp;
        Assert.Throws<InvalidOperationException>(
            () => tmp = dequeue.Front()
        );
    }
    [Test]
    public void Back_CreateNewDeque_ThrowsError()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        int tmp;
        Assert.Throws<InvalidOperationException>(
            () => tmp = dequeue.Back()
        );
    }
    [Test]
    public void PopFront_CreateNewDeque_ThrowsError()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        Assert.Throws<InvalidOperationException>(
            dequeue.PopFront
        );
    }
    [Test]
    public void PopBack_CreateNewDeque_ThrowsError()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        Assert.Throws<InvalidOperationException>(
            dequeue.PopBack
        );
    }


    [Test]
    public void PushFront_PushOneItem_SizeEqualsOne()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushFront(10);
        Assert.That(dequeue.Size, Is.EqualTo(1));
    }
    [Test]
    public void PushFront_PushTwoItems_SizeEqualsTwo()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushFront(10);
        dequeue.PushFront(20);
        Assert.That(dequeue.Size, Is.EqualTo(2));
    }
    [Test]
    public void PushFront_PushTthreeItems_SizeEqualsThree()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushFront(10);
        dequeue.PushFront(20);
        dequeue.PushFront(30);
        Assert.That(dequeue.Size, Is.EqualTo(3));
    }
    [Test]
    public void PushFront_PushOneItem_FrontIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushFront(10);
        Assert.That(dequeue.Front(), Is.EqualTo(10));
    }
    [Test]
    public void PushFront_PushTwoItems_FrontIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushFront(10);
        dequeue.PushFront(20);
        Assert.That(dequeue.Front(), Is.EqualTo(20));
    }
    [Test]
    public void PushFront_PushTthreeItems_FrontIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushFront(10);
        dequeue.PushFront(20);
        dequeue.PushFront(30);
        Assert.That(dequeue.Front(), Is.EqualTo(30));
    }
    [Test]
    public void PushFront_PushOneItem_BackIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushFront(10);
        Assert.That(dequeue.Back(), Is.EqualTo(10));
    }
    [Test]
    public void PushFront_PushTwoItems_BackIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushFront(10);
        dequeue.PushFront(20);
        Assert.That(dequeue.Back(), Is.EqualTo(10));
    }
    [Test]
    public void PushFront_PushTthreeItems_BackIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushFront(10);
        dequeue.PushFront(20);
        dequeue.PushFront(30);
        Assert.That(dequeue.Back(), Is.EqualTo(10));
    }


    [Test]
    public void PushBack_PushOneItem_SizeEqualsOne()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushBack(10);
        Assert.That(dequeue.Size, Is.EqualTo(1));
    }
    [Test]
    public void PushBack_PushTwoItems_SizeEqualsTwo()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushBack(10);
        dequeue.PushBack(20);
        Assert.That(dequeue.Size, Is.EqualTo(2));
    }
    [Test]
    public void PushBack_PushTthreeItems_SizeEqualsThree()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushBack(10);
        dequeue.PushBack(20);
        dequeue.PushBack(30);
        Assert.That(dequeue.Size, Is.EqualTo(3));
    }
    [Test]
    public void PushBack_PushOneItem_BackIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushBack(10);
        Assert.That(dequeue.Back(), Is.EqualTo(10));
    }
    [Test]
    public void PushBack_PushTwoItems_BackIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushBack(10);
        dequeue.PushBack(20);
        Assert.That(dequeue.Back(), Is.EqualTo(20));
    }
    [Test]
    public void PushBack_PushTthreeItems_BackIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushBack(10);
        dequeue.PushBack(20);
        dequeue.PushBack(30);
        Assert.That(dequeue.Back(), Is.EqualTo(30));
    }
    [Test]
    public void PushBack_PushOneItem_FrontIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushBack(10);
        Assert.That(dequeue.Front(), Is.EqualTo(10));
    }
    [Test]
    public void PushBack_PushTwoItems_FrontIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushBack(10);
        dequeue.PushBack(20);
        Assert.That(dequeue.Front(), Is.EqualTo(10));
    }
    [Test]
    public void PushBack_PushTthreeItems_FrontIsCorrect()
    {
        IDequeue<int> dequeue = new LinkedListDequeue<int>();
        dequeue.PushBack(10);
        dequeue.PushBack(20);
        dequeue.PushBack(30);
        Assert.That(dequeue.Front(), Is.EqualTo(10));
    }
}
