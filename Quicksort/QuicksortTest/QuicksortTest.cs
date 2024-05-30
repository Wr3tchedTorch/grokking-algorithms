using Domain;
using FluentAssertions;

namespace QuicksortTest;

public class QuicksortTest
{
    Quicksort subject = new();

    [Theory]
    [InlineData(new double[] { 3, 2, 1, 8, 9 }, new double[] { 1, 2, 3, 8, 9 })]
    [InlineData(new double[] { 2, 1 }, new double[] { 1, 2 })]
    [InlineData(new double[] { 1 }, new double[] { 1 })]
    [InlineData(new double[0], new double[0])]
    public void TestIntegerArray(double[] arr, double[] expected)
    {
        subject.Qsort(subject.Qsort(arr)).Should().ContainInOrder(expected, "the Qsort function should reorder the array in crescent order");
    }

    [Theory]
    [InlineData(new double[] { 0.2, 1.2, 1.1, 1.11, 1.115 }, new double[] { 0.2, 1.1, 1.11, 1.115, 1.2 })]
    [InlineData(new double[] { 0.1000001, 0.1 }, new double[] { 0.1, 0.1000001 })]
    public void TestDecimalArray(double[] arr, double[] expected)
    {
        subject.Qsort(subject.Qsort(arr)).Should().ContainInOrder(expected, "the Qsort function should reorder the array in crescent order");
    }

    [Theory]
    [InlineData(new string[] { "Eric", "Ana", "Beatriz" }, new string[] { "Ana", "Beatriz", "Eric" })]
    [InlineData(new string[] { "Luiz Marcos", "Luiz Vinnicius", "Luiz Antonio" }, new string[] { "Luiz Antonio", "Luiz Marcos", "Luiz Vinnicius" })]
    public void TestStringArray(string[] arr, string[] expected)
    {
        subject.Qsort(arr).Should().ContainInOrder(expected);
    }
}