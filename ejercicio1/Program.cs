namespace ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función llamada “producto” que reciba dos números enteros 
        // y que devuelva el producto de ambos. Luego hacer un programa que pida el precio de un artículo
        // y la cantidad vendida y muestre por pantalla el monto total a pagar. Usar la función.

        float n1, n2, resultado;

        Console.WriteLine("Ingrese el precio del articulo: ");
        n1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese la cantidad vendida: ");
        n2 = float.Parse(Console.ReadLine());

        resultado = producto(n1, n2);
        Console.WriteLine("El monto a pagar es: " + resultado);
    }
    static float producto(float a, float b)
    {
        float r;
        r = a * b;
        return r;
    }

}
