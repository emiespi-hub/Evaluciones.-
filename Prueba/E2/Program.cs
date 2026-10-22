using System;
using System.Runtime.CompilerServices;
// Espacio de nombres
namespace E2
{
    class Program
    {
        static void Main(string [] arg)
        {
             // Escribir la sintaxis para definir una funcion
            //function nombreDeLaFuncion(parametro1, parametro2) {
           // Bloque de código que ejecuta la función
           // let resultado = parametro1 + parametro2;
           // return resultado;
           // Definir in ciclo para imprimir las siguintes secuencias 2,4,6,9,12,15,19,23,27
           int t = 2; 
           int incremento = 2;
           while (t <= 27)
            {
                Console.WriteLine($"t: {t}");
                if (t == 6 || t == 15) incremento += 1;
                t += incremento;
            }
            // 5
            // Defenir e invocar una funcion vacia para imprimir "Examen: Programacion III", dodne "Programacion III" corresponda a un argumento
            // 1. Definición de la función vacía (void) con un argumento
            void ImprimirExamen(string materia)
            {
            Console.WriteLine($"Examen: {materia}");
            }

           // 2. Invocación de la función pasando el argumento
           ImprimirExamen("Programacion III");
           // 4.  Defenir e Invocar una funcion para determninar si un numero es multiplo de 5. Si el numero es multiplo de 5, devolver true; en caso contrario, False. Imprimir la devolucion usando interpolacion. 
        
            bool EsMultiploDeCinco(int numero)
            {
               return numero % 5 == 0;
            }

             // 2. Invocar la función con un número 
             int numeroAProbar = 20;
            bool resultado = EsMultiploDeCinco(numeroAProbar);

            // 3. interpolación
            Console.WriteLine($"¿El número {numeroAProbar} es múltiplo de 5?: {resultado}"); 
        }    

    }

       
            
        
        

    
}
