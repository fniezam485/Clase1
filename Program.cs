// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World DAM2!");
int num1 = 10;
int num2 = 20;
int suma = num1 + num2;
Console.WriteLine("La suma de " + num1 + " y " + num2 + " es: " + suma);

// Leer dos valores desde consola e imprimir la suma
int num3;
int num4;
Console.Write("Introduce el primer número: ");
string num3String = Console.ReadLine();
num3 = Convert.ToInt32(num3String);
Console.Write("Introduce el segundo número:");
num4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("La suma de " + num3 + " y " + num4 + " es: " + (num3 + num4));

static int Sumar(int a, int b)
{
    return a + b;
}   