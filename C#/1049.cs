using System;

class URI
{

    static void Main(string[] args)
    {
        string word1 = Console.ReadLine().ToLower();
        string word2 = Console.ReadLine().ToLower();
        string word3 = Console.ReadLine().ToLower();

        if (word1 == "vertebrado" && word2 == "ave")
        {
            if (word3 == "carnivoro")
            {
                Console.WriteLine("aguia");
            }
            else if (word3 == "onivoro")
            {
                Console.WriteLine("pomba");
            }
        }
        else if (word1 == "vertebrado" && word2 == "mamifero")
        {
            if (word3 == "onivoro")
            {
                Console.WriteLine("homem");
            }
            else if (word3 == "herbivoro")
            {
                Console.WriteLine("vaca");
            }
        }

        if (word1 == "invertebrado" && word2 == "inseto")
        {
            if (word3 == "hematofago")
            {
                Console.WriteLine("pulga");
            }
            else if (word3 == "herbivoro")
            {
                Console.WriteLine("lagarta");
            }
        }
        else if (word1 == "invertebrado" && word2 == "anelideo")
        {
            if (word3 == "hematofago")
            {
                Console.WriteLine("sanguessuga");
            }
            else if (word3 == "onivoro")
            {
                Console.WriteLine("minhoca");
            }
        }
    }
}
