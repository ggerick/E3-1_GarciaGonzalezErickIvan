using System; using System.Collections; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;     namespace E31GarciaGonzalezErickIvan {        class Program     {         static void Main(string[] args)         {
            int tamClases = 0, numAlumnos = 0;             string nombresClases;              //Aqui designamos cuantas clases abra             Console.Write("Cuantas clases deseas asignar, galgo: ");             tamClases = int.Parse(Console.ReadLine());             //Estas son las creaciones de las listas             List<string> clases = new List<string>();             List<int> Noalumnos = new List<int>();             List<int> calificaciones = new List<int>();
            for (int i = 0; i < tamClases; i++)             {                 //Aqui pedimos los nombres de las clases y la cantidad de alumnos                 Console.Write("\nAgregale un nombre a la clase: ");                 nombresClases = Console.ReadLine();                 clases.Add(nombresClases);
                Console.Write("Cuantos alumnos en la clase {0}: ", nombresClases);                 numAlumnos = int.Parse(Console.ReadLine());                 Noalumnos.Add(numAlumnos);              }             int calif = 0;


                //Se busca en la lista de numero de alumnos
                foreach (var x in Noalumnos)                 {
                    //Para capturar las calificaciones de la primera clase del "x" numero de alumnos


                    for (int a = 0; a < x; a++)
                    {
                        //Se piden las calificaciones de los alumnos
                        Console.Write("\nAgrega la calificacion del alumno: ");                         calif = int.Parse(Console.ReadLine());                         calificaciones.Add(calif);                     }                  } 

            Console.Clear();             Console.WriteLine("Calificiones de las clases: ");
            //Impresion de los datos capturados             foreach (var item in clases)
            {                 Console.WriteLine(item);             }           
            foreach (var item in calificaciones)
            {                 Console.WriteLine(item);             }                         Console.ReadKey();         }     } }      