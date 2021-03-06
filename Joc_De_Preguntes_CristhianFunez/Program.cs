﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc_De_Preguntes_CristhianFunez
{
    class Program
    {
        static void Main()
        {
            Console.Clear();
            string tema;
            Console.WriteLine("Juego de preguntas");
            //pas 1
            tema = escollirTema();
            //pas 2
            string[] arrayPreguntes = creaArray(tema, '|');
            //pas 2 plus
            arrayPreguntes = aleatorizaArray(arrayPreguntes);
            //pas 3
            ferPreguntes(arrayPreguntes);


        }
        //pas 1
        //en aquet metode es on estan guardades les preguntes amb el seu respectiu tema
        //en format "pregunta;respostaCorrecta;respostaIncorrecta;respostaIncorrecta;respostaIncorrecta;"
        static string escollirTema()
        {
            string tema="", opcio;
            Console.WriteLine("escoge una opcio o prem 'Q' per surti");
            Console.WriteLine("1 - Geografia");
            Console.WriteLine("2 - Arte y literatura");
            Console.WriteLine("3 - Micelánea");
            do
            {
                opcio = Console.ReadLine();
                switch (opcio)
                {
                    case "1":
                        tema =
                            "¿Dónde está la ciudad de Ho Chi Minh?;Vietnam;Rusia;Colombia;China;|" +
                            "¿En que país se encuentra el pico más alto de américa?;Argentina;Perú;Colombia;Estados Unidos;|" +
                            "¿En qué lugar nace el Río Duero?;Picos de Urbión;Sierra Nevada;Sierra de Cazorla;Sierra de la Demanda;|" +
                            "¿Cuántos kilómetros mide el rió Amazonas;6400;4800;6650;7090;|" +
                            "¿Cual es la cascada más ancha del mundo?;Las Cataratas Victoria;El Salto de Ángel;Las Cataratas del Niágara;La Catarata de Gocta;|";
                        break;
                    case "2":
                        tema =
                            "¿Quién escribió Fábula de polifemo y Galatea ?; Luis de Góngora; Miguel de Cervantes; Tirso de Molina; Antonio Machado;|" +
                            "Título de la segunda parte de 'El Señor de los Anillos'; Las dos torres; El regreso a la Tierra Media; La comunidad del anillo; El retorno del Rey;|" +
                            "¿Cúal fu el título original de Las Novelas Ejemplares de Miguel de Cervantes ?; Novelas ejemplares de honestísimo entretenimiento; Novelísimas; Novelas varias de entretenimiento; Novelas ejemplares que de ejemplo sirvan;|" +
                            "¿Qué representa Romeo y Julieta, los personajes de Shakespeare?; Amor; Duda; Vergüenza; Hipocresía;|" +
                            "Famosa obra de Mary Shelley; Frankenstein; El Retrato de Dorian Gray; El resplandor; Drácula;|";
                        break;
                    case "3":
                        tema =
                            "¿Quién era Minerva según la mitología romana ?; Diosa de la Sabiduría; Diosa de la Tierra; Diosa de la Caza; Diosa de la Belleza;|" +
                            "¿Qué es patidifuso ?; Paralizado por el asombro; Trabajador incansable; Constante, tenaz; Persona entregada al vicio;|" +
                            "¿Qué significa el dicho: Más vale maña que fuerza ?; Que se hacen mejor las cosas con inteligencia que con violencia; Que es mejor hacer las cosas rapido y bien; Que la gente forzuda es tonta; Que la fuerza te acompañe... es una suerte;|" +
                            "¿Qué significa el dicho: Aquí hay gato encerrado?; Desconfía, algo no está claro; Que lo que se hace con gusto no molesta; Que al final siempre se paga las consecuencias de lo hecho; Que hay que aprovechar el día a día y vivir el presente;|" +
                            "¿En qué país es típica la Tortilla de Patata ?; España; Brasil; Canadá; Colombia;|";
                        break;
                    case "Q":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opcio invalida, torna a introduir una opcio");
                        opcio = "";
                        break;
                }
            } while (opcio == "");
            return tema;
        }
        //pas 2
        //escollit el tema, aquet metode carrega el string on es troban les preguntes
        //i crea una array, on cada element(pregunta) ocupa un lloc
        static string[] creaArray(string tema, char separador)
        {
            string linia;
            int cont = 0;
            //conta quants separadors hi ha
            //per calcula extencio de la array
            for(int i = 0; i < tema.Length; i++)
            {
                if (tema[i] == separador)
                    cont++;
            }
            //crea la array
            string[] preguntesArray = new string[cont];
            //aquet "for" posa cada element en un lloc de la array
            for (int i = 0; i < cont; i++)
            {
                linia = tema.Substring(0, tema.IndexOf(separador));
                tema = tema.Remove(0, tema.IndexOf(separador) + 1);
                preguntesArray[i] = linia;
            }
            
            return preguntesArray;
        }
        //pas 2, plus meu
        //per evitar que les preguntes surtin sempre en el ordre que les vaix
        //escriure, aquet metode aleatoritza els elements de la array
        static string[] aleatorizaArray(string[] preguntesArray)
        {
            int n = preguntesArray.Length;
            Random rnd = new Random();
            for (int i = n - 1; i > 0; i--)
            {
                int j = rnd.Next(0, i);
                string temp = preguntesArray[i];
                preguntesArray[i] = preguntesArray[j];
                preguntesArray[j] = temp;
            }
            return preguntesArray;
        }
        //pas 3
        // a priori, mostra la pregunta, mostra les opcions
        // i escrius la opcio que creus correcta
        static void ferPreguntes(string[] arrayPreguntes)
        {
            int preguntesFetes = 0;
            string opcio = "", enunciat, respostaCorrecta;
            Console.WriteLine("Escull la resposta correcta o prem 'Q' per surti");
            do
            {
                // crea una nova array, on el anunciat i cada opcio de la pregunta ocupa un lloc
                string[] Opcions = creaArray(arrayPreguntes[preguntesFetes], ';');

                //declaro el enunciat i la resposta correcta
                enunciat = Opcions[0];
                respostaCorrecta = Opcions[1];

                //elimino el enunciat de la array, per despres aleatoritza
                Opcions = eliminaEnunciat(Opcions);

                //aleatoritza la array de opcions perque la resposta sigui dinamica, i no sempre sigui la resposta "1","1","1"...
                //perque per defecte la resposta correcta la opcio "1"
                Opcions = aleatorizaArray(Opcions);
                //diu el anunciat
                Console.WriteLine(enunciat);
                for(int i = 0; i < Opcions.Length; i++)
                {
                    //diu les opcions
                    Console.WriteLine("{0} ) {1}",i+1,Opcions[i]);
                }
                //escrius la resposta
                opcio = Console.ReadLine();
                try
                {
                    if(Opcions[(Convert.ToInt32(opcio))-1] == respostaCorrecta)
                        Console.WriteLine("Correcte");
                    else
                        Console.WriteLine("Incorrecte");
                }
                catch { if (opcio == "Q")
                        Main();
                else
                        Console.WriteLine("Incorrecta");
                }
                preguntesFetes++;
            } while (opcio != "Q" && preguntesFetes < arrayPreguntes.Length);
            Main();
        }
        //metode del pas 3
        static string[] eliminaEnunciat(string[] Opcions)
        {
            string[] opcionSenseAnunciat = new string[Opcions.Length - 1];
            for(int i = 0; i < Opcions.Length - 1; i++)
            {
                opcionSenseAnunciat[i] = Opcions[i + 1];
            }
            return opcionSenseAnunciat;
        }
    }
}
