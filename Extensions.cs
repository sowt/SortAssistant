using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoSortAssistant
{
    public static class Extensions
    {
        [ThreadStatic]
        static Random _rnd;

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            var rnd = _rnd ?? (_rnd = new Random());

            T[] arr = source.ToArray();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int j = rnd.Next(i + 1);
                yield return arr[j];
                arr[j] = arr[i];
            }
        }
    }
}