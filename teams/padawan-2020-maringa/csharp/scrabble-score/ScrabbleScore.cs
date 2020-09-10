using System;
using System.Linq;
using System.Text.RegularExpressions;

/// <summary>
/// 
/// Introduction
///Given a word, compute the scrabble score for that word.
///
///Letter Values
///You'll need these:
///
///Letter Value
///A, E, I, O, U, L, N, R, S, T       1
///D, G                               2
///B, C, M, P                         3
///F, H, V, W, Y                      4
///K                                  5
///J, X                               8
///Q, Z                               10
///Examples
///"cabbage" should be scored as worth 14 points:
///
///3 points for C
///1 point for A, twice
///3 points for B, twice
///2 points for G
///1 point for E
///And to total:
///
///3 + 2*1 + 2*3 + 2 + 1
///= 3 + 2 + 6 + 3
///= 5 + 9
///= 14
/// </summary>
public static class ScrabbleScore
{

    public static int Score(string input)
    {
        input = input.ToUpper();

        var grupo1 = new Regex(@"{|A|E|I|O|U|L|N|R|S|T|}");
        var grupo2 = new Regex(@"{|D|G|}");
        var grupo3 = new Regex(@"{|B|C|M|P|}");
        var grupo4 = new Regex(@"{|F|H|V|W|Y|}");
        var grupo5 = new Regex(@"{|K|}");
        var grupo8 = new Regex(@"{|J|X|}");
        var grupo10 = new Regex(@"{|Q|Z|}");

        int soma = 0;

        if (grupo1.IsMatch(input))
        {
            int multiplicador = grupo1.Matches(input).Count();
            soma = soma + (1 * multiplicador);
        }

        if (grupo2.IsMatch(input))
        {
            int multiplicador = grupo2.Matches(input).Count();
            soma = soma + (2 * multiplicador);
        }
        if (grupo3.IsMatch(input))
        {
            int multiplicador = grupo3.Matches(input).Count();
            soma = soma + (3 * multiplicador);
        }
        if (grupo4.IsMatch(input))
        {
            int multiplicador = grupo4.Matches(input).Count();
            soma = soma + (4 * multiplicador);
        }
        if (grupo5.IsMatch(input))
        {
            int multiplicador = grupo5.Matches(input).Count();
            soma = soma + (5 * multiplicador);
        }
        if (grupo8.IsMatch(input))
        {
            int multiplicador = grupo8.Matches(input).Count();
            soma = soma + (8 * multiplicador);
        }
        if (grupo10.IsMatch(input))
        {
            int multiplicador = grupo10.Matches(input).Count();
            soma = soma + (10 * multiplicador);
        }

        return soma;
    }
}