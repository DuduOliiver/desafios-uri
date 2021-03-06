using System; 

class URI {

    static void Main(string[] args) { 
        string[] line = Console.ReadLine().Split(' ');
        int.TryParse(line[0], out int n1);
        int.TryParse(line[1], out int n2);
        Console.WriteLine(((n2 % n1) == 0) || ((n1 % n2) == 0) ? "Sao Multiplos" : "Nao sao Multiplos");
    }
}
