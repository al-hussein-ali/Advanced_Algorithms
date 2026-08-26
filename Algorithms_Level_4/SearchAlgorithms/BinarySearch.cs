namespace Algorithms_Level_4.SearchAlgorithms;

public static class BinarySearch
{
    public static void Run(bool isRecursive = false)
    {

        int[] arr = { 1, 2, 7, 11, 17, 22, 35, 44, 47, 55, 66, 76, 89, 92, 95};

        int target = 11;
        var result =  isRecursive 
                        ? BinarySearchWithRecursion(arr,target,0,arr.Length - 1) 
                        : BinarySearchWithLoop(arr, target);
        
        if(result == -1)
            Console.WriteLine("No such element was found in the array.");
        else
            Console.WriteLine($"Element was found in index {result} in the array.");

    }


    private static int BinarySearchWithLoop(int[] arr, int target)
    {
        int start = 0, end = arr.Length - 1;

        while (start <= end)
        {
            int middle = start + (end - start) / 2;

            if (arr[middle] == target) return middle;

            if (target > arr[middle])
                start = middle + 1;

            else
                end = middle - 1;
        }

        return -1;
    }

    private static int BinarySearchWithRecursion(int[] arr, int target, int start, int end)
    {
        if (start > end)
            return -1;

        int middle = start + (end - start) / 2;

        if (arr[middle] == target)
            return middle;

        if (target > arr[middle])
            return BinarySearchWithRecursion(arr, target, middle + 1, end);

        return BinarySearchWithRecursion(arr, target, start, middle - 1);

    }
}