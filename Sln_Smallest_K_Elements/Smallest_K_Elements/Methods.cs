
namespace Smallest_K_Elements
{
    public class Methods
    {
        #region Public Methods
        public static int[] GetSmallestKElements(int[] arr, int k)
        {
            if (k <= 0 || arr == null || arr.Length == 0) return [];
            if (k >= arr.Length) return (int[])arr.Clone();

            var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));

            foreach (var num in arr)
            {
                if (pq.Count < k) pq.Enqueue(num, num);
                else if (num < pq.Peek()) // si es menor que el mayor actual
                {
                    pq.Dequeue();        // quito el mayor
                    pq.Enqueue(num, num); // meto el nuevo
                }
            }
            var result = new int[pq.Count];
            int i = 0;
            while (pq.Count > 0)
            {
                result[i++] = pq.Dequeue();
            }
            Array.Sort(result);
            return result;
        }

        public static T[] GetSmallestKElements<T>(T[] arr, int k) where T : IComparable<T>
        {
            if (k <= 0 || arr == null || arr.Length == 0) return [];
            if (k >= arr.Length) return (T[])arr.Clone();

            var pq = new PriorityQueue<T, T>(Comparer<T>.Create((a, b) => b.CompareTo(a)));

            foreach (var x in arr)
            {
                if (pq.Count < k) pq.Enqueue(x, x);
                else if (x.CompareTo(pq.Peek()) < 0)
                {
                    pq.Dequeue();
                    pq.Enqueue(x, x);
                }
            }
            var result = pq.UnorderedItems.Select(item => item.Element).ToArray();
            Array.Sort(result);
            return result;
            /*var result = new T[k];
            for (int i = 0; i < k; i++)
            {
                result[i] = pq.Dequeue();
            }
            Array.Sort(result);
            return result;
            */
        }
        #endregion
    }
}
