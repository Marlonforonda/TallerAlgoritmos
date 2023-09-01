//1ro definir clase con su respectivo main
public class MiPrimerPuntoTaller
{
    static void Main(string[] args)
    {   // Ingresar por pantalla las coordenadas del punto 

        //2do declaración de mis variables

        double x1, x2, y1, y2, distancia;


        //3ro pedir los valores por consola
        Console.Write("Ingrese x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese y1 :");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese x2 :");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        //4to Cálculos (procesos)
        distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


        //5to imprimir los resultados (datos de salida)
        Console.Write("la distancia entre los dos puntos es: " + distancia );















    }







}