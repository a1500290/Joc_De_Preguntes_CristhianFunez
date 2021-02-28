using System;
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
    }
}
