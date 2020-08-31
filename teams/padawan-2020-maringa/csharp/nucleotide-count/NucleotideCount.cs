using System;
using System.Collections.Generic;

public static class NucleotideCount
{
      public static IDictionary<char, int> Count(string sequence)
    {
        IDictionary<char, int> dicionario = new Dictionary<char, int>();
        int contadorA = 0;
        int contadorC = 0;
        int contadorG = 0;
        int contadorT = 0;

        foreach (var item in sequence)
        {
            if(item == 'A')
            {
                contadorA++;
            }
            else if (item == 'C')
            {
                contadorC++;
            }
            else if (item == 'G')
            {
                contadorG++;
            }
            else if (item =='T')
            {
                contadorT++;
            }
            else
            {
                throw new System.ArgumentException("O caracter não faz parte da sequencia genética");
            }

        }
        dicionario.Add('A', contadorA);
        dicionario.Add('C', contadorC);
        dicionario.Add('G', contadorG);
        dicionario.Add('T', contadorT);

        return dicionario;
    }
}