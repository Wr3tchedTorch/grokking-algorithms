using System.Linq;

namespace Domain;

public class Quicksort
{
    public string[] Qsort(string[] arr)
    {
        return Qsort(arr, 0);
    }
    public string[] Qsort(string[] arr, int targetLetterIndex)
    {
        if (arr.Length == 1) return arr;

        int pivot = GetCharNumericValue(arr[0], targetLetterIndex);
        string[] lower = arr.Where(word => GetCharNumericValue(word, targetLetterIndex) < pivot).ToArray();
        string[] higher = arr.Where(word => GetCharNumericValue(word, targetLetterIndex) > pivot).ToArray();
        string[] equals = arr.Where(word => GetCharNumericValue(word, targetLetterIndex) == pivot).ToArray();

        return Qsort(lower, 0).Concat(Qsort(equals, targetLetterIndex + 1)).Concat(Qsort(higher, targetLetterIndex)).ToArray();
    }

    private int GetCharNumericValue(string word, int charIndex)
    {
        return (int)char.ToLower(word.Replace(" ", "").ToCharArray()[charIndex]);
    }

    public double[] Qsort(double[] arr)
    {
        if (arr.Length == 0) return [];

        double pivot = arr[0];
        double[] higherNums = arr.Where(n => n > pivot).ToArray();
        double[] lowerNums = arr.Where(n => n < pivot).ToArray();
        double[] equalNums = arr.Where(n => n == pivot).ToArray();

        return Qsort(lowerNums).Concat(equalNums).Concat(Qsort(higherNums)).ToArray();
    }
}
