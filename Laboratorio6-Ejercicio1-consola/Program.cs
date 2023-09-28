using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6_Ejercicio1_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número máximo de personas: ");
            int personas = int.Parse(Console.ReadLine());

            Console.WriteLine("=================================");
            Console.WriteLine("El numero máximo establecido es de: " + personas +
            " personas, " + "presione una tecla para comenzara contar");
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("=================================");
            Console.WriteLine("|Asistentes actuales| 0");
            Console.WriteLine("|Aforo              | 0");
            Console.WriteLine("|Máximo             | "+personas+" personas");
            Console.WriteLine("=================================");
            Console.WriteLine("Presione");
            Console.WriteLine("[i] si ingresa una persona");
            Console.WriteLine("[s] si sale una persona");
            Console.WriteLine("[x] para terminar ");
            char opcion = char .Parse(Console.ReadLine());

            int asistentes = 0;
            float porcenta = 1;
            int ingresaron = 0;
            int salieron = 0;
            int lleno = 0;
            int vacio = 1;
            if (opcion == 'i')
            {
                while (opcion == 'i')
                {
                    asistentes++;
                    porcenta = (asistentes * 100) / personas;
                    Console.Clear();
                    Console.WriteLine("=================================");
                    Console.WriteLine("|Asistentes actuales| " + asistentes);
                    Console.WriteLine("|Aforo              | " + porcenta + "%");
                    Console.WriteLine("|Máximo             | " + personas + " personas");
                    Console.WriteLine("=================================");
                    Console.WriteLine("Presione");
                    Console.WriteLine("[i] si ingresa una persona");
                    Console.WriteLine("[s] si sale una persona");
                    Console.WriteLine("[x] para terminar ");
                    opcion = char.Parse(Console.ReadLine());
                    ingresaron ++;
                    if (asistentes==personas)
                    {
                        lleno++;
                    }

                    while (opcion == 's')
                    {
                        asistentes--;
                        porcenta = (asistentes * 100) / personas;
                        Console.Clear();
                        Console.WriteLine("=================================");
                        Console.WriteLine("|Asistentes actuales| " + asistentes);
                        Console.WriteLine("|Aforo              | " + porcenta + "%");
                        Console.WriteLine("|Máximo             | " + personas + " personas");
                        Console.WriteLine("=================================");
                        Console.WriteLine("Presione");
                        Console.WriteLine("[i] si ingresa una persona");
                        Console.WriteLine("[s] si sale una persona");
                        Console.WriteLine("[x] para terminar ");
                        opcion = char.Parse(Console.ReadLine());
                        salieron ++;
                    }
                    if (asistentes == 0)
                    {
                        vacio++;
                    }

                    while (opcion == 'x')
                    {
                        Console.Clear();
                        Console.WriteLine("=================================");
                        Console.WriteLine("El programa ha terminado");
                        Console.WriteLine("=================================");
                        Console.WriteLine("Estadísticas:");
                        Console.WriteLine("----------------------------------");

                        Console.WriteLine(ingresaron+" personas ingresaron");
                        Console.WriteLine(salieron+" personas salieron");
                        Console.WriteLine(lleno +" veces se llenó el local");
                        Console.WriteLine(vacio+" Estuvo vacío ");
                        opcion++;
                        
                    }
                }
            }
            Console.ReadKey();

        }
    }
}
