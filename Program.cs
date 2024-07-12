using System;

class Program
{
    static int FindSingle(int[] arr)
    {
        int left = 0, right = arr.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            // Ensure mid is even for simpler comparison
            if (mid % 2 == 1)
                mid--;

            // Check if mid and mid+1 form a pair
            if (arr[mid] == arr[mid + 1])
            {
                left = mid + 2;  // Move to the right half
            }
            else
            {
                right = mid;  // Move to the left half
            }
        }

        return arr[left];
    }

    static void Main()
    {
        // Test cases to validate the correctness of the solution
        Console.WriteLine(FindSingle(new int[] { 1, 1, 2, 2, 5, 5, 6, 6, 7, 8, 8, 9, 9 }));  // Output: 7
        Console.WriteLine(FindSingle(new int[] { 1, 1, 2, 2, 3 }));  // Output: 3
        Console.WriteLine(FindSingle(new int[] { 1, 2, 2, 3, 3, 4, 4 }));  // Output: 1
        Console.WriteLine(FindSingle(new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5 }));  // Output: 5
        Console.WriteLine(FindSingle(new int[] { 2, 3, 3, 4, 4, 5, 5 }));  // Output: 2
    }
}

