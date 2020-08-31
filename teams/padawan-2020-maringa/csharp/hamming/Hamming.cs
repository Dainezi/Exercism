using System;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        int diference = 0;
        if (firstStrand.Length == secondStrand.Length)
        {
            for (int i = 0; i < firstStrand.Length; i++)
            {
                if (firstStrand[i] != secondStrand[i])
                {
                    diference += 1;
                }
            }
        }
        else
        {
            throw new System.ArgumentException("A Sequência tem que ser de tamanhos iguais");
        }
        return diference;
    }
}