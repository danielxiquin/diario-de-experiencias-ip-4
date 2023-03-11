using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");

            

            Console.WriteLine("Ingrese un numero entero");

            try
            {
                int x = Convert.ToInt32(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("Su numero entero es 0");
                }
                else if (x > 0)
                {
                    Console.WriteLine("Su numero es positivo");
                }
                else
                {
                    Console.WriteLine("Su numero es negativo");
                }
            }
            catch(Exception ex) { 
                
                Console.WriteLine("Debe ingresar un numero valido"+ ex.Message);


            }


            Console.WriteLine("Ejercicio 2");



            Console.WriteLine("Ingrese el numero del dia");

            int dia = Convert.ToInt32(Console.ReadLine());

            if (dia >= 1 && dia <= 7)
            {
                if (dia == 1)
                {
                    Console.WriteLine("DIA: Lunes");
                }
                else if (dia == 2)
                {
                    Console.WriteLine("DIA: Martes");
                }
                else if (dia == 3)
                {
                    Console.WriteLine("DIA: Miercoles");

                }
                else if (dia == 4)
                {
                    Console.WriteLine("DIA: Jueves");
                }
                else if (dia == 5)
                {
                    Console.WriteLine("DIA: Viernes");
                }
                else if (dia == 6)
                {
                    Console.WriteLine("DIA: Sabado");

                }
                else if (dia == 7)
                {
                    Console.WriteLine("DIA: Domingo");
                }

            }
            else
            {
                Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
            }


                //TAREA PROBLE NO.2

                Console.WriteLine("Problema No.2");

            Console.WriteLine("Oscar Daniel Xiquin Cumes - 1118423");
            double num;
            double billete100, billete50, billete20, billete10, billete5, moneda1, moneda25, moneda1c;


            Console.WriteLine("Ingrese un numero");
            num = Convert.ToDouble(Console.ReadLine());

            if (num >= 0 && num <= 999999)
            {
                billete100 = (int)num / 100;
                num = num - (billete100 * 100);
                
                billete50 = (int)num / 50;
                num = num - (billete50 * 50);
                
                billete20 = (int)num / 20;
                num = num - (billete20 * 20);


                billete10 = (int)num / 10;
                num = num - (billete10 * 10);


                billete5 = (int)num / 5;
                num = num - (billete5 * 5);

                moneda1 = (int)num / 1;
                num = num - (moneda1*1);

                moneda25= (int)(num / 0.25);
                num = num - (float)(moneda25 * 0.25);

                moneda1c = (int)Math.Round(num / 0.01);
                num = num - (float)(moneda1c * 0.01);

                Console.WriteLine(billete100 + " de Q.100");
                Console.WriteLine(billete50 + " de Q.50");
                Console.WriteLine(billete20 + " de Q.20");
                Console.WriteLine(billete10 + " de Q.10");
                Console.WriteLine(billete5 + " de Q.5");
                Console.WriteLine(moneda1 + " de Q.1");
                Console.WriteLine(moneda25 + " de 25 centavos");
                Console.WriteLine(moneda1c + " de 1 centavo");

            

            }
         









        }
    }
}
