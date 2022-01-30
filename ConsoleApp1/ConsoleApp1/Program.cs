using System;

namespace ConsoleApplication1
{
    [Flags]
    enum Category
    {
        Seoul = 0,
        Deagu = 0b001,
        Boosan = 0b010,
        Daejeon = 0b100,
        Jeju = 0b011
    }

    class Car
    {
        public int[,] arr2 = new int[,]{ { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 }, { 9, 10, 11 } };
        public int[] record = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };

        public IEnumerable<int> GetNumber()
        {
            yield return 1;
            yield return 2;
            yield return 3;
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Hello World");
            Car car = new Car();
            int sum = 0;
            for (int i = 0; i < car.record.Length; i++)
            {
               sum += car.record[i];
            }
            Console.WriteLine(sum);

            var it =car.GetNumber().GetEnumerator();
            while (it.MoveNext())
            {
                Console.WriteLine(it.Current);
            }
        }
    }
}