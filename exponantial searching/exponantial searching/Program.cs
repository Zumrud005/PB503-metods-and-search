using System;

class ExponentialSearch
{
        static void Main()
        {
            int[] array = { 10,23,25,45,89,96,102,120,690,847,921 };
            int target = 102;

            int result = ExponentiaSearch(array, target);

            if (result != -1)
                Console.WriteLine("ededin indeksi: " + result);
            else
                Console.WriteLine("eded tapılmadı.");
        }

    static int BinarySearch(int[] array, int left, int right, int target)
    {
        while (left <= right)
        {
            int mid = left + (right - left) / 2;


            if (array[mid] == target)
                return mid;

            if (array[mid] < target)
                left = mid + 1;

            else
                right = mid - 1;
        }
        return -1;


    }
        static int ExponentiaSearch(int[] array, int target)
        {
            int n = array.Length;

            if (array[0] == target)
                return 0;


            int i = 1;
            while (i < n && array[i] <= target)
                i *= 2;


            return BinarySearch(array, i / 2, Math.Min(i, n - 1), target);
        }
}
