namespace Algorithms_Level_4.SortingAlgorithms;

public class SelectionSort
{
    public static void Run(bool asc =  true)
    {
        int[] arr = { 22, 44, 1, 66, 35, 76, 92, 47, 2, 55, 17, 89, 95, 11, 7 };


        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"The Array Before sort: {string.Join(", ", arr)}");
        Console.WriteLine(new string('-', 50));


        SelectionSortAlgorithm(arr,asc);


        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine(new string('-', 50));
        Console.WriteLine($"The Array After sort: {string.Join(", ", arr)}");
        Console.WriteLine(new string('-', 50));
    }


    private static void SelectionSortAlgorithm(int[] arr, bool asc = true)
    {
        var predicate = (int num1, int num2) => asc ? num1 > num2 : num1 < num2;
        
        for (int i = 0; i < arr.Length -1; i++)
        {
            var min = SelectElementIndex(arr, i,predicate);
            if(min != i)
             (arr[i], arr[min]) = (arr[min], arr[i]);
        }
    }

    private static int SelectElementIndex(int[] arr, int startFrom,Func<int,int, bool> predicate)
    {
        int elementIndex = startFrom;
        for (int i = startFrom; i < arr.Length; i++)
        {
            if (predicate(arr[elementIndex] ,arr[i]))
            {
                elementIndex = i;
            }
        }

        return elementIndex;
    }
    
}