using System;
using System.Diagnostics.CodeAnalysis;

public class Clock : IEquatable<Clock>
{
    private int Hora { get; }
    private int Minuto { get; }
    public Clock(int hours, int minutes)
    {
        Hora = (hours + (minutes / 60)) % 24;
        Minuto = minutes % 60;

        if (Minuto < 0)
        {
            Hora--;
            Minuto = 60 + Minuto;
        }
        if (Hora < 0)
        {
            Hora = 24 + Hora;
        }


    }


    public Clock Add(int minutesToAdd)
    {
        return new Clock(Hora, Minuto + minutesToAdd);

    }

    public Clock Subtract(int minutesToSubtract)
    {
        return new Clock(Hora, Minuto - minutesToSubtract);
    }

    public override string ToString()
    {
        return $"{Hora:0#}:{Minuto:0#}";
    }

    public bool Equals([AllowNull] Clock other)
    {
        if (Hora == other.Hora && Minuto == other.Minuto)
        {
            return true;
        }
        else
        {
            return false;
        }



    }
}