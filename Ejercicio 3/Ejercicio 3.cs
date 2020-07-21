using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_No._1_4
{
    class Program
    {
        static int antiguMay;
        static string nombreMay;
        static void Main(string[] args)
        {
            #region Ejercicio 2: 
            /*
              Plantear una clase Club y otra clase Socio. 
              
              * * La clase socio debe tener los siguientes atributos privados:
              -nombre
              -antiguedad en el club(en anios)
              -- En el constructor pedir la carga del nombre y la antiguedad.
              
             * * La clase Club debe tener como atributos 3 objetos de la clase socio.
              -Difinir una responsabilidad para imprimir el nombre del socio con mmayor antiguedad en el club


             */
            Club club = new Club();
            club.ImprimirSocioMayor();
            #endregion

        }
        class Club
        {

            Socio socio1 = new Socio("Daniel", 7);
            Socio socio2 = new Socio("Jose", 11);
            Socio socio3 = new Socio("Pedro", 3);




            class Socio
            {
                //Atributos]
                private string nombre;
                private int antiguedad;



                //Constr| Metodo de carga
                public Socio(string nom, int antig)
                {
                    nombre = nom;
                    antiguedad = antig;

                    //Verificar mayor
                    SocioMayor(nom, antig);

                }



                public void SocioMayor(string nom, int antig)
                {
                    //int ant = Parsocio.antiguedad;
                    if (antiguMay < antig)
                    {
                        nombreMay = nom;
                        antiguMay = antig;

                    }
                }
            }
            public void ImprimirSocioMayor()
            {
                Console.WriteLine("CLUB DE SOCIOS\n");
                Console.WriteLine("EL SOCIO CON MAYOR ANTIGUEDAD ES: {0} CON: {1}AÑO", nombreMay, antiguMay);
                Console.ReadKey();
            }

        }
    }
}
