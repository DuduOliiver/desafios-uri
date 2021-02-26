using System; 

class URI {

    static void Main(string[] args) { 
    int time = Int32.Parse(Console.ReadLine());
    int kmh = Int32.Parse(Console.ReadLine());
    double lts = time * kmh / 12.00;
    Console.WriteLine("{0:0.000}", lts);
    }
}

Método 2:

using System; 

class URI {

    static void Main(string[] args) { 
    int time = Int32.Parse(Console.ReadLine());
    int kmh = Int32.Parse(Console.ReadLine());
    double lts = time * kmh / 12.00;
    Console.WriteLine((lts).ToString("F3"));
    }
}
