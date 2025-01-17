﻿using System.Collections.Generic;

public static class Extensions {

    /// <summary>
    /// Shuffles the contents of the list.
    /// </summary>
    public static void shuffle<T>(this List<T> list) {
        int n = list.Count;
        System.Random rnd = new System.Random();
        while(n > 1) {
            int k = (rnd.Next(0, n) % n);
            n--;
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}
