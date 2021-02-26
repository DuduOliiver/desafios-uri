using System; 

class URI {

    static void Main(string[] args) { 
        string[] valores = Console.ReadLine().Split(' ');
        double A = Convert.ToDouble(valores[0]); 
        double B = Convert.ToDouble(valores[1]);
        double C = Convert.ToDouble(valores[2]);
        
        double triangulo = A*C/2;
        double circulo = 3.14159 * Math.Pow(C,2);
        double trapezio = (A+B)*C/2;
        double quadrado = Math.Pow(B,2);
        double retangulo = A*B;
        
        Console.WriteLine(string.Format("TRIANGULO: {0:0.000}", triangulo));
        Console.WriteLine(string.Format("CIRCULO: {0:0.000}", circulo));
        Console.WriteLine(string.Format("TRAPEZIO: {0:0.000}",trapezio));
        Console.WriteLine(string.Format("QUADRADO: {0:0.000}", quadrado));
        Console.WriteLine(string.Format("RETANGULO: {0:0.000}", retangulo));
    }
}
