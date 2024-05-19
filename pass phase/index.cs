using System;
using System.Collections.Generic;

public class Personagem
{
    public string Cafezinho { get; set; }
    public int Pontuacao { get; private set; }
    private static Random random = new Random();

    public Personagem(string cafezinho)
    {
        Cafezinho = cafezinho;
        Pontuacao = 0;
    }

    public void PassarFase()
    {
        Pontuacao += 10;
        string doceGanho = ObterDoce();
        Console.WriteLine($"{Cafezinho} passou de fase, ganhou um {doceGanho}, e agora tem {Pontuacao} pontos.");
    }

    private string ObterDoce()
    {
        List<string> doces = new List<string> { "bala", "bolo", "chocolate", "pirulito", "doce de leite" };
        int index = random.Next(doces.Count);
        return doces[index];
    }
}

public class Program
{
    public static void Main()
    {
        Personagem personagem = new Personagem("Cafezudo");

        for (int i = 0; i < 10; i++)
        {
            personagem.PassarFase();
        }
    }
}