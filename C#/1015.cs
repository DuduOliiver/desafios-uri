using System; 

class URI {

    static void Main(string[] args) { 
        string[] line = Console.ReadLine().Split(' ');
        string[] line2 = Console.ReadLine().Split(' ');

        double x1 = Convert.ToDouble(line[0]);
        double y1 = Convert.ToDouble(line[1]);
        double x2 = Convert.ToDouble(line2[0]);
        double y2 = Convert.ToDouble(line2[1]);

        Console.WriteLine( Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)).ToString("0.0000") );
    }

}
