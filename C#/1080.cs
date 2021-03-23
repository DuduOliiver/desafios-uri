using System;

class URI {

    static void Main(string[] args) {
            int count = 0; int position = 0; int value=0;

            for (int i = 1; i <= 100; i++)
            {
                int.TryParse(Console.ReadLine(), out value);
                if (value > count)
                {
                    count = value;
                    position = i;
                }
            }
            Console.WriteLine($"{count}\n{position}");
    }
}
