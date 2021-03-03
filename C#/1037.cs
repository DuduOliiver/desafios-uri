using System; 

class URI {

    static void Main(string[] args) 
    { 
        double.TryParse(Console.ReadLine(), out double num);
        if((num>=0.0) && (num<=25.0)){
            Console.WriteLine("Intervalo [0,25]");
        }
        else if((num>25.0) && (num<=50.0)){
            Console.WriteLine("Intervalo (25,50]");
        }
        else if((num>50.0) && (num<=75.0)){
            Console.WriteLine("Intevalo [50,75]");
        }
        else if((num>75.0) && (num<=100.0)){
            Console.WriteLine("Intervalo (75,100]");
        }else{
            Console.WriteLine("Fora de intervalo");
        }
    }

}
