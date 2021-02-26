using System; 

class URI {

    static void Main(string[] args) { 
        
        double pi = 3.14159;
        double R;
        double area;
        
        R = double.Parse(Console.ReadLine());
        
        area = (4/3.0) * pi * Math.Pow(R,3);
        
        Console.WriteLine(string.Format("VOLUME = {0:0.000}", area));
    }

}
