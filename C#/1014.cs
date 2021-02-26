using System; 

class URI {

    static void Main(string[] args) { 
        
        int x = Convert.ToInt32(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        
        double kml = (x*1.0) / y;
        
        Console.WriteLine(string.Format("{0:0.000} km/l", kml));
    }

}
