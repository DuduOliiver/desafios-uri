//MÉTODO 1:

using System; 

class URI {

    static void Main(string[] args) 
    { 
        double A,B,C,D;
        string[] number = Console.ReadLine().Split(' ');
        A = double.Parse(number[0]);
        B = double.Parse(number[1]);
        C = double.Parse(number[2]);
        D = (Math.Pow(B, 2) - (4.0 * A * C));
            
        if(D < 0 || A == 0){
            Console.WriteLine("Impossivel calcular");
        }else{
            Console.WriteLine($"R1 = {((-B + Math.Sqrt(D))/(2.0*A)).ToString("F5")}");
            Console.WriteLine($"R2 = {((-B - Math.Sqrt(D)) / (2.0*A)).ToString("F5")}");
        }
    }
}


//MÉTODO 2:

using System; 

class URI {

    static void Main(string[] args) 
    { 
        double A,B,C,R1,R2,D;
        string[] number = Console.ReadLine().Split(' ');
        A = double.Parse(number[0]);
        B = double.Parse(number[1]);
        C = double.Parse(number[2]);
        D = (Math.Pow(B, 2) - (4.0 * A * C));

        R1 = ((-B + Math.Sqrt(D)) / (2.0*A));
        R2 = ((-B - Math.Sqrt(D)) / (2.0*A));
        if(D < 0 || A == 0){
            Console.WriteLine("Impossivel calcular");
        }else{
            Console.WriteLine("R1 = {0:0.00000}", R1);
            Console.WriteLine("R2 = {0:0.00000}", R2);
        }
    }
}


