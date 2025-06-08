using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamiento
{
    class Program
    {
        static int conttmotos = 0, conttautos = 0, conttutilit = 0, conttcamiones = 0, recaudaciontt = 0, zona, inicio, vehiculo, hora, contvehiculos = 0;
        static int totalmotos, totalautos, totalutilit, totalcamiones;
        static int acumrmoto, acumrauto, acumrutilit, acumrcamiones;
        static int contmoto, contauto, contutilit, contcamiones,  i=1;
        static int porcmoto, porcauto,porcutilit, porccamion;
        static double valorttr, acumttvalor;
        static void Main(string[] args)
        {
            Console.WriteLine($"--BUENOS DIAS-- ¿DESEA INGRESAR UNA ZONA? ( 1 -SI-  0 -NO-)");
            zona = Convert.ToInt32(Console.ReadLine());
            while (zona != 0) 
            {
                acumrauto = 0;
                acumrcamiones=0;
                acumrmoto = 0;
                acumrutilit = 0;
                contauto = 0;
                contcamiones = 0;
                contmoto = 0;
                contutilit = 0;
                valorttr = 0;               
                Console.WriteLine($"¿INGRESAMOS LA ZONA {i++} ? ( 1 para seguir o 0 para finzalir)");
                inicio = Convert.ToInt32(Console.ReadLine());
                while (inicio != 0) 
                {
                    Console.WriteLine("--INGRESE EL VEHICULO ESTACIONADO--");
                    Console.WriteLine("-MOTOS(1)- ($100 P/H)");
                    Console.WriteLine("-AUTOS(2)- ($200 P/H)");
                    Console.WriteLine("-UTILITARIOS(3)- ($250 P/H)");
                    Console.WriteLine("-CAMIONES(4)- ($700 P/H)");
                    vehiculo = Convert.ToInt32(Console.ReadLine());
                    switch (vehiculo) 
                    {
                        case 1:
                            Console.WriteLine("LA HORA MOTO ES DE $100");
                            Console.WriteLine("CUANTAS HORAS ESTUVO EL VEHICULO ESTACIONADO");
                            hora = Convert.ToInt32(Console.ReadLine());
                            acumrmoto=(hora *100);
                            contvehiculos++;
                            contmoto++;
                            conttmotos = conttmotos + contmoto;
                            acumttvalor = acumttvalor + acumrmoto;
                            break;
                        case 2:
                            Console.WriteLine("LA HORA AUTO ES DE $200");
                            Console.WriteLine("CUANTAS HORAS ESTUVO EL VEHICULO ESTACIONADO");
                            hora = Convert.ToInt32(Console.ReadLine());
                            acumrauto = (hora * 200);
                            contvehiculos++;
                            contauto++;
                            conttautos = conttautos + contauto;
                            acumttvalor = acumttvalor + acumrauto;
                            break;
                        case 3:
                            Console.WriteLine("LA HORA UTILITARIOS ES DE $250");
                            Console.WriteLine("CUANTAS HORAS ESTUVO EL VEHICULO ESTACIONADO");
                            hora = Convert.ToInt32(Console.ReadLine());
                            acumrutilit = (hora * 250);
                            contvehiculos++;
                            contutilit++;
                            conttutilit = conttutilit + contutilit;
                            acumttvalor = acumttvalor + acumrutilit;
                            break;
                        case 4:
                            Console.WriteLine("LA HORA camion ES DE $750");
                            Console.WriteLine("CUANTAS HORAS ESTUVO EL VEHICULO ESTACIONADO");
                            hora = Convert.ToInt32(Console.ReadLine());
                            acumrcamiones = (hora * 750);
                            contvehiculos++;
                            contcamiones++;
                            conttcamiones = conttcamiones + contcamiones;
                            acumttvalor = acumttvalor + acumrcamiones;
                            break;
                        default:
                            Console.WriteLine("--EL VEHICULO SELECIONADO NO ES VALIDO-- (ELIJA OTRO) -1-MOTO -2- AUTO -3- UTILITARIOS -4- CAMIONES");
                            vehiculo = Convert.ToInt32(Console.ReadLine());
                            break;

                    }
                    Console.WriteLine("-- ¿QUIERE CARGAR OTRO VEHICULO? INGRESE 1 ,DE OTRO MODO INGRESE 0--");
                    inicio = Convert.ToInt32(Console.ReadLine());
                    
                    

                }


                valorttr = (acumrmoto + acumrauto + acumrutilit + acumrcamiones);
                
                double porcmoto = (acumrmoto / valorttr) * 100;
                double porcauto = (acumrauto / valorttr) * 100;
                double porcutilit = (acumrutilit / valorttr) * 100;
                double porccamion = (acumrcamiones / valorttr) * 100;

                Console.WriteLine($"Total recaudado en la zona es de ${valorttr}");
                Console.WriteLine($"Porcentaje de motos: {porcmoto:F2}%");
                Console.WriteLine($"Porcentaje de autos: {porcauto:F2}%");
                Console.WriteLine($"Porcentaje de utilitarios: {porcutilit:F2}%");
                Console.WriteLine($"Porcentaje de camiones: {porccamion:F2}%");

                Console.WriteLine($"-QUIERE SEGUIR CARGANDO ZONAS --1-- SI  --0-- NO");
                zona = Convert.ToInt32(Console.ReadLine());
                
                Console.ReadKey();




            }

            Console.WriteLine($"Total: {acumttvalor}");
            zona = Convert.ToInt32(Console.ReadLine());

            double totalmotos = (conttmotos / (double)contvehiculos) * 100;
                double totalautos = (conttautos / (double)contvehiculos) * 100;
                double totalutilit = (conttutilit / (double)contvehiculos) * 100;
                double totalcamiones = (conttcamiones / (double)contvehiculos) * 100;

                Console.WriteLine($"Porcentaje de motos: {totalmotos:F2}%");
                Console.WriteLine($"Porcentaje de autos: {totalautos:F2}%");
                Console.WriteLine($"Porcentaje de utilitarios: {totalutilit:F2}%");
                Console.WriteLine($"Porcentaje de camiones: {totalcamiones:F2}%");                                                  
        }
    }
}
