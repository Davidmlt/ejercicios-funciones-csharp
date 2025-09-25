namespace ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o
        //  cero si no lo es. 
        // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

        int n1 = 0, con = 0;

        for (int x = 0; x < 20; x++)
        {
            pedirDatos(ref n1);
            if (par(n1) == 1)
            {
                con++;
            }
        }
        Console.WriteLine("En total hay " + con + " numeros pares");
    }
    static void pedirDatos(ref int a)
    {
        Console.WriteLine("Ingrese un numero");
        a = int.Parse(Console.ReadLine());
    }

    static int par(int b)
    {
        int r;
        if (b % 2 == 0)
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
