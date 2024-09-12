using System;
using NUnit.Framework;

namespace DynamicArrayLib.Tests;

public class DynamicArrayTests
{
    [Test]
    public void Size_CreateEmptyArray_EqualsZero()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        Assert.That(data.Size, Is.EqualTo(0));
    }
    [Test]
    public void Size_CreateArrayThenAddElement_EqualsOne()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        data.Add(10);
        Assert.That(data.Size, Is.EqualTo(1));
    }
    [Test]
    public void Size_CreateArrayThenAddTwoElements_EqualsTwo()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        data.Add(10);
        data.Add(20);
        Assert.That(data.Size, Is.EqualTo(2));
    }
    [Test]
    public void Size_CreateArrayThenAddTwoElementsThenRemoveOne_EqualsOne()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        data.Add(10);
        data.Add(20);
        data.Remove();
        Assert.That(data.Size, Is.EqualTo(1));
    }

    [Test]
    public void Get_GetZeroIndexFromEmptyArray_ThrowError()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        int a = 0;

        Assert.Throws<ArgumentOutOfRangeException>(
            () => a = data[0]
        );
    }
    [Test]
    public void Get_GetPositiveIndexFromEmptyArray_ThrowError()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        int a = 0;

        Assert.Throws<ArgumentOutOfRangeException>(
            () => a = data[3]
        );
    }
    [Test]
    public void Get_GetNegativeIndexFromEmptyArray_ThrowError()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        int a = 0;

        Assert.Throws<ArgumentOutOfRangeException>(
            () => a = data[-3]
        );
    }
    [Test]
    public void Get_GetFromNonEmptyArrayWithNegativeOutOfBounds_ThrowError()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        data.Add(10);
        data.Add(20);
        data.Add(30);
        int a = 0;

        Assert.Throws<ArgumentOutOfRangeException>(
            () => a = data[-1]
        );
    }
    [Test]
    public void Get_GetFromNonEmptyArrayWithPositiveOutOfBounds_ThrowError()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        data.Add(10);
        data.Add(20);
        data.Add(30);
        int a = 0;

        Assert.Throws<ArgumentOutOfRangeException>(
            () => a = data[5]
        );
    }
    [Test]
    public void Get_GetFromNonEmptyArray_ReturnsCorrectValue()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        data.Add(10);
        data.Add(20);
        data.Add(30);

        Assert.That(data[0], Is.EqualTo(10));
        Assert.That(data[1], Is.EqualTo(20));
        Assert.That(data[2], Is.EqualTo(30));
    }


    [Test]
    public void Set_SetToZeroIndexToEmptyArray_ThrowError()
    {
        DynamicArray<int> data = new DynamicArray<int>();

        Assert.Throws<ArgumentOutOfRangeException>(
            () => data[0] = 100
        );
    }
    [Test]
    public void Set_SetToPositiveIndexToEmptyArray_ThrowError()
    {
        DynamicArray<int> data = new DynamicArray<int>();

        Assert.Throws<ArgumentOutOfRangeException>(
            () => data[3] = 100
        );
    }
    [Test]
    public void Set_SetToNegativeIndexToEmptyArray_ThrowError()
    {
        DynamicArray<int> data = new DynamicArray<int>();

        Assert.Throws<ArgumentOutOfRangeException>(
            () => data[-3] = 100
        );
    }
    [Test]
    public void Set_SetToNonEmptyArrayWithNegativeOutOfBounds_ThrowError()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        data.Add(10);
        data.Add(20);
        data.Add(30);

        Assert.Throws<ArgumentOutOfRangeException>(
            () => data[-1] = 100
        );
    }
    [Test]
    public void Set_SetToNonEmptyArrayWithPositiveOutOfBounds_ThrowError()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        data.Add(10);
        data.Add(20);
        data.Add(30);

        Assert.Throws<ArgumentOutOfRangeException>(
            () => data[5] = 100
        );
    }
    [Test]
    public void Set_SetToNonEmptyArray_UpdateValueCorrect()
    {
        DynamicArray<int> data = new DynamicArray<int>();
        data.Add(10);
        data.Add(20);
        data.Add(30);

        data[0] = 100;
        data[1] = 200;
        data[2] = 300;

        Assert.That(data[0], Is.EqualTo(100));
        Assert.That(data[1], Is.EqualTo(200));
        Assert.That(data[2], Is.EqualTo(300));
    }

    [Test]
    public void Add_AddToEmptyArray_ZeroIndexItemIsCorrect()
    {
        DynamicArray<int> data = new DynamicArray<int>();

        data.Add(10);

        Assert.That(data[0], Is.EqualTo(10));
    }

    [Test]
    public void Remove_AddThreeElementsThenRemoveOne_ArrayContainsCorrectElements()
    {
        DynamicArray<int> data = new DynamicArray<int>();

        data.Add(10);
        data.Add(20);
        data.Add(30);
        data.Remove();

        Assert.That(data[0], Is.EqualTo(10));
        Assert.That(data[1], Is.EqualTo(20));
    }
}
