using System;
using System.Collections.Generic;

using System.Text.RegularExpressions;

// Referencia https://youtu.be/CRwWHAjKvVY
namespace Programa7_ExprecionRegular
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> nombre = new List<string>();
            // Metodo 1
            Titulo("Metodo 1");
            System.String texto = "La casa del casamentero";
            string exp = "casa";

            MatchCollection encontrar = Regex.Matches(texto,exp);
            foreach (Match e in encontrar) {
                Console.WriteLine(e);
            }
            Linias();

            // Metodo 2
            // Busca la palabra espesifica
            Titulo("Metodo 2");
            texto = "El estudiante es un casa nova en la escuela";
            exp = " casa ";// exactamente como esta en la expresion
            Regex regex = new Regex(exp);// intaciamos el Obj con la expresion 
            encontrar = regex.Matches(texto);
            foreach (Match e in encontrar) {
                Console.WriteLine(e);
            }
            Linias();

            // Uso de . significa cualquier caracter
            // cabal, campeon, academico
            Titulo("Uso de . Significa cualquier caracter");
            string[] palabra = { "cabal", "campeon", "academico" };
            texto = "Saludos al mas ";
            exp = "ca.";
            MatcheExp(texto+palabra[0], exp);
            MatcheExp(texto+palabra[1], exp);
            MatcheExp(texto+palabra[2], exp);
            Linias();


            //  Uso de clases de caracteres, se usa [] para contener los caracteres
            // Nico, Necio, Naco
            Titulo("Clases de Caracter [] contiene los caracteres");
            nombre.Add("Nico")/*[0]*/;nombre.Add("Necio")/*1*/;
            nombre.Add("Naco")/*[2]*/;
            texto = "Hola ";
            exp = "N[ie]c";
            MatcheExp(texto+nombre[0], exp);
            MatcheExp(texto+nombre[1], exp);
            MatcheExp(texto+nombre[2], exp);
            Linias();

            // Un rango
            //puede se de 0-9 o de la A-Z 
            //o desde un Arreglo que definamos previamente
            // Nico, Neco, Noco, Ndco, Nzco
            Titulo("Rango");
            nombre.Add("Neco")/*[3]*/;nombre.Add("Noco")/*[4]*/;
            nombre.Add("Ndco")/*[5]*/;nombre.Add("Nzco")/*[6]*/;
            texto = "Hola ";
            exp = "N[a-u]c";
            MatcheExp(texto+nombre[0], exp);
            MatcheExp(texto+nombre[3], exp);
            MatcheExp(texto+nombre[4], exp);
            MatcheExp(texto+nombre[5], exp);
            MatcheExp(texto+nombre[6], exp);
            Linias();

            // Uso de Complemento 
            // Noco, Nico
            // https://youtu.be/CRwWHAjKvVY?t=3m23s
            Titulo("Complementos");
            texto = "Hola ";
            exp = "N[^ie]c";
            MatcheExp(texto+nombre[0], exp);
            MatcheExp(texto+nombre[4], exp);
            Linias();

            // Verificando si tiene la expresion despues de n caracter 
            // https://youtu.be/CRwWHAjKvVY?t=4m41s
            Titulo("Verifica"); 
            texto = "De Youtube Nicosiered es mi Canal de tutorial para practical";
            exp = "N[ie]c";
            regex = new Regex(exp);
            if (regex.IsMatch(texto, 5))// Busca desde el caracter numero 5
                Console.Write("Si tiene \n");
            else
                Console.Write("No tiene \n");
            Linias();

            // Para saber si una cadena finaliza con una expresion
            // https://youtu.be/CRwWHAjKvVY?t=6m30s
            Titulo("Finalizo la expresion");
            texto = "De Youtube Nicosiered es mi Canal de tutorial para practical";
            exp = "N[ie]c$";
            MatcheExp(texto,exp);
            Linias();

            // Elemento Opcionales
            // Nico, Nilo, Nio
            Titulo("Opcionales");
            nombre.Add("Nilo");/*[7]*/;nombre.Add("Nio")/*[8]*/;
            texto = "Hola ";
            exp = "N[ie]c?o";
            MatcheExp(texto+nombre[0], exp);
            MatcheExp(texto+nombre[7], exp);
            MatcheExp(texto+nombre[8], exp);  
            Linias();

            // Cuantificador
            // Busca que existan n de esos elementos
            Titulo("Cuantificador");
            texto = "Holaa 255 Nico";
            MatcheExp(texto, "[0-9]{2}");//pero solo si tiene 2 o mas
            MatcheExp(texto, "[a]{2}");
            Linias();

            // Alternaciones
            // https://youtu.be/CRwWHAjKvVY?t=12m46s
            Titulo("Alternaciones");
            string[] lenguje = { "C#","JavaScript","PHP","Ruby"};
            texto = "Yo se programar en ";
            exp = "(C#|JavaScript|PHP)";
            MatcheExp(texto+lenguje[1], exp);
            MatcheExp(texto+lenguje[0], exp);
            MatcheExp(texto+lenguje[3], exp);
            Linias();

            // Split
            // Corta el texto cuando en cuentre un caracter.
            // https://youtu.be/CRwWHAjKvVY?t=13m52s
            Titulo("Split");
            texto = "Este es un tes de separacion, divicion";
            exp = ",";// en cada lugar donde encuentre exp hara una divicion.
            string[] cadenas = Regex.Split(texto, exp);
            foreach (string c in cadenas)
                Console.WriteLine(c);
            Linias();

            // Reemplazar
            //https://youtu.be/CRwWHAjKvVY?t=15m57s
            Titulo("Reemplazar");
            texto = "Yo hablo ingles y no soy ingles";
            regex = new Regex("ingles");
            string reemplazo = "Español";
            string resultado = regex.Replace(texto, reemplazo);
            Console.Write(resultado+"\n");
            nombre.Clear();
            Console.ReadKey();
        }

        public static void MatcheExp(string pTexto, string pExp)
        {
            MatchCollection encontrar = Regex.Matches(pTexto, pExp);
            foreach (Match e in encontrar)
            {
                Console.WriteLine(e);
            }
        }
        public static void Linias()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------");
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(1600);
        }
        public static void Titulo(string titulo="Sin titulo")
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Titulo: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(titulo+"\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}