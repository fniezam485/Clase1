using System;

public class Validador
{
	public delegate bool ValidarNumero(int x);
	
	public static bool EsNegativo(int x)
	{
		bool resultado = x < 0;
		Console.WriteLine($"El resultado de la funcion EsNegativo para {x} es: {resultado}");
        return resultado;
    }
	public static bool EsPositivo(int x)
	{
		bool resultado = x > 0;
		Console.WriteLine($"El resultado de la funcion EsPositivo para {x} es: {resultado}");
		return resultado;
    }

	public static bool EsPar(int x)
	{
		bool resultado = x % 2 == 0;
		Console.WriteLine($"El resultado de la funcion EsPar para {x} es: {resultado}");
		return resultado;
	}

	public static bool MayorACero(int x)
	{
		bool resultado = x > 0;
		Console.WriteLine($"El resultado de la funcion MayorACero para {x} es: {resultado}");
		return resultado;
    }
    public static bool Ejecutar(ValidarNumero validate, int x )
	{		
		bool resultado = validate(x);
        if (resultado)
		{
			Console.WriteLine($"El numero {x} cumple con las validaciones");
		}
		else
		{
			Console.WriteLine($"El numero {x} NO cumple con las validaciones");
        }
		return resultado;
    }
}