using System; 
using System.Globalization;

class URI {

    static void Main(string[] args) { 
            double.TryParse(Console.ReadLine(),NumberStyles.Any, CultureInfo.InvariantCulture, out double value);
            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{(int)(value / 100)} nota(s) de R$ 100.00");
            value %= 100;
            Console.WriteLine($"{(int)(value / 50)} nota(s) de R$ 50.00");
            value %= 50;
            Console.WriteLine($"{(int)(value / 20)} nota(s) de R$ 20.00");
            value %= 20;
            Console.WriteLine($"{(int)(value / 10)} nota(s) de R$ 10.00");
            value %= 10;
            Console.WriteLine($"{(int)(value / 5)} nota(s) de R$ 5.00");
            value %= 5;
            Console.WriteLine($"{(int)(value/ 2)} nota(s) de R$ 2.00");
            value %= 2;

            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{(int)(value)} moeda(s) de R$ 1.00");
            value = value % 1 * 100;
            Console.WriteLine($"{(int)(value/50)} moeda(s) de R$ 0.50");
            value %= 50;
            Console.WriteLine($"{(int)(value/25)} moeda(s) de R$ 0.25");
            value %= 25;
            Console.WriteLine($"{(int)(value/10)} moeda(s) de R$ 0.10");
            value %= 10;
            Console.WriteLine($"{(int)(value/5)} moeda(s) de R$ 0.05");
            value %= 5;
            Console.WriteLine($"{(int)(value)} moeda(s) de R$ 0.01");
            value %= 1;        
    }

}
