// Task 1
// void PrintDigit(int min, int max)
// {
//     if (min > max)
//     {
//         System.Console.WriteLine();
//         return;
//     }
//     System.Console.Write(min + " ");
//     PrintDigit(min + 1, max);
// }

// PrintDigit(4, 8);

// Task 2
// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return Akkerman(m - 1, Akkerman(m, n - 1));
//     }
// }
// System.Console.WriteLine($"Akkerman Function Result = {Akkerman(3, 2)}");

// Task 3
// void PrintReversArray(int[] array, int size)
// {
//     System.Console.Write($"{array[size - 1]} ");
//     if (size > 1)
//     {
//         PrintReversArray(array, size - 1);
//     }
// }

// int[] array = { 2, 24, 5, 252, 13, };
// PrintReversArray(array, array.Length);