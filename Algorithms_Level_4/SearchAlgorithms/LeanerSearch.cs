namespace Algorithms_Level_4.SearchAlgorithms;

public static class LeanerSearch
{


    public static void Run()
    {
        int[] arr = Enumerable.Range(1, 30).ToArray();

        int item = 18;

        Console.WriteLine($"The Current Items are {string.Join(", " , arr)}");
        var result = Search(arr,item);
        
        if(result == -1)
            Console.WriteLine("No such Item.");
        
        else
            Console.WriteLine($"The Item was found in position {result}");
            

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
}