using System;
using System.Collections.Generic;

public class Robot
{
    private readonly Random _random = new Random();
    private static HashSet<string> _names = new HashSet<string>();
    public string Nome { get; private set; }



    public Robot()
    {
        Reset();
    }


    public void Reset()
    {
        Nome = Gerador();
    }

    public string Gerador()
    {
        string nome = "";
        do
        {

            for (int i = 0; i < 5; i++)
            {
                nome += (i < 2) ? ((char)_random.Next(65, 90)).ToString() : _random.Next(0, 9).ToString();
            }
        }
        while (!Unico(nome));
        return nome;
    }

    public bool Unico(string name)
    {
        return _names.Add(name);
    }
}