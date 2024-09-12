using NUnit.Framework;

namespace AlgorithmsAndDataStructures.Tests;

public class DoubleLinkedListTests
{
    [Test]
    public void Create_CteateNewList_SizeIsEmpty()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        Assert.That(dll.Size, Is.EqualTo(0));
    }

    [Test]
    public void AddHead_CteateNewListThenAdd_SizeEqualsOne()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddHead(10);
        Assert.That(dll.Size, Is.EqualTo(1));
    }
    [Test]
    public void AddHead_CteateNewListThenAddTwoItems_SizeEqualsTwo()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddHead(10);
        dll.AddHead(20);
        Assert.That(dll.Size, Is.EqualTo(2));
    }
    [Test]
    public void AddHead_CteateNewListThenAdd_HeadEqualsAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddHead(10);
        Assert.That(dll.Head.Data, Is.EqualTo(10));
    }
    [Test]
    public void AddHead_CteateNewListThenAddTwoItems_HeadEqualsLastAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddHead(10);
        dll.AddHead(20);
        Assert.That(dll.Head.Data, Is.EqualTo(20));
    }
    [Test]
    public void AddHead_CteateNewListThenAddTwoItems_HeadNextEqualsFirstAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddHead(10);
        dll.AddHead(20);
        Assert.That(dll.Head.Next!.Data, Is.EqualTo(10));
    }
    [Test]
    public void AddHead_CteateNewListThenAddTwoItems_TailEqualsFirstAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddHead(10);
        dll.AddHead(20);
        Assert.That(dll.Tail.Data, Is.EqualTo(10));
    }
    [Test]
    public void AddHead_CteateNewListThenAddThreeItems_HeadEqualsLastAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddHead(10);
        dll.AddHead(20);
        dll.AddHead(30);
        Assert.That(dll.Head.Data, Is.EqualTo(30));
    }
    [Test]
    public void AddHead_CteateNewListThenAddThreeItems_HeadPrevEqualsSecondAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddHead(10);
        dll.AddHead(20);
        dll.AddHead(30);
        Assert.That(dll.Head.Next!.Data, Is.EqualTo(20));
    }
    [Test]
    public void AddHead_CteateNewListThenAddThreeItems_HeadEqualsFirstAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddHead(10);
        dll.AddHead(20);
        dll.AddHead(30);
        Assert.That(dll.Tail.Data, Is.EqualTo(10));
    }
    [Test]
    public void AddHead_CteateNewListThenAddThreeItems_TailPrevEqualsSecondAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddHead(10);
        dll.AddHead(20);
        dll.AddHead(30);
        Assert.That(dll.Tail.Previous!.Data, Is.EqualTo(20));
    }

    [Test]
    public void AddTail_CteateNewListThenAdd_SizeEqualsOne()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        Assert.That(dll.Size, Is.EqualTo(1));
    }
    [Test]
    public void AddTail_CteateNewListThenAddTwoItems_SizeEqualsTwo()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        Assert.That(dll.Size, Is.EqualTo(2));
    }
    [Test]
    public void AddTail_CteateNewListThenAdd_HeadEqualsAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        Assert.That(dll.Tail.Data, Is.EqualTo(10));
    }
    [Test]
    public void AddTail_CteateNewListThenAddTwoItems_TailEqualsLastAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        Assert.That(dll.Tail.Data, Is.EqualTo(20));
    }
    [Test]
    public void AddTail_CteateNewListThenAddTwoItems_TailPrevEqualsFirstAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        Assert.That(dll.Tail.Previous!.Data, Is.EqualTo(10));
    }
    [Test]
    public void AddTail_CteateNewListThenAddTwoItems_HeadEqualsFirstAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        Assert.That(dll.Head.Data, Is.EqualTo(10));
    }
    [Test]
    public void AddTail_CteateNewListThenAddThreeItems_TailEqualsLastAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        Assert.That(dll.Tail.Data, Is.EqualTo(30));
    }
    [Test]
    public void AddTail_CteateNewListThenAddThreeItems_TailPrevEqualsSecondAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        Assert.That(dll.Tail.Previous!.Data, Is.EqualTo(20));
    }
    [Test]
    public void AddTail_CteateNewListThenAddThreeItems_HeadEqualsFirstAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        Assert.That(dll.Head.Data, Is.EqualTo(10));
    }
    [Test]
    public void AddTail_CteateNewListThenAddThreeItems_HeadNextEqualsSecondAdded()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        Assert.That(dll.Head.Next!.Data, Is.EqualTo(20));
    }

    [Test]
    public void AddBefore_InsertInCentre_OldNextIsCorrect()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        var n3 = dll.AddTail(30);
        var n4 = dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);

        var n35 = dll.AddBefore(n4, 35);
        Assert.That(n3.Next, Is.EqualTo(n35));
    }
    [Test]
    public void AddBefore_InsertInCentre_OldPrevIsCorrect()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        var n4 = dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);

        var n35 = dll.AddBefore(n4, 35);
        Assert.That(n4.Previous, Is.EqualTo(n35));
    }
    [Test]
    public void AddBefore_InsertInCentre_NewNextIsCorrect()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        var n4 = dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);

        var n35 = dll.AddBefore(n4, 35);
        Assert.That(n35.Next, Is.EqualTo(n4));
    }
    [Test]
    public void AddBefore_InsertInCentre_NewPrevIsCorrect()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        var n3 = dll.AddTail(30);
        var n4 = dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);

        var n35 = dll.AddBefore(n4, 35);
        Assert.That(n35.Previous, Is.EqualTo(n3));
    }

    [Test]
    public void AddAfter_InsertInCentre_OldNextIsCorrect()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        var n3 = dll.AddTail(30);
        dll.AddTail(50);
        dll.AddTail(60);

        var n35 = dll.AddAfter(n3, 35);
        Assert.That(n3.Next, Is.EqualTo(n35));
    }
    [Test]
    public void AddAfter_InsertInCentre_OldPrevIsCorrect()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        var n3 = dll.AddTail(30);
        var n4 = dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);

        var n35 = dll.AddAfter(n3, 35);
        Assert.That(n4.Previous, Is.EqualTo(n35));
    }
    [Test]
    public void AddAfter_InsertInCentre_NewNextIsCorrect()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        var n3 = dll.AddTail(30);
        var n4 = dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);

        var n35 = dll.AddAfter(n3, 35);
        Assert.That(n35.Next, Is.EqualTo(n4));
    }
    [Test]
    public void AddAfter_InsertInCentre_NewPrevIsCorrect()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        var n3 = dll.AddTail(30);
        dll.AddTail(50);
        dll.AddTail(60);

        var n35 = dll.AddAfter(n3, 35);
        Assert.That(n35.Previous, Is.EqualTo(n3));
    }


    [Test]
    public void Get_GettingByIndex_ValueIsCorrect()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);
        Assert.That(dll[3], Is.EqualTo(40));
    }
    [Test]
    public void Set_SettingByIndex_NewValueIsCorrect()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        var n3 = dll.AddTail(50);
        dll.AddTail(60);

        dll[3] = 40;

        Assert.That(n3.Data, Is.EqualTo(40));
    }

    [Test]
    public void Get_IndexOutOfBoundNeg1_ThrowsError()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);
        int tmp = 0;
        Assert.Throws<ArgumentOutOfRangeException>(
            () => tmp = dll[-1]
        );
    }
    [Test]
    public void Get_IndexOutOfBoundPos1_ThrowsError()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);
        int tmp = 0;
        Assert.Throws<ArgumentOutOfRangeException>(
            () => tmp = dll[6]
        );
    }
    [Test]
    public void Get_IndexOutOfBoundNeg5_ThrowsError()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);
        int tmp = 0;
        Assert.Throws<ArgumentOutOfRangeException>(
            () => tmp = dll[-6]
        );
    }
    [Test]
    public void Get_IndexOutOfBoundPos5_ThrowsError()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);
        int tmp = 0;
        Assert.Throws<ArgumentOutOfRangeException>(
            () => tmp = dll[11]
        );
    }

    [Test]
    public void Set_IndexOutOfBoundNeg1_ThrowsError()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);
        Assert.Throws<ArgumentOutOfRangeException>(
            () => dll[-1] = 100
        );
    }
    [Test]
    public void Set_IndexOutOfBoundPos1_ThrowsError()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);
        Assert.Throws<ArgumentOutOfRangeException>(
            () => dll[6] = 100
        );
    }
    [Test]
    public void Set_IndexOutOfBoundNeg5_ThrowsError()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);
        Assert.Throws<ArgumentOutOfRangeException>(
            () => dll[-6] = 100
        );
    }
    [Test]
    public void Set_IndexOutOfBoundPos5_ThrowsError()
    {
        DoubleLinkedList<int> dll = new DoubleLinkedList<int>();
        dll.AddTail(10);
        dll.AddTail(20);
        dll.AddTail(30);
        dll.AddTail(40);
        dll.AddTail(50);
        dll.AddTail(60);
        Assert.Throws<ArgumentOutOfRangeException>(
            () => dll[11] = 100
        );
    }
}
