using System;

namespace appParaAprovarAlumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración de variables
            string nombreAlumno, curso;
            byte calificacion;
            
            //pide los datos del alumno
            Console.WriteLine("Ingrese el nombre del alumno:");
            nombreAlumno = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del curso");
            curso = Console.ReadLine();
            Console.WriteLine("Ingrese la calificación:");
            calificacion = Convert.ToByte(Console.ReadLine());

            //sí lo cumple, sino, entonces
            if (calificacion>=70)
            {
                Console.WriteLine("\n");
                Console.WriteLine("El alumno: {0}", nombreAlumno); 
                Console.WriteLine("Ha aprovado el curso de: {0}" ,curso);
                Console.WriteLine("Con una calificaci+on de: {0}", calificacion);
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("El alumno: {0}", nombreAlumno);
                Console.WriteLine("Ha reprovado el curso de: {0}", curso);
                Console.WriteLine("El alumno deberá recursar el curso");
            }
        }
    }
}
