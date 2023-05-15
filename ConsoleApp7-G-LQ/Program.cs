using System;
using System.Linq;

namespace ConsoleApp7_G_LQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante[] Estudiantes =
            {
                new Estudiante() {Id=1,Nombre="Juan",Edad=18},
                new Estudiante() {Id=2,Nombre="Alex",Edad=17},
                new Estudiante() {Id=3,Nombre="Daniela",Edad=23},
                new Estudiante() {Id=4,Nombre="Marisa",Edad=26},
                new Estudiante() {Id=5,Nombre="Fernanda",Edad=29},
                new Estudiante() {Id=6,Nombre="Angela",Edad=18},
                new Estudiante() {Id=7,Nombre="Martin",Edad=20},
                new Estudiante() {Id=8,Nombre="Osvaldo",Edad=22},
            };

            Estudiante[] EstudiantesEdad = new Estudiante[10];
            int i = 0;
            foreach (var estu in Estudiantes)
            {
                if (estu.Edad > 12 && estu.Edad < 20)
                {
                    EstudiantesEdad[i] = estu;
                    i++;
                }
            }

            for (int x = 0; x < i; x++)
            {
                Console.WriteLine("Nombre:" + EstudiantesEdad[x].Nombre.ToString() + " Edad: " + EstudiantesEdad[x].Edad);
            }

            Console.WriteLine("Funcion Lambda");
            Estudiante[] EstudiantesEdad2 = Estudiantes.Where(estu => estu.Edad > 12 && estu.Edad < 20).ToArray();
            foreach (var ff in EstudiantesEdad2)
            {
                Console.WriteLine("Nombre: " + ff.Nombre.ToString() + " " + "Edad: " + ff.Edad);
            }

            Console.WriteLine("Expresion de Consulta");
            var exp = from e in Estudiantes where e.Edad > 12 && e.Edad < 20 select e;

            foreach (var item in exp)
            {
                Console.WriteLine("Nombre: " + item.Nombre.ToString() + " Edad: " + item.Edad);
            }


            var nombres = from noms in Estudiantes where noms.Nombre.EndsWith("n") select noms;
            foreach (var item in nombres)
            {
                Console.WriteLine("Nombres con o:" + item.Nombre.ToString());
            }

            Console.ReadKey();
        }
    }
}
