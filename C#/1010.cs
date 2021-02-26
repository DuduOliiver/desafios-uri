using System;
class URI {

    static void Main(string[] args) { 
        String line1 = Console.ReadLine();
        String line2 = Console.ReadLine();

        String[] values1 = line1.Split(' ');
        int codPeca1 = Int32.Parse(values1[0]);
        int numPecas1 = Int32.Parse(values1[1]);
        double valorPeca1 = Convert.ToDouble(values1[2]);

        String[] values2 = line2.Split(' ');
        int codPeca2 = Int32.Parse(values2[0]);
        int numPecas2 = Int32.Parse(values2[1]);
        double valorPeca2 = Convert.ToDouble(values2[2]);
        
        Console.WriteLine("VALOR A PAGAR: R$ " + ( (numPecas1*valorPeca1) + (numPecas2*valorPeca2) ).ToString("0.00"));    
        
    }
}


Método 2:

using System;
class URI {

    static void Main(string[] args) { 
        double total;
        
        String line1 = Console.ReadLine();
        String line2 = Console.ReadLine();

        String[] values1 = line1.Split(' ');
        int codPeca1 = Int32.Parse(values1[0]);
        int numPecas1 = Int32.Parse(values1[1]);
        double valorPeca1 = Convert.ToDouble(values1[2]);

        String[] values2 = line2.Split(' ');
        int codPeca2 = Int32.Parse(values2[0]);
        int numPecas2 = Int32.Parse(values2[1]);
        double valorPeca2 = Convert.ToDouble(values2[2]);
        
        total = (numPecas1*valorPeca1) + (numPecas2*valorPeca2);
        
        Console.WriteLine("VALOR A PAGAR: R$ " + (total).ToString("0.00"));    
        
    }
}

Método 3:

using System;
class URI {

    static void Main(string[] args) { 
        double total;
        
        String line1 = Console.ReadLine();
        String line2 = Console.ReadLine();

        String[] values1 = line1.Split(' ');
        int codPeca1 = Int32.Parse(values1[0]);
        int numPecas1 = Int32.Parse(values1[1]);
        double valorPeca1 = Convert.ToDouble(values1[2]);

        String[] values2 = line2.Split(' ');
        int codPeca2 = Int32.Parse(values2[0]);
        int numPecas2 = Int32.Parse(values2[1]);
        double valorPeca2 = Convert.ToDouble(values2[2]);
        
        total = (numPecas1*valorPeca1) + (numPecas2*valorPeca2);
        
        Console.WriteLine("VALOR A PAGAR: R$ {0}", total.ToString("0.00"));
        
    }
}

//O MELHOR
MÉTODO 4:
using System;
class URI {

    static void Main(string[] args) { 
        double total;
        
        String line1 = Console.ReadLine();
        String line2 = Console.ReadLine();

        String[] values1 = line1.Split(' ');
        int codPeca1 = Int32.Parse(values1[0]);
        int numPecas1 = Int32.Parse(values1[1]);
        double valorPeca1 = Convert.ToDouble(values1[2]);

        String[] values2 = line2.Split(' ');
        int codPeca2 = Int32.Parse(values2[0]);
        int numPecas2 = Int32.Parse(values2[1]);
        double valorPeca2 = Convert.ToDouble(values2[2]);
        
        total = (numPecas1*valorPeca1) + (numPecas2*valorPeca2);
        
        Console.WriteLine(string.Format("VALOR A PAGAR: R$ {0:0.00}", total));
        
    }
}
