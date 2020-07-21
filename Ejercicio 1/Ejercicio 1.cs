using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_No._1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1: Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo. Confeccionar los metodos para la carga, otro para imprimir sus datos por ultimo uno que imprima un mensaje si debe pagar impuestos(si el sueldo supera 30,000)

            Empleado empl = new Empleado("Pedro", 35000);
            empl.Impirmir();
            empl.Impuesto();
            Console.ReadKey();
            #endregion


        }
        class Empleado
        {
            //Atributos
            private string nombre;
            private double sueldo, impuesto;

            //Constr| Metodo de carga
            public Empleado(string nom, double suel)
            {
                nombre = nom;
                sueldo = suel;
            }
            //Imprimir
            public void Impirmir()
            {
                Console.WriteLine("*** DATOS EMPLEADO ***\n");
                Console.WriteLine("NOMBRE: {0}", nombre);
                Console.WriteLine("SUELDO: {0}", sueldo);
                Console.WriteLine("");
            }
            //Verificar si aplica impuesto
            public void Impuesto()
            {
                if (sueldo > 30000)
                {
                    impuesto = (sueldo * 0.18);
                    Console.WriteLine("SU SALARIO DE: {0} DEBE PAGAR UN IMPUESTO DE: {1}", sueldo, impuesto);
                }
            }
        }
    }
}
