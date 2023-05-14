﻿Console.WriteLine("Fluxograma da Engenharia");

Console.Write("está se movendo (s/n)? ");
bool estaSeMovendo = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

Console.Write("Deveria? ");
bool deveria = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper() == "S";

string mensagem;

if (!estaSeMovendo)
{
    if (!deveria)
    {
        mensagem = "perfeito!";
    }
    else
    {
        mensagem = "Use WD.";
    }
}
else
{
    if (deveria)
    {
        mensagem = "perfeito!";
    }
    else
    {
        mensagem = "Use Silver Tape.";
    }
}

Console.WriteLine();
Console.WriteLine(mensagem);
