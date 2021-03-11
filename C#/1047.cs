using System;

class URI
{
    static void Main(string[] args)
    {
        string[] line = Console.ReadLine().Split(' ');
        int horaInicial = int.Parse(line[0]);
        int minutoInicial = int.Parse(line[1]);
        int horaFinal = int.Parse(line[2]);
        int minutoFinal = int.Parse(line[3]);

        int instanteInicial = horaInicial * 60 + minutoInicial;
        int instanteFinal = horaFinal * 60 + minutoFinal;

        int duracao;
        if (instanteInicial < instanteFinal)
        {
            duracao = instanteFinal - instanteInicial;
        }
        else
        {
            duracao = (24 * 60 - instanteInicial) + instanteFinal;
        }

        int duracaoHoras = duracao / 60;
        int duracaoMinutos = duracao % 60;

        Console.WriteLine($"O JOGO DUROU {duracaoHoras} HORA(S) E {duracaoMinutos} MINUTO(S)");
    }

}
