using System;

public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception();
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        try
        {
            var valor = int.Parse(input);
            return valor;
        }
        catch
        {
            return null;
        }
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        bool validacao = int.TryParse(input, out result);
        if (validacao)
        {
            result = int.Parse(input);
            return true;
        }
        else
        {

            result = 0;
            return false;
        }
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        try
        {
            throw new Exception();
        }
        catch
        {
            disposableObject.Dispose();
            throw;
        }
    }
}
