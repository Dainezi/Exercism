using System;

public static class Leap
{
    /// <summary>
    /// on every year that is evenly divisible by 4
    /// except every year that is evenly divisible by 100
    /// unless the year is also evenly divisible by 400
    /// </summary>
    /// <param name="year"></param>
    /// <returns></returns>
    public static bool IsLeapYear(int year=1800)
    {
        bool validacao = false;
        if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
        {
            validacao = true;
        }
        return validacao;
    }
}


