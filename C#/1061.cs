using System;

class URI
{

    static void Main(string[] args)
    {
        string[] diaInicio = Console.ReadLine().Split(' ');
        string[] horarioInicial = Console.ReadLine().Split(':');
        string[] diaFinal = Console.ReadLine().Split(' ');
        string[] horarioFinal = Console.ReadLine().Split(':');

        int.TryParse(diaInicio[1], out int _diaInicio);
        int.TryParse(horarioInicial[0].Trim(), out int _horaInicial);
        int.TryParse(horarioInicial[1].Trim(), out int _minutoInicial);
        int.TryParse(horarioInicial[2].Trim(), out int _segundoInicial);
        int.TryParse(diaFinal[1], out int _diaFinal);
        int.TryParse(horarioFinal[0].Trim(), out int _horaFinal);
        int.TryParse(horarioFinal[1].Trim(), out int _minutoFinal);
        int.TryParse(horarioFinal[2].Trim(), out int _segundoFinal);

        int duracaoDia = 86400 - ((_horaInicial * 3600) + (_minutoInicial * 60) + _segundoInicial);
        int diasQtd = 86400 * (_diaFinal - _diaInicio - 1);
        int ultimoDia = (_horaFinal * 3600) + (_minutoFinal * 60) + _segundoFinal;
        int duracaoEvento = duracaoDia + diasQtd + ultimoDia;

        Console.WriteLine($"{duracaoEvento / 86400} dia(s)");
        Console.WriteLine($"{duracaoEvento % 86400 / 3600} hora(s)");
        Console.WriteLine($"{duracaoEvento % 86400 % 3600 / 60} minuto(s)");
        Console.WriteLine($"{duracaoEvento % 86400 % 3600 % 60} segundo(s)");
    }
}
