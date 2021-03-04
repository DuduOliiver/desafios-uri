using System; 

class URI {

    static void Main(string[] args){ 
        string[] line = Console.ReadLine().Split(' ');
        int.TryParse(line[0], out int entrada);
        int.TryParse(line[1], out int quantidade);

        switch (entrada)
        {
            case 1:
                Console.WriteLine($"Total: R$ {(quantidade * 4.00).ToString("F2")}");
            break;

            case 2:
                Console.WriteLine($"Total: R$ {(quantidade * 4.50).ToString("F2")}");
            break;

            case 3:
                Console.WriteLine($"Total: R$ {(quantidade * 5.00).ToString("F2")}");
            break;

            case 4:
                Console.WriteLine($"Total: R$ {(quantidade * 2.00).ToString("F2")}");
            break;

            case 5:
                Console.WriteLine($"Total: R$ {(quantidade * 1.50).ToString("F2")}");
            break;
        }
    }
}

