using System.Reflection;

namespace Course {
    class Calculator2 {

        public static int Sum(params int[] numbers) {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum+=numbers[i];
            }
            return sum;
        }

    }
}
