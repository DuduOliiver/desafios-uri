using System; 

class URI {

    static void Main(string[] args) { 
        int.TryParse(Console.ReadLine(), out int num);
        Console.WriteLine($"{num/365} ano(s)\n{num%365/30} mes(es)\n{num%365%30} dia(s)");
    }

}
