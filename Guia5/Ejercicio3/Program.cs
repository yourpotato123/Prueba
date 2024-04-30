using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///float prom = 0;                                     ///inicie promedio con 0 ya que es acumulador, es float por ser numero real
            float prom, promayor, promenor;                           ///inicie promedio mayor y menor, por ser numero real
            int lib, libmayor, libmenor;                        ///inicie libreta, libreta mayor y libreta menor, como integer por ser numero natural
            string nom, nomayor, nomenor;                       ///inicie nombre, nombre mayor y nombre menor, como string por ser cadena
            promayor = 0;
            promenor = 0;
            libmenor = 0;
            libmayor = 0;
            nomayor = "";
            nomenor = "";
            
            for (int i = 0; i < 10; i = i+1)
            {
                Console.WriteLine("Ingrese Nombre, Libreta, y Promedio del Alumno");
                nom = (Console.ReadLine());
                lib = Convert.ToInt16(Console.ReadLine());
                prom = Convert.ToSingle(Console.ReadLine());

                if (i == 0)
                {
                    promayor = prom;
                    nomayor = nom;
                    libmayor = lib;
                    promenor = prom;
                    nomenor = nom;
                    libmenor = lib;
                }
                else
                {
                    if (prom<promenor)
                    {
                        nomenor = nom;
                        libmenor = lib;
                        promenor = prom;
                    }
                    if (prom>promayor)
                    {
                        nomayor = nom;
                        libmayor = lib;
                        promayor = prom;
                    }
                }
            }
            Console.WriteLine("Promedio Mayor: \n Alumno: {0}. \n Libreta: {1}. \n Promedio: {2}.", nomayor, libmayor, promayor);
            Console.WriteLine("Promedio Menor: \n Alumno: {0}. \n Libreta: {1}. \n Promedio: {2}.", nomenor, libmenor, promenor);
        }
    }
}
