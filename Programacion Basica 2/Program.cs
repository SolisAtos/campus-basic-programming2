using System;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Practica1
{
    class Program
    {
        static Queue<int> ReverseWithQueue(int[] integerArray)
        {
            Queue<int> result = new Queue<int>();
            int i;
            
            for (i = integerArray.Length-1; i >= 0; i--)
            {
                result.Enqueue(integerArray[i]);
            }

            return result;
        }

        static List<int> ReverseWithList(int[] integerArray)
        {
            List<int> result = new List<int>();
            int i;

            for (i = integerArray.Length - 1; i >= 0; i--)
            {
                result.Add(integerArray[i]);
            }

            return result;
        }

        static Dictionary<int, int> ReverseWithDict(int[] integerArray)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            int i;
            int key = 1;

            for (i = integerArray.Length - 1; i >= 0; i--)
            {
                result.Add(key, integerArray[i]);
                key++;
            }

            return result;
        }

        static void PrintArray(int[] integerArray)
        {
            foreach(int integer in integerArray)
            {
                Console.WriteLine(integer);
            }
        }

        static void PrimerEjercicio()
        {
            // Declarar arreglo de enteros
            int[] IntegerArray = new int[] { 1, 3, 5, 7, 9, 13 };
            // Variables de los metodos
            Queue<int> QueueReversed = new Queue<int>();
            List<int> ListReversed = new List<int>();
            Dictionary<int, int> DictionaryReversed = new Dictionary<int, int>();

            // Imprimir arreglo original
            Console.WriteLine($"Original Array: {IntegerArray}");
            PrintArray(IntegerArray);

            // Imprimir cola de ReverseWithQueue()
            QueueReversed = ReverseWithQueue(IntegerArray);
            Console.WriteLine($"Reversed with Queue: {QueueReversed}");
            foreach (int integer in QueueReversed)
            {
                Console.WriteLine(integer);
            }

            // Imprimir lista de ReverseWithList()
            ListReversed = ReverseWithList(IntegerArray);
            Console.WriteLine($"Reversed with List: {ListReversed}");
            foreach (int integer in ListReversed)
            {
                Console.WriteLine(integer);
            }

            // Imprimir lista de ReverseWithDict()
            DictionaryReversed = ReverseWithDict(IntegerArray);
            Console.WriteLine($"Reversed with Dictionary: {DictionaryReversed}");
            foreach (KeyValuePair<int, int> integer in DictionaryReversed)
            {
                Console.WriteLine($"{integer.Key} : {integer.Value}");
            }

            // Utilizando Stopwatch, calcule la ejecucion de cada metodo e imprima el resultado en
            // consola junto con el primer dato del nuevo arreglo ya inverso.
            Stopwatch stopwatch = new Stopwatch();


            // Prueba de tiempo de ejecucion para Queue
            Console.WriteLine($"\nExecution time for Queue: {QueueReversed}");
            stopwatch.Start();

            Queue<int> QueueExecutionTest = new Queue<int>();
            QueueExecutionTest = ReverseWithQueue(IntegerArray);

            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            // Format and display the TimeSpan value.
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}. Tics:{4:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10, ts.Ticks);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine($"Primer dato: {QueueExecutionTest.Dequeue()}");

            // Prueba de tiempo de ejecucion para List
            Console.WriteLine($"\nExecution time for List: {ListReversed}");
            stopwatch.Start();

            List<int> ListExecutionTest = new List<int>();
            ListExecutionTest = ReverseWithList(IntegerArray);

            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}. Tics:{4:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10, ts.Ticks);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine($"Primer dato: {ListExecutionTest.First()}");

            // Prueba de tiempo de ejecucion para Dictionary
            Console.WriteLine($"\nExecution time for Dictionary: {DictionaryReversed}");
            stopwatch.Start();

            Dictionary<int, int> DictionaryExecutionTest = new Dictionary<int, int>();
            DictionaryExecutionTest = ReverseWithDict(IntegerArray);

            stopwatch.Stop();
            ts = stopwatch.Elapsed;
            // Format and display the TimeSpan value.
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}. Tics:{4:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10, ts.Ticks);
            Console.WriteLine("RunTime " + elapsedTime);
            Console.WriteLine($"Primer dato: {DictionaryExecutionTest.First()}");

        }
        static void SegndoEjercicio()
        {
            List<int> Lista10Numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 2.1.Funcion que enlista numeros pares.
            List<int> NumerosPares = Lista10Numeros.Where(a => a % 2 == 0).ToList();
            Console.WriteLine("Numeros pares:");
            foreach (int number in NumerosPares)
            {
                Console.WriteLine(number);
            }


            // 2.2.Funcion que enlista números impares.
            List<int> NumerosImpares = Lista10Numeros.Where(a => a % 2 != 0).ToList();
            Console.WriteLine("\nNumeros impares:");
            foreach (int number in NumerosImpares)
            {
                Console.WriteLine(number);
            }


            // 2.3.Funcion que ordena una lista en orden ascendente.
            Lista10Numeros.Sort((first, second) => first.CompareTo(second));
            Console.WriteLine("\nOrdenado ascendente:");
            foreach (int number in Lista10Numeros)
            {
                Console.WriteLine(number);
            }

            // 2.4.Funcion que ordena una lista en orden descendente.
            Lista10Numeros.Sort((first, second) => second.CompareTo(first));
            Console.WriteLine("\nOrdenado descendente:");
            foreach (int number in Lista10Numeros)
            {
                Console.WriteLine(number);
            }

            // 2.5.Funcion que revisa si un valor es multiplo de 3.
            Func<int, bool> multiploDeTres = num => num % 3 == 0;
            Console.WriteLine($"\n2 es multiplo de 3? {multiploDeTres(2)}");
            Console.WriteLine($"15 es multiplo de 3? {multiploDeTres(15)}");
        }
        static void TercerEjercicio()
        {
            Console.WriteLine("\n3. Lista de nombres:");
            string[] Nombres = new string[] { "Juan", "Pablo", "Pedro", "Pepe", "Ana", "Esteban", "Daniel", "Mariano", "Carolina", "Silvia", "Roberto", "Juanito", "Juana" };
            foreach (string nombre in Nombres)
            {
                Console.WriteLine(nombre);
            }


            List<string> Resultado = new List<string>();
            // 3.1.Funcion que recibe un arreglo de strings y retorna el arreglo ordenado de forma descendente.
            Console.WriteLine("\n3.1 Ordenar arreglo de forma descendente:");
            string[] nombresDescendente = OrdenarArregloDescendente(Nombres);
            foreach (string nombre in nombresDescendente)
            {
                Console.WriteLine(nombre);
            }


            // 3.2.Funcion que recibe un arreglo de strings y un string objetivo, la funcion retorna true en caso de
            // encontrar el string objetivo dentro del arreglo de strings, false en caso contrario.
            Console.WriteLine("\n3.2 Contiene subcadena:");
            string subcadena1 = "Ped";
            bool contiene1 = ContieneSubcadena(Nombres, subcadena1);
            string subcadena2 = "or";
            bool contiene2 = ContieneSubcadena(Nombres, subcadena2);

            Console.WriteLine($"El arreglo contiene '{subcadena1}'? {contiene1}");
            Console.WriteLine($"El arreglo contiene '{subcadena2}'? {contiene2}");


            // 3.3.Funcion que recibe un arreglo de strings y retorna los elementos del arreglo que empiecen con “Juan”.
            string[] arregloJuanes = RegresarSiEmpiezanConJuan(Nombres);
            Console.WriteLine("\n3.3 Empiezan con Juan:");
            foreach (string juan in arregloJuanes)
            {
                Console.WriteLine(juan);
            }


            // 3.4.Funcion que recibe un arreglo de strings y concatena a cada uno de los elementos dentro del string
            // el prefijo “hola ”. (ex. “Hola Juan”).
            string[] arregloSaludos = SaludarPersonas(Nombres);
            Console.WriteLine("\n3.4 Saludar personas:");
            foreach (string saludo in arregloSaludos)
            {
                Console.WriteLine(saludo);
            }
        }

        static string[] OrdenarArregloDescendente(string[] arreglo)
        {
            return arreglo.OrderByDescending(x => x).ToArray();
        }

        static bool ContieneSubcadena(string[] arreglo, string subcadena)
        {
            IEnumerable<string> resultString = arreglo.Where(x => x.Contains(subcadena));
            
            foreach (string coincidencia in resultString)
            {
                return true;
            }
            
            return false;
        }

        static string[] RegresarSiEmpiezanConJuan(string[] arreglo)
        {
            string [] result = arreglo.Where(x => x.Contains("Juan")).ToArray();
            return result;
        }

        static string[] SaludarPersonas(string[] arreglo)
        {
            string[] resultado = arreglo.Select(x => "Hola " + x).ToArray();
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tPrimer ejercicio:");
            PrimerEjercicio();

            Console.WriteLine("\n\tSegundo ejercicio:");
            SegndoEjercicio();

            Console.WriteLine("\n\tTercer ejercicio:");
            TercerEjercicio();

        }
    }

}