using System;

namespace Laboratorio1ivan
{
    public class Person
    {
        public string  Nombre;
        public string Apellido;
      
        public void  Lanzar()
        {
            Random random = new Random();
            int cachipum = random.Next(0, 3);
            Console.WriteLine(cachipum);
        }

        public Person(string nombre,string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;

        }





    }
}
