using NUnit.Framework;

namespace AlgorithmsAndDataStructures.Tests;

public class BinarySearchTreeTests
{
    [Test]
    public void Create_CreateNewTree_RootIsNull()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();

        Assert.That(tree.Root, Is.Null);
    }

    [Test]
    public void Size_CreateNewTree_EqualsZero()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();

        Assert.That(tree.Size, Is.EqualTo(0));
    }
    [Test]
    public void Size_AddNewItem_SizeEqualsOne()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");

        Assert.That(tree.Size, Is.EqualTo(1));
    }
    [Test]
    public void Size_AddTwoItems_SizeEqualsTwo()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(2, "two");

        Assert.That(tree.Size, Is.EqualTo(2));
    }
    [Test]
    public void Size_AddNewItemThenRemove_SizeEqualsZero()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Remove(1);

        Assert.That(tree.Size, Is.EqualTo(0));
    }
    [Test]
    public void Size_AddTwoItemsThenRemoveFirst_SizeEqualsOne()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(2, "two");
        tree.Remove(1);

        Assert.That(tree.Size, Is.EqualTo(1));
    }
    [Test]
    public void Size_AddTwoItemsThenRemoveSecond_SizeEqualsOne()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(2, "two");
        tree.Remove(2);

        Assert.That(tree.Size, Is.EqualTo(1));
    }

    [Test]
    public void Add_AddOneItem_RootKeyIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        Assert.That(tree.Root!.Key, Is.EqualTo(1));
    }
    [Test]
    public void Add_AddOneItem_RootDataIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        Assert.That(tree.Root!.Data, Is.EqualTo("one"));
    }

    [Test]
    public void Add_AddOneItem_RootLeftIsNoll()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        Assert.That(tree.Root!.Left, Is.Null);
    }
    [Test]
    public void Add_AddOneItem_RootRightIsNoll()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        Assert.That(tree.Root!.Right, Is.Null);
    }
    [Test]
    public void Add_AddOneThenTwo_TreeKeysSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(2, "two");
        Assert.That(tree.Root!.Key, Is.EqualTo(1));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(2));
    }
    [Test]
    public void Add_AddTwoThenOne_TreeKeysSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(2, "two");
        tree.Add(1, "one");
        Assert.That(tree.Root!.Key, Is.EqualTo(2));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(1));
    }
    [Test]
    public void Add_AddOneThenTwo_LeftIsNull()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(2, "two");
        Assert.That(tree.Root!.Left, Is.Null);
    }
    [Test]
    public void Add_AddTwoThenOne_RightIsNull()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(2, "two");
        tree.Add(1, "one");
        Assert.That(tree.Root!.Right, Is.Null);
    }
    [Test]
    public void Add_AddOneThenTwo_TreeValuesSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(2, "two");
        Assert.That(tree.Root!.Data, Is.EqualTo("one"));
        Assert.That(tree.Root!.Right!.Data, Is.EqualTo("two"));
    }
    [Test]
    public void Add_AddTwoThenOne_TreeValuesSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(2, "two");
        tree.Add(1, "one");
        Assert.That(tree.Root!.Data, Is.EqualTo("two"));
        Assert.That(tree.Root!.Left!.Data, Is.EqualTo("one"));
    }


    [Test]
    public void Add_AddOneTwoThree_TreeValuesSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(2, "two");
        tree.Add(3, "three");
        Assert.That(tree.Root!.Data, Is.EqualTo("one"));
        Assert.That(tree.Root!.Right!.Data, Is.EqualTo("two"));
        Assert.That(tree.Root!.Right!.Right!.Data, Is.EqualTo("three"));
    }
    [Test]
    public void Add_AddOneThreeTwo_TreeValuesSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(3, "three");
        tree.Add(2, "two");
        Assert.That(tree.Root!.Data, Is.EqualTo("one"));
        Assert.That(tree.Root!.Right!.Data, Is.EqualTo("three"));
        Assert.That(tree.Root!.Right!.Left!.Data, Is.EqualTo("two"));
    }
    [Test]
    public void Add_AddTwoOneThree_TreeValuesSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(2, "two");
        tree.Add(1, "one");
        tree.Add(3, "three");
        Assert.That(tree.Root!.Data, Is.EqualTo("two"));
        Assert.That(tree.Root!.Left!.Data, Is.EqualTo("one"));
        Assert.That(tree.Root!.Right!.Data, Is.EqualTo("three"));
    }
    [Test]
    public void Add_AddTwoThreeOne_TreeValuesSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(2, "two");
        tree.Add(3, "three");
        tree.Add(1, "one");
        Assert.That(tree.Root!.Data, Is.EqualTo("two"));
        Assert.That(tree.Root!.Left!.Data, Is.EqualTo("one"));
        Assert.That(tree.Root!.Right!.Data, Is.EqualTo("three"));
    }
    [Test]
    public void Add_AddThreeOneTwo_TreeValuesSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(3, "three");
        tree.Add(1, "one");
        tree.Add(2, "two");
        Assert.That(tree.Root!.Data, Is.EqualTo("three"));
        Assert.That(tree.Root!.Left!.Data, Is.EqualTo("one"));
        Assert.That(tree.Root!.Left!.Right!.Data, Is.EqualTo("two"));
    }
    [Test]
    public void Add_AddThreeTwoOne_TreeValuesSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(3, "three");
        tree.Add(2, "two");
        tree.Add(1, "one");
        Assert.That(tree.Root!.Data, Is.EqualTo("three"));
        Assert.That(tree.Root!.Left!.Data, Is.EqualTo("two"));
        Assert.That(tree.Root!.Left!.Left!.Data, Is.EqualTo("one"));
    }

    [Test]
    public void Add_AddOneTwoThree_TreeKeysSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(2, "two");
        tree.Add(3, "three");
        Assert.That(tree.Root!.Key, Is.EqualTo(1));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(2));
        Assert.That(tree.Root!.Right!.Right!.Key, Is.EqualTo(3));
    }
    [Test]
    public void Add_AddOneThreeTwo_TreeKeysSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(3, "three");
        tree.Add(2, "two");
        Assert.That(tree.Root!.Key, Is.EqualTo(1));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(3));
        Assert.That(tree.Root!.Right!.Left!.Key, Is.EqualTo(2));
    }
    [Test]
    public void Add_AddTwoOneThree_TreeKeysSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(2, "two");
        tree.Add(1, "one");
        tree.Add(3, "three");
        Assert.That(tree.Root!.Key, Is.EqualTo(2));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(1));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(3));
    }
    [Test]
    public void Add_AddTwoThreeOne_TreeKeysSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(2, "two");
        tree.Add(3, "three");
        tree.Add(1, "one");
        Assert.That(tree.Root!.Key, Is.EqualTo(2));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(1));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(3));
    }
    [Test]
    public void Add_AddThreeOneTwo_TreeKeysSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(3, "three");
        tree.Add(1, "one");
        tree.Add(2, "two");
        Assert.That(tree.Root!.Key, Is.EqualTo(3));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(1));
        Assert.That(tree.Root!.Left!.Right!.Key, Is.EqualTo(2));
    }
    [Test]
    public void Add_AddThreeTwoOne_TreeKeysSteuctureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(3, "three");
        tree.Add(2, "two");
        tree.Add(1, "one");
        Assert.That(tree.Root!.Key, Is.EqualTo(3));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(2));
        Assert.That(tree.Root!.Left!.Left!.Key, Is.EqualTo(1));
    }

    [Test]
    public void Add_AddDuplicateKey_TreeSizeNotChanged()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(3, "three");
        tree.Add(3, "two");
        Assert.That(tree.Size, Is.EqualTo(1));
    }
    [Test]
    public void Add_AddDuplicateKey_ValueChanged()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(3, "three");
        tree.Add(3, "two");
        Assert.That(tree.Root!.Data, Is.EqualTo("two"));
    }

    [Test]
    public void Get_AddOneThenGet_ReturnCorrectValue()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(3, "three");
        Assert.That(tree.Get(3), Is.EqualTo("three"));
    }
    [Test]
    public void Get_AddOneThenReplace_ReturnCorrectValue()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(3, "three");
        tree.Add(3, "two");
        Assert.That(tree.Get(3), Is.EqualTo("two"));
    }
    [Test]
    public void Get_AddTwoThenGetFirst_ReturnCorrectValue()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(3, "three");
        Assert.That(tree.Get(1), Is.EqualTo("one"));
    }
    [Test]
    public void Get_AddTwoThenGetSecond_ReturnCorrectValue()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(3, "three");
        Assert.That(tree.Get(3), Is.EqualTo("three"));
    }
    [Test]
    public void Get_GettingNonExistentKey_ReturnNull()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "one");
        tree.Add(3, "three");
        Assert.That(tree.Get(2), Is.Null);
    }

    [Test]
    public void Next_CreateFullEvenAndCheckFirstOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(1), Is.EqualTo(2));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck2dOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(3), Is.EqualTo(4));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck3dOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(5), Is.EqualTo(6));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck4thOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(7), Is.EqualTo(8));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck5thOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(9), Is.EqualTo(10));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck6thOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(11), Is.EqualTo(12));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck7thOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(13), Is.EqualTo(14));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck8thOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(15), Is.EqualTo(0));
    }

    [Test]
    public void Next_CreateFullEvenAndCheckFirstEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(0), Is.EqualTo(2));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck2dEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(2), Is.EqualTo(4));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck3dEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(4), Is.EqualTo(6));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck4thEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(6), Is.EqualTo(8));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck5thEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(8), Is.EqualTo(10));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck6thEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(10), Is.EqualTo(12));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck7thEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(12), Is.EqualTo(14));
    }
    [Test]
    public void Next_CreateFullEvenAndCheck8thEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Next(14), Is.EqualTo(0));
    }



    [Test]
    public void Previous_CreateFullEvenAndCheckFirstOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(1), Is.EqualTo(0));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck2dOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(3), Is.EqualTo(2));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck3dOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(5), Is.EqualTo(4));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck4thOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(7), Is.EqualTo(6));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck5thOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(9), Is.EqualTo(8));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck6thOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(11), Is.EqualTo(10));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck7thOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(13), Is.EqualTo(12));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck8thOdd_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(15), Is.EqualTo(14));
    }

    [Test]
    public void Previous_CreateFullEvenAndCheckFirstEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(2), Is.EqualTo(0));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck2dEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(4), Is.EqualTo(2));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck3dEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(6), Is.EqualTo(4));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck4thEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(8), Is.EqualTo(6));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck5thEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(10), Is.EqualTo(8));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck6thEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(12), Is.EqualTo(10));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck7thEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(14), Is.EqualTo(12));
    }
    [Test]
    public void Previous_CreateFullEvenAndCheck8thEven_ReturnsCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        Assert.That(tree.Previous(16), Is.EqualTo(14));
    }

    [Test]
    public void Min_EmptyTree_ReturnNull()
    {
        ITree<string, string> tree = new BinarySearchTree<string, string>();
        Assert.That(tree.Min(), Is.Null);
    }
    [Test]
    public void Min_AddOne_ReturnCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "oneValue");
        Assert.That(tree.Min(), Is.EqualTo(1));
    }
    [Test]
    public void Min_AddTwoItems_ReturnCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "oneValue");
        tree.Add(2, "twoValue");
        Assert.That(tree.Min(), Is.EqualTo(1));
    }
    [Test]
    public void Min_AddTwoItemsRev_ReturnCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(2, "twoValue");
        tree.Add(1, "oneValue");
        Assert.That(tree.Min(), Is.EqualTo(1));
    }

    [Test]
    public void Max_EmptyTree_ReturnNull()
    {
        ITree<string, string> tree = new BinarySearchTree<string, string>();
        Assert.That(tree.Max(), Is.Null);
    }
    [Test]
    public void Max_AddOne_ReturnCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "oneValue");
        Assert.That(tree.Max(), Is.EqualTo(1));
    }
    [Test]
    public void Max_AddTwoItems_ReturnCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(1, "oneValue");
        tree.Add(2, "twoValue");
        Assert.That(tree.Max(), Is.EqualTo(2));
    }
    [Test]
    public void Max_AddTwoItemsRev_ReturnCorrectKey()
    {
        ITree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(2, "twoValue");
        tree.Add(1, "oneValue");
        Assert.That(tree.Max(), Is.EqualTo(2));
    }



    [Test]
    public void Remove_FullTwoLevelTreeRemove2_StructureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        tree.Remove(2);
        Assert.That(tree.Root!.Key, Is.EqualTo(8));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(4));
        Assert.That(tree.Root!.Left!.Right!.Key, Is.EqualTo(6));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(12));
        Assert.That(tree.Root!.Right!.Left!.Key, Is.EqualTo(10));
        Assert.That(tree.Root!.Right!.Right!.Key, Is.EqualTo(14));
        Assert.That(tree.Size, Is.EqualTo(6));
    }
    [Test]
    public void Remove_FullTwoLevelTreeRemove4_StructureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        tree.Remove(4);
        Assert.That(tree.Root!.Key, Is.EqualTo(8));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(6));
        Assert.That(tree.Root!.Left!.Left!.Key, Is.EqualTo(2));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(12));
        Assert.That(tree.Root!.Right!.Left!.Key, Is.EqualTo(10));
        Assert.That(tree.Root!.Right!.Right!.Key, Is.EqualTo(14));
        Assert.That(tree.Size, Is.EqualTo(6));
    }
    [Test]
    public void Remove_FullTwoLevelTreeRemove6_StructureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        tree.Remove(6);
        Assert.That(tree.Root!.Key, Is.EqualTo(8));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(4));
        Assert.That(tree.Root!.Left!.Left!.Key, Is.EqualTo(2));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(12));
        Assert.That(tree.Root!.Right!.Left!.Key, Is.EqualTo(10));
        Assert.That(tree.Root!.Right!.Right!.Key, Is.EqualTo(14));
        Assert.That(tree.Size, Is.EqualTo(6));
    }
    [Test]
    public void Remove_FullTwoLevelTreeRemove8_StructureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        tree.Remove(8);
        Assert.That(tree.Root!.Key, Is.EqualTo(10));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(4));
        Assert.That(tree.Root!.Left!.Right!.Key, Is.EqualTo(6));
        Assert.That(tree.Root!.Left!.Left!.Key, Is.EqualTo(2));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(12));
        Assert.That(tree.Root!.Right!.Right!.Key, Is.EqualTo(14));
        Assert.That(tree.Size, Is.EqualTo(6));
    }
    [Test]
    public void Remove_FullTwoLevelTreeRemove10_StructureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        tree.Remove(10);
        Assert.That(tree.Root!.Key, Is.EqualTo(8));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(4));
        Assert.That(tree.Root!.Left!.Right!.Key, Is.EqualTo(6));
        Assert.That(tree.Root!.Left!.Left!.Key, Is.EqualTo(2));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(12));
        Assert.That(tree.Root!.Right!.Right!.Key, Is.EqualTo(14));
        Assert.That(tree.Size, Is.EqualTo(6));
    }
    [Test]
    public void Remove_FullTwoLevelTreeRemove12_StructureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        tree.Remove(12);
        Assert.That(tree.Root!.Key, Is.EqualTo(8));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(4));
        Assert.That(tree.Root!.Left!.Right!.Key, Is.EqualTo(6));
        Assert.That(tree.Root!.Left!.Left!.Key, Is.EqualTo(2));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(14));
        Assert.That(tree.Root!.Right!.Left!.Key, Is.EqualTo(10));
        Assert.That(tree.Size, Is.EqualTo(6));
    }
    [Test]
    public void Remove_FullTwoLevelTreeRemove14_StructureIsCorrect()
    {
        BinarySearchTree<int, string> tree = new BinarySearchTree<int, string>();
        tree.Add(8, "8");
        tree.Add(4, "4");
        tree.Add(6, "6");
        tree.Add(2, "2");
        tree.Add(12, "12");
        tree.Add(10, "10");
        tree.Add(14, "14");
        tree.Remove(14);
        Assert.That(tree.Root!.Key, Is.EqualTo(8));
        Assert.That(tree.Root!.Left!.Key, Is.EqualTo(4));
        Assert.That(tree.Root!.Left!.Right!.Key, Is.EqualTo(6));
        Assert.That(tree.Root!.Left!.Left!.Key, Is.EqualTo(2));
        Assert.That(tree.Root!.Right!.Key, Is.EqualTo(12));
        Assert.That(tree.Root!.Right!.Left!.Key, Is.EqualTo(10));
        Assert.That(tree.Size, Is.EqualTo(6));
    }
}
