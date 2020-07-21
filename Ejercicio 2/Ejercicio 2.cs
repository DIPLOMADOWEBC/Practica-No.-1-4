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
            #region Ejercicio 2: Desarrollar una clase que represente un punto en el plano y tenga los siguientes metodos: Cargar los valores de x e y, imprimir en que cuadrate se encuentra dicho punto
            /*
              Desarrollar una clase que represente un punto en el plano y tenga los siguientes metodos: Cargar los valores de x e y, imprimir en que cuadrate se encuentra dicho punto
              (concepto matematico, primer cuadrante si x e y son positivas, si x>0 e y>0 segundo cuadrante, etc etc)
             */
            Punto Plano = new Punto();
            Plano.CargarXY();
            Plano.Impirmir();
            Plano.Cuadrante();
            #endregion

        }
        class Punto
        {
            //Atributos
            private int ejeX, ejeY;
            private double sueldo, impuesto;

            //Constr| Metodo de carga
            /*
            public Punto(int x, int y)
            {
                ejeX = x;
                ejeY = y;
            }
            */
            //Cargar
            public void CargarXY()
            {
                Console.WriteLine("CUADRANTES EJE X e Y\n");
                Console.Write("EJE X: ");
                ejeX = int.Parse(Console.ReadLine());
                Console.Write("EJE Y: ");
                ejeY = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
            }
            //Imprimir
            public void Impirmir()
            {
                Console.WriteLine("DATOS");
                Console.WriteLine("EJE X: {0}", ejeX);
                Console.WriteLine("EJE Y: {0}", ejeY);
                Console.WriteLine("\n");
            }
            //Determinar cuadrante
            public void Cuadrante()
            {
                Console.WriteLine("RESULTADOS");
                /*
                    x e y
                    Cuadrante1: +,+
                    Cuadrante2: -,+
                    Cuadrante3: -,-
                    Cuadrante4: +,-
                 */
                if (ejeX > 0 && ejeY > 0)
                    Console.WriteLine("*** EL PUNTO X({0}) e Y({1}) ESTAN EN EL PRIMER CUADRANTE ***", ejeX, ejeY);
                else if (ejeX < 0 && ejeY > 0)
                    Console.WriteLine("*** EL PUNTO X({0}) e Y({1}) ESTAN EN EL SEGUNDO CUADRANTE ***", ejeX, ejeY);
                else if (ejeX < 0 && ejeY < 0)
                    Console.WriteLine("*** EL PUNTO X({0}) e Y({1}) ESTAN EN EL TERCER CUADRANTE ***", ejeX, ejeY);
                else if (ejeX > 0 && ejeY < 0)
                    Console.WriteLine("*** EL PUNTO X({0}) e Y({1}) ESTAN EN EL CUARTO CUADRANTE ***", ejeX, ejeY);

                Console.ReadKey();

            }
        }
    }
}
