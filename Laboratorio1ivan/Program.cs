using System;

namespace Laboratorio1ivan
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Person value = new Person("Bob","Kunga");
            value.Lanzar();

            Console.WriteLine(value.Nombre+ " "+ value.Apellido);
            

           


        }
    }
}
