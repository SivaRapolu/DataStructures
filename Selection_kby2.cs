using System;

namespace DS_Alogorithms
{
    class Selection_kby2
    {
        public static bool Find(int[] arr, int k)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == k)
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();

            int N = 9999999;
            int k = N / 2;

            int[] arrNums = new int[N];
            for(int i = 0; i < N; i++)
            {
                arrNums[i] = i;
            }

            Find(arrNums, k);

            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        }

        
    }
}
