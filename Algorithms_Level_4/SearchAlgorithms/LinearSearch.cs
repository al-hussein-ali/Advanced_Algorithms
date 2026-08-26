namespace Algorithms_Level_4.SearchAlgorithms;

public static class LinearSearch
{


    public static void Run()
    {
        int[] arr = Enumerable.Range(1, 30).ToArray();

        int item = 18;

        Console.WriteLine($"The Current Items are {string.Join(", " , arr)}");
        // var result =  Search(arr, i => i == item);
        var result = SearchFromTwoSides(arr,item);
        
        if(result == -1)
            Console.WriteLine("No such Item.");
        
        else
            Console.WriteLine($"The Item was found in position {result + 1}");



       
    }

    private static int Search(int[] arr, int item)
    {
        int length = arr.Length;

        for (int i = 0; i < length; i++)
        {
            if (arr[i] == item)
                return i;
        }

        return -1;
    }

    private static int Search(int[] arr, Func<int, bool> predicate)
    {
        int length = arr.Length;
        for (int i = 0; i < length; i++)
        {
            if(predicate(arr[i]))
                return i;
        }
        
        return -1;
    }

    private static int SearchFromTwoSides(int[] arr, int item)
    {
        int length = arr.Length;
        int left = 0, right = arr.Length;

        int mid = right / 2;

        for (left = 0; left <= mid; left++)
        {
            if (arr[left] == item) return left;

            if (arr[--right] == item)
                return right;
        }

        return -1;
    }
}