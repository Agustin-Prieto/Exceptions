using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int opcion;
            string dividendo;
            string divisor;

            Logic logic = new Logic();
            NewException newException = new NewException();

            Console.WriteLine("Elije una opcion");
            Console.WriteLine("1 - Excepción division por cero");
            Console.WriteLine("2 - Dividir");
            Console.WriteLine("3 - Generar excepción");
            Console.WriteLine("4 - Excepción personalizada");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            if (opcion == 1)
            {
                DividirPorCero();
            }
            else if (opcion == 2)
            {
                Console.WriteLine("Ingrese el dividendo");
                dividendo = Console.ReadLine();

                Console.WriteLine("Ingrese el divisor");
                divisor = Console.ReadLine();

                Dividir(dividendo, divisor);

            }
            else if (opcion == 3)
            {
                try
                {
                    logic.ThrowEx();
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("{0}: {1}", Ex.GetType(), Ex.Message);
                }
            }
            else if (opcion == 4)
            {
                try
                {
                    logic.NewEx();
                }
                catch (NewException NewEx)
                {
                    Console.WriteLine(NewEx.Message);
                }
            }

            Console.ReadLine();
        }

        static void DividirPorCero()
        {
            int a = 1;
            int b = 0;
            try
            {
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException divideByZero)
            {
                Console.WriteLine(divideByZero);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.GetType());
            }
            finally
            {
                Console.WriteLine("Finalizo");
            }
        }

        static void Dividir(string a, string b)
        {
            try
            {
                int divid = Convert.ToInt32(a);
                int divis = Convert.ToInt32(b);
                Console.WriteLine(divid / divis);
            }
            catch (DivideByZeroException Ex)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero!");
                Console.WriteLine(Ex);
            }
            catch (FormatException)
            {
                Console.WriteLine("Seguro Ingreso una letra o no ingreso nada!");
            }
            catch (Exception Ex)
            {
                Console.WriteLine("{0}:{1}", Ex.GetType(), Ex.Message);
            }
        }
    }
}
