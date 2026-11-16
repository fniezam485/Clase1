// See https://aka.ms/new-console-template for more information

//Ejecución de la función principal
bool esValido = true;
do
{
    Console.Write("\nIngrese un número entero: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Validador.ValidarNumero validar = Validador.EsPositivo;
    validar += Validador.EsPar;
    validar += delegate (int numero)
    {
        bool resultado = numero % 3 == 0;
        Console.WriteLine($"El resultado de la función anónima para {numero} es divisible por 3: {resultado}");
        return resultado;
    };

    esValido = Validador.Ejecutar(validar, x);
} while (!esValido);


Operacion op = Calculadora.Restar;


//EjecutarOperacion(op, 10, 20);


// Definiciones
// Funciones
delegate int Operacion(int a, int b);


// Clases
class Calculadora
{
    public static int Sumar(int a, int b)
    {
        int suma = a + b;
        return suma;
    }

    public static int Restar(int a, int b)
    {
        int resta = a - b;
        Console.WriteLine($"Resta: {a} - {b} = {resta}");
        return resta;
    }

}


