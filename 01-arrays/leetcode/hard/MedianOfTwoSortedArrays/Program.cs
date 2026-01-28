// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
// The overall run time complexity should be O(log (m+n)).
// Example 1:

// Input: nums1 = [1,3], nums2 = [2]
// Output: 2.00000
// Explanation: merged array = [1,2,3] and median is 2.
// Example 2:

// Input: nums1 = [1,2], nums2 = [3,4]
// Output: 2.50000
// Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums1 = { 1, 2 };
        int[] nums2 = { 3,4 };
        double median = FindMedianSortedArrays(nums1, nums2);
        Console.WriteLine("Median: " + median);
    }
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length;
        int n = nums2.Length;

        int totalLength = m + n;

        if (totalLength == 0)
        {
            return 0.0;
        }

        int[] newArray = new int[totalLength];
        for (int i = 0; i < m; i++)
        {
            newArray[i] = nums1[i];
        }
        for (int j = 0; j < n; j++)
        {
            newArray[m + j] = nums2[j];
        }

        Array.Sort(newArray);

        if(totalLength % 2 == 0){
            int midIndex1 = (totalLength / 2) - 1;
            int midIndex2 = totalLength / 2;
            return (newArray[midIndex1] + newArray[midIndex2]) / 2.0;
        }
        else{
            int midIndex = totalLength / 2;
            return newArray[midIndex];
        }
    }
}