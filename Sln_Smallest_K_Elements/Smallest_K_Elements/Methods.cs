
namespace Smallest_K_Elements
{
    public class Methods
    {
        #region Public Methods
        public static int[] GetSmallestKElements(int[] arr, int k)
        {
            if (k <= 0 || arr == null || arr.Length == 0) return [];
            if (k >= arr.Length) return (int[])arr.Clone();

            var comparer = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

            foreach (var num in arr)
            {
                if (comparer.Count < k) comparer.Enqueue(num, num);
                else if (num < comparer.Peek()) // si es menor que el mayor actual
                {
                    comparer.Dequeue();        // quito el mayor
                    comparer.Enqueue(num, num); // meto el nuevo
                }
            }
            var result = new int[comparer.Count];
            int i = 0;
            while (comparer.Count > 0)
            {
                result[i++] = comparer.Dequeue();
            }
            Array.Sort(result);
            return result;
        }

        public static T[] GetSmallestKElements<T>(T[] arr, int k) where T : IComparable<T>
        {
            if (k <= 0 || arr == null || arr.Length == 0) return [];
            if (k >= arr.Length) return (T[])arr.Clone();

            var comparer = new PriorityQueue<T, T>(Comparer<T>.Create((a, b) => b.CompareTo(a)));

            foreach (var x in arr)
            {
                if (comparer.Count < k) comparer.Enqueue(x, x);
                else if (x.CompareTo(comparer.Peek()) < 0)
                {
                    comparer.Dequeue();
                    comparer.Enqueue(x, x);
                }
            }
            var result = comparer.UnorderedItems.Select(item => item.Element).ToArray();
            Array.Sort(result);
            return result;
            /*
            var result = new T[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = comparer.Dequeue();
            }
            Array.Sort(result);
            return result;
            */
        }

        public static T[] Ts<T>(T[] arr, int k) where T : IComparable<T>
        {
            if (k <= 0 || arr == null || arr.Length == 0) return [];
            if (k >= arr.Length) return (T[])arr.Clone();
            Array.Sort(arr);
            var result = new T[k];
            Array.Copy(arr, result, k);
            return result;
        }
        #endregion
    }
}
