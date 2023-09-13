using System;

namespace TwoSum {
  class Program {
    static void Main(string[] args) {
      // Initialize the array
      int[] arr = { 1, 2, 3, 4, 5, 8 };
      int targetSum = 8;

      // Iterate through the array
      for (int i = 0; i < arr.Length; i++) {
        for (int j = i + 1; j < arr.Length; j++) {
          // Check if the sum of the two elements is equal to the target sum
          if (arr[i] + arr[j] == targetSum) {
            Console.WriteLine("{0} + {1} = {2}", arr[i], arr[j], targetSum);
          }
        }
      }
    }
  }
}
