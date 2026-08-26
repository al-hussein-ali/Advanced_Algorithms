namespace Algorithms_Level_4.SearchAlgorithms;

public static class InterpolationSearch
{


    public static void Run()
    {
        
    }


    private static int InterpolationSearchAlgorithm(int[] arr, int target)
    {
        int low = 0;
        int high = arr.Length - 1;

        // Since the array is sorted, an element present in array 
        // must be in range defined by corner
        while (low <= high && target >= arr[low] && target <= arr[high])
        {
            if (low == high)
            {
                if (arr[low] == target) return low;
                return -1;
            }

            // The core formula you described. 
            // We cast to double during division to prevent integer truncation, 
            // then cast the final position back to int.
            int pos = low + (int)(((double)(high - low) / (arr[high] - arr[low])) * (target - arr[low]));

            // Condition of target found
            if (arr[pos] == target)
            {
                return pos;
            }

            // If target is larger, it's in the upper part
            if (arr[pos] < target)
            {
                low = pos + 1;
            }
            // If target is smaller, it's in the lower part
            else
            {
                high = pos - 1;
            }
        }

        return -1; // Target not found
    }
    
}