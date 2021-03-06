using System; 

class URI {

    static void Main(string[] args) { 
        string[] line = Console.ReadLine().Split(' ');
        double.TryParse(line[0], out double A);
        double.TryParse(line[1], out double B);
        double.TryParse(line[2], out double C);

        if(((A+B) > C) && ((B+C) > A) && ((A+C)> B)){
            Console.WriteLine($"Perimetro = {(A + B + C).ToString("F1")}");
        }else{
            Console.WriteLine($"Area = {((A+B)*C/2).ToString("F1")}");
        }
    }
}
