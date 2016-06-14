using System;

namespace CA1
{
    class Program
    {
        static string name = "";
        static int month = 0;
        static int Main() //void
        {
            Console.WriteLine("Hola Estudiante");
            Console.Write("Digite su nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Buenas tardes, " + name);
            Console.Write("Digite su mes de nacimiento:");            
            month = int.Parse(Console.ReadLine());
            //month = Convert.ToInt16((Console.ReadLine()));
            if (month == 8){
                Console.WriteLine("Eres Leo");
            }else{
                Console.WriteLine("No tengo información");
            }
            //Console.ReadKey();
            return 0;
        }
    }
}
