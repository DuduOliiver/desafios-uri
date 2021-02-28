using System; 

class URI {

    static void Main(string[] args) { 
    int num = Int32.Parse(Console.ReadLine());
    Console.WriteLine($"{num/3600}:{num%3600/60}:{num%3600%60}");
    }
}
