using System; 

class URI {

    static void Main(string[] args) { 
        string[] line = Console.ReadLine().Split(' ');
        int inicial = Int32.Parse(line[0]);
        int final = Int32.Parse(line[1]);

        if (inicial > final)
        {
            Console.WriteLine($"O JOGO DUROU {24 + final - inicial} HORA(S)");
        }
        else if(final > inicial){
            Console.WriteLine($"O JOGO DUROU {final - inicial} HORA(S)");
        }
        else
        {
            Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
        }

    }

}
