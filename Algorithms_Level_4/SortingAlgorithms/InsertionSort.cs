namespace Algorithms_Level_4.SortingAlgorithms;

public static class InsertionSort
{

    public static void Run()
    {
        int[] arr = { 22, 44, 1, 66, 35, 76, 92, 47, 2, 55, 17, 89, 95, 11, 7 };


        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"The Array Before sort: {string.Join(", ", arr)}");
        Console.WriteLine(new string('-', 50));


        InsertionSortAlgorithm(arr);


        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"The Array After sort: {string.Join(", ", arr)}");
        Console.WriteLine(new string('-', 50));
        
    }

    private static void InsertionSortAlgorithm(int[] arr)
    {

        var predicate = (int num1, int num2) => num1 > num2;
        var length = arr.Length;

        for (int i = 1; i < length; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && predicate(arr[j], key))
            {
                arr[j + 1] = arr[j];
                j--;
            }

            arr[j + 1] = key;
        }

    }
    
    
    
}