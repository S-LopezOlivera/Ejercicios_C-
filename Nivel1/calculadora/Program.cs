using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
 Console.WriteLine("EJERCICIO 1");
            int n1, n2, resultado;

//Console.WriteLine("n1 tiene: " +n1);

            Console.WriteLine("Ingrese un numero");
           n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
           n2 = int.Parse(Console.ReadLine());

           resultado = n1 + n2;

           Console.WriteLine("El resulto es: " + resultado);

Console.WriteLine("EJERCICIO 2");

           int num, cubo;

           Console.WriteLine("Ingrese un numero");
           num = int.Parse(Console.ReadLine());

           cubo = num * num * num;
 
           Console.WriteLine("El cubo del numero ingresado es: " + cubo);

Console.WriteLine("EJERCICIO 3");

           int kms, velocidad, tiempo;

           Console.WriteLine("Ingrese la distncia entre ciudades: ");
           kms = int.Parse(Console.ReadLine()); //kms=float.Parse(Console.ReadLine())
           Console.WriteLine("Ingrese la velocidad del automovil: ");
           velocidad = int.Parse(Console.ReadLine());

           tiempo = kms/velocidad;

           Console.WriteLine("El tiempo para recorrer entre ciudades sera: " + tiempo);//"el teipo sera de: " +tiempo.ToString(0.00)+ # horas"

Console.WriteLine("EJERCICIO 4");

        int SFi, TFa, total, promedio;
        SFi = 15000;

        Console.WriteLine("Ingrese el total facturado");
           TFa = int.Parse(Console.ReadLine());
           
        promedio = (SFi + TFa) /100 *5; //(SFi + TFa) * 0.005  asi es mas directo o 
        total = SFi + TFa + promedio;

        Console.WriteLine("El sueldo total es de : " + total);

Console.WriteLine("EJERCICIO 5");
        int no1, no2, no3, prom;

        Console.WriteLine("Ingrese la primer nota: ");
        no1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la segund nota: ");
        no2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la tercer nota: ");
        no3 = int.Parse(Console.ReadLine());

        prom = (no1 + no2 + no3)/3;

        Console.WriteLine("El promedio de notas es de : " + prom);

        }
    }
}
