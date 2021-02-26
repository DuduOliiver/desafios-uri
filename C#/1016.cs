using System; 

class URI {

    static void Main(string[] args) { 
        int X = Convert.ToInt32(Console.ReadLine());
        int Y = X * 2; 
        Console.WriteLine("{0} minutos", Y);
    }

}

Método 2:

using System; 

class URI {

    static void Main(string[] args) { 
        int X;
        Int32.TryParse(Console.ReadLine(), out X);
        int Y = X * 2; 
        Console.WriteLine("{0} minutos", Y);
    }

}

Método 3:

using System; 

class URI {

    static void Main(string[] args) { 
        int X = Int32.Parse(Console.ReadLine());
        int Y = X * 2; 
        Console.WriteLine("{0} minutos", Y);
    }

}

