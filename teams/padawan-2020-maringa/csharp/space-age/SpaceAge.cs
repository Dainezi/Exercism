using System;

/// <summary>
/// Given an age in seconds, calculate how old someone would be on:

//Earth: orbital period 365.25 Earth days, or 31557600 seconds
//Mercury: orbital period 0.2408467 Earth years
//Venus: orbital period 0.61519726 Earth years
//Mars: orbital period 1.8808158 Earth years
//Jupiter: orbital period 11.862615 Earth years
//Saturn: orbital period 29.447498 Earth years
//Uranus: orbital period 84.016846 Earth years
//Neptune: orbital period 164.79132 Earth years
//So if you were told someone were 1,000,000,000 seconds old, you should be able to say that they're 31.69 Earth-years old.

/// </summary>
public class SpaceAge
{
    readonly double segundos;
    public SpaceAge(int seconds)
    {
        segundos = seconds;
    }

    public double OnEarth()
    {
        return segundos / 31557600;
    }

    public double OnMercury()
    {
        return OnEarth() / 0.2408467;
    }

    public double OnVenus()
    {
        return OnEarth() / 0.61519726;
    }

    public double OnMars()
    {
        return OnEarth() / 1.8808158;
    }

    public double OnJupiter()
    {
        return OnEarth() / 11.862615;
    }

    public double OnSaturn()
    {
        return OnEarth() / 29.447498;
    }

    public double OnUranus()
    {
        return OnEarth() / 84.016846;
    }

    public double OnNeptune()
    {
        return OnEarth() / 164.79132;
    }
}