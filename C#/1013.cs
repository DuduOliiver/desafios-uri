using System; 

class URI {

    static void Main(string[] args) { 
        string[] line = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(line[0]);
        int b = Convert.ToInt32(line[1]);
        int c = Convert.ToInt32(line[2]);
        
        int maiorAb = ((a+b+Math.Abs(a-b))/2);
        int maiorAbc = ((maiorAb+c+Math.Abs(maiorAb-c))/2);
        
        Console.WriteLine(string.Format("{0} eh o maior", maiorAbc));
    }

}
