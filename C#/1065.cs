using System; 

class URI {

    static void Main(string[] args) { 

            double[] num = new double[6];
            int contador = 0;

            for (int i = 0; i <= 4; i++)
            {
                double.TryParse(Console.ReadLine(), out num[i]);
                if (num[i] % 2 == 0)
                {
                    contador++;
                }
            }

            Console.WriteLine($"{contador} valores pares");
    }

}
