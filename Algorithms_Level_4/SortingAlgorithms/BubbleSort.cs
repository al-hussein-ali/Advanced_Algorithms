namespace Algorithms_Level_4.SortingAlgorithms;

public static class BubbleSort
{
    public static void Run()
    {
        int[] arr = { 22, 44, 1, 66, 35, 76, 92, 47, 2, 55, 17, 89, 95, 11, 7 };


        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"The Array Before sort: {string.Join(", ", arr)}");
        Console.WriteLine(new string('-', 50));


        BubbleSortAlgorithm(arr);


        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"The Array After sort: {string.Join(", ", arr)}");
        Console.WriteLine(new string('-', 50));
    }


    public static void BubbleSortAlgorithm(int[] arr)
    {
        int currentLength = arr.Length - 1;
        bool notSorted = true;


        while (notSorted)
        {
            notSorted = false;
            for (int i = 0; i < currentLength; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                    notSorted = true;
                }
            }

            currentLength--;
        }
    }
}