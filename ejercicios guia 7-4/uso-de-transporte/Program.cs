using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uso_de_transporte
{
    class Program
    {
        static int encuestadores,encuesta,transporte,contencuestas=0,contencuestastt,km,acumkmbici,acumkmmoto,conttbici,conttauto,conttmoto,conttbus;
        static int contbici , contauto , contmoto , contbus;
        static int prombici, prommoto;
        static void Main(string[] args)
        {
            Console.WriteLine("¿cuantos encuestadores son?");
            encuestadores = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < encuestadores; i++) 
            {
                contbici = 0;
                contauto = 0;
                contmoto = 0;
                contbus = 0;
                prombici = 0;
                prommoto = 0;

                contencuestas = 0;
                Console.WriteLine($"encuestador {i+1} ¿quieres realizar la primera encuesta? ( 1 para seguir 0 para finalizar)");
                encuesta = Convert.ToInt32(Console.ReadLine());
                while (encuesta != 0) 
                {
                    Console.WriteLine($"El encuestador {i + 1} te pregunta");
                    Console.WriteLine("Que tipo de transporte usa diario?");
                    Console.WriteLine("Auto presione -1-");
                    Console.WriteLine("Moto presione -2-");
                    Console.WriteLine("Bicicleta presione -3-");
                    Console.WriteLine("AutoBus presione -4-");
                    transporte = Convert.ToInt32(Console.ReadLine());
                    switch (transporte) 
                    {
                        case 1:
                            contauto++;
                            contencuestas++;
                            contencuestastt = contencuestastt + contencuestas;
                            Console.WriteLine("¿cual es la distancia en la que usas diariamente el medio de transporte en km?");
                            km = Convert.ToInt32(Console.ReadLine());
                            conttauto = conttauto + contauto;
                            break;
                        case 2:
                            contmoto++;
                            contencuestas++;
                            contencuestastt = contencuestastt + contencuestas;
                            Console.WriteLine("¿cual es la distancia en la que usas diariamente el medio de transporte en km?");
                            km = Convert.ToInt32(Console.ReadLine());
                            acumkmmoto = acumkmmoto + km;
                            conttmoto = conttmoto + contmoto;
                            break;
                        case 3:
                            contbici++;
                            contencuestas++;
                            contencuestastt = contencuestastt + contencuestas;
                            Console.WriteLine("¿cual es la distancia en la que usas diariamente el medio de transporte en km?");
                            km = Convert.ToInt32(Console.ReadLine());
                            acumkmbici = acumkmbici + km;
                            conttbici = conttbici + contbici;
                            break;
                        case 4:
                            contbus++;
                            contencuestas++;
                            contencuestastt = contencuestastt + contencuestas;
                            Console.WriteLine("¿cual es la distancia en la que usas diariamente el medio de transporte en km?");
                            km = Convert.ToInt32(Console.ReadLine());
                            conttbus = conttbus + contbus;
                            break;
                        default:
                            Console.WriteLine("el numero elejido no coincide con un medio de transporte,porfabor elija otro");
                            transporte = Convert.ToInt32(Console.ReadLine());
                            break;


                    }
                    Console.WriteLine("quieres encuestar a otra persona? ( 1 para seguir o 0 para finalizar)");
                    encuesta = Convert.ToInt32(Console.ReadLine());
                    


                    
                }
                Console.WriteLine($"La cantidad de encuestas que realizo el º{i + 1} cuestador fue de {contencuestas} encuestas !");
                Console.WriteLine($"La cantidad de persona que usan bici en el º{i + 1} encuestador es de {contbici} bicicletas");
                Console.WriteLine($"La cantidad de persona que usan auto en el º{i + 1} encuestador es de {contauto} automoviles");
                Console.WriteLine($"La cantidad de persona que usan autobus en el º{i + 1} encuestador es de {contbus} autobuses");

                if (contbici > 0)
                {
                    prombici = acumkmbici / contbici;
                }

                if (contmoto > 0)
                {
                    prommoto = acumkmmoto / contmoto;
                }
                Console.WriteLine($"El Promedio de km recorridos en bici de el º{i + 1} encuestador es de {prombici} kmetros");
                Console.WriteLine($"El Promedio de km recorridos en moto de el º{i + 1} encuestador es de {prommoto} kmetros");

            }
            Console.WriteLine($"La cantidad de encuestas que realizaron los {encuestadores} encuestadores fue de {contencuestastt} encuestas");
            int bici, auto, bus;
            bici = (conttbici * 100) / contencuestastt;
            auto = (conttauto * 100) / contencuestastt;
            bus = (conttbus * 100) / contencuestastt;
            Console.WriteLine($"El porcentaje de personas que utilizan bicicleta es {bici} bicleta/s");
            Console.WriteLine($"El porcentaje de personas que utilizan automovil es {auto} auto/s ");
            Console.WriteLine($"El porcentaje de personas que utilizan autobus es {bus} autobus/es ");

        }
    }
}
