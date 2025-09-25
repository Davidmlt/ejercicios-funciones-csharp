namespace ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        // Hacer una función llamada “primo” que reciba un número entero y 
        // devuelva 1 si el número es primo o cero si no lo es. 
        // Hacer un programa para ingresar números. 
        // El lote corta cuando se ingresa un número cero. 
        // Informar el promedio teniendo en cuenta sólo los números primos.

        int n1, con = 0;
        float promedio = 0;

        Console.WriteLine("Ingrese un numero: ");
        n1 = int.Parse(Console.ReadLine());

        while (n1 != 0)
        {
            if (primo(n1) == 1)
            {
                con++;
                promedio += n1;
            }
            Console.WriteLine("Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
        }

        promedio /= con;
        Console.WriteLine("El promedio de numeros primos es: " + promedio.toString("0.00"));
    }
    static int primo(int a)
    {
        int r, con = 0;
        for (int x = 0; x < a; x++)
        {
            if (a % (x + 1) == 0)
            {
                con++;
            }

        }
        if (con == 2)
        {
            r = 1;
            return r;
        }
        else
        {
            r = 0;
            return r;
        }
    }
}
